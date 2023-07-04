using System;
using System.Collections.Generic;


namespace AssignmentOrder
{
    

    public class Order
    {
        private static int orderId = 0;
        private static decimal orderValue = 0;

        public int OrderId { get; }
        public int ItemId { get; }
        public int ItemQuantity { get; }
        public decimal ItemPrice { get; }
        public decimal OrderAmt { get; }

        public Order(int itemId, int itemQuantity, decimal itemPrice)
        {
            OrderId = ++orderId;
            ItemId = itemId;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            OrderAmt = itemQuantity * itemPrice;
            orderValue += OrderAmt;
        }
    }

    public class Customer
    {
        public int CustId { get; }
        public string Name { get; }
        public string City { get; }
        public string Password { get; }

        public Customer(int custId, string name, string city, string password)
        {
            CustId = custId;
            Name = name;
            City = city;
            Password = password;
        }
    }

    public class Stock
    {
        private Dictionary<int, int> stock;

        public Stock()
        {
            stock = new Dictionary<int, int>();
        }

        public void AddItem(int itemId, int quantity)
        {
            stock[itemId] = quantity;
        }

        public void UpdateStock(int itemId, int quantity)
        {
            if (stock.ContainsKey(itemId))
            {
                stock[itemId] -= quantity;
            }
        }

        public int GetStock(int itemId)
        {
            return stock.ContainsKey(itemId) ? stock[itemId] : 0;
        }
    }

    public class OrderEntryApp
    {
        private Dictionary<int, Customer> customers;
        private Stock stock;
        private List<Order> orders;

        public object Stock { get; internal set; }

        public OrderEntryApp()
        {
            customers = new Dictionary<int, Customer>();
            stock = new Stock();
            orders = new List<Order>();
        }

        public void RegisterCustomer(int custId, string name, string city, string password)
        {
            Customer customer = new Customer(custId, name, city, password);
            customers[custId] = customer;
        }

        public bool Login(int custId, string password)
        {
            if (customers.TryGetValue(custId, out Customer customer))
            {
                return customer.Password == password;
            }
            return false;
        }

        public bool PlaceOrder(int custId, int itemId, int itemQuantity)
        {
            if (customers.TryGetValue(custId, out Customer customer))
            {
                int stockQty = stock.GetStock(itemId);
                if (stockQty >= itemQuantity)
                {
                    decimal itemPrice = 10; // Replace with your logic to fetch the item price
                    Order order = new Order(itemId, itemQuantity, itemPrice);
                    orders.Add(order);
                    stock.UpdateStock(itemId, itemQuantity);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void ShowOrders()
        {
            foreach (Order order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
                Console.WriteLine($"Item ID: {order.ItemId}");
                Console.WriteLine($"Quantity: {order.ItemQuantity}");
                Console.WriteLine($"Price: {order.ItemPrice}");
                Console.WriteLine($"Order Amount: {order.OrderAmt}");
                Console.WriteLine();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            OrderEntryApp app = new OrderEntryApp();
            app.RegisterCustomer(1, "Ankit", "Nagpur", "password");
            app.RegisterCustomer(2, "Adwait", "Mumbai", "pass123");
            app.RegisterCustomer(3, "Pranay", "kuhi", "abcxyz");

            object value = app.Stock.AddItem(101, 103);
            object value2 = app.Stock.AddItem(102, 100);

            int custId = 1;
            string password = "password";

            if (app.Login(custId, password))
            {
                if (app.PlaceOrder(custId, 101, 5))
                {
                    Console.WriteLine("Order placed successfully!");
                }
                else
                {
                    Console.WriteLine("Insufficient stock.");
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }

            Console.WriteLine();
            Console.WriteLine("All Orders:");
            app.ShowOrders();
        }
    }

}