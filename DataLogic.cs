using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UchetAvto
{
    public class DataLogic : DataManager
    {

        public bool CheckUser(string username, string email, string password, string type)
        {
            string parametrs = $"WHERE Username LIKE '{username}' OR Email LIKE '{email}' AND Pass LIKE '{password}' AND UserType LIKE '{type}'";
            SqlDataReader getUser = SelectValues("Users", parametrs);
            while (getUser.Read())
            {
                if (getUser["Username"].ToString() == username && getUser["Pass"].ToString() == password) return true;
                else return false;
            }
            return false;

        }
        public List<DataObjects.PutLists> GetPutLists(string parameters)
        {
            DataObjects.PutLists pl = new DataObjects.PutLists();
            SqlDataReader getLists = SelectValues("Lists", parameters);
            List<DataObjects.PutLists> lists = new List<DataObjects.PutLists>();
            while (getLists.Read())
            {
                pl.Id = getLists["Id"].ToString();
                pl.CarId = getLists["Car"].ToString();
                pl.DriverId = getLists["Driver"].ToString();
                pl.Date_Start = getLists["Date Start"].ToString();
                pl.Date_End = getLists["Date End"].ToString();
                pl.Start_Oils = getLists["Start Oils"].ToString();
                pl.End_Oils = getLists["End Oils"].ToString();
                pl.MarshrutId = getLists["Marshrut"].ToString();
                pl.Mass = getLists["Mass"].ToString();
                lists.Add(pl);
            }
            getLists.Close();
            return lists;
        }

        public List<DataObjects.Car> GetCars(string parameters) {
            
            List<DataObjects.Car> cars = new List<DataObjects.Car>();
            SqlDataReader getCars = SelectValues("Cars", parameters);
            while (getCars.Read())
            {
                DataObjects.Car car = new DataObjects.Car();
                car.Id = getCars["Id"].ToString();
                car.Name_Car = getCars["Name Car"].ToString();
                car.Marks = getCars["Marks"].ToString();
                car.CarTypeId = getCars["Car Type"].ToString();
                car.Org = getCars["Org"].ToString();
                car.Colonna = getCars["Colonna"].ToString();
                car.Date_realese = getCars["Date realease"].ToString();
                car.Car_Number = getCars["Car Number"].ToString();
                car.Motor_Number = getCars["Motor Minber"].ToString();
                car.Kuzov_Number = getCars["Kuzov Number"].ToString();
                car.Tech_Status = getCars["Tech Status"].ToString();
                car.Max_Speed = getCars["Max Speed"].ToString();
                car.OilMarksId = getCars["Oil Marks"].ToString();
                car.Oils_Lost = getCars["Oils Lost"].ToString();
                cars.Add(car);
            }
            getCars.Close();
            return cars;
        }

        public List<DataObjects.Drivers> GetDrivers(string parameters)
        {
           
            List<DataObjects.Drivers> drivers = new List<DataObjects.Drivers>();
            SqlDataReader getDrivers = SelectValues("Drivers", parameters);
            while (getDrivers.Read())
            {
                DataObjects.Drivers driver = new DataObjects.Drivers();
                driver.Id = getDrivers["Id"].ToString();
                driver.LastName = getDrivers["LastName"].ToString();
                driver.FirstName = getDrivers["FirstName"].ToString();
                driver.AfterName = getDrivers["AfterName"].ToString();
                driver.DateBorn = getDrivers["DateBorn"].ToString();
                driver.WorkTime = getDrivers["WorkTime"].ToString();
                driver.Currency = getDrivers["Currency"].ToString();
                driver.Category = getDrivers["Category"].ToString();
                drivers.Add(driver);
            }
            getDrivers.Close();
            return drivers;
        }

        public List<DataObjects.Car_Type> getCarTypes(string parameters)
        {
            
            List<DataObjects.Car_Type> car_types = new List<DataObjects.Car_Type>();
            SqlDataReader getTypes = SelectValues("Car Type", parameters);
            while (getTypes.Read())
            {
                DataObjects.Car_Type car_type = new DataObjects.Car_Type();
                car_type.Id = getTypes["Id"].ToString();
                car_type.CarType = getTypes["Car Type"].ToString();
                car_types.Add(car_type);
            }
            getTypes.Close();
            return car_types;
        }
    }
}
