using Xamarin.Forms;
using Xamarin.Forms.Fluent;

namespace FluentLayoutSample
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new AbsoluteLayout().SetChildren(
                new BoxView
                { 
                    Color = Color.Purple
                }.SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional, 0, 1, 1, 60),
                new Label()
                    .BindTextLabel(nameof(MainViewModel.Text))
                    .SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional, .5, 1),
                new StackLayout().SetChildren(
                    new Button()
                        .BindTextButton(nameof(MainViewModel.ButtonTitle))
                        .BindCommandButton(nameof(MainViewModel.ClickCommand))
                ).SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional, .5, .5)
                .BindBackgroundColorVisualElement(nameof(MainViewModel.StackColor))
            );

            BindingContext = new MainViewModel();
        }
    }
}
