using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public abstract class Shape
    {
        public double Area; // this is a common propery of all shapes, but how calculated depends on actual shape so leave for concrete class of "shape" to define
        public double Perimeter; // this is a common propery of all shapes, but how calculated depends on actual shape so leave for concrete class of "shape" to define
        public string WhatAmI = "I am a shape!!!!"; // this can be something that all shapes have in common and may be defined here or overridden in the concrete class
    }
}
