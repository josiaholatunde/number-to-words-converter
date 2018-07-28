using System;

namespace cSharp
{
    class Program
    {    
        



        public static string NumToWords(long num)
        {
     

            string words = "";

            if (num == 0)
            {
                return "zero";
            }

            
            if(Convert.ToString(num).Length > 12){
                return "Number out of range";
            }
            
          



            if((num / 1000000000) > 0 )
            {
                words += NumToWords(num/1000000000) + " billion ";
                num %= 1000000000;
            }

           

            if((num / 1000000) > 0 )
            {
                words += NumToWords(num/1000000) + " million ";
                num %= 1000000;
            }

          
            if((num / 1000) > 0 )
            {
                words += NumToWords(num/1000) + " thousand ";
                num %= 1000; //remainder passed on to next condition
            }

            if((num / 100) > 0 )
            {
        
                words += NumToWords(num/100) + " hundred ";
                num %= 100;
                
            }
            
            


            if (num > 0)
            {
                if (words != ""){
                    words += "and ";

                }

                string[] units =  { 
                    "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
                     "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
                      };
                string[] tens =  { 
                    "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 20)
                {
                    words += units[num];
                }
                else
                {
                    words += tens[num / 10];
                    //adds seventy-five for words that have tens and units
                    if((num % 10) > 0)
                    {
                        words += "-" +  units[num % 10];
                    }  
                }
            }
            
            
            return words;
        }       
        static void Main(string[] args)
        {
            long number;
             while( true ){

                Console.WriteLine("This program converts numbers to words");
                Console.Write("Enter a number? ");
                number = long.Parse(Console.ReadLine());
                

                Console.WriteLine(NumToWords(number));
                Console.ReadKey();

            }
            


        }
           
    }
    
}
