using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }

        public LeaveRequest(string employee,int leaveDays)
        {
            Employee = employee;
            LeaveDays = leaveDays;
        }

    }
}
