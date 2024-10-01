using System;

namespace Demo_DesignPattern
{
    // Factory interface for creating orders, payments, and shipping
    public interface IOrderFactory
    {
        IOrder CreateOrder();
        IPayment CreatePayment();
        IShipping CreateShipping();
    }

    // Order interface
    public interface IOrder
    {
        void ProcessOrder();
    }

    // Payment interface
    public interface IPayment
    {
        void ProcessPayment();
    }

    // Shipping interface
    public interface IShipping
    {
        void ProcessShipping();
    }

    // Domestic Order Implementation
    public class DomesticOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing domestic order...");
        }
    }

    public class DomesticPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing domestic payment...");
        }
    }

    public class DomesticShipping : IShipping
    {
        public void ProcessShipping()
        {
            Console.WriteLine("Shipping domestic order...");
        }
    }

    // International Order Implementation
    public class InternationalOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing international order...");
        }
    }

    public class InternationalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing international payment...");
        }
    }

    public class InternationalShipping : IShipping
    {
        public void ProcessShipping()
        {
            Console.WriteLine("Shipping international order...");
        }
    }

    // Concrete Factory for Domestic Products
    public class DomesticOrderFactory : IOrderFactory
    {
        public IOrder CreateOrder()
        {
            return new DomesticOrder();
        }

        public IPayment CreatePayment()
        {
            return new DomesticPayment();
        }

        public IShipping CreateShipping()
        {
            return new DomesticShipping();
        }
    }

    // Concrete Factory for International Products
    public class InternationalOrderFactory : IOrderFactory
    {
        public IOrder CreateOrder()
        {
            return new InternationalOrder();
        }

        public IPayment CreatePayment()
        {
            return new InternationalPayment();
        }

        public IShipping CreateShipping()
        {
            return new InternationalShipping();
        }
    }

    // Main class to demonstrate the Abstract Factory pattern
    internal class Demo_Abstract_Factory
    {
        public static void Main(string[] args)
        {
            // Choose the factory based on the requirement
            IOrderFactory factory = new DomesticOrderFactory();

            IOrder order = factory.CreateOrder();
            IPayment payment = factory.CreatePayment();
            IShipping shipping = factory.CreateShipping();

            // Process the order, payment, and shipping
            order.ProcessOrder();
            payment.ProcessPayment();
            shipping.ProcessShipping();

            // You can switch to InternationalOrderFactory to test international processing
            factory = new InternationalOrderFactory();
            order = factory.CreateOrder();
            payment = factory.CreatePayment();
            shipping = factory.CreateShipping();

            // Process the order, payment, and shipping for international
            order.ProcessOrder();
            payment.ProcessPayment();
            shipping.ProcessShipping();
        }
    }
}