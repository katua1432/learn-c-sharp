using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Square
    {
        public double side;
        string colour;
        double area;
        // нельзя сюда в поля типа double areaOfSquare = side * side   ??

        public Square(int side, string colour) 
        {
            this.side = side;
            this.colour = colour;
            area = side * side;
        }
      
        
        public void SquareInformation()
        {
            Console.WriteLine($"Side: {side}.\nColour: {colour}.\nArea: {area}.\n");
        }

    }
}
