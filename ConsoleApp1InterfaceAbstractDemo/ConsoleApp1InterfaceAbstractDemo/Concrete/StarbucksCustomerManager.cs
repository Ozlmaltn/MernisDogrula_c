using ConsoleApp1interfaceAbstractDemo.Entities;
using ConsoleApp1InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1InterfaceAbstractDemo.Concrete
{
   public class StarbucksCustomerManager:BaseCustomerManager
    {
        
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager()
        {
        }

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("Geçerli kişi değil");
            }
            


            

        }

    }
}
