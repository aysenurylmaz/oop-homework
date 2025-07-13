//****************************************************************************************
//**********       STUDENT NAME : AYÞENUR YILMAZ  ****************************************
//**********     STUDENT NUMBER : B231202019      ****************************************
//****************************************************************************************

using System.Globalization;

namespace b231202019
{
    public partial class Form1 : Form
    {
        //This code creates a polygon object that we can move and show on the screen.
        private Polygon polygon;
        //Static random number generator for creating random values.
        private static readonly Random rnd = new Random();

        //Form constructor. Runs when the form is first created.
        public Form1()
        {
            //Initialize all the form controls
            InitializeComponent();

            pictureBox1.Paint += PictureBox1_Paint;  //The PictureBox1_Paint method runs every time pictureBox1 is redrawn

            //Sets all values to their defaults.
            SetDefaultValues();
        }

        //Set all input fields to their default starting values
        private void SetDefaultValues()
        {
            //Sets default values for all input fields
            txtCenterX.Text = "0";          //X coordinate of polygon center, starting at origin (0)
            txtCenterY.Text = "0";          //Y coordinate of polygon center, starting at origin (0)
            txtLength.Text = "4";           //Length of the polygon, how far vertices are from center
            txtEdges.Text = "5";            //Number of edges (5 = pentagon)
            txtAngle.Text = "30";           //Rotation angle in degrees
            trackRed.Value = 0;             //Red color value (0-255), starts at 0
            trackGreen.Value = 0;           //Green color value (0-255), starts at 0
            trackBlue.Value = 0;            //Blue color value (0-255), starts at 0
            chkCCW.Checked = false;         //Direction of rotation, false = clockwise, true = counter-clockwise
        }

        //This method runs whenever any color trackbar is moved
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            //Null check: verifies the polygon object is valid.
            if (polygon != null)
            {
                //Updates the polygon's color with current red, green, blue values from trackbars
                polygon.Color = new ColorRGB(trackRed.Value, trackGreen.Value, trackBlue.Value);

                //If the polygon has vertices, redraw it with the new color
                if (polygon.Vertices != null && polygon.Vertices.Length > 0)
                {
                    DrawPolygon();
                }
            }
        }

