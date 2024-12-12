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
        public class RoomsDB : DB
        {

            #region  Data members        
            private string table1 = "Rooms";
            private string sqlLocal1 = "SELECT * FROM Rooms";
            private Collection<Rooms> rooms;

            #endregion

            #region Property Method: Collection
            public Collection<Rooms> AllRooms
            {
                get
                {
                    return rooms;
                }
            }
            #endregion

            #region Constructor
            public RoomsDB() : base()
            {
                rooms = new Collection<Rooms>();
                FillDataSet(sqlLocal1, table1);
                Add2Collection(table1);
                

            }
            #endregion

            #region Utility Methods
            public DataSet GetDataSet()
            {
                return dsMain;
            }

            private void Add2Collection(string table)
            {
               
                DataRow myRow = null;
                Rooms anRoom;
                Rooms room;

                 
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVariable;
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        anRoom = new Rooms();
                        anRoom.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                        anRoom.HotelID = Convert.ToString(myRow["HotelID"]).TrimEnd();
                        anRoom.Date = Convert.ToDateTime(myRow["Date"]);
                        anRoom.NumRoomsAvailable = Convert.ToInt32(myRow["NumberOfRoomsAvailable"]);

                        rooms.Add(anRoom);
                    }
                }
            }

            private void FillRow(DataRow aRow, Rooms anEmp, DB.DBOperation operation)
            {
                

                if (operation == DB.DBOperation.Add)
                {
                    aRow["ID"] = anEmp.ID;
                    aRow["HotelID"] = anEmp.HotelID;
                }
                aRow["Date"] = anEmp.Date;
                aRow["NumberOfRoomsAvailable"] = anEmp.NumRoomsAvailable;
               
            }

            private int FindRow(Rooms anRoom, string table)
            {
                int rowIndex = 0;
                DataRow myRow;
                int returnValue = -1;


                foreach (DataRow myRow_loopVarianble in dsMain.Tables[table].Rows)
                {
                    myRow = myRow_loopVarianble;
                    if (myRow.RowState != DataRowState.Deleted)
                    {
                        if (anRoom.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
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
            public void DataSetChange(Rooms anRoom, DB.DBOperation operation)
            {
                DataRow aRow = null;
                string dataTable = table1;
                
                        dataTable = table1;
                    

                switch (operation)
                {
                    case DB.DBOperation.Add:
                        aRow = dsMain.Tables[dataTable].NewRow();
                        FillRow(aRow, anRoom, operation);
                        dsMain.Tables[dataTable].Rows.Add(aRow);
                        break;

                    case DB.DBOperation.Edit:
                        aRow = dsMain.Tables[dataTable].Rows[FindRow(anRoom, dataTable)];
                        FillRow(aRow, anRoom, operation);
                        break;

                    case DB.DBOperation.Delete:
                        int rowIndex = FindRow(anRoom, dataTable);
                        if (rowIndex >= 0)
                        {
                            dsMain.Tables[dataTable].Rows.RemoveAt(rowIndex);
                        }
                        break;
                }
            }
            #endregion

            #region Build Parameters, Create Commands & Update database
            private void Build_INSERT_Parameters(Rooms anRoom)
            {
                SqlParameter param = default(SqlParameter);
                param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@HotelID", SqlDbType.NVarChar, 10, "HotelID");
                daMain.InsertCommand.Parameters.Add(param);

            
                param = new SqlParameter("@Date", SqlDbType.Date);
                param.SourceColumn = "Date";  // Bind to the "Date" column in your DataTable
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@NumberOfRoomsAvailable", SqlDbType.Int, 10, "NumberOfRoomsAvailable");
                daMain.InsertCommand.Parameters.Add(param);

            }


            private void Create_INSERT_Command(Rooms anRoom)
            {
                
               daMain.InsertCommand = new SqlCommand("INSERT into Rooms (ID, HotelID, Date, NumberOfRoomsAvailable) VALUES (@ID, @HotelID, @Date, @NumberOfRoomsAvailable)", cnMain);
                       
                Build_INSERT_Parameters(anRoom);
            }

            public bool UpdateDataSource(Rooms anRoom)
            {
                bool success = true;
                Create_INSERT_Command(anRoom);
                Create_UPDATE_Command(anRoom);
                Create_DELETE_Command(anRoom);
                success = UpdateDataSource(sqlLocal1, table1);
                return success;
            }
            

            private void Build_UPDATE_Parameters(Rooms anRoom)
            {
                SqlParameter param = default(SqlParameter);
                param = new SqlParameter("@HotelID", SqlDbType.NChar, 100, "HotelID");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Date", SqlDbType.Date);
                param.SourceColumn = "Date";  // Bind to the "Date" column in your DataTable
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@NumberOfRoomsAvailable", SqlDbType.Int, 10, "NumberOfRoomsAvailable");
                param.SourceVersion = DataRowVersion.Current;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);
            }

            private void Build_DELETE_Parameters(Rooms anRoom)
            {
                SqlParameter param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.DeleteCommand.Parameters.Add(param);
            }

            private void Create_UPDATE_Command(Rooms anRoom)
            {
               
                daMain.UpdateCommand = new SqlCommand("UPDATE Rooms SET HotelID=@HotelID, Date=@Date, NumberOfRoomsAvailable=@NumberOfRoomsAvailable " + "WHERE ID=@Original_ID", cnMain);
                Build_UPDATE_Parameters(anRoom);
            }

            private void Create_DELETE_Command(Rooms anRoom)
            {
                
                daMain.DeleteCommand = new SqlCommand("DELETE FROM Rooms WHERE ID=@ID", cnMain);   
                Build_DELETE_Parameters(anRoom);
            }
        #endregion

    }

}
