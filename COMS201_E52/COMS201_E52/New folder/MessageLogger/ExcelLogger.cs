using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace COMS201_E52
{
    class ExcelLogger : ILogger
    {
        private readonly string _connectionstring;

        public ExcelLogger(string filepath)
        {
            _connectionstring = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ filepath };Jet OLEDB:Engine Type=5;Extended Properties=\"Excel 12.0;HDR=YES;\"";        
        }

        public void Save(string message)
        {
            OleDbConnection cnn = new OleDbConnection(_connectionstring);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Sheet1$] ([Message]) VALUES(@message_text)", cnn);
            cmd.Parameters.AddWithValue("@message_text", message);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Dispose();
            cnn.Dispose();
        }
    }
}
