using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Circle: Shape  
    {
        private string iAmAWhat = "Circle"; // let's give our shape a name to self identify
        public double Diameter; // this would be a "property" of a circl, but not necessarily any shape

        public Circle(double diameter) //here is how we "instatiate" or create an instance of this object with a required input variable/parameter
        {
            Diameter = diameter; // we can set our properties equal to the input variable
            Area = calcArea(diameter); // we can pass input variables to methods/fuctions which will perform actions (voids) or return something (methods)
            Perimeter = calcPerimeter(diameter); // we can pass input variables to methods/fuctions which will perform actions (voids) or return something (methods)
        }
        
        private double calcArea(double diameter) // method/function to return value of specified type based on any relevant input paramters/variables
        {
            return Math.Pow(diameter, 2) * Math.PI / 4; // what method returns
        }

        private double calcPerimeter(double diameter) // method/function to return value of specified type based on any relevant input paramters/variables
        {
            return diameter * Math.PI; // what method returns
        }

        public void FindMyself() // voids don't return values, but rather perform actions based on any relevant input paramters/variables
        {
            WhatAmI = iAmAWhat; // here we are reassigning the default value of this variable (defined in Shape class) to a more specific value.... but only if we call this method
        }
    }
}
