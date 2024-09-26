using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftEnums
{
    /*Uppgift 4: Read-Only Egenskaper
Skapa en klass Rectangle med följande egenskaper:
• Width(double)
• Height(double)
En read-only egenskap Area som beräknar och returnerar rektangelns area.*/
    internal class Rectangle
    {
        //Properties
        public double Width { get; set; }
        public double Height { get; set; }

        // Read-only property for Area
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

    }
}
