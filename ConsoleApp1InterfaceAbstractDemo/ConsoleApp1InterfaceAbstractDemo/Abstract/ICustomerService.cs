using ConsoleApp1interfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1InterfaceAbstractDemo.Abstract
{
   public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
