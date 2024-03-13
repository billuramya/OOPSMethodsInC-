using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Transactions;
namespace ProblemsSolving
{
    /*Write a C# program that takes a student's score as input and
    classifies it into grades (A, B, C, D, or F) based on the following criteria:
    A: 90 - 100

    B: 80 - 89

    C: 70 - 79

    D: 60 - 69

    F: 0 - 59

    */

    public class FirstProblem
    {
        public void Firstproblems()
        {
            Console.WriteLine("Enter the stdents Score");
            int score = Convert.ToInt32(Console.ReadLine());
            int[] gradeA = { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
            int[] gradeB = { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };
            int[] gradeC = { 70, 71, 72, 73, 74, 75, 76, 77, 78, 79 };
            int[] gradeD = { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69 };
            if (gradeA.Contains(score)) { Console.WriteLine("A"); }
            else if (gradeB.Contains(score)) { Console.WriteLine("B"); }
            else if (gradeC.Contains(score)) { Console.WriteLine("C"); }
            else if (gradeD.Contains(score)) { Console.WriteLine("D"); }
            else { Console.WriteLine("Fail"); }
        }
    }

    /* 
     Develop a C# program that converts temperatures between Fahrenheit and Celsius
    based on user input. Use conditional statements to determine the conversion formula
    based on the user's choice.
    */

    public class secondProblem
    {
        public void Secondproblems()
        {
            Console.WriteLine("enter temperature reading");
            int temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter temperature type");
            char tem_reading = Convert.ToChar(Console.ReadLine());
            if (tem_reading == 'f')
            {
                Console.WriteLine(((temperature - 32) * 5 / 9) + " C");
            }
            else
            {
                Console.WriteLine(((tem_reading - 9 / 5) + 32 + 6) + " F");
            }
        }
    }

    /*
     Write a C# program that calculates the price of a movie ticket based on the age
    of the customer and the time of the movie. Implement different pricing rules for
    children (under 12), adults (12-64), and seniors (65+), and consider matinee discounts.
    */


    public class ThirdProblem
    {
        public void thirdproblems()
        {
            Console.WriteLine("enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            int maintanacecost = 12;
            double discount = 5.21;
            if (1 < 12)
            {
                Console.WriteLine("prize of the movie ticket:{0}", 50 + maintanacecost + discount);
            }
            else if (12 < 64)
            {
                Console.WriteLine("prize of the movie ticket : {0}", 100 + maintanacecost + discount);
            }
            else if (age > 64)
            {
                Console.WriteLine("prize of the movie ticket : {0}", 80 + maintanacecost + discount);
            }
        }
    } 


    /* 
     Design a simple login system in C# where users provide their username and password. Use conditional
    statements to check the credentials and provide appropriate feedback, such as successful login,
    incorrect username, incorrect password, or account locked.*/


    public class FourthProblem
    {
        public void Fourthproblems()
        {
            string userName = "RamyaBillu2002";
            string password = "munisekhar@125";
            Console.WriteLine("enter username name");
            string enterUserName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter your password");
            string userPassWord = Convert.ToString(Console.ReadLine());
            if (userName != enterUserName)
            {
                Console.WriteLine("incorrect username");
            }
            else if (password != userPassWord)
            {
                Console.WriteLine("incorrect password");
            }
            else if ((userName == enterUserName) && (password == userPassWord))
            {
                Console.WriteLine("Successfully Login");
            }
            else
            {
                Console.WriteLine("account logged");
            }
        }
    }

    /* 
     Implement a menu-driven calculator in C# that allows users to perform basic 
    operations (addition, subtraction, multiplication, division). Use conditional
    statements to execute the selected operation and handle invalid inputs.*/


    public class FifthProblem
    {
        public void Fifthproblems()
        {
            Console.WriteLine("enter the first value");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter second number");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter the operator like + - / * %");
            string operators = Convert.ToString(Console.ReadLine());
            if (operators == "+")
            {
                Console.WriteLine(value2 + value1);
            }
            else if (operators == "-")
            {
                Console.WriteLine(value2 - value1);

            }
            else if (operators == "*")
            {
                Console.WriteLine(value2 * value1);
            }
            else if (operators == "/")
            {
                Console.WriteLine(value2 / value1);
            }
            else if (operators == "%")
            {
                Console.WriteLine(value2 / value1);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }
        }
    }


    /* Develop a C# program that calculates the Air Quality Index (AQI) based 
      on the concentration of pollutants. Use conditional statements to classify
      the AQI into different categories (Good, Moderate, Unhealthy, etc.) based on 
      predefined thresholds for different pollutants.*/


