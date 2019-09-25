using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CalendarViewModel : BindableObject, INotifyPropertyChanged
    {
        private ObservableCollection<Month> _months;
        DayOfWeek firstDayOfMonth;
        DayOfWeek lastDayOfMonth;
        int resetCount = 0;
        int previousMonthStart;
        int previousMonthEnd;
        int thisMonthEnd;
        int nextMonthEnd;

        public string Header { get; set; }


        public CalendarViewModel()
        {
            LoadMonths();
        }

        public ObservableCollection<Month> Months
        { get; set; }
        //get { return _months; }
        //set
        //{
        //    _months = value;
        //    OnPropertyChanged();
        //}
        //}

        void LoadMonths()
        {
            Months = new ObservableCollection<Month>();

            var currentMonth = DateTime.Now;
            var _month = DateTime.Now.AddMonths(-5);
            List<int> calDay = new List<int>();

            do
            {
                GetFirstOfMonthDay(_month);
                int idate;

                if (firstDayOfMonth == DayOfWeek.Sunday)
                {
                    idate = 1;
                    resetCount = 1;
                }
                else idate = previousMonthStart;

                calDay = new List<int>();

                do
                {
                    calDay.Add(idate);

                    idate += 1;

                    if (idate == previousMonthEnd + 1 && resetCount == 0)
                    {
                        idate = 1;
                        resetCount = 1;
                    }
                    else if (idate == thisMonthEnd + 1 && resetCount == 1)
                    {
                        if (nextMonthEnd <= 0)
                        {
                            resetCount = 0;
                            break;
                        }
                        idate = 1;
                        resetCount = 2;
                    }
                    else if (idate == nextMonthEnd + 1 && resetCount == 2)
                    {
                        resetCount = 0;
                        break;
                    }

                } while (true);

                Months.Add(new Month
                {
                    MonthTitle = _month.ToString("MMMM yyyy"),
                    c1 = calDay[0].ToString(),
                    c2 = calDay[1].ToString(),
                    c3 = calDay[2].ToString(),
                    c4 = calDay[3].ToString(),
                    c5 = calDay[4].ToString(),
                    c6 = calDay[5].ToString(),
                    c7 = calDay[6].ToString(),
                    c8 = calDay[7].ToString(),
                    c9 = calDay[8].ToString(),
                    c10 = calDay[9].ToString(),
                    c11 = calDay[10].ToString(),
                    c12 = calDay[11].ToString(),
                    c13 = calDay[12].ToString(),
                    c14 = calDay[13].ToString(),
                    c15 = calDay[14].ToString(),
                    c16 = calDay[15].ToString(),
                    c17 = calDay[16].ToString(),
                    c18 = calDay[17].ToString(),
                    c19 = calDay[18].ToString(),
                    c20 = calDay[19].ToString(),
                    c21 = calDay[20].ToString(),
                    c22 = calDay[21].ToString(),
                    c23 = calDay[22].ToString(),
                    c24 = calDay[23].ToString(),
                    c25 = calDay[24].ToString(),
                    c26 = calDay[25].ToString(),
                    c27 = calDay[26].ToString(),
                    c28 = calDay[27].ToString(),
                    c29 = calDay[28].ToString(),
                    c30 = calDay[29].ToString(),
                    c31 = calDay[30].ToString(),
                    c32 = calDay[31].ToString(),
                    c33 = calDay[32].ToString(),
                    c34 = calDay[33].ToString(),
                    c35 = calDay[34].ToString(),
                    c36 = calDay[35].ToString(),
                    c37 = calDay[36].ToString(),
                    c38 = calDay[37].ToString(),
                    c39 = calDay[38].ToString(),
                    c40 = calDay[39].ToString(),
                    c41 = calDay[40].ToString(),
                    c42 = calDay[41].ToString()
                });

                _month = _month.AddMonths(1);

                if (_month.Month == currentMonth.AddMonths(6).Month)
                    break;

            } while (true);

        }

        private void GetFirstOfMonthDay(DateTime ThisDay)
        {
            previousMonthEnd = DateTime.DaysInMonth(ThisDay.AddMonths(-1).Year, ThisDay.AddMonths(-1).Month);
            thisMonthEnd = DateTime.DaysInMonth(ThisDay.Year, ThisDay.Month);

            firstDayOfMonth = ThisDay.AddDays((-ThisDay.Day) + 1).DayOfWeek;
            lastDayOfMonth = ThisDay.AddDays((-ThisDay.Day) + thisMonthEnd).DayOfWeek;

            previousMonthStart = previousMonthEnd - (subtractBy(firstDayOfMonth));
            nextMonthEnd = addBy(lastDayOfMonth);

            if ((firstDayOfMonth == DayOfWeek.Friday || firstDayOfMonth == DayOfWeek.Saturday) && (lastDayOfMonth == DayOfWeek.Sunday || lastDayOfMonth == DayOfWeek.Monday)) nextMonthEnd -= 7;
        }

        private int subtractBy(DayOfWeek _day)
        {
            if (_day == DayOfWeek.Sunday) return 0;
            if (_day == DayOfWeek.Monday) return 0;
            if (_day == DayOfWeek.Tuesday) return 1;
            if (_day == DayOfWeek.Wednesday) return 2;
            if (_day == DayOfWeek.Thursday) return 3;
            if (_day == DayOfWeek.Friday) return 4;
            if (_day == DayOfWeek.Saturday) return 5;
            else return 0;
        }

        private int addBy(DayOfWeek _day)
        {
            if (_day == DayOfWeek.Sunday) return 13;
            if (_day == DayOfWeek.Monday) return 12;
            if (_day == DayOfWeek.Tuesday) return 11;
            if (_day == DayOfWeek.Wednesday) return 10;
            if (_day == DayOfWeek.Thursday) return 9;
            if (_day == DayOfWeek.Friday) return 8;
            if (_day == DayOfWeek.Saturday) return 7;
            else return 0;
        }

    }
}
