using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;

    public class DateUtils
    {
        public DateTime TakeABreak(int minutes) 
        { 
            return DateTime.Now.AddMinutes(minutes);
        }
    }

