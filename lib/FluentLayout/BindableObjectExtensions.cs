using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class BindableObjectExtensions
    {
        public static TBindable As<TBindable>(this BindableObject self) where TBindable : BindableObject
            => self as TBindable;

        public static TBindable Do<TBindable>(this TBindable self,
            Action<TBindable> action) where TBindable : BindableObject
        {
            action?.Invoke(self);
            return self;
        }

        public static TBindable Set<TBindable>(this TBindable self,
            BindableProperty targetProperty,
            object value) where TBindable : BindableObject
        {
            self.SetValue(targetProperty, value);
            return self;
        }

        public static TBindable Bind<TBindable>(this TBindable self,
            BindableProperty targetProperty, 
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : BindableObject
        {
            var binding = new Binding
            {
                Path = path,
                Mode = mode,
                Converter = converter,
                ConverterParameter = converterParameter,
                StringFormat = stringFormat,
                Source = source,
                TargetNullValue = targetNullValue,
                FallbackValue = fallbackValue
            };
            self.SetBinding(targetProperty, binding);
            return self;
        }
    }
}