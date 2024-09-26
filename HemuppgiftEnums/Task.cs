using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftEnums
{
    class Task
    {
        //Properties
        Color color {  get; set; }
        Priority priority { get; set; }

        //Constructor
        public Task (Color color, Priority priority)
        {
            this.color = color;
            this.priority = priority;
        }
        public void PrintDescription()
        {
            Console.WriteLine($"Task color: {color}. Task priority: {priority}.");
        }
    }
    public enum Color
    {
        Red,
        Yellow, 
        Green,
        Blue,
        
    }
    public enum Priority
    {
        Low,
        Medium, 
        High
    }
}
