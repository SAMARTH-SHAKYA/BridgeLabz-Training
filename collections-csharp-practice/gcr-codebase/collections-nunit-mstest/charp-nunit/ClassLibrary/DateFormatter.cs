using System;
using System.Globalization;

namespace TestingProject.csharp_collections.assignment.Nunit
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (!DateTime.TryParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime date))
            {
                throw new FormatException("Invalid date format");
            }

            return date.ToString("dd-MM-yyyy");
        }
    }
}
