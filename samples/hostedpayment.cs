using System;
using VoguepaySDK;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create voguepay merchant instance
            Merchant merchantinfo = new Merchant();
            merchantinfo.MerchantID = "6359-0000000";
            merchantinfo.Username = "username";
            merchantinfo.Email = "sample@gmail.com"; 

            //Create voguepay instance (Parameters "live" or "demo", default is demo)
            Voguepay voguepay = new Voguepay("live");
            voguepay.Init(merchantinfo);

            //Create customer instance
            Customerinfo customer = new Customerinfo();
            customer.Name = "Sam Great";
            customer.Phone = "20339922";
            customer.Email = "sample@yahoo.com";
            customer.City = "Allen";
            customer.Country = "NGA";
            customer.State = "Ikeja";
            customer.ZipCode = "23401";
            customer.Address = "3 Drive view estate";

            //Create a hosted payment transaction           
            HostedPayment hostedPayment = new HostedPayment();
            hostedPayment.Amount = 250.3333;
            hostedPayment.Reference = "MyRef123";
            hostedPayment.Memo = "Sample payment";
            hostedPayment.Currency = "NGN";
            hostedPayment.StoreID = "293330002";  //optional
            hostedPayment.SuccessURL = "https://sample.com/success";
            hostedPayment.FailureURL = "https://sample.com/fail";
            hostedPayment.NotificationURL = "https://sample.com/notify";

            string jsonResult = voguepay.Pay(hostedPayment, customer);

            Console.WriteLine(jsonResult);
            Console.ReadKey();
        }
    }
}