    public class SixthProblem
    {
        public void Sixthproblems()
        {
            Console.WriteLine("Enter the percentage of pollution between 0 to 100");
            int pollution = Convert.ToInt32(Console.ReadLine());
            if (0 <= pollution && pollution < 40)
            {
                Console.WriteLine("you are in GOOD area");
            }
            else if (40 <= pollution && pollution < 60)
            {
                Console.WriteLine("you are in MODERATE area");
            }
            else if (60 <= pollution && pollution <= 100)
            {
                Console.WriteLine("you are in UNHEALTHY area");
            }
            else
            {
                Console.WriteLine("pease enter the correct range");
            }
        }
    }



    /* Implement a simple rock, paper, scissors game in C#. Prompt the user to enter 
      their choice, and use conditional statements to determine the winner based on
      the game rules (rock beats scissors, scissors beat paper, paper beats rock). */

    public class SeventhProblem
    {
        public void Seventhproblems()
        {
            Console.WriteLine("enter rock or paper or scissors");
            string userChoice = Convert.ToString(Console.ReadLine());
            Random num = new Random();
            int value = num.Next(4);
            Console.WriteLine(value);
            if (value == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("user choise rock");
                    Console.WriteLine("Is was a Tie");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("user choise paper");
                    Console.WriteLine("Is was a Tie");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("user choise scissors");
                    Console.WriteLine("Is was a Tie");
                }
                else { Console.WriteLine("write correct word"); }
            }

            else if (value == 2)

            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("user choise rock");
                    Console.WriteLine("sorry! you loose the  game");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("user choise paper");
                    Console.WriteLine("sorry! you loose the  game");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("user choise scissors");
                    Console.WriteLine("sorry! you loose the  game");
                }
                else { Console.WriteLine("write correct word"); }
            }



