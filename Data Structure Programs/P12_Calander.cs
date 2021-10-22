using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class P12_Calander
    {
        public void Calander()
        {
            Console.WriteLine("Enter month:  ");
            string month = Console.ReadLine();
            Console.WriteLine("Enter year:  ");
            int year = Convert.ToInt32(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            

            int m=1;
            for(int i =0; i<months.Length; i++)
            {
                if (month == months[i])
                {
                    m = i + 1;
                }
            }

            int feb = 28;
            if (checkLeapYear(year))
            {
                feb = 29;
            }

            string[,] calander = new string[6,7];
           
            int k = 1;
            int max = 31;
            if (m == 2)
            {
                max = feb;
            }
            else if(m==4 || m==6 || m==9 || m==11)
            {
                max = 30;
            }
           
            int day = dayOfWeek(year, m);

            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j < day && i==0 || k>max)
                    { 
                        calander[i, j] = "      ";
                    }
                    else 
                    {
                        if (k < 10)
                        {
                            calander[i, j] = k + "     ";
                        }    
                        else
                        {
                            calander[i, j] = k + "    ";
                        }
                         k++;
                    }
                    
                }
               
            }

            displayCalander(calander,month,year);
           


        }

        void displayCalander(string[,] calander,string month, int year)
        {
            Console.Clear();
            Console.WriteLine("{0}  {1}\n",month,year);
            Console.WriteLine("Sun   Mon   Tue   Wed   Thu   Fri   Sat");
            for (int i =0; i< 6; i++)
            {
                for(int j=0; j<7; j++)
                {
                    Console.Write(calander[i, j]);
                }
                Console.WriteLine();
            }

        }

        int dayOfWeek(int y, int m)
        {
            int d = 1;
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

            y -= (m < 3) ? 1 : 0;
            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }
        bool checkLeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) ||(year % 400 == 0));
        }
    }
    
}
