// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class MasterDetailPageExtensions
    {

        
        public static TBindable BindIsGestureEnabledMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.IsGestureEnabledProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindIsPresentedMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.IsPresentedProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindMasterBehaviorMasterDetailPage<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : MasterDetailPage
                => self.Bind(MasterDetailPage.MasterBehaviorProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}