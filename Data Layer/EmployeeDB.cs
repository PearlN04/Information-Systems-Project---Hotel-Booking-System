using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Data
{
    public class EmployeeDB:DB
    {
        
            #region  Data members        
            private string table1 = "Receptionist";
            private string sqlLocal1 = "SELECT * FROM Receptionist";
            private string table2 = "Manager";
            private string sqlLocal2 = "SELECT * FROM Manager";
            private Collection<Employee> employees;

            #endregion

            #region Property Method: Collection
            public Collection<Employee> AllEmployees
            {
                get
                {
                    return employees;
                }
            }
            #endregion

            #region Constructor
            public EmployeeDB() : base()
            {
                employees = new Collection<Employee>();
                FillDataSet(sqlLocal1, table1);
                Add2Collection(table1);
                FillDataSet(sqlLocal2, table2);
                Add2Collection(table2);
                
            }
            #endregion

            #region Utility Methods
            public DataSet GetDataSet()
            {
                return dsMain;
            }
            private void Add2Collection(string table)
            {
                //Declare references to a myRow object and an Employee object
                DataRow myRow = null;
                Employee anEmp;
                Receptionist receptionist;
                Manager manager;
                
                Role.RoleType roleValue = Role.RoleType.NoRole;  //Declare roleValue and initialise
                switch (table)
                {
                    case "Receptionist":
                        roleValue = Role.RoleType.Receptionist;
                        break;
                    case "Manager":
                        roleValue = Role.RoleType.Manager;
                        break;
                    
                }
                //READ from the table  
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new Employee object
                        anEmp = new Employee(roleValue);
                        //Obtain each employee attribute from the specific field in the row in the table
                        anEmp.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                        //Do the same for all other attributes
                        anEmp.EmployeeID = Convert.ToString(myRow["EMPID"]).TrimEnd();
                        anEmp.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                        anEmp.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                        anEmp.role.getRoleValue = (Role.RoleType)Convert.ToByte(myRow["Role"]);
                        anEmp.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                        anEmp.Password = Convert.ToString(myRow["Password"]).TrimEnd();
                        anEmp.HotelID = Convert.ToString(myRow["HotelID"]).TrimEnd(); ;
                    //Depending on Role read more Values
                    switch (anEmp.role.getRoleValue)
                        {
                            case Role.RoleType.Receptionist:
                                receptionist = (Receptionist)anEmp.role;
                                break;
                            case Role.RoleType.Manager:
                                manager = (Manager)anEmp.role;
                                break;
                      
                        }
                        employees.Add(anEmp);
                    }
                }
            }
            private void FillRow(DataRow aRow, Employee anEmp, DB.DBOperation operation)
            {
                Receptionist receptionist;
                Manager manager;

                if (operation == DB.DBOperation.Add)
                {
                    aRow["ID"] = anEmp.ID;  //NOTE square brackets to indicate index of collections of fields in row.
                    aRow["EmpID"] = anEmp.EmployeeID;
                }
                aRow["Name"] = anEmp.Name;
                aRow["Phone"] = anEmp.Telephone;
                aRow["Email"] = anEmp.Email;
                aRow["Role"] = (byte)anEmp.role.getRoleValue;
                aRow["Password"] = anEmp.Password;
                aRow["HotelID"] = anEmp.HotelID;
                //*** For each role add the specific data variables
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        receptionist = (Receptionist)anEmp.role;
                        break;
                    case Role.RoleType.Manager:
                        manager = (Manager)anEmp.role;
                        break;
            
                }
            }

            private int FindRow(Employee anEmp, string table)
            {
                int rowIndex = 0;
                DataRow myRow;
                int returnValue = -1;


                foreach (DataRow myRow_loopVarianble in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVarianble;
                    if (myRow.RowState != DataRowState.Deleted)
                    {
                        if (anEmp.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                        {
                            returnValue = rowIndex;
                        }
                    }
                    rowIndex = rowIndex + 1;

                }
                return returnValue;
            }
            #endregion

            #region Database Operations CRUD
            public void DataSetChange(Employee anEmp, DB.DBOperation operation)
            {
                DataRow aRow = null;
                string dataTable = table1;
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        dataTable = table1;
                        break;
                    case Role.RoleType.Manager:
                        dataTable = table2;
                        break;
                    
                }

                switch (operation)
                {
                    case DB.DBOperation.Add:
                        aRow = dsMain.Tables[dataTable].NewRow();
                        FillRow(aRow, anEmp, operation);
                        dsMain.Tables[dataTable].Rows.Add(aRow);
                        break;

                    case DB.DBOperation.Edit:
                        aRow = dsMain.Tables[dataTable].Rows[FindRow(anEmp, dataTable)];
                        FillRow(aRow, anEmp, operation);
                        break;

                    case DB.DBOperation.Delete:
                        int rowIndex = FindRow(anEmp, dataTable);
                        if (rowIndex >= 0)
                        {
                            dsMain.Tables[dataTable].Rows.RemoveAt(rowIndex);
                        }
                        break;
                }
            }
            #endregion

            #region Build Parameters, Create Commands & Update database
            private void Build_INSERT_Parameters(Employee anEmp)
            {
                //Create Parameters to communicate with SQL INSERT
                SqlParameter param = default(SqlParameter);
                param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@EMPID", SqlDbType.NVarChar, 10, "EMPID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Name", SqlDbType.NVarChar, 10, "Name");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Role", SqlDbType.TinyInt, 1, "Role");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar, 30, "Email");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Password", SqlDbType.NVarChar, 15, "Password");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@HotelID", SqlDbType.NVarChar, 15, "HotelID");
                daMain.InsertCommand.Parameters.Add(param);

  
            }

            private void Create_INSERT_Command(Employee anEmp)
            {
                //Create the command that must be used to insert values into the Books table..
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        daMain.InsertCommand = new SqlCommand("INSERT into Receptionist (ID, EMPID, Name, Phone, Role, Email,Password,HotelID) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Email, @Password, @HotelID)", cnMain);
                        break;
                    case Role.RoleType.Manager:
                        daMain.InsertCommand = new SqlCommand("INSERT into Manager (ID, EMPID, Name, Phone, Role, Email, Password, HotelID) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Email, @Password, @HotelID)", cnMain);
                        break;
                   
                }
                Build_INSERT_Parameters(anEmp);
            }

            public bool UpdateDataSource(Employee anEmp)
            {
                bool success = true;
                Create_INSERT_Command(anEmp);
                Create_UPDATE_Command(anEmp);
                Create_DELETE_Command(anEmp);
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        success = UpdateDataSource(sqlLocal1, table1);
                        break;
                    case Role.RoleType.Manager:
                        success = UpdateDataSource(sqlLocal2, table2);
                        break;
                }
                return success;
            }

            #endregion

            private void Build_UPDATE_Parameters(Employee anEmp)
            {
                SqlParameter param = default(SqlParameter);
                param = new SqlParameter("@Name", SqlDbType.NChar, 100, "Name");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Role", SqlDbType.TinyInt, 1, "Role");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar, 30, "Email");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Password", SqlDbType.NVarChar, 15, "Password");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@HotelID", SqlDbType.NVarChar, 15, "HotelID");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);
         
                param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);
            }

            private void Build_DELETE_Parameters(Employee anEmp)
            {
                SqlParameter param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.DeleteCommand.Parameters.Add(param);
            }

            private void Create_UPDATE_Command(Employee anEmp)
            {
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        daMain.UpdateCommand = new SqlCommand("UPDATE Receptionist SET Name=@Name, Phone=@Phone, Role=@Role, Email=@Email , Password=@Password, HotelID=@HotelID " + "WHERE ID=@Original_ID", cnMain);
                        break;
                    case Role.RoleType.Manager:
                        daMain.UpdateCommand = new SqlCommand("UPDATE Manager SET Name=@Name, Phone=@Phone, Role=@Role, Email=@Email, Password=@Password, HotelID =@HotelID" + "WHERE ID=@Original_ID", cnMain);
                        break;
                  

                }
                Build_UPDATE_Parameters(anEmp);
            }

            private void Create_DELETE_Command(Employee anEmp)
            {
                switch (anEmp.role.getRoleValue)
                {
                    case Role.RoleType.Receptionist:
                        daMain.DeleteCommand = new SqlCommand("DELETE FROM Receptionist WHERE ID=@ID", cnMain);
                        break;
                    case Role.RoleType.Manager:
                        daMain.DeleteCommand = new SqlCommand("DELETE FROM Manager WHERE ID=@ID", cnMain);
                        break;
                    
                }
                Build_DELETE_Parameters(anEmp);
            }

        }

    }

