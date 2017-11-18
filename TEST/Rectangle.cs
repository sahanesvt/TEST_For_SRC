using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Rectangle: Shape
    {
        private string iAmAWhat = "Rectangle"; // let's give our shape a name to self identify
        public double Width;  // this would be a "property" of a rectangle, but not necessarily any shape
        public double Depth;  // this would be a "property" of a rectangle, but not necessarily any shape

        public Rectangle(double width, double depth) //here is how we "instatiate" or create an instance of this object with a required input variable/parameter
        {
            Width = width; // we can set our properties equal to the input variable
            Depth = depth; // we can set our properties equal to the input variable
            Area = calcArea(width, depth); // we can pass input variables to methods/fuctions which will perform actions (voids) or return something (methods)
            Perimeter = calcPerimeter(width, depth); // we can pass input variables to methods/fuctions which will perform actions (voids) or return something (methods)
        }

        private double calcArea(double width, double depth) // method/function to return value of specified type based on any relevant input paramters/variables
        {
            return width * depth; // what method returns
        }

        private double calcPerimeter(double width, double depth) // method/function to return value of specified type based on any relevant input paramters/variables
        {
            return 2 * (width + depth); // what method returns
        }

        public void FindMyself()  // voids don't return values, but rather perform actions based on any relevant input paramters/variables
        {
            WhatAmI = iAmAWhat;  // here we are reassigning the default value of this variable (defined in Shape class) to a more specific value.... but only if we call this method
        }
    }
}
