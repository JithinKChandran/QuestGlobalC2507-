//// Violating SRP
//using System;

//public class UserProfile
//{
//    public void CreateProfile(User user)
//    {
//        // Code to create user profile
//    }

//    public void GenerateReport(User user)
//    {
//        // Code to generate user profile report
//    }
//}

//// Adhering to SRP
//public class UserProfile
//{
//    public void CreateProfile(User user)
//    {
//        // Code to create user profile
//    }
//}

//public class UserProfileReport
//{
//    public void GenerateReport(User user)
//    {
//        // Code to generate user profile report
//    }
//}

//// Violating OCP
//public class PaymentProcessor
//{
//    public void ProcessPayment(string paymentType)
//    {
//        if (paymentType == "creditCard")
//        {
//            // Process credit card payment
//        }
//        else if (paymentType == "paypal")
//        {
//            // Process PayPal payment
//        }
//    }
//}

//// Adhering to OCP
//public interface IPaymentMethod
//{
//    void ProcessPayment();
//}

//public class CreditCardPayment : IPaymentMethod
//{
//    public void ProcessPayment()
//    {
//        // Process credit card payment
//    }
//}

//public class PayPalPayment : IPaymentMethod
//{
//    public void ProcessPayment()
//    {
//        // Process PayPal payment
//    }
//}

//public class PaymentProcessor
//{
//    private readonly IPaymentMethod _paymentMethod;

//    public PaymentProcessor(IPaymentMethod paymentMethod)
//    {
//        _paymentMethod = paymentMethod;
//    }

//    public void ProcessPayment()
//    {
//        _paymentMethod.ProcessPayment();
//    }
//}




//// Violating LSP
//public class Bird
//{
//    public virtual void Fly()
//    {
//        Console.WriteLine("Bird is flying");
//    }
//}

//public class Ostrich : Bird
//{
//    public override void Fly()
//    {
//        throw new NotImplementedException("Ostrich can't fly");
//    }
//}

//// Adhering to LSP
//public abstract class Bird
//{
//    public abstract void Move();
//}

//public class Sparrow : Bird
//{
//    public override void Move()
//    {
//        Console.WriteLine("Sparrow is flying");
//    }
//}

//public class Ostrich : Bird
//{
//    public override void Move()
//    {
//        Console.WriteLine("Ostrich is running");
//    }
//}




//// Violating ISP
//public interface IWorker
//{
//    void Work();
//    void Eat();
//}

//public class Worker : IWorker
//{
//    public void Work() { /* Work implementation */ }
//    public void Eat() { /* Eat implementation */ }
//}

//public class Robot : IWorker
//{
//    public void Work() { /* Work implementation */ }
//    public void Eat() { /* Empty implementation */ } // Robots don't eat
//}

//// Adhering to ISP
//public interface IWorkable
//{
//    void Work();
//}

//public interface IFeedable
//{
//    void Eat();
//}

//public class Worker : IWorkable, IFeedable
//{
//    public void Work() { /* Work implementation */ }
//    public void Eat() { /* Eat implementation */ }
//}

//public class Robot : IWorkable
//{
//    public void Work() { /* Work implementation */ }
//}




//// Violating DIP
//public class LightBulb
//{
//    public void TurnOn()
//    {
//        // Light bulb on
//    }
//}

//public class Switch
//{
//    private LightBulb _bulb;

//    public Switch(LightBulb bulb)
//    {
//        _bulb = bulb;
//    }

//    public void Operate()
//    {
//        _bulb.TurnOn();
//    }
//}

//// Adhering to DIP
//public interface IDevice
//{
//    void TurnOn();
//}

//public class LightBulb : IDevice
//{
//    public void TurnOn()
//    {
//        // Light bulb on
//    }
//}

//public class Switch
//{
//    private IDevice _device;

//    public Switch(IDevice device)
//    {
//        _device = device;
//    }

//    public void Operate()
//    {
//        _device.TurnOn();
//    }
//}
