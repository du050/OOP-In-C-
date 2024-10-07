using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrator
{
    public class Period
    {
        DateTime startdate;
        DateTime enddate;
        

        public Period(DateTime startdate, DateTime enddate)
        {
           
            int result = DateTime.Compare(startdate, enddate);
            if (result >= 0)
            {
                throw new ArgumentException("The start date has to be earlier than the end date!");
            }
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public DateTime getStartDate()
        {
            return startdate;
        }

        public DateTime getEndDate()
        {
            return enddate;
        }

        public override string ToString()
        {
            return $"{startdate} to {enddate}";
        }
    }
}
