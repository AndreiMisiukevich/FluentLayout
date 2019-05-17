using System;
using System.Reflection;

namespace Xamarin.Forms.Fluent
{
    public static class EventExtensions
    {
        public static void ClearEventInvocations(object obj, string eventName)
        {
            var fi = GetEventField(obj.GetType(), eventName);
            if (fi == null) return;
            fi.SetValue(obj, null);
        }

        private static FieldInfo GetEventField(Type type, string eventName)
        {
            FieldInfo field = null;
            while (type != null)
            {
                /* Find events defined as field */
                field = type.GetField(eventName, BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
                if (field != null && (field.FieldType == typeof(MulticastDelegate) || field.FieldType.IsSubclassOf(typeof(MulticastDelegate))))
                    break;

                /* Find events defined as property { add; remove; } */
                field = type.GetField("EVENT_" + eventName.ToUpper(), BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
                if (field != null)
                    break;
                type = type.BaseType;
            }

            return field;
        }
    }
}
