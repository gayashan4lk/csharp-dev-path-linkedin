using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials;

public static class AbstractClassesDriver
{
    public static void Drive()
    {
        ShiftWorker sw = new ShiftWorker
        {
            FirstName = "staff",
            LastName = "one",
            StartDate = new DateOnly(2014, 2, 17),
            ShiftStartTime = new TimeOnly(8, 30)
        };

        Console.WriteLine("\n=============Shift Worker=============");
        bool payrollProcessed = sw.ProcessPayroll();
        sw.Terminate(DateTime.Now);
        bool active = sw.IsActive();

        EmployeeAbs mgr = new ManagerAbs
        {
            FirstName = "manager",
            LastName = "one",
            NumberOfDirectReports = 7
        };

        Console.WriteLine("\n=============Manager=============");
        bool mgrPayrollProcessed = mgr.ProcessPayroll();
        mgr.Terminate(DateTime.Now);
        bool mgrActive = mgr.IsActive();
    }
}
