using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xitdkL9y;cxi
            //int age = 25;


            //string name = "john Smith";
            //bool isStudent = true;
            //char grade = 'A';
            //decimal salary = (decimal)55000.75;

            //Console.WriteLine("{0} {1} {2} {3}", age,Height,name,isStudent );

            //Console.WriteLine("you grade {0}", grade);

            //Console.WriteLine("you monny {0}", salary);

            //if (isStudent)
            //{
            //    Console.WriteLine("STUDENT");
            //}
            //else
            //{
            //    Console.WriteLine("NO STUDENT");


            //}
            //Console.WriteLine("please enter your name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age : ");
            //string age = Console.ReadLine();


            //Console.WriteLine("hello  {0} you age is  {1} year", name, age);



            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //int[] cars2 = { 000, 124, 054, 5555 };

            //Console.WriteLine(cars);

            //Console.WriteLine("hello  {0} you age is year", cars[2]);

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    if (i != 2) {  
            //        Console.WriteLine(cars[i]);
            //    } else {

            //    }

            //}
            //string firstName = "\"";
            //string lastName = "Doe";
            //string name = "My full name is: "+firstName+" "+lastName;
            //Console.WriteLine(firstName);

            ////int x = 5;
            ////int y = 3;
            ////Console.WriteLine(x > y); // returns True because 5 is greater than 3


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            //Console.WriteLine(numbers[0, 2]);


            //string[] studentNames = { "John", "Alice", "Bob", "Eve", "Charlie" };
            //int[] studentIDs = { 1001, 1002, 1003, 1004, 1005 };

            //int[][] scores = new int[5][];
            //scores[0] = new int[] { 92, 88, 78, 90, 95, 78 };
            //scores[1] = new int[] { 76, 85, 92, 89, 78, 78 };
            //scores[2] = new int[] { 64, 72, 81, 77, 60, 78 };
            //scores[3] = new int[] { 88, 79, 92, 93, 87, 78 };
            //scores[4] = new int[] { 55, 60, 70, 48, 58, 78 };

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //    for (int j = 0; j < scores[i].Length; j++)
            //    {

            //        Console.Write(scores[i][j] + " gread =");
            //        if (scores[i][j] >= 90)
            //        {
            //            Console.WriteLine("A");
            //            continue;
            //        }
            //        else if (scores[i][j] >= 80)
            //        {

            //            Console.WriteLine("B");
            //            continue;
            //        }
            //        else if (scores[i][j] >= 70)
            //        {

            //            Console.WriteLine("C");
            //            continue;
            //        }
            //        else if (scores[i][j] >= 60)
            //        {

            //            Console.WriteLine("D");
            //            continue;
            //        }
            //        else if (scores[i][j] < 60)
            //        {

            //            Console.WriteLine("F");
            //            continue;
            //        }

            //    }

            //}
            // string[] productNames = { "เสื้อยืด", "กางเกงยีนส์", "รองเท้า", "เสื้อโค้ท", "กระเป๋า" };
            //string[] productNames = { };
            //double[] productPrices = { 250.0, 500.0, 1000.0, 800.0, 300.0 };
            //int[] productQuantities = { 50, 30, 20, 10, 40 };

            //int[] productCodes = { 101, 102, 103, 104, 105 };
            //List<string> termsList = new List<string>();

            //termsList.Add(productNames[0]);
            //termsList.Add(productNames[1]);
            //termsList.Add(productNames[2]);
            //termsList.Add(productNames[3]);        

            //for (int i = 0; i == 0; )
            //{

            //    Console.WriteLine("please input new data : ");..
            //    termsList.Add(Console.ReadLine());


            //    for (int j= 0; j < termsList.Count; j++)
            //    {
            //        Console.WriteLine(termsList[j]);                  
            //    }
            //    Console.ReadLine(); // รอผู้ใช้กด Enter ก่อนปิดจอ
            //}
            //string[] terms = termsList.ToArray();













            //for (int i = 0; i < scores.Length; i++) 
            //{
            //    Console.Write(studentIDs[i]);
            //    Console.WriteLine(studentNames[i]);

            //    for (int j = 0;j < scores[i].Length; j++)
            //    {
            //        Console.Write(scores[i][j]);
            //        if (scores[i][j] >= 90)
            //        {
            //            Console.WriteLine(": grade A");
            //        }
            //       else  if (scores[i][j] >= 80 || scores[i][j] < 90)
            //        {
            //            Console.WriteLine(": grade B");
            //        }


            //    }

            //}

         




            for (int i = 0; i == 0;)
            {



                Console.WriteLine("in push number 1000-5000");
                string numbers1 = Console.ReadLine();
                int number_parse =0;
                try
                {
                     number_parse = int.Parse(numbers1);
                }
                catch (Exception e)
                {
                    //  Block of code to handle errors
                }

          
                if (number_parse > 1000 && number_parse < 5000)
                {
                    Console.WriteLine("is 1000-5000");
                    number_parse.ToString();


                    string originalNumber = number_parse.ToString();

                    string reversedNumber = "";

                    for (int a = originalNumber.Length - 1; a >= 0; a--)
                    {
                        reversedNumber += originalNumber[a];
                    }

                    Console.WriteLine("เลขสลับ: " + reversedNumber);
                    Console.WriteLine(number_parse + int.Parse(reversedNumber));
                }



                Console.ReadLine(); // รอผู้ใช้กด Enter ก่อนปิดจอ
            }




        }

        static void test()
        {



        }
    }
}
