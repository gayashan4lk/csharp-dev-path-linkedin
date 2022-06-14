using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials;

public  class AbstractClassesDriver
{
    public void Drive()
    {
        EmployeeAbs sw = new ShiftWorker
        {
            FirstName = "staff",
            LastName = "one",
            StartDate = new DateOnly(2014, 2, 17),
            ShiftStartTime = new TimeOnly(8, 30)
        };


        Console.WriteLine("=============Shift Worker=============");
        bool payrollProcessed = sw.ProcessPayroll();
        sw.Terminate(DateTime.Now);
        bool active = sw.IsActive();
        Console.WriteLine();


        //Employee mgr = new Manager
        //{
        //    FirstName = "manager",
        //    LastName = "one",
        //    NumberOfDirectReports = 7
        //};

        //Console.WriteLine("=============Manager=============");
        //bool mgrPayrollProcessed = mgr.ProcessPayroll();
        //mgr.Terminate(DateTime.Now);
        //bool mgrActive = mgr.IsActive();
    }
}



