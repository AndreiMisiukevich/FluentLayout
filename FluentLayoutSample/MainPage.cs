using System;
using System.ComponentModel;
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
                }.SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional, 0, 1, 1, 80),

                new Label
                {
                    TranslationY = -40
                }.BindTextLabel(nameof(MainViewModel.Text))
                .SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional, .5, 1, -1, 80),

                new StackLayout().SetChildren(
                    new Button()
                        .BindTextButton(nameof(MainViewModel.ButtonTitle))
                        .BindCommandButton(nameof(MainViewModel.ClickCommand)),
                    new Label
                    {
                        // Blue will never appear, as the binding will be triggering the  
                        // PropertyChanged event handler
                        BackgroundColor = Color.Blue
                    }
                    .BindTextLabel(nameof(MainViewModel.Label))
                    .WithLabelPropertyChangedEvent(HandlePropertyChangedEvent)
                ).SetAbsoluteLayout(AbsoluteLayoutFlags.PositionProportional, .5, .5)
            );

            BindingContext = new MainViewModel();
        }

        private void HandlePropertyChangedEvent(object sender, PropertyChangedEventArgs e)
        {
            var label = sender as Label;
            label.BackgroundColor = Color.Red;
        }
    }
}
