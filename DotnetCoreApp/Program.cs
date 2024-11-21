namespace DotnetCoreApp
{
    internal class Program
    {
        //Console.writeline---cw+tab
        //multiple line Commentining--ctrl+kc
        //uncomment lines----ctrl+ku
        //formatting---ctrl+kd


        static void Main(string[] args)
        {
            #region Datatypes
            ////Explicit type Declaration
            //int bikeId = 100;
            //string bikeName = "Duke";
            //decimal price = 50000.00M;
            //float rating = 4.4F;
            //#region Printing variables on seperateline
            ////Console.WriteLine(bikeId);
            ////Console.WriteLine(bikeName);
            ////Console.WriteLine(price);
            ////Console.WriteLine(rating);
            //#endregion
            //Console.WriteLine($"BikeId::{bikeId}\tName::{bikeName}\tPrice::{price}\trating::{rating}");
            ////Implicit Typed Variable or declarations
            //var userId = 1;
            //var userName = "vanishree";
            //// var city; not allowed in C#

            //dynamic city;
            //city = "Bangalore";
            //Console.WriteLine($"City::{city}\tType::{city.GetType()}");

            //Console.WriteLine($"Id::{userId}\tName::{userName}");
            #endregion
            Console.WriteLine("Enter UserName::");
            string userName=Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            float score = float.Parse(Console.ReadLine());
            //int age=Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine($"UserName::{userName}\tAge::{age}");

            int number = 100;
            float num1 = number;

            float num2 = 100.00F;
            decimal d = (decimal)num2;
            int mark = (int)num2;

                

        }
    }

    
}