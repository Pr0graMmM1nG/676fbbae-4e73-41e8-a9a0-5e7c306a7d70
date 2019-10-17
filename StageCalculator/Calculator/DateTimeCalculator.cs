using System;

namespace StageCalculator.Calculator
{
    class DateTimeCalculator
    {
        public  string DeltaTime(DateTime FirstDataParam, DateTime LastDataParam)
        {
            if (FirstDataParam.CompareTo(LastDataParam) != -1) return "0.0.0";
            DateTime date1 = FirstDataParam;
            DateTime date2 = LastDataParam;
            var oldMonth = date2.Month;
            while (oldMonth == date2.Month)
            {
                date1 = date1.AddDays(-1);
                date2 = date2.AddDays(-1);
            }

            int years = 0, months = 0, days = 0;

            while (date2.CompareTo(date1) >= 0)
            {
                years++;
                date2 = date2.AddYears(-1);
            }
            date2 = date2.AddYears(1);
            years--;

            oldMonth = date2.Month;
            while (date2.CompareTo(date1) >= 0)
            {
                days++;
                date2 = date2.AddDays(-1);
                if ((date2.CompareTo(date1) >= 0) && (oldMonth != date2.Month))
                {
                    months++;
                    days = 0;
                    oldMonth = date2.Month;
                }
            }
            date2 = date2.AddDays(1);
            days--;

            return years.ToString() + "." + months.ToString() + "." + days.ToString();
        }

        //public string Total(Object LocalBDBParam)
        //{
        //    int years = 0, months = 0, days = 0;
        //    foreach (var item in LocalBDBParam)
        //    {
        //        string[] separate = item.Split('.');
        //        years = years + Convert.ToInt32(separate[0]);
        //        months = months + Convert.ToInt32(separate[1]);
        //        days = days + Convert.ToInt32(separate[2]);
        //    }
        //    return YMD(years, months, days);
        //}

        public  string YMD(int YearsParam, int MonthParam, int DaysParam)
        {
            var TotalDays = DaysParam % 30;
            var monthFromDays = DaysParam / 30;
            var Temp = MonthParam + monthFromDays;
            var TotalMonth = Temp % 12;
            var yearFromMonth = Temp / 12;
            var TotalYears = YearsParam + yearFromMonth;
            return TotalYears + "y " + TotalMonth.ToString() + "m " + TotalDays.ToString() + "d ";
        }


    }
}
