using System;
namespace UchetAvto
{
    public class DataObjects
    {
        //table "Lists"
        public class PutLists
        {
            //9
            public string Id;
            public string CarId;
            public string DriverId;
            public string Date_Start;
            public string Date_End;
            public string Start_Oils;
            public string End_Oils;
            public string MarshrutId;
            public string Mass;
        }
        //table "Drivers"
        public class Drivers
        {
            //8
            public string Id;
            public string LastName;
            public string FirstName;
            public string AfterName;
            public string DateBorn;
            public string WorkTime;
            public string Currency;
            public string Category;
        }
        //table "Oils"
        public class Oils
        {
            //6
            public string Id;
            public string ListId;
            public string Check_Number;
            public string Time;
            public string OilMarks;
            public string Value;
        }
        //table "Oil Marks"
        public class Oil_Marks
        {
            //3
            public string Id;
            public string Oil_Mark;
            public string Price;
        }
        //table "Marshruts"
        public class Marshruts
        {
            //8
            public string Id;
            public string From;
            public string To;
            public string Date_Start;
            public string Date_End;
            public string Length;
            public string Oils_lost;
            public string Time_to_sleep;
        }
        //table "Car Type"
        public class Car_Type
        {
            public string Id;
            public string CarType;
        }
        //table "Car"
        public class Car
        {
            //14
            public string Id;
            public string Name_Car;
            public string Marks;
            public string CarTypeId;
            public string Org;
            public string Colonna;
            public string Date_realese;
            public string Car_Number;
            public string Motor_Number;
            public string Kuzov_Number;
            public string Tech_Status;
            public string Max_Speed;
            public string OilMarksId;
            public string Oils_Lost;
        }

    }
}
