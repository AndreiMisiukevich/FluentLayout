// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class WebViewExtensions
    {

        
        public static TBindable BindSourceWebView<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : WebView
                => self.Bind(WebView.SourceProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindCanGoBackWebView<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : WebView
                => self.Bind(WebView.CanGoBackProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindCanGoForwardWebView<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : WebView
                => self.Bind(WebView.CanGoForwardProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}