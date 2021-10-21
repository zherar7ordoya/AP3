using System;
using static System.Console;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            IDCardGenerator id = new IDCardGenerator();
            EmailGenerator mail = new EmailGenerator();

            UserProcessor.UserProcessorEvent += db.SaveToDB;
            UserProcessor.UserProcessorEvent += id.GenerateIDCard;
            UserProcessor.UserProcessorEvent += mail.SendEmailToUser;

            WriteLine("Commands Accepted:\n");
            WriteLine("1.  new: Add new User");
            WriteLine("2. exit: Close the application");

            while (true)
            {
                Write("\nEnter your command: ");
                var input = ReadLine();

                if (input.Equals("exit")) { break; }
                else if (input.Equals("new"))
                {
                    Write("\n        User Name: ");
                    var name = ReadLine();
                    Write("         User Age: ");
                    var age = int.Parse(ReadLine());
                    Write("Send email? (y/n): ");
                    var needed = ReadLine();

                    if(needed.Equals("n")) { UserProcessor.UserProcessorEvent -= mail.SendEmailToUser; }

                    UserProcessor.ProcessUser(name, age);
                }
                else { WriteLine("\n\tInvalid command..."); }
            }
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
        public void SaveToDB(object sender, EventArgs e)
        {
            WriteLine("\n\tData saved to DB.");
        }
    }
    public class IDCardGenerator
    {
        public void GenerateIDCard(object sender, EventArgs e)
        {
            WriteLine("\tID Card generated.");
        }
    }
    public class EmailGenerator
    {
        public void SendEmailToUser(object sender, UserArgs e)
        {
            WriteLine($"\tEmail sent to User { e.Name }");
        }
    }
}
