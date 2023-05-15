using System;


    interface ICreditCard
    {
        string CardholderName { get; set; }
        string CardNumber { get; set; }
        DateTime CardExpiryDate { get; set; }
        int CardVerificationValue { get; set; }
        double CreditCardLimit { get; set; }
        string Currency { get; }
        void PutMoney(double amount);
        void Payment(double amount, DateTime expiryDate, int verificationValue);
        void ViewCardInformation();
    }

    interface IVisa : ICreditCard
    {
        double ConvertToEuro();
    }

    interface IMasterCard : ICreditCard
    {
    }

    public class CreditCard : ICreditCard
    {
        public string CardholderName { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardExpiryDate { get; set; }
        public int CardVerificationValue { get; set; }
        private double _creditCardLimit;
        public double CreditCardLimit
        {
            get { return _creditCardLimit; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Credit card limit cannot be negative");
                }
                _creditCardLimit = value;
            }
        }
        public string Currency
        {
            get { return "USD"; }
        }
        public void PutMoney(double amount)
        {
            CreditCardLimit += amount;
            Console.WriteLine("Your card has received a payment: " + amount);
            Console.WriteLine("Current balance: " + CreditCardLimit + " " + Currency);
        }
        public void Payment(double amount, DateTime expiryDate, int verifiValue)
        {
            if (CardVerificationValue != verifiValue || expiryDate <= DateTime.Today)
            {
                Console.WriteLine("The information you entered is not valid");
                return;
            }
            if (amount > CreditCardLimit)
            {
                Console.WriteLine("Transaction declined: " + amount);
                Console.WriteLine("Reason: Over limit");
                return;
            }
            CreditCardLimit -= amount;
            Console.WriteLine("Your card has been charged: " + amount);
            Console.WriteLine("Current balance: " + CreditCardLimit + " " + Currency);
        }
        public void ViewCardInformation()
        {
            Console.WriteLine("Cardholder Name: " + CardholderName);
            Console.WriteLine("Card Number: " + CardNumber);
            Console.WriteLine("Credit Card Limit: " + CreditCardLimit + " " + Currency);
        }
    }

    public class Visa : CreditCard, IVisa
    {
        public double ConvertToEuro()
        {
            double euroAmount = CreditCardLimit * 0.93;
            Console.WriteLine("Credit Card Limit: " + euroAmount + " EURO");
            return euroAmount;
        }
    }

    public class MasterCard : CreditCard, IMasterCard
    {
    }

    class Assignment4
    {
        static void Main(string[] args)
        {
            var visaCard = new Visa();
            visaCard.CardholderName = "John Smith";
            visaCard.CardNumber = "1234567890123456";
            visaCard.CardExpiryDate = new DateTime(2025, 1, 1);
            visaCard.CardVerificationValue = 123;
            visaCard.ViewCardInformation();
            visaCard.PutMoney(1000);
            visaCard.Payment(500, new DateTime(2025, 1, 1), 123);
            visaCard.ConvertToEuro();

        }
    }
