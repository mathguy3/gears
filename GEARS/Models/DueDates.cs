using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEARS.Models
{
    public class DueDates
    {
        public DateTime DueDate { get; set; }
        public DateTime DueTime { get; set; }
        public DateTime GradDueDate { get; set; }
        public DateTime GradDueTime { get; set; }

        public DueDates(){}

        public DueDates(DateTime dueDate, DateTime dueTime, DateTime gradDueDate, DateTime gradDueTime)
        {
            DueDate = dueDate;
            DueTime = dueTime;
            GradDueDate = gradDueDate;
            GradDueTime = gradDueTime;
        }
    }
}