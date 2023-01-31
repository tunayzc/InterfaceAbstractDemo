// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class program
    {
        static void Main(string[] args)

        {
            BaseCustomerManager customerManager= new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1998,5,16), FirstName="Tunahan", 
                LastName="Yazıcı", NationalityId="28082377072" });
            Console.ReadLine();

        }

    }


}
