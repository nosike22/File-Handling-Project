using System;
using System.IO;

namespace Handling_project
{
    class Program
    {
        static void Main(string[] args)
        {

           


            Console.WriteLine("File Handling Processes");
            Console.WriteLine("~~~~~~~~~~~");

            Console.WriteLine("Enter File Name");
            var fileName = Console.ReadLine();
            var filePath = $"C:/New User/{fileName}.txt";


            if (File.Exists(filePath) == true)
            {
                using (TextWriter writer = File.AppendText(filePath))
                {
                    Console.WriteLine("Enter your desired text");
                    var text = Console.ReadLine();
                    writer.WriteLine($"Content written into file ={text}");
                }
                Console.WriteLine("Entry stored successfull!");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("File Does Not exist\n ..Choose option 1 to create file");

                var x = 0;

                while (true)
                {
                    Console.WriteLine("Choose which operation you wish to carry");
                    Console.WriteLine("1. Creating a text File");
                    Console.WriteLine("2. Writing into the text file");
                    Console.WriteLine("3. Reading The text File ");
                    Console.WriteLine("4. Exit");
                    
                    //Enter the option of your choice
                    Console.WriteLine("Enter the option of your choice");
                     x = int.Parse((Console.ReadLine()));

                    if (x == 1)
                    {
                        Console.WriteLine("Enter file Name");
                         fileName = Console.ReadLine();
                        filePath = $"C:/New User/{fileName}.txt";
                        Console.Write("File has been created ");
                        Console.ReadKey();
                    }


                    if (x == 2)
                    {
                        string file = $"C:/New User/{fileName}.txt";
                        using (TextWriter writer = File.AppendText(file))
                        {
                            Console.WriteLine("Enter your desired text");
                            var text = Console.ReadLine();
                            writer.WriteLine($"Content written into file = { text}");
                        }
                        Console.WriteLine("Entry stored successfull!");
                        Console.ReadKey();
                    }
                    if (x == 3)
                    {
                        using (TextReader tr = File.OpenText($"C:/New User/{fileName}.txt")) 
                        {
                            Console.WriteLine(tr.ReadToEnd());
                        }
                        Console.ReadKey();
                    }

                    if (x == 4)
                    {
                        Environment.Exit(0);
                    }


                }


              



               

              

               
            }

        }
    }
}
 
