using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int hours { get; set; }

public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            this.hours = hours;
        }
        public double TotalValue()
        {
            return hours * ValuePerHour
        }
    }
}
