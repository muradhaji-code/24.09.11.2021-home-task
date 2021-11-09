using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._09._11._2021_home_task.CRUD
{
    public interface IDepartmentService
    {
        Department Create(Department employee);
        Department Update(int id, Department employee);
        bool Delete(int id);
        Department[] Read();
        Department Find(int id);
    }
}
