using System;
using System.ComponentModel;
using System.Diagnostics;

namespace lemonPharmacy.Common.Utils.Extensions
{
    public static class TypeConversionExtensions
    {
        [DebuggerStepThrough]
        public static T ConvertTo<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                return (T)converter.ConvertFromString(input);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }


        [DebuggerStepThrough]
        public static T ConvertTo<T>(this object input)
        {
            return ConvertTo<T>(input.ToString());
        }
    }
}
