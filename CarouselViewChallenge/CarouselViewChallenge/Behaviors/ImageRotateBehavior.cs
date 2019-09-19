using System;
using System.Threading;
using Xamarin.Forms;

namespace CarouselViewChallenge.Behaviors
{
    public class ImageRotateBehavior : Behavior<Image>
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        protected override async void OnAttachedTo(Image bindable)
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                await bindable.RotateTo(360, 2500, Easing.Linear);
                await bindable.RotateTo(0, 0); // reset to initial position
            }
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Image bindable)
        {
            cancellationTokenSource.Cancel();
            base.OnDetachingFrom(bindable);
        }
    }
}
