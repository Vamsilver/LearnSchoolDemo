using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchoolPractice.ADO
{
    partial class ClientService
    {
        public TimeSpan TimeBeforeRecord => StartTime.Subtract(DateTime.Now);

        public double HoursBeforeRecord => TimeBeforeRecord.Hours + TimeBeforeRecord.Days * 24;
        public double MinutesBeforeRecord => TimeBeforeRecord.Minutes;

    }
}
