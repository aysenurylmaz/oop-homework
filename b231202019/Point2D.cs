//****************************************************************************************
//**********       STUDENT NAME : AYŞENUR YILMAZ  ****************************************
//**********     STUDENT NUMBER : B231202019      ****************************************
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace b231202019
{
    internal class Point2D
    {
        //Data members for Cartesian coordinates
        private double x;
        private double y;

        //Data members for polar coordinates
        private double r; //radius
        private double theta; //angle (in radians)

        //X and Y properties
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        //Constructor that takes x and y values as parameters
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Second constructor that sets initial coordinates with random x and y values
        public Point2D()
        {
            Random rnd = new Random();
            this.x = rnd.Next(0, 4); //0-3 range
            this.y = rnd.Next(0, 4); //0-3 range
        }

        //Method to print the 2D point's coordinates
        public void printCoordinates()
        {
            Console.WriteLine("Cartesian Coordinates: (" + x + ", " + y + ")");
        } 

        //Method to calculate polar coordinates of the 2D point
        public void calculatePolarCoordinates()
        {
            //r = √(x² + y²)
            r = Math.Sqrt(x * x + y * y);

            //θ = atan2(y, x) - atan2 function calculates the correct angle in all four quadrants
            theta = Math.Atan2(y, x);
        }

        //Method to calculate cartesian coordinates from polar coordinates
        public void calculateCartesianCoordinates()
        {
            // x = r * cos(θ)
            x = r * Math.Cos(theta);

            // y = r * sin(θ)
            y = r * Math.Sin(theta);
        }

        //Method that creates a string for this 2D point's pre-calculated polar coordinates
        public string printPolarCoordinates()
        {
            calculatePolarCoordinates();
            return "Polar Coordinates: (r=" + r.ToString("F2") + ", θ=" + theta.ToString("F2") + " rad / " + (theta * 180 / Math.PI).ToString("F2") + "°)";  //Converts the values to a string with 2 digits after the decimal point.
        }
    }
}
