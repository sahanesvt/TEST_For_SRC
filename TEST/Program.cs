using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program 
    {
        static void Main(string[] args) // this is an "entry point" into our program
        {
            Circle coolCircle = new Circle(5); // creates Circle object
            coolCircle.FindMyself(); // redifines abstract class's definition of "WhatAmI"
            Rectangle betterRectangle = new Rectangle(5, 5); // creates Rectangle object
            // note that we choose not to redefine abstract class's definition of "WhatAmI" for our Rectangle

            ClassThatUsesShape firstClassThatUsesShape = new ClassThatUsesShape(coolCircle); // let's create some random class that will use a shape of unknown type
            ClassThatUsesShape nextClassThatUsesShape = new ClassThatUsesShape(betterRectangle); // let's create another random class that will also use another shape of unknown type

            double firstArea = firstClassThatUsesShape.returnArea(); // call a method that will return the area of the arbitrary shape that we input as a parameter
            double firstPerimeter = firstClassThatUsesShape.returnPerimeter(); // call a method that will return the perimeter of the arbitrary shape that we input as a parameter

            double nextArea = nextClassThatUsesShape.returnArea(); // call a method that will return the area of the arbitrary shape that we input as a parameter
            double nextPerimeter = nextClassThatUsesShape.returnPerimeter(); // call a method that will return the perimeter of the arbitrary shape that we input as a parameter


            Console.WriteLine("Area of first shape is {0}\nPerimeter of first shape is {1}\nI am a {2}",firstArea,firstPerimeter,coolCircle.WhatAmI); // show text with following parameters on console
            Console.WriteLine("Area of next shape is {0}\nPerimeter of next shape is {1}\nI am a {2}", nextArea,nextPerimeter,betterRectangle.WhatAmI); // show text with following parameters on console
        }
    }
}
