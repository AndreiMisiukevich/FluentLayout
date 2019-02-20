// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class PageExtensions
    {


        public static TBindable SetLayoutChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.LayoutChanged += handlerAction;

            return self;
        }

        public static TBindable SetAppearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.Appearing += handlerAction;

            return self;
        }

        public static TBindable SetDisappearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.Disappearing += handlerAction;

            return self;
        }

        public static TBindable SetChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable SetFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : Page
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable SetMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable SetSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable SetUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : Page
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable SetBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : Page
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable SetFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : Page
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable SetChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Page
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable SetChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Page
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable SetDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Page
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable SetDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : Page
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable SetPlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable SetPropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : Page
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable SetBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : Page
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable SetPropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : Page
        {
            self.PropertyChanging += handlerAction;

            return self;
        }
        
        public static TBindable BindBackgroundImagePage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Page
                => self.Bind(Page.BackgroundImageProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindIsBusyPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Page
                => self.Bind(Page.IsBusyProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindPaddingPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Page
                => self.Bind(Page.PaddingProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindTitlePage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Page
                => self.Bind(Page.TitleProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindIconPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Page
                => self.Bind(Page.IconProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}