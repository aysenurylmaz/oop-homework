//****************************************************************************************
//**********       STUDENT NAME : AYŞENUR YILMAZ  ****************************************
//**********     STUDENT NUMBER : B231202019      ****************************************
//****************************************************************************************

namespace b231202019
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCenter = new Label();
            labelLength = new Label();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            labelEdge = new Label();
            labelAngle = new Label();
            txtCenterX = new TextBox();
            txtCenterY = new TextBox();
            txtLength = new TextBox();
            txtEdges = new TextBox();
            txtAngle = new TextBox();
            btnDraw = new Button();
            btnRotate = new Button();
            btnReset = new Button();
            lstCoordinates = new ListBox();
            pictureBox1 = new PictureBox();
            trackRed = new TrackBar();
            trackGreen = new TrackBar();
            trackBlue = new TrackBar();
            chkCCW = new CheckBox();
            labelEdgCrd = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).BeginInit();
            SuspendLayout();
            // 
            // labelCenter
            // 
            labelCenter.AutoSize = true;
            labelCenter.Location = new Point(514, 58);
            labelCenter.Name = "labelCenter";
            labelCenter.Size = new Size(67, 15);
            labelCenter.TabIndex = 0;
            labelCenter.Text = "Center (x,y)";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(514, 94);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(44, 15);
            labelLength.TabIndex = 1;
            labelLength.Text = "Length";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(520, 130);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(27, 15);
            lblRed.TabIndex = 2;
            lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(514, 170);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(38, 15);
            lblGreen.TabIndex = 3;
            lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(522, 212);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(30, 15);
            lblBlue.TabIndex = 4;
            lblBlue.Text = "Blue";
            // 
            // labelEdge
            // 
            labelEdge.AutoSize = true;
            labelEdge.Location = new Point(514, 287);
            labelEdge.Name = "labelEdge";
            labelEdge.Size = new Size(33, 15);
            labelEdge.TabIndex = 5;
            labelEdge.Text = "Edge";
            // 
            // labelAngle
            // 
            labelAngle.AutoSize = true;
            labelAngle.Location = new Point(514, 334);
            labelAngle.Name = "labelAngle";
            labelAngle.Size = new Size(38, 15);
            labelAngle.TabIndex = 6;
            labelAngle.Text = "Angle";
            // 
            // txtCenterX
            // 
            txtCenterX.Location = new Point(594, 50);
            txtCenterX.Name = "txtCenterX";
            txtCenterX.Size = new Size(38, 23);
            txtCenterX.TabIndex = 7;
            txtCenterX.Text = "0";
            txtCenterX.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCenterY
            // 
            txtCenterY.Location = new Point(644, 50);
            txtCenterY.Name = "txtCenterY";
            txtCenterY.Size = new Size(38, 23);
            txtCenterY.TabIndex = 8;
            txtCenterY.Text = "0";
            txtCenterY.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(594, 86);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 9;
            txtLength.Text = "4";
            txtLength.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEdges
            // 
            txtEdges.Location = new Point(553, 287);
            txtEdges.Name = "txtEdges";
            txtEdges.Size = new Size(54, 23);
            txtEdges.TabIndex = 10;
            txtEdges.Text = "5";
            txtEdges.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAngle
            // 
            txtAngle.Location = new Point(578, 326);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(89, 23);
            txtAngle.TabIndex = 11;
            txtAngle.Text = "30";
            txtAngle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(566, 484);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 13;
            btnDraw.Text = "DRAW";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(566, 523);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(75, 23);
            btnRotate.TabIndex = 14;
            btnRotate.Text = "ROTATE";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(566, 564);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 15;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lstCoordinates
            // 
            lstCoordinates.AccessibleName = "";
            lstCoordinates.FormattingEnabled = true;
            lstCoordinates.ItemHeight = 15;
            lstCoordinates.Location = new Point(547, 384);
            lstCoordinates.Name = "lstCoordinates";
            lstCoordinates.Size = new Size(120, 94);
            lstCoordinates.TabIndex = 16;
            lstCoordinates.Tag = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(23, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 500);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // trackRed
            // 
            trackRed.Location = new Point(578, 130);
            trackRed.Maximum = 255;
            trackRed.Name = "trackRed";
            trackRed.Size = new Size(104, 45);
            trackRed.TabIndex = 18;
            trackRed.ValueChanged += trackBar_ValueChanged;
            // 
            // trackGreen
            // 
            trackGreen.Location = new Point(578, 170);
            trackGreen.Maximum = 255;
            trackGreen.Name = "trackGreen";
            trackGreen.Size = new Size(104, 45);
            trackGreen.TabIndex = 19;
            trackGreen.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBlue
            // 
            trackBlue.Location = new Point(578, 212);
            trackBlue.Maximum = 255;
            trackBlue.Name = "trackBlue";
            trackBlue.Size = new Size(104, 45);
            trackBlue.TabIndex = 20;
            trackBlue.ValueChanged += trackBar_ValueChanged;
            // 
            // chkCCW
            // 
            chkCCW.AutoSize = true;
            chkCCW.Location = new Point(626, 289);
            chkCCW.Name = "chkCCW";
            chkCCW.Size = new Size(53, 19);
            chkCCW.TabIndex = 21;
            chkCCW.Text = "CCW";
            chkCCW.UseVisualStyleBackColor = true;
            // 
            // labelEdgCrd
            // 
            labelEdgCrd.AutoSize = true;
            labelEdgCrd.Location = new Point(553, 366);
            labelEdgCrd.Name = "labelEdgCrd";
            labelEdgCrd.Size = new Size(100, 15);
            labelEdgCrd.TabIndex = 22;
            labelEdgCrd.Text = "Edge Coordinates";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 609);
            Controls.Add(labelEdgCrd);
            Controls.Add(chkCCW);
            Controls.Add(trackBlue);
            Controls.Add(trackGreen);
            Controls.Add(trackRed);
            Controls.Add(pictureBox1);
            Controls.Add(lstCoordinates);
            Controls.Add(btnReset);
            Controls.Add(btnRotate);
            Controls.Add(btnDraw);
            Controls.Add(txtAngle);
            Controls.Add(txtEdges);
            Controls.Add(txtLength);
            Controls.Add(txtCenterY);
            Controls.Add(txtCenterX);
            Controls.Add(labelAngle);
            Controls.Add(labelEdge);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(labelLength);
            Controls.Add(labelCenter);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCenter;
        private Label labelLength;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Label labelEdge;
        private Label labelAngle;
        private TextBox txtCenterX;
        private TextBox txtCenterY;
        private TextBox txtLength;
        private TextBox txtEdges;
        private TextBox txtAngle;
        private Button btnDraw;
        private Button btnRotate;
        private Button btnReset;
        private ListBox lstCoordinates;
        private PictureBox pictureBox1;
        private TrackBar trackRed;
        private TrackBar trackGreen;
        private TrackBar trackBlue;
        private CheckBox chkCCW;
        private Label labelEdgCrd;
    }
}

