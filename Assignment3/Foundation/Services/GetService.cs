using Foundation.Entities;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class GetService : IGetService
    {
        private readonly IShopingUnitOfWork _shopingUnitOfWork;


        public GetService(IShopingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }


        public IList<Student> GetstudentList() 
        {
            return _shopingUnitOfWork.StudentRepository.GetAll();
        }
    }
}
