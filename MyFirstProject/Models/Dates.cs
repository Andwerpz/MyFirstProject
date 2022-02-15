using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public static class Dates
    {
        public static DateTime MinDate { get; set; } = new DateTime(2021, 1, 1);

        public static DateTime MaxDate { get; set; } = new DateTime(2022, 12, 31);

        public static DateTime CurrentDate { get; set; } = new DateTime(2021, 1, 1);

    }
}
