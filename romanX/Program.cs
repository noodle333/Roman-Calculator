using System;

namespace romanX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to convert a roman string to numbers, or an int to roman numbers?");
            Console.WriteLine("Enter 'String' for string conversion or 'Int' for int conversion.");
            string input = Console.ReadLine().ToLower();

            if(input == "string")
            {
                Console.WriteLine("Enter a roman numeral you want to convert to an int. (No spaces)");
                string playerString = Console.ReadLine();
                Console.WriteLine("Your string in roman numerals is " + StringSolution(playerString));
                Console.ReadLine();
                

            }
            else if (input == "int")
            {
                int playerInt = 0;
                while(playerInt < 1)
                {
                    Console.WriteLine("Enter a positive int you want to convert.");
                    Int32.TryParse(Console.ReadLine(), out playerInt);
                }
                Console.WriteLine("Your int in roman numerals is " + IntSolution(playerInt));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the word 'string' or the word 'int' after you restart the program.");
                Console.ReadLine();
            }
            
        }


        public static string IntSolution(int n)
        {
            if (n < 1) 
                return string.Empty; 
            if (n >= 1000) 
                return "M" + IntSolution(n - 1000);
            if (n >= 900) 
                return "CM" + IntSolution(n - 900); 
            if (n >= 500) 
                return "D" + IntSolution(n - 500);
            if (n >= 400) 
                return "CD" + IntSolution(n - 400);
            if (n >= 100) 
                return "C" + IntSolution(n - 100);            
            if (n >= 90) 
                return "XC" + IntSolution(n - 90);
            if (n >= 50) 
                return "L" + IntSolution(n - 50);
            if (n >= 40) 
                return "XL" + IntSolution(n - 40);
            if (n >= 10) 
                return "X" + IntSolution(n - 10);
            if (n >= 9) 
                return "IX" + IntSolution(n - 9);
            if (n >= 5) 
                return "V" + IntSolution(n - 5);
            if (n >= 4) 
                return "IV" + IntSolution(n - 4);
            if (n >= 1) 
                return "I" + IntSolution(n - 1);
            return "";
        }

        public static int StringSolution(string roman)
        {
            int result = 0;
            char[] arr;
        
            arr = roman.ToCharArray();
    
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 'M' && i == 0)
                {
                    result += 1000;
                }
                else if (arr[i] == 'M' && arr[i-1] != 'C') 
                {
                    result += 1000;
                }
                if (arr[i] == 'D')
                {
                    result += 500;
                }
                if (arr[i] == 'C' && arr[i-1] != 'X')
                {
                    result += 100;
                }
                if (arr[i] == 'L')
                {
                    result += 50;
                }
                if (arr[i] == 'X')
                {
                    result += 10;
                }
                if (arr[i] == 'V' && arr[i-1] != 'I')
                {
                    result += 5;
                }
                if (arr[i] == 'I')
                {
                    result += 1;
                }
                
                if (i > 0)
                {
                    if(arr[i] == 'V' && arr[i-1] == 'I')
                    {
                        result += 3;
                    }
                
                    if (arr[i] == 'M' && arr[i-1] == 'C')
                    {
                        result += 800;
                    }
                
                    if (arr[i] == 'C' && arr[i-1] == 'X')
                    {
                        result += 80;
                    }
                }

            }
        return result;
        }
    }
}
