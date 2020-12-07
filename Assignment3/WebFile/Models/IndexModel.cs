using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFile.Models
{
    public class IndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

   
        private readonly IAddingService _addingService;


        public IndexModel(IAddingService addingService)
        {

            _addingService = addingService;
        }
        public void Add()
        {
            _addingService.Add(new Student
            {
                Name = "Ahmed Khan",
                DateOfBirth = DateTime.Now
            
            });
        }
    }
}
