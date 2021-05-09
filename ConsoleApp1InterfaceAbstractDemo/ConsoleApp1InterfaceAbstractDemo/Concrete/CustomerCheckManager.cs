using ConsoleApp1interfaceAbstractDemo.Entities;
using ConsoleApp1InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            return true;
           

        }
    }
}
