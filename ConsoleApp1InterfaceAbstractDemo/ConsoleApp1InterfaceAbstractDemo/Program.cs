using ConsoleApp1interfaceAbstractDemo.Entities;
using ConsoleApp1InterfaceAbstractDemo.Abstract;
using ConsoleApp1InterfaceAbstractDemo.Adapters;
using ConsoleApp1InterfaceAbstractDemo.Concrete;
using System;

namespace ConsoleApp1InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{
                DateOfBirth = new DateTime(1996, 8, 1), FirstName = "Ozlem",LastName = "Altun" ,
                                  NationalityId = "24"});
            Console.ReadLine();

        }
    }

   

}
