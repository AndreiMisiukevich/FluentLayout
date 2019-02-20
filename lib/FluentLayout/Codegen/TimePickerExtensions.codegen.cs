// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class TimePickerExtensions
    {


        public static TBindable SetChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TimePicker
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable SetFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable SetMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TimePicker
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable SetSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TimePicker
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable SetUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable SetBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : TimePicker
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable SetFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : TimePicker
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable SetChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable SetChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable SetDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable SetDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TimePicker
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable SetPlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TimePicker
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable SetPropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : TimePicker
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable SetBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TimePicker
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable SetPropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : TimePicker
        {
            self.PropertyChanging += handlerAction;

            return self;
        }
        
        public static TBindable BindFormatTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.FormatProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindTextColorTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.TextColorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindTimeTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.TimeProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontFamilyTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.FontFamilyProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontSizeTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.FontSizeProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindFontAttributesTimePicker<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TimePicker
                => self.Bind(TimePicker.FontAttributesProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}