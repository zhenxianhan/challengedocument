using System;
using System.IO;


namespace challengedocument
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document");
                Console.WriteLine(" ");
                Console.WriteLine("Please Enter The Name of This Document: ");
                string filename = Console.ReadLine() + ".txt";
                StreamWriter sw = new StreamWriter(filename);

                Console.WriteLine("Please Enter The Content of This Documents: ");
                string content = Console.ReadLine();
                sw.WriteLine(content);
                sw.Close();


                Console.WriteLine(filename + " was successfully saved.The document contains " + content.Length + " characters.");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

    }
}
