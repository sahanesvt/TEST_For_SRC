using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class ClassThatUsesShape
    {
        private Shape someShape; // creating "local" variable allows us to use this variable in "returnArea()" and "returnPerimeter()" methods/functions

        public ClassThatUsesShape(Shape anyShape) //here is how we "instatiate" or create an instance of this object with a required input variable/parameter
        {
            someShape = anyShape; // we set our local variable equal to the input parameter
        }

        public double returnArea()  
        {
            return someShape.Area;  // this method/function does not care about specifics of shape, so long as shape has an "area"
        }

        public double returnPerimeter()
        {
            return someShape.Perimeter; // this method/function does not care about specifics of shape, so long as shape has a "perimeter"
        }

        public string returnWhatAmI()
        {
            return someShape.WhatAmI; // this method/function does not care about specifics of shape, so long as shape has a "WhatAmI" property
        }
    }
}
