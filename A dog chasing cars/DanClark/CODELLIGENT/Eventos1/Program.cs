using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Eventos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            IdCardGenerator id = new IdCardGenerator();
            EmailGenerator eg = new EmailGenerator();

            UserProcessor.UserProcessorEvent += db.SaveToDB;
            UserProcessor.UserProcessorEvent += id.GenerateIdCard;
            UserProcessor.UserProcessorEvent += eg.SendEmailToUser;

            WriteLine("Commands Accepted:");
            // 15 MINUTOS
        }
    }
    public class UserProcessor
    {
        public static event EventHandler<UserArgs> UserProcessorEvent;
        public static void ProcessUser(string name, int age) { }
    }
    public class UserArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Database
    {
        public void SaveToDB(object sender, EventArgs e) { WriteLine("Data Saved!"); }
    }
    public class IdCardGenerator
    {
        public void GenerateIdCard(object sender, EventArgs e) { WriteLine("Card Generated!"); }
    }
    public class EmailGenerator
    {
        public void SendEmailToUser(object sender, EventArgs e) { WriteLine("Email Sent!"); }
    }
}
