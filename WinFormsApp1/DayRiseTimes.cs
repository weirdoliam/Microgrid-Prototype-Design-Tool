using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class DayRiseTimes
    {
        private int month;
        private int day;
        private DateTime sunrise;
        private DateTime sunset;
        private TimeSpan daylight; 

        public DayRiseTimes(DateTime sunrise, DateTime sunset, TimeSpan daylight)
        {
            this.month = sunrise.Month;
            this.day = sunrise.Day;
            this.sunrise = sunrise;
            this.sunset = sunset;
            this.daylight = daylight;
        }

        public int Month { get => month;}
        public int Day { get => day;}
        public int Year { get => sunrise.Year; }

        public void setSunset(DateTime v)
        {
            sunset = v;
            recalculateDaylightHours();
        }
        public void setSunrise(DateTime v)
        {
            sunrise = v;
            recalculateDaylightHours();
        }

        public DateTime getSunrise() {
            return sunrise;
        }

        public DateTime getSunset()
        {
            return sunset;
        }

        public string getSunriseString()
        {
            return sunrise.ToShortTimeString();
        }

        public string getSunsetString()
        {
            return sunset.ToShortTimeString();
        }

        public string getSunrise24hr()
        {
            return sunrise.ToString("HHmm");
        }

        public string getSunset24hr()
        {
            return sunset.ToString("HHmm");
        }

        private void recalculateDaylightHours()
        {
            daylight = sunrise.Subtract(sunset);
        }

        public int getDaylightHours()
        {
            return daylight.Hours;
        }

        public int getDaylightMinutes()
        {
            return daylight.Minutes;
        }

        public int getValue()
        {
            return month + day + sunrise.Minute + sunrise.Hour + sunset.Minute + sunset.Hour;
        }
    }
}
