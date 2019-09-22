using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewChallenge.Behaviours
{
    public class EventToCommandBehavior : BindableBehavior<Xamarin.Forms.View>
    {
        public static BindableProperty CommandProperty =
            BindableProperty.CreateAttached(
                "Command",
                typeof(ICommand),
                typeof(EventToCommandBehavior),
                null,
                BindingMode.OneWay);

        public static BindableProperty CommandParameterProperty =
            BindableProperty.CreateAttached(
                "CommandParameter",
                typeof(object),
                typeof(EventToCommandBehavior),
                null,
                BindingMode.OneWay);

        public static BindableProperty EventArgsConverterProperty =
            BindableProperty.CreateAttached(
                "EventArgsConverter",
                typeof(IValueConverter),
                typeof(EventToCommandBehavior),
                null,
                BindingMode.OneWay);

        public static BindableProperty EventArgsConverterParameterProperty =
            BindableProperty.CreateAttached(
                "EventArgsConverterParameter",
                typeof(object),
                typeof(EventToCommandBehavior),
                null,
                BindingMode.OneWay);

        protected Delegate _handler;

        private static BindableProperty EventNameProperty =
            BindableProperty.CreateAttached(
                "EventName",
                typeof(string),
                typeof(EventToCommandBehavior),
                null,
                BindingMode.OneWay);


        private EventInfo _eventInfo;

        public string EventName
        {
            get { return (string)GetValue(EventNameProperty); }
            set { SetValue(EventNameProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public IValueConverter EventArgsConverter
        {
            get { return (IValueConverter)GetValue(EventArgsConverterProperty); }
            set { SetValue(EventArgsConverterProperty, value); }
        }

        public object EventArgsConverterParameter
        {
            get { return GetValue(EventArgsConverterParameterProperty); }
            set { SetValue(EventArgsConverterParameterProperty, value); }
        }

        protected override void OnAttachedTo(Xamarin.Forms.View visualElement)
        {
            base.OnAttachedTo(visualElement);

            var events = AssociatedObject.GetType().GetRuntimeEvents().ToArray();
            if (events.Any())
            {
                this._eventInfo = events.FirstOrDefault(e => e.Name == EventName);
                if (this._eventInfo == null)
                    throw new ArgumentException(String.Format("EventToCommand: Can't find any event named '{0}' on attached type", EventName));

                AddEventHandler(this._eventInfo, this.AssociatedObject, this.OnFired);
            }
        }

        protected override void OnDetachingFrom(Xamarin.Forms.View view)
        {
            if (this._handler != null)
            {
                this._eventInfo.RemoveEventHandler(this.AssociatedObject, this._handler);
            }


            base.OnDetachingFrom(view);
        }

        private void AddEventHandler(EventInfo eventInfo, object item, Action<object, EventArgs> action)
        {
            var eventParameters = eventInfo.EventHandlerType
                .GetRuntimeMethods().First(m => m.Name == "Invoke")
                .GetParameters()
                .Select(p => Expression.Parameter(p.ParameterType))
                .ToArray();

            var actionInvoke = action.GetType()
                .GetRuntimeMethods().First(m => m.Name == "Invoke");

            this._handler = Expression.Lambda(
                eventInfo.EventHandlerType,
                Expression.Call(Expression.Constant(action), actionInvoke, eventParameters[0], eventParameters[1]),
                    eventParameters)
                .Compile();

            eventInfo.AddEventHandler(item, this._handler);
        }

        private void OnFired(object sender, EventArgs eventArgs)
        {
            if (this.Command == null)
            {
                return;
            }

            var parameter = this.CommandParameter;

            if (eventArgs != null && eventArgs != EventArgs.Empty)
            {
                parameter = eventArgs;

                if (this.EventArgsConverter != null)
                {
                    parameter = this.EventArgsConverter.Convert(eventArgs, typeof(object), this.EventArgsConverterParameter, CultureInfo.CurrentUICulture);
                }
            }

            if (this.Command.CanExecute(parameter))
            {
                this.Command.Execute(parameter);
            }
        }
    }
}
