using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.DIP
{
    public class FileProcessor
    {
        private FileReader _fileReader;
        private FileWriter _fileWriter;
        public FileProcessor(FileReader fileReader , FileWriter filewriter)
        {
            _fileReader = fileReader;
            _fileWriter = filewriter;
        }
        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = _fileReader.ReadFile(inputFilePath);

        }
    }

    public class FileReader
    {
        public string ReadFile(string filePath)
        {

            return "";
        }

    }

    public class FileWriter
    {
        public void WriteFile(string filePath, string content)
        {


        }
    }

}




