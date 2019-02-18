using System;

namespace Xamarin.Forms.Fluent
{
    [Flags]
    public enum AbsoluteFlags
    {
        None = 0,
        X = 1 << 0,
        Y = 1 << 1,
        Width = 1 << 2,
        Height = 1 << 3,
        Position = 1 | 1 << 1,
        Size = 1 << 2 | 1 << 3,
        All = ~0
    }

    public static partial class AbsoluteLayoutExtensions
    {
        public static TView SetAbsoluteLayoutFlags<TView>(this TView view, AbsoluteLayoutFlags flags) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, flags);
            return view;
        }

        public static TView SetAbsoluteLayoutFlags<TView>(this TView view, AbsoluteFlags flags) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, (AbsoluteLayoutFlags)flags);
            return view;
        }

        public static TView SetAbsoluteLayoutBounds<TView>(this TView view, double x = 0, double y = 0, double width = -1, double height = -1) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(x, y, width, height));
            return view;
        }

        public static TView SetAbsoluteLayoutChild<TView>(this TView view, AbsoluteFlags flags = AbsoluteFlags.None, double x = 0, double y = 0, double width = -1, double height = -1) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, (AbsoluteLayoutFlags)flags);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(x, y, width, height));
            return view;
        }

        public static TView SetFillAbsoluteLayoutChild<TView>(this TView view) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(0, 0, 1, 1));
            return view;
        }

        public static TView SetCenterAbsoluteLayoutChild<TView>(this TView view, double width = -1, double height = -1) where TView : BindableObject
        {
            AbsoluteLayout.SetLayoutFlags(view, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(.5, .5, width, height));
            return view;
        }
    }
}
