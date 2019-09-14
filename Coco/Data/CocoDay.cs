using System;
using System.Globalization;

namespace Coco.Data
{
    public class CocoDay
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        public CocoDay()
        {
        }

        public CocoDay(DayOfWeek value)
        {
            Value = value;
        }

        public DayOfWeek Value { get; set; }

        public override string ToString()
        {
            return CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(Value);
        }
    }
}
