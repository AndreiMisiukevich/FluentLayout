namespace Xamarin.Forms.Fluent
{
    public static partial class AbsoluteLayoutExtensions
    {
        public static TView SetAbsoluteLayout<TView>(this TView view, AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None, double x = 0, double y = 0, double width = -1, double height = -1) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, flags);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(x, y, width, height));
            return view;
        }

        public static TView SetAbsoluteLayoutFillParent<TView>(this TView view) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(0, 0, 1, 1));
            return view;
        }

        public static TView SetAbsoluteLayoutCenter<TView>(this TView view, double width = -1, double height = -1) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(.5, .5, width, height));
            return view;
        }
    }
}
