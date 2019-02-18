using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class GestureExtensions
    {
        public static TView BindTap<TView>(this TView view, string propName, object param = null) where TView : View
        {
            var tapGesture = new TapGestureRecognizer
            {
                CommandParameter = param
            };
            tapGesture.SetBinding(TapGestureRecognizer.CommandProperty, propName);
            view.GestureRecognizers.Add(tapGesture);
            return view;
        }

        public static TView SetTap<TView>(this TView view, Action<TView> action) where TView : View
        {
            var gesture = new TapGestureRecognizer();
            gesture.Tapped += (sender, e) => action?.Invoke(view);
            view.GestureRecognizers.Add(gesture);
            return view;
        }

        public static TView SetTap<TView>(this TView view, Action action) where TView : View
            => view.SetTap((v) => action?.Invoke());
    }
}
