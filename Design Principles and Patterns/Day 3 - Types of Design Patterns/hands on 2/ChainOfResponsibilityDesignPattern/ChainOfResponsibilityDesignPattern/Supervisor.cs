using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    class Supervisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler NextHandler;
        public ILeaveRequestHandler nextHandler { get { return NextHandler; } set {NextHandler=value; } }

        public void HandleRequest(LeaveRequest leave)
        {
            if(leave.LeaveDays<4&&leave.LeaveDays>0)
            {
                Console.WriteLine("Approved By Supervisor");
            }
            else
            {
                Console.WriteLine("Passed to Project Manager due to number of leaves ");
                nextHandler = new ProjectManager();
                nextHandler.HandleRequest(leave);
            }
        }
    }
}
