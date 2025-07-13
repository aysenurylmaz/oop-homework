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
    internal class Polygon
    {
        private Point2D center;     //The center point of the polygon   
        private int length;         //The length of each edge of the polygon
        private ColorRGB color;       //The color of the polygon in RGB format
        private int numberOfEdges;    //The number of edges of the polygon
        private Point2D[] vertices;   //An array holding the vertex points of the polygon

        //Properties with getters and setters
        public Point2D Center
        {
            get { return center; }
            set { center = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public ColorRGB Color
        {
            get { return color; }
            set { color = value; }
        }

        public int NumberOfEdges
        {
            get { return numberOfEdges; }
            set { numberOfEdges = Math.Max(3, Math.Min(10, value)); } //Limit between 3-10 edges
        }

        public Point2D[] Vertices
        {
            get { return vertices; }
        }


        public Polygon()
        {
            // Default values
            this.center = new Point2D(0, 0); //Center at origin (0,0)
            this.length = 4;                 //Length of 4 units
            this.color = new ColorRGB();     //Black color (default)
            this.numberOfEdges = 5;          //Pentagon (5 edges)
            this.vertices = new Point2D[numberOfEdges]; // Initialize vertex array
        }

        //constructor that takes center point and length as parameters
        public Polygon(Point2D center, int length)
        {
            this.center = center;          //set custom center
            this.length = length;          //set custom length
            this.color = new ColorRGB();   //default color (black)
            this.numberOfEdges = 5;        //default to pentagon (5 edges)
            this.vertices = new Point2D[numberOfEdges]; //initialize vertex array
        }

        //Calculates the coordinates of all polygon vertices based on current properties
        public void calculateEdgeCoordinates()
        {
            //Resizes the vertices array to match the current number of edges
            vertices = new Point2D[numberOfEdges];

            //Sets the starting angle for the first vertex (0 radians means pointing to the right)
            double startAngle = 0; // 0 radians

            //Calculate angle step between vertices (full circle / number of edges)
            double angleStep = 2 * Math.PI / numberOfEdges;

            //Calculate all vertices
            for (int i = 0; i < numberOfEdges; i++)
            {
                double angle = startAngle + i * angleStep; //Calculates the angle for the current vertex by adding angleStep each time

                //Calculates vertex position relative to center (for regular polygon)
                double vertexX = center.X + length * Math.Cos(angle);
                double vertexY = center.Y + length * Math.Sin(angle);

                //Creates a new Point2D for this vertex and store it in the array
                vertices[i] = new Point2D(vertexX, vertexY);
            }
        }

        //Rotates the polygon around its center by the specified angle
        public void rotatePolygon(double angleInDegrees, bool isCounterClockWise)
        {
            //Calculates vertices first if they haven't been calculated yet
            if (vertices == null || vertices.Length != numberOfEdges)
            {
                calculateEdgeCoordinates();
            }

            //Converts degrees to radians for calculation
            double angleInRadians = angleInDegrees * (Math.PI / 180);

            //Adjusts angle direction based on rotation type
            if (!isCounterClockWise) //If not counter-clockwise
            {
                angleInRadians = -angleInRadians; //Makes angle negative
            }

            //Rotates each vertex around the center
            for (int i = 0; i < numberOfEdges; i++)
            {
                //Calculates position relative to center before rotation
                double x = vertices[i].X - center.X;
                double y = vertices[i].Y - center.Y;

                // Apply rotation matrix transformation
                double newX = x * Math.Cos(angleInRadians) - y * Math.Sin(angleInRadians);
                double newY = x * Math.Sin(angleInRadians) + y * Math.Cos(angleInRadians);

                //The new coordinates are shifted back to the center point.
                vertices[i].X = center.X + newX;
                vertices[i].Y = center.Y + newY;
            }
        }
    }
}
