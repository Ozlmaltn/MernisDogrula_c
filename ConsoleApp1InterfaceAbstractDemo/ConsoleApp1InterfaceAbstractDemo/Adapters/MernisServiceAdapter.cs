using ConsoleApp1interfaceAbstractDemo.Entities;
using ConsoleApp1InterfaceAbstractDemo.Abstract;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year);

        }
    }
}
