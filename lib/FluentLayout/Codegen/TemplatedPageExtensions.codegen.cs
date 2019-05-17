// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class TemplatedPageExtensions
    {


        public static TBindable WithTemplatedPageLayoutChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.LayoutChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageLayoutChangedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "LayoutChanged");

            return self;
        }

        public static TBindable WithTemplatedPageAppearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.Appearing += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageAppearingHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Appearing");

            return self;
        }

        public static TBindable WithTemplatedPageDisappearingEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.Disappearing += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageDisappearingHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Disappearing");

            return self;
        }

        public static TBindable WithTemplatedPageChildrenReorderedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.ChildrenReordered += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageChildrenReorderedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildrenReordered");

            return self;
        }

        public static TBindable WithTemplatedPageFocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.Focused += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageFocusedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Focused");

            return self;
        }

        public static TBindable WithTemplatedPageMeasureInvalidatedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.MeasureInvalidated += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageMeasureInvalidatedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "MeasureInvalidated");

            return self;
        }

        public static TBindable WithTemplatedPageSizeChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.SizeChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageSizeChangedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "SizeChanged");

            return self;
        }

        public static TBindable WithTemplatedPageUnfocusedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.FocusEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.Unfocused += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageUnfocusedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "Unfocused");

            return self;
        }

        public static TBindable WithTemplatedPageBatchCommittedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> handlerAction) where TBindable : TemplatedPage
        {
            self.BatchCommitted += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageBatchCommittedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BatchCommitted");

            return self;
        }

        public static TBindable WithTemplatedPageFocusChangeRequestedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.FocusChangeRequested += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageFocusChangeRequestedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "FocusChangeRequested");

            return self;
        }

        public static TBindable WithTemplatedPageChildAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.ChildAdded += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageChildAddedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildAdded");

            return self;
        }

        public static TBindable WithTemplatedPageChildRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.ChildRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageChildRemovedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "ChildRemoved");

            return self;
        }

        public static TBindable WithTemplatedPageDescendantAddedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.DescendantAdded += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageDescendantAddedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantAdded");

            return self;
        }

        public static TBindable WithTemplatedPageDescendantRemovedEvent<TBindable>(this TBindable self,
            System.EventHandler<Xamarin.Forms.ElementEventArgs> handlerAction) where TBindable : TemplatedPage
        {
            self.DescendantRemoved += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageDescendantRemovedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "DescendantRemoved");

            return self;
        }

        public static TBindable WithTemplatedPagePlatformSetEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.PlatformSet += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPagePlatformSetHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PlatformSet");

            return self;
        }

        public static TBindable WithTemplatedPagePropertyChangedEvent<TBindable>(this TBindable self,
            System.ComponentModel.PropertyChangedEventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.PropertyChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPagePropertyChangedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanged");

            return self;
        }

        public static TBindable WithTemplatedPageBindingContextChangedEvent<TBindable>(this TBindable self,
            System.EventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.BindingContextChanged += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPageBindingContextChangedHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "BindingContextChanged");

            return self;
        }

        public static TBindable WithTemplatedPagePropertyChangingEvent<TBindable>(this TBindable self,
            Xamarin.Forms.PropertyChangingEventHandler handlerAction) where TBindable : TemplatedPage
        {
            self.PropertyChanging += handlerAction;

            return self;
        }

        public static TBindable ClearTemplatedPagePropertyChangingHandlers<TBindable>(this TBindable self) where TBindable : TemplatedPage
        {
            Xamarin.Forms.Fluent.EventExtensions.ClearEventInvocations(self, "PropertyChanging");

            return self;
        }
        
        public static TBindable BindControlTemplateTemplatedPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : TemplatedPage
                => self.Bind(TemplatedPage.ControlTemplateProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}