using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._09._11._2021_home_task.CRUD
{
    public class DepartmentService : IDepartmentService
    {
        private Department[] Departments = new Department[0];

        public Department Create(Department department)
        {
            if (Departments.Length == 0)
                department.Id = 1;
            else
                department.Id = Departments[Departments.Length - 1].Id + 1;

            Array.Resize(ref Departments, Departments.Length + 1);
            Departments[Departments.Length - 1] = department;
            return department;
        }

        public bool Delete(int Id)
        {
            Department[] newArr = Array.FindAll(Departments, item => item.Id != Id);
            if (newArr.Length < Departments.Length)
            {
                Departments = newArr;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Department Find(int Id)
        {
            return Array.Find(Departments, item => item.Id == Id);
        }

        public Department[] Read()
        {
            return this.Departments;
        }

        public Department Update(int Id, Department department)
        {
            Department foundDepartment = Array.Find(Departments, item => item.Id == Id);
            foundDepartment = department;
            return foundDepartment;
        }
    }
}
