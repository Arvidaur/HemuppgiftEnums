using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HemuppgiftEnums
{

    /*Skapa ett enum för olika typer av användarroller och använd en switch-sats för
att skriva ut olika meddelanden beroende på vilken roll användaren har.
Steg:
1. Skapa ett enum som heter UserRole med värdena Admin, Moderator, User,
Guest.
2. Skapa en klass User med en property Role av typen UserRole.
3. Implementera en metod PrintRoleMessage som använder en switch-sats
för att skriva ut olika meddelanden beroende på rollen.
Utskrifterna ska vara
• Welcome, Admin! You have full access.
• Welcome, Moderator! You can manage content.
• Welcome, User! You can view and comment.
• Welcome, Guest! You have limited access.*/

    public enum UserRole
    {
        Admin,
        Moderator,
        User,
        Guest
    }
    class User
    {
        //Properties
        public UserRole Role {  get; set; }

        //Constructor
        public User (UserRole role)
        {
        Role = role; 
        }

        public void PrintUserRole()
        {
            switch (Role)
            {
                case UserRole.Admin:
                    Console.WriteLine($"Welcome, Admin! You have full access.");
                    break;
                case UserRole.Moderator:
                    Console.WriteLine($"Welcome, Moderator! You can manage content.");
                    break;
                case UserRole.User:
                    Console.WriteLine($"Welcome, User! You can view and comment.");
                    break;
                case UserRole.Guest:
                    Console.WriteLine($"Welcome, Guest! You have limited access.");
                    break;
                default:
                    Console.WriteLine("Error, user role not found");
                    break;

            }
        }
    }
}
