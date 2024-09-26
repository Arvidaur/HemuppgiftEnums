using System;
using System.Collections.Generic;
using System.Linq;

namespace HemuppgiftEnums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Arvid", "Rönnkvist", 28);
            string fullName = person1.GetFullName();
            Console.WriteLine(fullName);

            Task task = new Task(Color.Red, Priority.High);
            task.PrintDescription();

            User admin = new User(UserRole.Admin);
            admin.PrintUserRole();
            User moderator = new User(UserRole.Moderator);
            moderator.PrintUserRole();
            User user = new User(UserRole.User);
            user.PrintUserRole();
            User guest = new User(UserRole.Guest);
            guest.PrintUserRole();

        }
    }
}
