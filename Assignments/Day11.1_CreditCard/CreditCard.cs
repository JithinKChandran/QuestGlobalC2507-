using System;

namespace Day11._1_CreditCard
{
    public class CreditCard
    {
        public string CardHolderName;
        public int CardNumber;
        public int ExpiryMonth;
        public int ExpiryYear;
        public int CVC;

        public CreditCard(int cardNumber, int expiryMonth, int expiryYear, int cvc)
        {
            CardNumber = cardNumber;
            ExpiryMonth = expiryMonth;
            ExpiryYear = expiryYear;
            CVC = cvc;
        }

        public void Display()
        {
            Console.WriteLine($"Card Number: {CardNumber}, Expiry: {ExpiryMonth}/{ExpiryYear}, CVC: {CVC}");
        }
    }
}
