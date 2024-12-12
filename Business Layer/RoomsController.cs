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
    public class RoomsController
    {

            #region Data Members
            RoomsDB roomsDB;
            Collection<Rooms> rooms;
            #endregion

            #region Properties
            public Collection<Rooms> AllRooms
            {
                get
                {
                    return rooms;
                }
            }
            #endregion

            #region Constructor
            public RoomsController()
            {
                //***instantiate the RoomsDB object to communicate with the database
                roomsDB = new RoomsDB();
                rooms = roomsDB.AllRooms;
            }
            #endregion

            #region Database Communication.
            public void DataMaintenance(Rooms anRoom, DB.DBOperation operation)
            {
                int index = 0;
                roomsDB.DataSetChange(anRoom, operation);
                switch (operation)
                {
                    case DB.DBOperation.Add:
                        rooms.Add(anRoom);
                        break;
                    case DB.DBOperation.Edit:
                        index = FindIndex(anRoom);
                        rooms[index] = anRoom;
                        break;
                    case DB.DBOperation.Delete:
                        index = FindIndex(anRoom);
                        if (index >= 0)
                        {
                            rooms.RemoveAt(index);
                        }
                        break;
                }

            }

            //***Commit the changes to the database
            public bool FinalizeChanges(Rooms room)
            {
                return roomsDB.UpdateDataSource(room);
            }
            #endregion


            #region Search Method
            public Collection<Rooms> FindByRole(Collection<Rooms> rms)
            {
                Collection<Rooms> matches = new Collection<Rooms>();
                foreach (Rooms emp in rms)
                {

                    matches.Add(emp);

                }
                return matches;
            }

            public Rooms Find(string id)
            {
                int index = 0;
                bool found = (rooms[index].ID == id);
                int count = rooms.Count;

                while (!(found) && (index < rooms.Count - 1))
                {
                    index = index + 1;
                    found = (rooms[index].ID == id);
                }
                return rooms[index];
            }

            public int FindIndex(Rooms anRoom)
            {
                int counter = 0;
                bool found = false;
                found = (anRoom.ID == rooms[counter].ID);

                while (!found && counter != rooms.Count)
                {
                    counter = counter + 1;
                    found = (anRoom.ID == rooms[counter].ID);
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
