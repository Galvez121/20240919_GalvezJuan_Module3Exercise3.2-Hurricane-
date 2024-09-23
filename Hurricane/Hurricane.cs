using System;
using System.Text.RegularExpressions;

class Hurricane
{
    public static void Main(){
        Console.WriteLine("Enter wind speed: ");

        string inputSpeed = Console.ReadLine();


        string onlyNumbers = Regex.Match(inputSpeed, @"\d+").Value;

        double windSpeed;

        // Make sure the input is a valid number before converting it
         if (double.TryParse(onlyNumbers, out windSpeed)){
            if (windSpeed >= 157)
            {
                Console.WriteLine("Category Five Hurricane");
            }
            else if (windSpeed >= 130)
            {
                Console.WriteLine("Category Four Hurricane");
            }
            else if (windSpeed >= 111)
            {
                Console.WriteLine("Category Three Hurricane");
            }
            else if (windSpeed >= 96)
            {
                Console.WriteLine("Category Two Hurricane");
            }
            else if (windSpeed >= 74)
            {
                Console.WriteLine("Category One Hurricane");
            }
            else if (windSpeed < 74)
            {
                Console.WriteLine("It is not a Hurricane.");
            }
         }
          else
            {
             Console.WriteLine("Enter a valid numeric value.");
            }      
    }
        
 }