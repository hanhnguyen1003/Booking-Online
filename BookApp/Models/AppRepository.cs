using WebApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppRepository
    {
        DepartmentRepository department;

       public DepartmentRepository Department
        {
            get
            {
                if (department is null)
                {
                    department = new DepartmentRepository();
                }
                return department;
            }
        }

    }
}
