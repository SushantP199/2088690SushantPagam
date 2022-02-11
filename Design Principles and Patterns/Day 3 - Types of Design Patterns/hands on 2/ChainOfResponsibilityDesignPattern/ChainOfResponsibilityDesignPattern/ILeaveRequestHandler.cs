using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public interface ILeaveRequestHandler
    {
         ILeaveRequestHandler nextHandler { get; set; }

        void HandleRequest(LeaveRequest leaveRequest);
    }
}
