using System;
using static System.Console;

/// <summary>
/// https://youtu.be/841BAFuoXGE
/// </summary>

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

            WriteLine("Commands Accepted:\n");
            WriteLine("new: \tAdd new User");
            WriteLine("exit: \tClose the application");

            while (true)
            {
                Write("\nEnter your command: ");
                var input = ReadLine();

                if (input.Equals("exit")) { break; }
                else if (input.Equals("new"))
                {
                    Write("\nUser Name: \t");
                    var name = ReadLine();
                    Write("User Age: \t");
                    var age = int.Parse(ReadLine());
                    Write("y/n send mail: \t");
                    var needed = ReadLine();

                    if (needed.Equals("n")) { UserProcessor.UserProcessorEvent -= eg.SendEmailToUser; }

                    UserProcessor.ProcessUser(name, age);
                }
                else { WriteLine("\n\tInvalid command..."); }
            }
            Write("\n*** PROGRAM FINISHED ***");
            ReadKey();
        }
    }
    public class UserProcessor
    {
        public static event EventHandler<UserArgs> UserProcessorEvent;
        public static void ProcessUser(string name, int age) 
        {
            UserArgs args = new UserArgs();
            args.Name = name;
            args.Age = age;
            UserProcessorEvent?.Invoke(null, args);
        }
    }
    public class UserArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Database
    {
        public void SaveToDB(object sender, EventArgs e) { WriteLine("\n\tData Saved!"); }
    }
    public class IdCardGenerator
    {
        public void GenerateIdCard(object sender, EventArgs e) { WriteLine("\tCard Generated!"); }
    }
    public class EmailGenerator
    {
        public void SendEmailToUser(object sender, UserArgs e) { WriteLine($"\tEmail sent to {e.Name}"); }
    }
}
