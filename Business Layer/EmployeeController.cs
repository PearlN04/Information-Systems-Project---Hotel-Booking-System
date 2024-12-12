using PhumlaKamnandiSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Business
{
    public class EmployeeController
    {
 
            #region Data Members
            EmployeeDB employeeDB;
            Collection<Employee> employees;
            #endregion

            #region Properties
            public Collection<Employee> AllEmployees
            {
                get
                {
                    return employees;
                }
            }
            #endregion

            #region Constructor
            public EmployeeController()
            {
                //***instantiate the EmployeeDB object to communicate with the database
                employeeDB = new EmployeeDB();
                employees = employeeDB.AllEmployees;
            }
            #endregion

            #region Database Communication.
            public void DataMaintenance(Employee anEmp, DB.DBOperation operation)
            {
                int index = 0;
                //perform a given database operation to the dataset in memory; 
                employeeDB.DataSetChange(anEmp, operation);
                switch (operation)
                {
                    case DB.DBOperation.Add:
                        employees.Add(anEmp);
                        break;
                    case DB.DBOperation.Edit:
                        index = FindIndex(anEmp);
                        employees[index] = anEmp;
                        break;
                    case DB.DBOperation.Delete:
                        index = FindIndex(anEmp);
                        if (index >= 0)
                        {
                            employees.RemoveAt(index);
                        }
                        break;
                }

            }

            //***Commit the changes to the database
            public bool FinalizeChanges(Employee employee)
            {
                return employeeDB.UpdateDataSource(employee);
            }
            #endregion


            #region Search Method
            public Collection<Employee> FindByRole(Collection<Employee> emps, Role.RoleType roleVal)
            {
                Collection<Employee> matches = new Collection<Employee>();
                foreach (Employee emp in emps)
                {
                    if (emp.role.getRoleValue == roleVal)
                    {
                        matches.Add(emp);
                    }
                }
                return matches;
            }

            public Employee Find(string id)
            {
                int index = 0;
                bool found = (employees[index].ID == id);
                int count = employees.Count;

                while (!(found) && (index < employees.Count - 1))
                {
                    index = index + 1;
                    found = (employees[index].ID == id);
                }
                return employees[index];
            }

            public int FindIndex(Employee anEmp)
            {
                int counter = 0;
                bool found = false;
                found = (anEmp.ID == employees[counter].ID);

                while (!found && counter != employees.Count)
                {
                    counter = counter + 1;
                    found = (anEmp.ID == employees[counter].ID);
                }
                if (found)
                {
                    return counter;
                }
                else
                {
                    return -1;
                }

            }
            #endregion
        }
    }
