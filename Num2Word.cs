using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Num2Word
{
   /*
      Program Name: Week 9 Num2Words
      Date: 12/15/2020
      Programmer: Jacob Ward
      Class: CSCI 231

      Program Description: takes positive integer with or without decimal value and converts it to words

      Input: number

      Output: The given integer in english

      Givens:  I assumed that the number of digits in the integer would not be greater than 5

      Testing Data:
      (input), (output)
      Test 1: (12345.123), (Twelve Thousand Three Hundred Fourty Five and 12/100)
      Test 2: (10101.01), (Ten Thousand One Hundred One and 1/100)
      Test 3:(100), (One Hundred)
      Test 4: (1.12), (One and 12/100)
      Test 5: (0.12), (Zero and 12/100)
      
      
      */
   class Num2Word
   {
      public static void LessThanHundredThousand(int fifthDigit, int fourthDigit, int thirdDigit, 
         int secondDigit, int firstDigit)
      {
         //deals with values from 1000 to 19000
         if (((fifthDigit * 10) + fourthDigit) < 20)
         {
            LessThanNineteen((fifthDigit * 10) + fourthDigit);
            Console.Write("Thousand ");

            if (thirdDigit != 0)
            {
               Hundreds(thirdDigit, secondDigit, firstDigit);
            }
            else
            {
               LessThanHundred(secondDigit, firstDigit);
            }
            
         }
         //deals with all values from 19000 to 99999
         else
         {
            LessThanHundred(fifthDigit, fourthDigit);
            Console.Write("Thousand ");

            if (thirdDigit != 0)
            {
               Hundreds(thirdDigit, secondDigit, firstDigit);
            }
            else
            {
               LessThanHundred(secondDigit, firstDigit);
            }
         }
      }
      //This method is to write any hundred value
      public static void Hundreds (int thirdDigit, int secondDigit, int firstDigit)
      {
         
         //just to catch 100 through 119
         if (secondDigit <= 1)
         {
            LessThanNineteen(thirdDigit);

            Console.Write("Hundred ");

            if (((secondDigit * 10) + firstDigit) != 0)
            {
               LessThanNineteen((secondDigit * 10) + firstDigit);
            }
         }
         //cathces the rest
         else
         {
            LessThanNineteen(thirdDigit);

            Console.Write("Hundred ");

            if (((secondDigit * 10) + firstDigit) != 0)
            {
               LessThanNineteen((secondDigit * 10) + firstDigit);
            }
         }
      }

      //this method just sends values to the correct method ie twenties, thirties, etc as long as it is lower than 100
      public static void LessThanHundred (int secondDigit, int firstDigit)
      {
         if (((secondDigit * 10) + firstDigit) == 0)
         {

         }
         else if (((secondDigit * 10) + firstDigit) < 20 )
         {
            LessThanNineteen(((secondDigit * 10) + firstDigit));
         }
         else if (secondDigit == 2)
         {
            Twenties(secondDigit, firstDigit);
         }
         else if (secondDigit == 3)
         {
            Thirties(secondDigit, firstDigit);
         }
         else if (secondDigit == 4)
         {
            Fourties(secondDigit, firstDigit);
         }
         else if (secondDigit == 5)
         {
            Fifties(secondDigit, firstDigit);
         }
         else if (secondDigit == 6)
         {
            Sixties(secondDigit, firstDigit);
         }
         else if (secondDigit == 7)
         {
            Seventies(secondDigit, firstDigit);
         }
         else if (secondDigit == 8)
         {
            Eighties(secondDigit, firstDigit);
         }
         else if (secondDigit == 9)
         {
            Nineties(secondDigit, firstDigit);
         }

      }

      //deals with all the different words less than 19
      public static void LessThanNineteen(int firstDigit)
      {
         string[] lessThanNineteen = { "Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ",
         "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen "};

         Console.Write($"{lessThanNineteen[firstDigit]}");
      }

      //deals with numbers in the 20s
      public static void Twenties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 21 to 29
            Console.Write("Twenty "); 
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Twenty");
         }
      }
      //deals with numbers in the 30s
      public static void Thirties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 31 to 39
            Console.Write("Thirty ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Thirty");
         }
      }

      //deals with numbers in the 40s
      public static void Fourties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 41 to 49
            Console.Write("Fourty ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Fourty");
         }
      }

      //deals with numbers in the 50s
      public static void Fifties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 51 to 59
            Console.Write("Fifty ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Fifty");
         }
      }

      //deals with numbers in their 60s
      public static void Sixties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 61 to 69
            Console.Write("Sixty ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Sixty");
         }
      }

      //deals with numbers in their 70s 
      public static void Seventies(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 71 to 79
            Console.Write("Seventy ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Seventy");
         }
      }

      //deals with numbers in their 80s
      public static void Eighties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 81 to 89
            Console.Write("Eighty ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Eighty");
         }
      }

      //deals with numbers in their 90s
      public static void Nineties(int secondDigit, int firstDigit)
      {
         if (firstDigit != 0)
         {
            //display 91 to 99
            Console.Write("Ninety ");
            LessThanNineteen(firstDigit);
         }
         else
         {
            Console.Write("Ninety");
         }
      }
      
      //meant to calulate and display the hundredths value
      public static void CalculateHundredths(decimal hundredths)
      {
         hundredths *= 100;
         
         Console.Write($"and {(int)hundredths}/100 \n");
      }

      static void Main(string[] args)
      {
         //initialize variables and arrays 
         decimal hundredths;
         int counter = 0;
         int[] number = new int[0];
         


         //Prompt input
         Console.WriteLine("Please enter integer");
         decimal integer = decimal.Parse(Console.ReadLine());



         //setting int variable = (int)integer, as to preserve initial integer
         int variable = (int)integer;

         //determine length - 1
         int length = (int)integer;
         length = (int)Math.Log10(length);

         if (length > 4)
         {
            Console.WriteLine("Integer is too large, please input a value us humans can deal with");
         }
         else if (integer < 1 && integer > 0)
         {
            LessThanNineteen((int)integer);

            hundredths = integer % 1;

            if (hundredths != 0)
            {
               CalculateHundredths(hundredths);
            }
         }
         else
         {
            //resize array to variable length, length + 1
            Array.Resize(ref number, length + 1);


            //put each digit in the array if integer is greater than 19
            for (int x = length; x >= 0; x--)
            {
               int y = variable % 10;

               number[x] = y;

               variable /= 10;
               
               counter++;

            }

            //display whole numbers as words. Its variable to allow inputs of different size 5 or lower
            if (counter == 1)
            {
               LessThanNineteen(number[length]);
            }
            else if (counter == 2)
            {
               LessThanHundred(number[length - 1], number[length]);
            }
            else if (counter == 3)
            {
               Hundreds(number[length - 2], number[length - 1], number[length]);
            }
            else if (counter == 4)
            {
               LessThanHundredThousand(0, number[length - 3], number[length - 2], number[length - 1], number[length]);
            }
            else if (counter == 5)
            {
               LessThanHundredThousand(number[length - 4], number[length - 3], number[length - 2], number[length - 1], number[length]);
            }
            

            //determine if there is a value past the decimal
            hundredths = integer % 1;
            
            if (hundredths != 0)
            {
               CalculateHundredths(hundredths);
            }
         }

         
      }
   }
}
