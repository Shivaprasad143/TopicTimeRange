using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfDates
{
   class TimeRange
        {
            public DateTime StartingDate { get; set; }

            public DateTime EndingDate { get; set; }

            public TimeRange(DateTime start, DateTime end)
            {
                this.StartingDate = start;
                this.EndingDate = end;
            }

            public TimeRange()
            {

            }
        }


    }


