using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Enums
{
    public class MyEnum<TEnum> where TEnum : struct, IConvertible
    {
        public static CarDescription GetDetails(TEnum item)
        {
            FieldInfo info = item.GetType().GetField(item.ToString());
            var attributes = (CarDescription[])info.GetCustomAttributes(typeof(CarDescription), false);
            return attributes[0];
        }
        public static int GetLength()
        {
            return ToArray().Length;
        }
        public static string Stringify(TEnum item)
        {
            #region Variables
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] spacers = { ' ' };
            string result = String.Empty;
            #endregion

            for (int index = 0; index < item.ToString().Length; index++)
            {
                if (index > 0 && item.ToString().Length > 3)
                {
                    foreach (char splitter in chars)
                    {
                        if (item.ToString()[index] == splitter)
                        {
                            result += spacers[new Random(index).Next(0, spacers.Length)];
                        }
                    }
                }
                result += item.ToString()[index];
            }
            return result;
        }
        public static string[] ToArray()
        {
            return Enum.GetNames(typeof(TEnum));
        }
    }
    public class CarDescription : DescriptionAttribute
    {
        public Manufacturers Manufacturer { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }

        public CarDescription(string picture, string description)
        {
            this.Picture = picture;
            this.DescriptionValue = description;
        }

        public CarDescription(Manufacturers manufacturer, string picture, string description)
        {
            this.Manufacturer = manufacturer;
            this.Picture = picture;
            this.DescriptionValue = description;
        }
    }
    public enum DataResult
    {
        // Status
        Success,
        Failure,
        // Availability
        ModelExists,
        ModelNotFound,
        // Registration Results
        UsernameExists,
        // Login Results
        InvalidUsername,
        InvalidPassword,
        InvalidInput, // Both Username & Password Are Invalid
        // Validation Results
        ValidUsername,
        ValidPassword
    }
}
