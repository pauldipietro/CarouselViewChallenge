using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarouselViewChallenge.Helpers
{
    public class AsyncCommand<T> : AsyncCommand
    {
        public AsyncCommand(Func<T, Task> execute) : base(o => execute((T)o))
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.MobCat.Mvvm.Command"/> class.
        /// </summary>
        /// <param name="execute">Action to call when Execute is invoked.</param>
        /// <param name="canExecute">Action to determine whether the command can execute or not.</param>
        public AsyncCommand(Func<T, Task> execute, Func<T, bool> canExecute) : base((o) => execute((T)o), o => canExecute((T)o))
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));

            if (canExecute == null)
                throw new ArgumentNullException(nameof(canExecute));
        }
    }

    public class AsyncCommand : ICommand
    {
        Func<object, Task> _action;
        readonly Func<object, bool> _canExecute;
        Task _task;

        public AsyncCommand(Func<object, Task> action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public AsyncCommand(Func<Task> action) : this(o => action())
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
        }

        public AsyncCommand(Func<object, Task> action, Func<object, bool> canExecute) : this(action)
        {
            this._canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
        }

        public AsyncCommand(Func<Task> action, Func<bool> canExecute) : this(o => action(), o => canExecute())
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (canExecute == null)
                throw new ArgumentNullException(nameof(canExecute));
        }

        /// <inheritdoc />
        public bool CanExecute(object parameter)
        {
            if (_task == null)
                return _canExecute == null ? true : _canExecute(parameter);

            var canExecute = true;
            if (_canExecute != null)
                canExecute = _canExecute(parameter);

            return canExecute && _task.IsCompleted;
        }

        public event EventHandler CanExecuteChanged;

        /// <inheritdoc />
        public async void Execute(object parameter) => await ExecuteAsync(parameter);

        /// <summary>
        /// Raises the CanExecuteChanged event if there is a handler.
        /// </summary>
        void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Executes the command is invoked.
        /// </summary>
        /// <returns>Task with result of type object.</returns>
        /// <param name="parameter">Parameter.</param>
        public async Task ExecuteAsync(object parameter)
        {
            _task = _action(parameter);

            OnCanExecuteChanged();

            await _task;

            OnCanExecuteChanged();
        }

        public void ChangeCanExecute()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
