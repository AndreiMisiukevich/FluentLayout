using System.Linq;

namespace Xamarin.Forms.Fluent
{
    public static class LayoutExtensions
    {
        public static TLayout SetChildren<TLayout>(this TLayout self, params View[] views) where TLayout : Layout<View>
        {
            foreach (var view in views?.Where(v => v != null) ?? Enumerable.Empty<View>())
            {
                self.Children.Add(view);
            }
            return self;
        }
    }
}
