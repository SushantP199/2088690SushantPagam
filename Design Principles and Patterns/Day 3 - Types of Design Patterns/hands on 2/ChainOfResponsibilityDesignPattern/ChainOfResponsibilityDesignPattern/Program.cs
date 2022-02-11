using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leaveRequest = new LeaveRequest("Sushant", 15);
            ILeaveRequestHandler leaveRequestHandler = new Supervisor();
            leaveRequestHandler.HandleRequest(leaveRequest);

            Console.Read();
        }
    }
}
