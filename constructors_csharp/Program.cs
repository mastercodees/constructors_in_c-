using System;
using System.Collections.Generic;

namespace constructors_csharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
      
    } 
    public class Order
    {
            
    }
     class Program
    {
        public static void Main()
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "john";
            
            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name); 
        }
    }
}