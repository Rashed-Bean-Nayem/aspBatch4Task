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
            //dataOperation.GetAll();
            dataOperation.GetById(5);



    
        }
    }
}
