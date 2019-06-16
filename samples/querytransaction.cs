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
         
         //Create voguepay instance (Parameters "live" or "demo", default is demo)
          Voguepay voguepay = new Voguepay("live");
          voguepay.Init(merchantinfo);

         //Query Transaction
          Transaction transaction = new Transaction();
          transaction.TransactionID= "5d041a2843bd8";
          string jsonResult = voguepay.Query(transaction);

          Console.WriteLine(jsonResult);
          Console.ReadKey();
        }
    }
}
