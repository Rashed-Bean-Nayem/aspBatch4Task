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
            
           var dataOperation2 = new DataOperation<House>();

            var room = new Room { Rent = 2.9 };
          

            var house = new House
            {
                //Id = 21,
                Name = "HouseYou",
                Rooms = new List<Room> { room }
                
            };
         
           dataOperation2.Insert(house);
    
        }
    }
}
