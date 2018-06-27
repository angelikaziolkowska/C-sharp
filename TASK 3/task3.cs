//Angelika Ziolkowska
//20 June 2018

using System;

namespace ConsoleApp
{
    class Task3
    {
        static void Main(string[] args)
        {
            int shift = 0, shiftend = 0, data = 0;
            bool changeme = false;

            //reads in text file
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\compgeek\Desktop\TASKS\TASK 3\Data2.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Equals("[SHIFTS]"))
                {
                    shift = i + 1;
                }
                else if (lines[i].Equals("[DATA]"))
                {
                    shiftend = i - 2;
                    data = i + 1;
                }
            }

            DateTime[] shifts = new DateTime[shiftend - shift + 1];
            double[] hours = new double[shiftend - shift + 1];
            DateTime[] datetimes = new DateTime[lines.Length - data];
            double[] myData = new double[lines.Length - data];
            //save all shifts
            for (int i = shift + 1; i <= shiftend; i++)
            {
                try
                {
                    shifts[i - 1] = DateTime.ParseExact(lines[i].Substring(0, 16), "dd/MM/yyyy HH:mm",
                       System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Datetime out of range!");
                }

                try
                {
                    hours[i - 1] = Convert.ToDouble(lines[i].Substring(17, lines[i].Length - 17));
                }
                catch
                {
                    Console.WriteLine("Wrong format of hours!");
                }
            }

            //save all data
            for (int i = data; i < lines.Length; i++)
            {
                try
                {
                    datetimes[i - data] = DateTime.ParseExact(lines[i].Substring(0,16), "dd/MM/yyyy HH:mm",
                       System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Index out of range!");
                }

                try
                {
                    myData[i - data] = Convert.ToDouble(lines[i].Substring(17, lines[i].Length - 17));
                }
                catch
                {
                    Console.WriteLine("Wrong format of my data!");
                }

            }

            //for every shift compare with data
            for (int i = 0; i<shifts.Length; i++)
            {
                for (int j = 0; j<datetimes.Length; j++)
                {
                    if (shifts[i] == datetimes[j])
                    {
                        changeme = true;
                    }
                    if (changeme)
                    {
                        //add hours
                        datetimes[j] = datetimes[j].AddHours(hours[i]);

                        if (j == datetimes.Length - 1)
                        {
                            changeme = false;
                        }
                    }

                }
            }

            //output
            for(int i = 0; i<datetimes.Length; i++)
            {
                Console.Write("{0:dd/MM/yyyy HH:mm, }", datetimes[i]);
                Console.WriteLine("{0:N1}", myData[i]);
            }         
        }
    }
}