        //Validates that the input is a valid integer value
        private bool ValidateIntInput(TextBox textBox, string fieldName, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            //Checks if input can be parsed as integer
            if (!int.TryParse(textBox.Text, out int value))
            {
                //Shows simple error message
                MessageBox.Show("Enter a valid integer for " + fieldName, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            //Checks if value is within allowed range
            if (value < minValue || value > maxValue)
            {
                //Shows simple error message
                MessageBox.Show(fieldName + " must be between " + minValue + " and " + maxValue, "Invalid Value Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            return true;
        }

        //Validates that the input is a valid double value
        private bool ValidateDoubleInput(TextBox textBox, string fieldName, double minValue = double.MinValue, double maxValue = double.MaxValue)
        {
            //Checks if input can be parsed as double
            if (!double.TryParse(textBox.Text, out double value))
            {
                //Shows simple error message 
                MessageBox.Show("Enter a valid number for " + fieldName, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();  // Direct user attention to invalid field
                return false;
            }

            //Checks if value is within allowed range
            if (value < minValue || value > maxValue)
            {
                //Shows simple error message
                MessageBox.Show(fieldName + " must be between " + minValue + " and " + maxValue, "Invalid Value Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus(); //Directs user attention to invalid field
                return false;
            }

            return true;
        }

        //Creates a new polygon using current input values
        private void CreateNewPolygon()
        {
            try
            {
                //Validates all inputs, returns if any fail (shows error automatically)

                if (!ValidateDoubleInput(txtCenterX, "Center X", 0, 3) ||
                    !ValidateDoubleInput(txtCenterY, "Center Y", 0, 3) ||
                    !ValidateDoubleInput(txtLength, "Length", 3, 9) ||
                    !ValidateIntInput(txtEdges, "Edges", 3, 10) ||
                    !ValidateIntInput(txtAngle, "Angle", -360, 360))
                {

                    return;
                }

                //Creates a new polygon with center and length from input fields
                int centerX = int.Parse(txtCenterX.Text);
                int centerY = int.Parse(txtCenterY.Text);
                int length = int.Parse(txtLength.Text);
                int edges = int.Parse(txtEdges.Text);


                Point2D center = new Point2D(centerX, centerY);

                polygon = new Polygon(center, length)
                {
                    //Sets additional properties using object initializer
                    NumberOfEdges = edges,
                    Color = new ColorRGB(trackRed.Value, trackGreen.Value, trackBlue.Value)
                };

                //Calculates the vertex coordinates
                polygon.calculateEdgeCoordinates();

                //Draws the polygon on the picture box
                DrawPolygon();

                //Updates the coordinates list display
                UpdateCoordinatesList();
            }
            catch (Exception ex)
            {
                //Show simple error message
                MessageBox.Show("Error creating polygon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Updates the listbox with the current coordinates of all vertices
        private void UpdateCoordinatesList()
        {
            try
            {
                //Removes all items from the list
                lstCoordinates.Items.Clear();

                //returns if polygon or its vertices are not initialized
                if (polygon == null || polygon.Vertices == null) return;

                //Adds center point coordinates to the list
                //Format the coordinates with one decimal place (F1)
                lstCoordinates.Items.Add("Center = (" + polygon.Center.X.ToString("F1") + ", " + polygon.Center.Y.ToString("F1") + ")");

                //adds each vertex point to the list
                for (int i = 0; i < polygon.Vertices.Length; i++)
                {
                    //adds vertex with index (starting from 1) and coordinates with one decimal place
                    lstCoordinates.Items.Add("V" + (i + 1) + " = (" + polygon.Vertices[i].X.ToString("F1") + ", " + polygon.Vertices[i].Y.ToString("F1") + ")");
                }
            }
            catch (Exception ex)
            {
                //Shows simple error message
                MessageBox.Show("Error updating coordinates list: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Runs when the DRAW button is clicked
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                //Tries to call the CreateNewPolygon() method.
                CreateNewPolygon();
            }
            catch (Exception ex)
            {
                //Shows simple error message
                MessageBox.Show("Error drawing polygon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Runs when the ROTATE button is clicked
        private void btnRotate_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the polygon object is null (has not been initialized).
                if (polygon == null)
                {
                    //Shows simple error message
                    MessageBox.Show("Please draw a polygon first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Gets rotation angle
                double angle = double.Parse(txtAngle.Text);

                //Gets rotation direction from checkbox
                bool isCounterClockwise = chkCCW.Checked;

                //Rotates the polygon by the specified angle and direction.
                polygon.rotatePolygon(angle, isCounterClockwise);

                //Redraws the polygon with the new rotated position.
                DrawPolygon();

                //updates the coordinates list with the new vertex positions.
                UpdateCoordinatesList();
            }
            catch (Exception ex)
            {
                //Shows simple error message
                MessageBox.Show("Error rotating polygon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Runs when the RESET button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                //Generates random values for all input fields
                txtCenterX.Text = rnd.Next(0, 4).ToString();     //random X between 0-3
                txtCenterY.Text = rnd.Next(0, 4).ToString();     //random Y between 0-3
                txtLength.Text = rnd.Next(3, 10).ToString();     //random length between 3-9
                txtEdges.Text = rnd.Next(3, 11).ToString();      //random edges between 3-10
                trackRed.Value = rnd.Next(0, 256);               //random red value 0-255
                trackGreen.Value = rnd.Next(0, 256);             //random green value 0-255
                trackBlue.Value = rnd.Next(0, 256);              //random blue value 0-255

                //Creates a new polygon with these random values
                CreateNewPolygon();
            }
            catch (Exception ex)
            {
                //Shows simple error message 
                MessageBox.Show("Error resetting values: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Draws the polygon on the picture box
        private void DrawPolygon()
        {
            try
            {
                //If polygon or vertices don't exist, exit the method
                if (polygon == null || polygon.Vertices == null || polygon.Vertices.Length == 0)
                {
                    //Nothing to draw
                    return;
                }

                //Marks the control as invalid and triggers a repaint
                pictureBox1.Invalidate();
            }

            catch (Exception ex)
            {
                //Shows simple error message
                MessageBox.Show("Error drawing polygon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {//Check if the polygon or its vertices are missing or empty
                if (polygon == null || polygon.Vertices == null || polygon.Vertices.Length == 0)
                {
                    //Nothing to draw
                    return;
                }
                //Gets the graphics object from the event arguments for drawing operations
                Graphics g = e.Graphics;

                //Makes lines smoother by enabling anti-aliasing
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                //Calculates center of picture box for coordinate transformation
                int originX = pictureBox1.Width / 2;   //Center X of picture box
                int originY = pictureBox1.Height / 2;  //Center Y of picture box

                //Creates a PointF array to store the screen positions of the polygon's corners
                PointF[] points = new PointF[polygon.Vertices.Length];

                for (int i = 0; i < polygon.Vertices.Length; i++)
                {
                    //Checks if the vertex is null
                    if (polygon.Vertices[i] == null)
                    {
                        //If it's null, throws an error to stop the program
                        throw new InvalidOperationException("Vertex " + i + " is null");
                    }

                    //Converts X coordinate to screen space
                    //Multiply by 18 to make it bigger and move it based on the origin
                    float screenX = originX + (float)(polygon.Vertices[i].X * 18);

                    //Converts Y coordinate to screen space
                    //Subtract because Y grows down on screen
                    float screenY = originY - (float)(polygon.Vertices[i].Y * 18);

                    //Saves the screen point into the array
                    points[i] = new PointF(screenX, screenY);
                }

                //Creates a pen with the polygon's color and 2 pixel width
                using (Pen pen = new Pen(Color.FromArgb(
                  polygon.Color.Red,    //Red component
                  polygon.Color.Green,  //Green component
                  polygon.Color.Blue),  //Blue component
                  2))                   //2 pixel width
                {
                    //Draws the polygon outline
                    g.DrawPolygon(pen, points);
                }


                g.FillEllipse(Brushes.Black,  //Draws a small filled black circle at the center of the polygon.

                 originX + (float)(polygon.Center.X * 18) - 3, //Multiply by 18 to scale the center position to screen size.
                 originY - (float)(polygon.Center.Y * 18) - 3, //originX and originY shift the point to the correct screen position.
                                                               //Subtract 3 so the circle is centered (because drawing starts from top-left).

                 4, 4); //The width and height of the circle are 5 pixels
            }
            catch (Exception ex)
            {
                //Shows simple error message
                MessageBox.Show("Error drawing polygon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


