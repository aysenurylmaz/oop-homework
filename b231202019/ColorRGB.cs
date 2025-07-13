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
    internal class ColorRGB
    {
        //Data members for color values
        private int red;    //Red (0-255)
        private int green;  //Green (0-255)
        private int blue;   //Blue (0-255)

        private static readonly Random rnd = new Random();  // Static random, tekrar oluşturmayı önler

        public int Red
        {
            get { return red; }
            set { red = Math.Max(0, Math.Min(255, value)); } //keeps it between 0 and 255
        }

        public int Green
        {
            get { return green; }
            set { green = Math.Max(0, Math.Min(255, value)); }  //keeps it between 0 and 255
        }

        public int Blue
        {
            get { return blue; }
            set { blue = Math.Max(0, Math.Min(255, value)); } //keeps it between 0 and 255
        }

        //For deafult values
        public ColorRGB()
        {
            this.red = 0;    //Initialize red to 0
            this.green = 0;  //Initialize green to 0
            this.blue = 0;   //Initialize blue to 0
        }

        //Constructor taking red, green and blue values
        //Allows creating a specific color by providing all three RGB components
        public ColorRGB(int red, int green, int blue)
        {
            //Keeps values between 0-255 using the properties validation
            this.Red = Math.Max(0, Math.Min(255, red));       //Set red with validation
            this.Green = Math.Max(0, Math.Min(255, green));   //Set green with validation
            this.Blue = Math.Max(0, Math.Min(255, blue));     //Set blue with validation
        }

        //Constructor that can initialize with random color values
        //If random=true, generates a random color; otherwise creates black
        public ColorRGB(bool random)
        {
            if (random)
            {
                //Generates random values for each color component
                this.red = rnd.Next(0, 256);   //Random red value (0-255)
                this.green = rnd.Next(0, 256); //Random green value (0-255)
                this.blue = rnd.Next(0, 256);  //Random blue value (0-255)
            }
            else
            {
                //Default to black if random is false
                this.red = 0;
                this.green = 0;
                this.blue = 0;
            }
        }
    }
}
