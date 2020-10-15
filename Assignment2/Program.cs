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

            var room = new Room { Rent = 5500 };
          
            var house = new House
            {
                Name = "Yellow House",
                Rooms = new List<Room> { room }
            };

            //dataOperation.Insert(house);  //This is insert opetation



            var room2 = new Room { Id = 4 , Rent=5500};

            var house2 = new House
            {
                Rooms = new List<Room> { room2 }
            };

            //dataOperation.Update(house2); //this is Update operation



            var room3 = new Room {Id=3};

            var house3 = new House
            {
                 Rooms = new List<Room> { room3 }
            };

            //dataOperation.Delete(house3); //This is Delete operation

            //dataOperation.GetById(2);  //This is GetById

            //dataOperation.GetAll();  // This is GetAll operation
        }
    }
}
