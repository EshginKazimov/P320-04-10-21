using System;

//IDE - Integrated Development Environment
//Visual studio - IDE - text editor + compiler
//Visual studio code - text editor
namespace FirstProject
{
    class Program
    {
        //Intellisense
        static void Main(string[] args)
        {
            #region DataTypes

            int firstNumber = 12;
            double secondNumber = 10.5;
            float thirdNumber = 9.4F;
            decimal fourthNumber = 3.4M;
            string text = "akgaskgjaslgjaslgjakljg";
            char symbol = 'A';
            bool isAdmin = false;

            //var number = 10;
            var title = "aglaglalsglasgk";
            //title = 10;

            //dynamic test = 10;
            //Console.WriteLine(test);
            //test = "afsasfasf";
            //Console.WriteLine(test);

            #endregion

            #region If-else, Switch

            //if (isAdmin) //if (isAdmin == true)
            //{
            //    Console.WriteLine("Welcome Admin!");
            //    Console.WriteLine("Admin");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome");
            //    Console.WriteLine("Simple user");
            //}

            //if (firstNumber == 10)
            //    Console.WriteLine("ten");
            //else if (firstNumber == 11)
            //    Console.WriteLine("eleven");
            //else if (firstNumber == 12)
            //    Console.WriteLine("twelve");
            //else
            //    Console.WriteLine("other1");

            //switch (firstNumber)
            //{
            //    case 10:
            //        Console.WriteLine("ten");
            //        break;
            //    case 11:
            //        Console.WriteLine("eleven");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            #endregion

            #region Loops

            //int[] arr = { 5, 4, 6, 3, 2, 6, 8, 9 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //}

            #endregion

            #region Try-catch-finally (runtime error)

            Console.WriteLine("Input number:");
            string result = Console.ReadLine();
            //int number = int.Parse(result);
            //Console.WriteLine(number * 2);

            //if (int.TryParse(result, out int number))
            //{
            //    Console.WriteLine(number * 2);
            //}
            //else
            //{
            //    Console.WriteLine("Reqem daxil edin");
            //}

            //try
            //{
            //    int number = int.Parse(result);
            //    Console.WriteLine(number * 2);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Reqem daxil edin");
            //}
            //finally
            //{
            //    Console.WriteLine("Emeliyyat icra olundu");
            //}

            //Tapshiriq:
            //Int array-da, butun elementlerin cemini tapib ekrana yazdirmaq
            //Int array-da, max elementi tapmaq
            //Int array-da, min elementi tapmaq
            //Int array-da, butun elementlerin hasilini tapmaq
            //Int array-da, elementlerin yerini deishmek,
            //meselen 1,2,3,4 -> 4,3,2,1

            #endregion
        }

        private void Test()
        {

        }
    }
}
