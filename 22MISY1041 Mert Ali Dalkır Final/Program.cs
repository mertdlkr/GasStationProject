using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _22MISY1041_Mert_Ali_Dalkır_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        
        public class Account(string accountNo, string accountHolder, decimal balance) //teacher I tried to create a class but it gave error :(
        {
            static void accountNo()
            {
                Console.WriteLine("Please enter your account number");
                string accountNo = Convert.ToString(Console.ReadLine());
            }
            static void  withdraw(decimal amount)
            {
                Console.WriteLine("Please enter the amount of you want to withdraw");
                string withdraw = Convert.ToString(Console.ReadLine());
            }
            static void deposit(decimal amount)
            {
                Console.WriteLine("Please enter the amount of you want to deposit");
                string deposit = Convert.ToString(Console.ReadLine());
            }
            static void getAccountSummary()
            {
                Console.WriteLine("Please enter the account number that you want to get summary");
                string getAccountSummary = Convert.ToString(Console.ReadLine());
            }
            
        }
        public class CheckingAccount : Account
        {
            public CheckingAccount(string accountNo, string accountHolder, decimal balance) : base(accountNo, accountHolder, balance)
            {

            }

            static void WriteCheck(string payee, decimal amount)
            {
                Console.WriteLine("Please write the payee information");
                string payee1 = Convert.ToString(Console.ReadLine()); //I tried to write payee but it gave error so I make it payee1

                Console.WriteLine("Please write the amount information");
                string amount1 = Convert.ToString(Console.ReadLine()); //the same definition as the upper one
            }
            

        }
        public class SavingAccount : Account
        {
            public SavingAccount(string accountNo, string accountHolder, decimal balance) : base(accountNo, accountHolder, balance)
            {
            }

            static void ApplyInterest(string period) //teacher faiz is haram
            {

            }

        }
        public class CreditAccount : Account
        {
            public CreditAccount(decimal CreditLimit, decimal amount)
            {
                CreditAccount credit = new CreditAccount(CreditLimit, amount);
            }
        }
        public class ICustomerManager()
        {
            static void AddCustomer(string customerID , string name)
            {
                Console.WriteLine("Enter your CustomerID");
                string customerID1 = Convert.ToString(Console.ReadLine()); //I tried to write customerID but it gave error so I make it customerID1

                Console.WriteLine("Enter your name");
                string name1 = Convert.ToString(Console.ReadLine()); //I tried to write name but it gave error so I make it name1
            }
            static void RemoveCustomer(string customerID)
            {

            }
            static void GetCustomerDetails(string customerID)
            {

            }
            static void ListAllCustomers()
            {

            }
        }
        public class Customer(string customerID, string Name) //I want to sleep
        {

        }
        public class Bank() //it says "birincil oluşturucular c# 7.3te kullanılamaz, 12 veya üst bir sürüm kullanın" and I don't know what to do
        {

            static void Transfer(string fromAccountNo, string toAccountNo, decimal amount)
            {

            }
            static void PayBill(string accountNo, decimal amount)
            {
                Console.WriteLine($"Please enter your account no");
                string accountNo1 = Convert.ToString(Console.ReadLine()); //I tried to yaz string accountNo but it gave error so I made it like that
                Console.WriteLine("Please enter the amount of you want to Pay Bill");
                decimal amount1 = Convert.ToDecimal(Console.ReadLine()); //the same with the upper one
            }
            
        }
    }
}
