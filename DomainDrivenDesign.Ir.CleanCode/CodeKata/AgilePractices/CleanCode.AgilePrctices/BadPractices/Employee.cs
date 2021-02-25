using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode.AgilePractices.BadPractices
{
    public enum EmployeeType
    {
        Normal,
        Hourly,
        Consultant
    }

    public class Employee
    {
        public decimal MonthlyFee { get; set; }

        /// <summary>
        /// این فیلد به این معنی که یک کارمند حقوق ساعتی چقدر میگیرد؟
        /// لفطا توجه کنید این فیلد فقط برای کارمندان ساعتی است
        /// </summary>
        public decimal HourlyFee { get; set; }

        public List<Day> Days { get; set; }
        public EmployeeType EmployeeType { get; set; }

        /// <summary>
        /// این متد حقوق ماهیانه این کارمند را محاسبه کرده و بر میگرداند.
        /// حقوق کارمند بر اساس اینکه آیا ساعتی یا ماهیانه کار میکند یا مشاوره هست فرق میکند
        /// آقای عباس کیارسمتی در جلسه دیروز گفتن حقوق کارمند ساعتی بر اساس فرمول زیر محاسبه شود
        /// میزان توافق شده برای ساعت * تعداد ساعاتی که کار کرده است
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthlySalary()
        {
            if (EmployeeType == EmployeeType.Hourly)
            {
                var sum = Days.Sum(d => d.ExitHour.Hour - d.EnterHour.Hour);
                return sum * HourlyFee;
            }
            if (EmployeeType == EmployeeType.Consultant)
            {
                var sum1 = Days.Sum(d => d.ExitHour.Hour - d.EnterHour.Hour);
                return sum1 * HourlyFee;
            }


            int x = new MyCalendar().CurrentMonth.WorkingDays.Count;
            int extractDayWorks = 0;
            int lowTimeWork = 0;

            if (x > Days.Count)
            {
                extractDayWorks = x - Days.Count;
            }
            else if (x < Days.Count)
            {
                lowTimeWork = Days.Count - x;
            }
            else
            {
                lowTimeWork = 0;
                extractDayWorks = 0;
            }


            if (extractDayWorks > 0)
                return MonthlyFee + extractDayWorks * 8 * HourlyFee * 1.25M;
            else if (lowTimeWork > 0)
                return MonthlyFee - extractDayWorks * 8 * HourlyFee * 1.25M;
            else return MonthlyFee;

        }




    }

    public class MyCalendar
    {
        public Month CurrentMonth { get; set; }
    }

    public class Month
    {
        public int Holidays { get; set; }
        public List<Day> WorkingDays { get; set; }
    }


    public class Day
    {
        public DateTime EnterHour { get; set; }
        public DateTime ExitHour { get; set; }
    }
}