using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator :   IWorkDayCalculator
    {
        public DateTime Calculate (DateTime startDate, int dayCount,  WeekEnd[] weekEnds)
        {

            int count = 0;
            
            if (weekEnds == null)
            {
                return startDate;
            }


            foreach (WeekEnd i in weekEnds)
            {
                if (i.EndDate == i.StartDate )
                    count = count + 1;

                else 
                {
                    TimeSpan j = i.EndDate - i.StartDate;
                    count = count + j.Days;

                     if (startDate.AddDays(dayCount+count) > i.StartDate) 
                        break;
                }


            }





            return startDate.AddDays(dayCount + count);




            throw new NotImplementedException();
            




        }
    }
}
