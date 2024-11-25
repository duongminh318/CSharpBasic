using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationSample
{
    public static class EnumHelper
    {
        public static List<(int Value, string Name, string Description)> GetEnumDescriptions<T>() where T : Enum
        {
            var enumList = new List<(int Value, string Name, string Description)>();

            foreach (var value in Enum.GetValues(typeof(T)))
            {
                Enum enumValue = (Enum)value;
                int intValue = Convert.ToInt32(enumValue);
                string name = enumValue.ToString();
                string description = enumValue.GetDescription();

                enumList.Add((intValue, name, description));
            }

            return enumList;
        }
    }
}
