using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataOperation = new DataOperation<House>();

            var room = new Room { Rent = 2900 };
            var room8 = new Room { Rent = 8000 };
          
            var house = new House
            {
                Name = "Yellow House",
                Rooms = new List<Room> { room, room8 }
            };

            //dataOperation.Insert(house);  //This is insert opetation


            var room2 = new Room { Id = 5 , Rent=1000};
            var room9 = new Room { Id = 6 , Rent=3400};

            var house2 = new House
            {
                Rooms = new List<Room> { room2,room9 }
            };

            //dataOperation.Update(house2); //this is Update operation


            var room3 = new Room {Id=11};
            var room11 = new Room {Id=9};

            var house3 = new House
            {
                 Rooms = new List<Room> { room3,room11 }
            };

            //dataOperation.Delete(house3); //This is Delete operation

            //dataOperation.GetById(15);  //This is GetById operation

            //dataOperation.GetAll();  // This is GetAll operation
        }
    }
}
