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
         merchantinfo.CommandAPIToken = "ZnHzcbxKVbvF5d3J5JvZqZe587Rna";
         merchantinfo.PublicKeyFile = @"C:\Users\Rock\public.txt"; //URL path to saved public key
        
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


        DirectPayment directpayment = new DirectPayment();
        directpayment.version = 2;
        directpayment.Amount = 100.22;
        directpayment.Currency = "USD";
        directpayment.Reference = "MY_UNIQUE_REF";
        directpayment.Memo = "Sample payment";
        directpayment.RedirectURL="https://sample.com/redirect";
        directpayment.ReferralURL="https://sample.com/referral";
        directpayment.ResponseURL="https://sample.com/notify/";
        directpayment.StoreID = "5a33c3933ca"; //optional

        directpayment.CardName = "Steve";
        directpayment.CardPan = "5389830123937029";
        directpayment.CardExpiryMonth = 5;
        directpayment.CardExpiryYear = 21;
        directpayment.CardCVV = 170;


        directpayment.ServerPublicIP= "192.333.44.33";
        directpayment.ServerWebsiteURL= "www.google.com";
        directpayment.CustomerReferringIP= "10.22.333.33";
        directpayment.CustomerReferringWebsite= "www.shades.com";

        directpayment.DescriptorCompanyName= "Sparks";
        directpayment.DescriptorCountryAddress= "Sparks Street";
        directpayment.DescriptorCityAddress= "Califonia";
        directpayment.DescriptorCountryAddress= "USA"; //country or 3 letter ISO

        // directpayment.CardToken = "5a344439203";
        //  directpayment.CardTokenize =true;

        string jsonResult = voguepay.Pay(directpayment, customer);

        Console.WriteLine(jsonResult);
        Console.ReadKey();
        }
    }
}
