using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using THWeb_BigSchool.Models;

namespace THWeb_BigSchool.ViewModels
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
        public IEnumerable<Category> category { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}