            else if (value == 3)

            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("user choise rock");
                    Console.WriteLine("you win the  game");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("user choise paper");
                    Console.WriteLine("you win the  game");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("user choise scissors");
                    Console.WriteLine("you win the  game");
                }
                else { Console.WriteLine("write correct word"); }
            }


            else
            {
                Console.WriteLine("give the correct string");
            }

        }
    }



    /* Design a C# program that calculates the fine for overdue library books. 
     * The program should take the number of days a book is overdue as input and 
     * apply different fine rates based on predefined rules (e.g., first 7 days free, 
     * after that $0.50 per day). */

    public class EigthProblem
    {
        public void Eigthtproblems()
        {
            Console.WriteLine(" enter number of days");
            int days = Convert.ToInt32(Console.ReadLine());
            if (days <= 7)
            {
                Console.WriteLine("first 7 days free");
            }
            else if (days > 7)
            {

                Console.WriteLine("after seven days fine : {0}", (days - 7) * 0.5);
            }
            else
            {
                Console.WriteLine("enter nmber of days");
            }
        }
    }


    /* Create a C# program that simulates a traffic light. Implement
     * a system where the light changes based on predefined time intervals.
     * Use conditional statements to determine which color (Red, Yellow, Green) should be 
     * displayed at any given time. */


    public class NinthProblem
    {
        public void NinthProblems()
        {
            Console.WriteLine("enter the traffic collors");

            string userChoice = (Console.ReadLine());

            if (userChoice == "red")
            {
                Console.WriteLine("All vehicals are stop");
            }
            else if (userChoice == "yellow")
            {
                Console.WriteLine("All vehicals are ready to stop");
            }
            else if (userChoice == "green")
            {
                Console.WriteLine("All vehicals are go");
            }
            else
            {
                Console.WriteLine("eneter the correct traffic color");
            }
            Console.Read();
        }
    }




    /*Design a library reservation system in C#. Allow users to check the availability of
      books and reserve them. Use conditional statements to manage the reservation process, 
      considering factors like book availability, user limits, and reservation duration.
    */


    class BookAvailability
    {
        public string Tittle { get; set; }
        public bool IsAvailbility { get; set; }
        public string Reservation { get; set; }
    }
    class CheckAvailabily
    {
        List<BookAvailability> book = new List<BookAvailability>() {
       new BookAvailability{ Tittle="Harry Portter",IsAvailbility=true,Reservation="Reserved"},
        new BookAvailability{ Tittle="Harry Portter1",IsAvailbility=false,Reservation="Not Reserved"},
         new BookAvailability{ Tittle="Harry Portter2",IsAvailbility=false, Reservation = "Reserved"},
          new BookAvailability{ Tittle="Harry Portter3",IsAvailbility=true , Reservation = "Not Reserved"},
           new BookAvailability{ Tittle="Harry Portter4",IsAvailbility=true , Reservation = "Reserved"},

       };
        public void CheckReservation()

        {
            Console.WriteLine("Enter the Book Name");
            string bookName = Console.ReadLine();
            foreach (var item in book)
            {
                if ((item.Tittle == bookName) && (item.Reservation == "Not Reserved") && (item.IsAvailbility == true))
                {
                    Console.WriteLine("Book is Vailable");
                    break;
                }
                else
                {
                    Console.WriteLine("Book is Not Available");
                    break;
                }
            }
        }
    }
    //Design an object-oriented system for a virtual classroom. Consider classes like Student,
    //Teacher, and Course. Implement features such as enrollment, grading, and communication between
    //students and teachers. Utilize concepts like inheritance, encapsulation, and polymorphism to model
    //the relationships and behaviors in this system.

    class ClassRoom
    {
        public string StudenName { get; set; }
        public string TeacherName { get; set; }
        public string Course { get; set; }
        public string Grading { get; set; }

    }
    public class Features
    {
        List<ClassRoom> classrooms = new List<ClassRoom>()
        {
            new ClassRoom{ StudenName="Ramya",TeacherName="Proffissor PriyanshuSing",Course=".Net FullStack",Grading="A"}
        };
        public void Communication()
        {
            foreach (var item in classrooms)
            {
                Console.WriteLine("Hello {0} How Are You!", item.TeacherName);
                Console.WriteLine("hii {0} I am fine Thanks for Asking");
            }
        }
    }


    // Create an object-oriented model for a banking system that supports various account
    // types(e.g., savings, checking). Implement transactional operations like deposits, withdrawals,
    // and transfers between accounts.Use inheritance to represent different account types and encapsulation
    // to protect sensitive information.

    class BanckAccount
    {
        public double Savings { get; set; }
        public void Deposit()
        {
            Console.WriteLine("Enter the Deposite Amount");
            double DepositAmount = int.Parse(Console.ReadLine());
            Savings = Savings + DepositAmount;

        }
        public void WithDraw()
        {

            Console.WriteLine("Enter the WithDraw Amount");
            double WithtAmount = int.Parse(Console.ReadLine());
            Savings = Savings + WithtAmount;
        }
        public void Checking()
        {
            Console.WriteLine(Savings);
        }


    }


    //Given a list of customer records, filter out customers who have made purchases
    //in the last month, and create a new list with their names and total purchase amounts.

    class CustomerRecords
    {
        public string Name { get; set; }
        public DateTime PurchasDate { get; set; }
        public double TotalPurchaseAmount { get; set; }

    }
    class FilterOut
    {
        List<CustomerRecords> Records = new List<CustomerRecords>()
        { new CustomerRecords { Name="Rani",PurchasDate=DateTime.Now.AddMonths(-2),TotalPurchaseAmount=150 },
            new CustomerRecords { Name="Nandu",PurchasDate=DateTime.Now.AddMonths(-3),TotalPurchaseAmount=100 },
            new CustomerRecords { Name="Siva",PurchasDate=DateTime.Now.AddMonths(-5),TotalPurchaseAmount=500 },
            new CustomerRecords { Name="Ramesh",PurchasDate=DateTime.Now.AddMonths(-7),TotalPurchaseAmount=340 },
        };

        public void Checking()
        {
            var result = Records.Where(x => x.PurchasDate >= DateTime.Now.AddMonths(-1))
                .Select(s => new { s.Name, s.TotalPurchaseAmount });
            foreach (var record in result)
            {
                Console.WriteLine("CustemerNaame {0} and TotalPurchase {1}", record.Name, record.TotalPurchaseAmount);
            }


        }
    }

    //Manage a list of orders and group them by product category. Calculate the total sales for each category.
    class GroupByProduct
    {
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public double Quantity { get; set; }

    }
    class OrderingAndPrinting
    {
        List<GroupByProduct> Product = new List<GroupByProduct>()
        {
            new GroupByProduct{ ProductName="T-Shirt",ProductCategory="Cloths",Quantity=2},
            new GroupByProduct{ ProductName="Kurthas",ProductCategory="Cloths",Quantity=1},
            new GroupByProduct{ ProductName="Electric",ProductCategory="Domestic",Quantity=5},
            new GroupByProduct{ ProductName="T-Shirt",ProductCategory="Cloths",Quantity=6},
            new GroupByProduct{ ProductName="Electric",ProductCategory="Cloths",Quantity=5},
            new GroupByProduct{ ProductName="Kurthas",ProductCategory="Cloths",Quantity=2},
        };
        public void FileringData()
        {
            var result = Product.OrderBy(A => A.ProductCategory);
            foreach (var record in result) { Console.WriteLine(record.ProductName + "\t" + record.Quantity); }
        }
    }
    //Sort a list of products based on their prices using a lambda expression for custom sorting criteria. 
    class SortingProducts
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

    }
    class ListOFSortingData
    {
        List<SortingProducts> products = new List<SortingProducts>()
        {
            new SortingProducts{ProductName = "Saree",Price=2000},
            new SortingProducts{ProductName = "Saree",Price=2500},
            new SortingProducts{ProductName = "T-Shirt",Price=1000},
            new SortingProducts{ProductName = "Tea-Cups",Price=1800},
            new SortingProducts{ProductName = "Shoes",Price=1200},
        };
        public void sortingPrice()
        {
            var result = products.OrderBy(s => s.Price);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + "\t" + item.Price);
            }
        }
    }
    //Filter a list of employees based on certain criteria using lambda expressions,
    //such as selecting all employees with a salary above a certain threshold.
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class EmployeeInfo
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee() { Name= "Ramya",Salary=25000},
             new Employee() { Name= "Ravi",Salary=40000},
              new Employee() { Name= "Ramesh",Salary=35000},
               new Employee() { Name= "siva",Salary=25000},
                new Employee() { Name= "Ganesh",Salary=25000 },
        };
        public void AllowCriteria()
        {
            double SalaryCriteria = 20000;
            var result = employees.Select(s => s.Salary > SalaryCriteria);
        }
    }
    //Join two collections of data, such as a list of customers and their orders,
    //to create a result set with combined information.
    class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

    }
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderName { get; set; }
        public double OrderAmount { get; set; }
    }
    class JoinCustomerAndOrders
    {
        List<Customer> GetCustomers = new List<Customer>()
        {
            new Customer { Id = 1, CustomerName = "Ramya" },
            new Customer { Id = 2, CustomerName = "Ramya" },
            new Customer { Id = 3, CustomerName = "Ramya" },
            new Customer { Id = 4, CustomerName = "Ramya" },
        };
        List<Order> GetOrders = new List<Order>() {
            new Order { Id = 101,CustomerId = 1,OrderName="LapTop",OrderAmount=500000},
             new Order { Id = 102,CustomerId = 1,OrderName="Mobile",OrderAmount=500000},
              new Order { Id = 103,CustomerId = 1,OrderName="Mixer",OrderAmount=500000},
               new Order { Id = 104,CustomerId = 1,OrderName="LapTop",OrderAmount=500000}, };

        public void GetDetails()
        {

            var result1 = GetCustomers
            .Join(GetOrders, customer => customer.Id, order => order.CustomerId, (customer, order) => new
            {
                customer.Id,
                customer.CustomerName,

            });
            foreach (var item in result1)
            {
                Console.WriteLine(item.Id + "\t" + item.CustomerName);
            }
        }

    }
    //Utilize LINQ to group a list of transactions by date and calculate the total transaction amount for each date. 
    class Tronsactions
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
    class GroupOfList
    {

        List<Tronsactions> transactions = new List<Tronsactions>()
            {
                new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-2)},
                 new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-6)},
                  new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-5)},
                 new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-3)},
                  new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-2)},
                   new  Tronsactions { Amount = 2000,Date =DateTime.Now.AddMonths(-3)},
            };

        public void GetResul()
        {
            var result = transactions.GroupBy(s => s.Date).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
    //Use LINQ to find distinct elements in a list and perform set operations like union to
    //combine two lists without duplicates.

    public class UnionOperation
    {
        public void RemoveDuplicates()
        {
            int[] list1 = { 1, 2, 3, 4, 5 };
            int[] list2 = { 2, 3, 4, 5, 7, 8, 9 };
            var result = list1.Union(list2);
            foreach (var item in result)
            {
                Console.Write(item);
            }


        }
    }
    //As a system administrator, I want a regex pattern to validate usernames. Usernames
    //should consist of an uppercase first letter followed by exactly two lowercase letters.
    //This ensures a consistent and easily readable username format.
    class ValidUserName
    {
        public void GetValidUserName()
        {
            string[] UserName = { "ABC", "Abc", "Ram", "ramya", "Siva" };
            string pattern = "^[A-Z][a-z]{2}$";
            foreach (var item in UserName)
            {
                var result = Regex.IsMatch(item, pattern);
                Console.WriteLine(item + "\t" + result);
            }

        }
    }
    //Create a regex pattern to extract URLs from a given text. Account for different URL
    //formats and variations, such as those with or without "http://" or "www." 
    class URLMatch
    {
        public void UserUrls()
        {
            string Urls = "\b(?http://?) (www.?)[a-zA-Z0-9]+([.][a-z]{2,}\b";
            string pattern = " http://www.example.com ";
            var result = Regex.IsMatch(Urls, pattern);
            Console.WriteLine(result);
        }
    }
    //Create a regex pattern to extract dates from a given text. Account for different date formats,
    //such as "YYYY-MM-DD," "MM/DD/YYYY," and "Month DD, YYYY." 
    class ExtractDate
    {
        public void GetDate()
        {
            string date = "2002-04-27";
            string pattern = @"^\d{4}-\d{2}-\d{2}";
            var result = Regex.IsMatch(date, pattern);
            Console.WriteLine(result);
        }
    }
    //Implement a regex pattern to identify and mask credit card numbers in a text.
    //Replace actual card numbers with asterisks while preserving the last four digits for display.
    class CreditCardNumber
    {
        public void GetCresdiCardNumber()
        {
            string CardNumber = "234-5687-2389-2344";
            string p = @"\b(?:\d[ -]*?)\b";
            string Pattern = @"^\d{4}-\d{4}-\d{4}-\d{4}$";
            var Result = Regex.IsMatch(CardNumber, Pattern);
            Console.WriteLine(Result);
        }
    }
    // Develop a function that takes a string as input and returns its length. Write unit tests to
    // verify that the string length checker handles empty strings, single-character strings, and
    // longer strings correctly.
    public class FindTheStringLength
    {
        public int GetTheStringLength(string input)
        {
            return input.Length;
        }
    }
    //Create a function that calculates the factorial of a given non-negative integer. Write unit tests to
    //ensure the correctness of the factorial calculator for various input values, including zero and positive integers.

    public class FactorialNumber
    {
        public int GetFactorialNumber(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("given non-negative integer");
            }
            else
            {
                var fact = 1;
                for (int i = 1; i < input + 1; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }

    //Implement a function that checks whether a given positive integer is a prime number. Write unit tests to verify
    //the prime number checker for different prime and non-prime numbers. 

    public class PrimeNumbers
    {
        public int GetPrimeNumbers(int input)
        {
            int primeCount = 0;
            if (input > 0)
            {
                for (int i = 1; i < input + 1; i++)
                {
                    if (input % i == 0)
                    {
                        primeCount++;
                    }
                }
            }
            else
            {
                throw new ArgumentException("enter positive Nubers");
            }
            return primeCount;
        }
    }

    // Implement a C# program that reads the contents of a text file and displays them to the console.
    // Handle cases where the file may not exist and provide appropriate error messages.
    class FileExist
    {
        public void FileExistOrNot()
        {
            string filePath = @"C:\Users\billu\source\repos\problemSolving";
            var result = File.Exists(filePath);
            if (result == false)
            {
                Console.WriteLine("your file not exist");
            }
            else { Console.WriteLine("your file will exist"); }
        }
    }


    //Create a C# utility that allows a user to copy the contents of one text file to another. Include error handling
    //for scenarios like the source file not existing or insufficient permissions. 
    class CopyFile
    {
        public void CopyTheTextAnotherFile()
        {
            try
            {
                string source = @"C:\Users\billu\source\repos\problemSolving\text.txt";
                string destination = @"C:\Users\billu\source\repos\problemSolving";
                if (!File.Exists(source))
                {
                    Console.WriteLine("Source File Does Not Exist");
                }
                else
                {
                    File.Copy(source, destination);
                }


            }
            catch
            {
                Console.WriteLine("give correct file");
            }







        }
    }


    //Develop a C# application that reads a text file and counts the occurrences of each word. Display the word frequency or
    //generate a report highlighting the most frequently used words.

    class CountTheCharecters
    {
        public void GetStringCount()
        {
            string FilePath = @"";
            string[] Content = File.ReadAllLines(FilePath);
            foreach (string content in Content)
            {
                string[] word = content.Split(' ');
                foreach(string line in word)
                {
                    string ClearSplChar = line.Trim(',', '.', '!', ' ', '[', ']', '\'');
                    if (!string.IsNullOrEmpty(ClearSplChar))
                    {
                        string LowerCase = ClearSplChar.ToLower();
                    }
                    
                }
            }
        }
    }

}


