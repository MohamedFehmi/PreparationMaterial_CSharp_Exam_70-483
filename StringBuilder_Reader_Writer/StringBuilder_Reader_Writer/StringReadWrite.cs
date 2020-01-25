using System;
using System.IO;
using System.Text;

namespace StringBuilder_Reader_Writer
{
    public class StringReadWrite
    {
        StringBuilder stringBuilder = new StringBuilder();

        public StringReadWrite()
        {
            WriteData();
            ReadData();
        }

        #region "Write data to stringBuilder"
        public void WriteData()
        {
            StringWriter writer = new StringWriter(stringBuilder);

            Console.WriteLine("Please enter your first and last name: ");

            //Read input from console
            string name = Console.ReadLine();

            //Write input to the StringBuilder object
            writer.WriteLine($"Name: {name}");

            //writer.Flush();
            //writer.Close();
        }
        #endregion

        #region "Read data from the StringBuilder object"
        public void ReadData()
        {
            StringReader stringReader = new StringReader(stringBuilder.ToString());

            Console.WriteLine("Reading the information...");

            //Go through the string by checking if there is a next character
            while (stringReader.Peek() > -1)
            {
                Console.WriteLine(stringReader.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            stringReader.Close();
        }
        #endregion
    }
}