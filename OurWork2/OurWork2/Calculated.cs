using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    class Calculated
    {
        public static int Calculate(int year, int month, int day)
        {
            return CalculateDay(day) - CalculateThisMonth() + CalculateThatMonth(year, month) + CalculateYear(year);

        }
        //计算今年距今月有多少天
        public static int CalculateThisMonth()
        {
            int count = 0;
            //判断闰年的月份
            int[] YearMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(DateTime.Now.Year))
                YearMonths[1] = 29;
            for (int i = 0; i < DateTime.Now.Month; i++) count += YearMonths[i];

            return count;
        }
        //计算计划年据计划月有多少天
        public static int CalculateThatMonth(int year, int month)
        {
            int count = 0;
            //判断闰年的月份
            int[] YearMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(year))
                YearMonths[1] = 29;
            for (int i = 0; i < month; i++) count += YearMonths[i];
            return count;
        }
        //计算日差
        public static int CalculateDay(int day)
        {
            return day - DateTime.Now.Day;
        }
        //计算年份间的天数差
        public static int CalculateYear(int year)
        {
            int count = 0;
            for (int i = DateTime.Now.Year; i < year; i++)
            {
                count += 365;
                if (IsLeapYear(i)) count += 1;
            }
            return count;
        }
        public static bool IsLeapYear(int year)//判断闰年
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
    }
}
