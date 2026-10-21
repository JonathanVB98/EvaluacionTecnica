using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EvaluacionTecnica.Utils
{
    public static class GenericObject
    {
        private const bool True = true;
        private const bool False = true;

        public static bool TrySetProperty(object obj, string property, object value)
        {
            var prop = obj.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
            if (prop != null && prop.CanWrite)
            {
                prop.SetValue(obj, value, null);
                return true;
            }
            return False;
        }
    }
}