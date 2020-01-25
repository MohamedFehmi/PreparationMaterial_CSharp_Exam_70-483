using System;
using System.IO;
using System.Text;

namespace StringBuilder_Reader_Writer
{
    public class FileReadWrite
    {
        StringBuilder stringBuilder = new StringBuilder();

        //A read only property that returns the file name
        public string DocFullPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TestFile.txt");
            }
        }

        public string FileName
        {
            get
            {
                return @"TestFile.txt";
            }
        }

        public FileReadWrite()
        {
            //Display original content
            ReadFromFileSync("==== This is the original file before modification ==>");
            WriteToFileSync();
            ReadFromFileSync("==== This is the modified file ==> ");
        }

        #region "Writing text to a file Synchronously"
        public void WriteToFileSync()
        {
            try
            {
                Console.WriteLine("Write some text down here to save it to your file:");

                //Read user input
                String text = Console.ReadLine();

                //1- Create new text content
                using (StreamReader streamReader = new StreamReader(DocFullPath))
                {
                    stringBuilder.AppendLine(streamReader.ReadToEnd() + text);
                }

                //2- Save the new text content
                using (StreamWriter outputFile = new StreamWriter(DocFullPath))
                {
                    outputFile.WriteLine(stringBuilder);
                    stringBuilder.Clear();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Could not write to the file :(");
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region "Reading file content Synchronously"
        public void ReadFromFileSync(string message)
        {
            try
            {
                Console.WriteLine(message);

                // Open the text file using a stream reader
                using (StreamReader streamReader = new StreamReader(DocFullPath))
                {
                    //Read the stream to a string and write it the StringBuilder object
                    stringBuilder.AppendLine(streamReader.ReadToEnd());
                    Console.WriteLine(stringBuilder);
                    stringBuilder.Clear();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :(");
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}