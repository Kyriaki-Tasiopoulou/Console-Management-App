using PrivateSchool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrivateSchool
{
    internal class Validation
    {
        public static bool IsValidDate(string dateTimeInput, out DateTime dateTime)
        {
            bool isValid = DateTime.TryParse(dateTimeInput, out DateTime result);
            dateTime = result;
            return isValid && result > DateTime.Now;
        }
        public static bool IsValidCourseStream(string stream)
        {
            return Regex.IsMatch(stream, @"^(cb|CB)-[8-9]$|^(cb|CB)-1([0-5])$");
        }
        public static bool IsValidName(string name)
        {
            bool isNumber = name.Any(x => char.IsNumber(x));
            return isNumber;
        }
        public static bool IsValidDateOfBirth(string dateTimeInput, out DateTime dateTime)
        {
            bool isValid = DateTime.TryParse(dateTimeInput, out DateTime result);
            dateTime = result;
            return isValid && result.Year <= DateTime.Now.Year - 18;
        }
        public static bool IsValidFees(string feesInput)
        {
            bool isNumber = feesInput.All(x => char.IsNumber(x));
            return isNumber;
        }
        public static bool IsValidMark(string markInput, out int fees)
        {
            bool isValid = Int32.TryParse(markInput, out int result);
            fees = result;
            return isValid && result <= 100;
        }
    }
}
