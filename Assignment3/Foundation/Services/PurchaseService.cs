using Foundation.Entities;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IShopingUnitOfWork _shopingUnitOfWork;
        public PurchaseService(IShopingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }

        public void Purchase(Student student)
        {
            _shopingUnitOfWork.StudentRepository.Add(student);
            _shopingUnitOfWork.Save();
        }
    }
}