using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler NextHandler;
        public ILeaveRequestHandler nextHandler { get { return NextHandler; }
            set {  NextHandler =value; }
        }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if(leaveRequest.LeaveDays > 2 && leaveRequest.LeaveDays < 6)
            {
                Console.WriteLine("Request Approved By Project Manager");
            }
            else
            {
                Console.WriteLine("Passing towards Human Resources as leaves are more than regular criteria...");
                nextHandler = new HumanResources();
                nextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
