using PhumlaKamnandiSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*GROUP MEMBERS: Athule Malgas ,Akhona Mwelase, Zandile Nofemela , Pheliswa Nontsanga, Group 65*/
namespace PhumlaKamnandiSystem.Data
{
    public class DB
    {
            public enum DBOperation
            {
                Add = 0,
                Edit = 1,
                Delete = 2,
            }
            #region Variable declaration
           
            private string strConn = Settings.Default.BookingDatabaseConnectionString;
            protected SqlConnection cnMain;
            protected DataSet dsMain;
            protected SqlDataAdapter daMain;
            #endregion

            #region Constructor
            public DB()
            {
                try
                {
                    //Open a connection & create a new dataset object
                    cnMain = new SqlConnection(strConn);
                    dsMain = new DataSet();
                }
                catch (SystemException e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                    return;
                }
            }

            #endregion

            #region Update the DateSet
            public void FillDataSet(string aSQLstring, string aTable)
            {
                //fills dataset fresh from the db for a specific table and with a specific Query
                try
                {
                    daMain = new SqlDataAdapter(aSQLstring, cnMain);
                    cnMain.Open();
                    daMain.Fill(dsMain, aTable);
                    cnMain.Close();
                }
                catch (Exception errObj)
                {
                    MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                }
            }

            #endregion

            #region Update the data source 
            protected bool UpdateDataSource(string sqlLocal, string table)
            {
                bool success;
                try
                {
                    //open the connection
                    cnMain.Open();
                    //***update the database table via the data adapter
                    daMain.Update(dsMain, table);
                    //---close the connection
                    cnMain.Close();
                    //refresh the dataset
                    FillDataSet(sqlLocal, table);
                    success = true;
                }
                catch (Exception errObj)
                {
                    MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                    success = false;
                }
                finally
                {
                }
                return success;
            }
            #endregion



        }
    }

