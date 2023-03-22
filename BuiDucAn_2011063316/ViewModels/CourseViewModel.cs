using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuiDucAn_2011063316.Models;
using BuiDucAn_2011063316.ViewModels;
using Microsoft.Build.Framework;

namespace BuiDucAn_2011063316.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}