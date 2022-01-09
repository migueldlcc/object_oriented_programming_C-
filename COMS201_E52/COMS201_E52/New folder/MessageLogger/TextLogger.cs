using System;
using System.Collections.Generic;
using System.Text;

namespace COMS201_E52
{
    class TextLogger : ILogger
    {
        private readonly string _filename;

        public TextLogger(string filepath)
        {
            _filename = filepath;
        }

        public void Save(string message)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(path:_filename, append:true);
            file.WriteLine(message);
            file.Dispose();
        }
    }
}
