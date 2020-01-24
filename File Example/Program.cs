using System;
using static System.Console;
using  System.IO;

namespace File_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader F = new StreamReader("sample.txt");

            WriteLine(F.ReadLine()); //reading from a file
            F.Close(); // closing file
            
            StreamReader File = new StreamReader("sample.txt"); //starting from the beginning
            WriteLine(File.ReadLine());
            File.Close();

            ////////////////////////////////////////////////////////////
            ///

            WriteLine("Give a number:");
            string input = ReadLine();
            int userInt = Convert.ToInt32(input);

            StreamReader Lib = new StreamReader("sample.txt"); //opening file

            string Line = Lib.ReadLine(); //line from file

            WriteLine("Your number is equal to these words:");
            while(Line != null) //running until next line in file is null
            {
                int spaceLocation = Line.IndexOf(" "); //find where the space between number and the word is in the line
                int value = Convert.ToInt32(Line.Substring(0, spaceLocation + 1)); //find number in file
                string word = Line.Substring(spaceLocation); //find word in line in the file
                if(userInt == value)
                {
                    WriteLine(word);
                }
                Line = Lib.ReadLine();
            }
            Lib.Close();

            // Write to end of file
            using (StreamWriter lib2 = new StreamWriter("sample.txt", true))
            {
                lib2.WriteLine("23 shark");
            }

                
           

            

            




        }
    }
}
