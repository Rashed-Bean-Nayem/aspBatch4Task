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

            //dataOperation.Insert(house);



            var room2 = new Room { Id = 3 , Rent=6500};

            var house2 = new House
            {
                Rooms = new List<Room> { room2 }
            };

            //dataOperation.Update(house2);



            var room3 = new Room {Id=3};

            var house3 = new House
            {
                 Rooms = new List<Room> { room3 }
            };

            //dataOperation.Delete(house3);

            //dataOperation.GetAll();

            //dataOperation.GetById(5);
        }
    }
}
