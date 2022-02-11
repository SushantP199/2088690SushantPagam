using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class HumanResources : ILeaveRequestHandler
    {
        private ILeaveRequestHandler NextHandler;
        public ILeaveRequestHandler nextHandler { get { return NextHandler; } set { NextHandler =value; } }

        public void HandleRequest(LeaveRequest leave)
        {   
            Console.WriteLine("Approved By HR");
        }
    }
}
