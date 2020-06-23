using System.Windows.Forms;

namespace DNOLights.Desktop
{
    partial class RoadieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BL_Pan = new System.Windows.Forms.TextBox();
            this.BL_Tilt = new System.Windows.Forms.TextBox();
            this.panleft = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPanRight = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BL_Fade = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BL_Red_Dwn = new System.Windows.Forms.Button();
            this.BL_Red = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.BL_Green = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BL_Blue = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.FL_Blue = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.FL_Green = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.FL_Red = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.FL_Fade = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.FL_Tilt = new System.Windows.Forms.TextBox();
            this.FL_Pan = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.FR_Blue = new System.Windows.Forms.TextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.FR_Green = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.FR_Red = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.FR_Fade = new System.Windows.Forms.TextBox();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.FR_Tilt = new System.Windows.Forms.TextBox();
            this.FR_Pan = new System.Windows.Forms.TextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.BR_Blue = new System.Windows.Forms.TextBox();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.BR_Green = new System.Windows.Forms.TextBox();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.BR_Red = new System.Windows.Forms.TextBox();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.BR_Fade = new System.Windows.Forms.TextBox();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.BR_Tilt = new System.Windows.Forms.TextBox();
            this.BR_Pan = new System.Windows.Forms.TextBox();
            this.DMXStatusLabel = new System.Windows.Forms.TextBox();
            this.connectionstatus = new System.Windows.Forms.Label();
            this.firstpositions = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.BL_White = new System.Windows.Forms.TextBox();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.FL_White = new System.Windows.Forms.TextBox();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.FR_White = new System.Windows.Forms.TextBox();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.BR_White = new System.Windows.Forms.TextBox();
            this.button56 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Front Left";
            // 
            // BL_Pan
            // 
            this.BL_Pan.Location = new System.Drawing.Point(125, 62);
            this.BL_Pan.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Pan.Name = "BL_Pan";
            this.BL_Pan.Size = new System.Drawing.Size(65, 22);
            this.BL_Pan.TabIndex = 1;
            this.BL_Pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BL_Pan.TextChanged += new System.EventHandler(this.BL_Pan_TextChanged);
            // 
            // BL_Tilt
            // 
            this.BL_Tilt.Location = new System.Drawing.Point(125, 91);
            this.BL_Tilt.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Tilt.Name = "BL_Tilt";
            this.BL_Tilt.Size = new System.Drawing.Size(65, 22);
            this.BL_Tilt.TabIndex = 2;
            this.BL_Tilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panleft
            // 
            this.panleft.Location = new System.Drawing.Point(27, 60);
            this.panleft.Margin = new System.Windows.Forms.Padding(4);
            this.panleft.Name = "panleft";
            this.panleft.Size = new System.Drawing.Size(83, 25);
            this.panleft.TabIndex = 4;
            this.panleft.Text = "Pan Left";
            this.panleft.UseVisualStyleBackColor = true;
            this.panleft.Click += new System.EventHandler(this.panleft_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Back Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Back Right";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Front Right";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPanRight
            // 
            this.btnPanRight.Location = new System.Drawing.Point(212, 62);
            this.btnPanRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanRight.Name = "btnPanRight";
            this.btnPanRight.Size = new System.Drawing.Size(83, 25);
            this.btnPanRight.TabIndex = 29;
            this.btnPanRight.Text = "Pan Right";
            this.btnPanRight.UseVisualStyleBackColor = true;
            this.btnPanRight.Click += new System.EventHandler(this.panright_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 25);
            this.button2.TabIndex = 30;
            this.button2.Text = "Tilt fwd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(212, 94);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 25);
            this.button14.TabIndex = 31;
            this.button14.Text = "Tilt Bck";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BL_Tilt_Up_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 126);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 25);
            this.button3.TabIndex = 34;
            this.button3.Text = "All Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BL_Fade_Up_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 124);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 25);
            this.button5.TabIndex = 33;
            this.button5.Text = "All Dwn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BL_Fade_Dwn_Click);
            // 
            // BL_Fade
            // 
            this.BL_Fade.Location = new System.Drawing.Point(125, 123);
            this.BL_Fade.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Fade.Name = "BL_Fade";
            this.BL_Fade.Size = new System.Drawing.Size(65, 22);
            this.BL_Fade.TabIndex = 32;
            this.BL_Fade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 25);
            this.button4.TabIndex = 37;
            this.button4.Text = "R Up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BL_Red_Up_Click);
            // 
            // BL_Red_Dwn
            // 
            this.BL_Red_Dwn.Location = new System.Drawing.Point(27, 156);
            this.BL_Red_Dwn.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Red_Dwn.Name = "BL_Red_Dwn";
            this.BL_Red_Dwn.Size = new System.Drawing.Size(83, 25);
            this.BL_Red_Dwn.TabIndex = 36;
            this.BL_Red_Dwn.Text = "R Dwn";
            this.BL_Red_Dwn.UseVisualStyleBackColor = true;
            this.BL_Red_Dwn.Click += new System.EventHandler(this.BL_Red_Dwn_Click);
            // 
            // BL_Red
            // 
            this.BL_Red.Location = new System.Drawing.Point(125, 155);
            this.BL_Red.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Red.Name = "BL_Red";
            this.BL_Red.Size = new System.Drawing.Size(65, 22);
            this.BL_Red.TabIndex = 35;
            this.BL_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(212, 190);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 25);
            this.button7.TabIndex = 40;
            this.button7.Text = "G Up";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(27, 188);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 25);
            this.button8.TabIndex = 39;
            this.button8.Text = "G Dwn";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BL_G_Dwn_Click);
            // 
            // BL_Green
            // 
            this.BL_Green.Location = new System.Drawing.Point(125, 187);
            this.BL_Green.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Green.Name = "BL_Green";
            this.BL_Green.Size = new System.Drawing.Size(65, 22);
            this.BL_Green.TabIndex = 38;
            this.BL_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(212, 222);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 25);
            this.button9.TabIndex = 43;
            this.button9.Text = "B Up";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(27, 220);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 25);
            this.button10.TabIndex = 42;
            this.button10.Text = "B Dwn";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BL_Blue
            // 
            this.BL_Blue.Location = new System.Drawing.Point(125, 219);
            this.BL_Blue.Margin = new System.Windows.Forms.Padding(4);
            this.BL_Blue.Name = "BL_Blue";
            this.BL_Blue.Size = new System.Drawing.Size(65, 22);
            this.BL_Blue.TabIndex = 41;
            this.BL_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BL_Blue.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(212, 512);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(83, 25);
            this.button11.TabIndex = 61;
            this.button11.Text = "B Up";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.FL_Blue_Up_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(27, 511);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 25);
            this.button12.TabIndex = 60;
            this.button12.Text = "B Dwn";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.FL_Blue_Dwn_Click);
            // 
            // FL_Blue
            // 
            this.FL_Blue.Location = new System.Drawing.Point(125, 510);
            this.FL_Blue.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Blue.Name = "FL_Blue";
            this.FL_Blue.Size = new System.Drawing.Size(65, 22);
            this.FL_Blue.TabIndex = 59;
            this.FL_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(212, 480);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 25);
            this.button13.TabIndex = 58;
            this.button13.Text = "G Up";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.FL_Green_Dwn_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(27, 479);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 25);
            this.button15.TabIndex = 57;
            this.button15.Text = "G Dwn";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.FL_Green_Up_Click);
            // 
            // FL_Green
            // 
            this.FL_Green.Location = new System.Drawing.Point(125, 478);
            this.FL_Green.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Green.Name = "FL_Green";
            this.FL_Green.Size = new System.Drawing.Size(65, 22);
            this.FL_Green.TabIndex = 56;
            this.FL_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(212, 448);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 25);
            this.button16.TabIndex = 55;
            this.button16.Text = "R Up";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.FL_Red_Up_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(27, 447);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 25);
            this.button17.TabIndex = 54;
            this.button17.Text = "R Dwn";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.FL_Red_Dwn_Click);
            // 
            // FL_Red
            // 
            this.FL_Red.Location = new System.Drawing.Point(125, 446);
            this.FL_Red.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Red.Name = "FL_Red";
            this.FL_Red.Size = new System.Drawing.Size(65, 22);
            this.FL_Red.TabIndex = 53;
            this.FL_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(212, 416);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(83, 25);
            this.button18.TabIndex = 52;
            this.button18.Text = "All Up";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.FL_Fade_Up_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(27, 415);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(83, 25);
            this.button19.TabIndex = 51;
            this.button19.Text = "All Dwn";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.FL_Fade_Dwn_Click);
            // 
            // FL_Fade
            // 
            this.FL_Fade.Location = new System.Drawing.Point(125, 414);
            this.FL_Fade.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Fade.Name = "FL_Fade";
            this.FL_Fade.Size = new System.Drawing.Size(65, 22);
            this.FL_Fade.TabIndex = 50;
            this.FL_Fade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(212, 384);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(83, 25);
            this.button20.TabIndex = 49;
            this.button20.Text = "Tilt Bck";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.FL_Tilt_Bck_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(27, 383);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(83, 25);
            this.button21.TabIndex = 48;
            this.button21.Text = "Tilt fwd";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.FL_Tilt_Fwd_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(212, 352);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(83, 25);
            this.button22.TabIndex = 47;
            this.button22.Text = "Pan Right";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.FL_Pan_Right_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(27, 351);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(83, 25);
            this.button23.TabIndex = 46;
            this.button23.Text = "Pan Left";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.FL_Pan_Left_Click);
            // 
            // FL_Tilt
            // 
            this.FL_Tilt.Location = new System.Drawing.Point(125, 382);
            this.FL_Tilt.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Tilt.Name = "FL_Tilt";
            this.FL_Tilt.Size = new System.Drawing.Size(65, 22);
            this.FL_Tilt.TabIndex = 45;
            this.FL_Tilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FL_Pan
            // 
            this.FL_Pan.Location = new System.Drawing.Point(125, 352);
            this.FL_Pan.Margin = new System.Windows.Forms.Padding(4);
            this.FL_Pan.Name = "FL_Pan";
            this.FL_Pan.Size = new System.Drawing.Size(65, 22);
            this.FL_Pan.TabIndex = 44;
            this.FL_Pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(719, 519);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(83, 25);
            this.button24.TabIndex = 98;
            this.button24.Text = "B Up";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.FR_Blue_Up_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(533, 518);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(83, 25);
            this.button25.TabIndex = 97;
            this.button25.Text = "B Dwn";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.FR_Blue_Dwn_Click);
            // 
            // FR_Blue
            // 
            this.FR_Blue.Location = new System.Drawing.Point(632, 517);
            this.FR_Blue.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Blue.Name = "FR_Blue";
            this.FR_Blue.Size = new System.Drawing.Size(65, 22);
            this.FR_Blue.TabIndex = 96;
            this.FR_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Blue.TextChanged += new System.EventHandler(this.FR_Blue_TextChanged);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(719, 487);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(83, 25);
            this.button26.TabIndex = 95;
            this.button26.Text = "G Up";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.FR_Green_Up_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(533, 486);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(83, 25);
            this.button27.TabIndex = 94;
            this.button27.Text = "G Dwn";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.FR_Green_Dwn_Click);
            // 
            // FR_Green
            // 
            this.FR_Green.Location = new System.Drawing.Point(632, 485);
            this.FR_Green.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Green.Name = "FR_Green";
            this.FR_Green.Size = new System.Drawing.Size(65, 22);
            this.FR_Green.TabIndex = 93;
            this.FR_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Green.TextChanged += new System.EventHandler(this.FR_Green_TextChanged);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(719, 455);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(83, 25);
            this.button28.TabIndex = 92;
            this.button28.Text = "R Up";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.FR_Red_Up_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(533, 454);
            this.button29.Margin = new System.Windows.Forms.Padding(4);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(83, 25);
            this.button29.TabIndex = 91;
            this.button29.Text = "R Dwn";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.FR_Red_Dwn_Click);
            // 
            // FR_Red
            // 
            this.FR_Red.Location = new System.Drawing.Point(632, 453);
            this.FR_Red.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Red.Name = "FR_Red";
            this.FR_Red.Size = new System.Drawing.Size(65, 22);
            this.FR_Red.TabIndex = 90;
            this.FR_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Red.TextChanged += new System.EventHandler(this.FR_Red_TextChanged);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(336, 499);
            this.button30.Margin = new System.Windows.Forms.Padding(4);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(83, 69);
            this.button30.TabIndex = 89;
            this.button30.Text = "All Up";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(533, 422);
            this.button31.Margin = new System.Windows.Forms.Padding(4);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(83, 25);
            this.button31.TabIndex = 88;
            this.button31.Text = "All Dwn";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.FR_Fade_Dwn_Click);
            // 
            // FR_Fade
            // 
            this.FR_Fade.Location = new System.Drawing.Point(632, 421);
            this.FR_Fade.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Fade.Name = "FR_Fade";
            this.FR_Fade.Size = new System.Drawing.Size(65, 22);
            this.FR_Fade.TabIndex = 87;
            this.FR_Fade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Fade.TextChanged += new System.EventHandler(this.FR_Fade_TextChanged);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(719, 391);
            this.button32.Margin = new System.Windows.Forms.Padding(4);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(83, 25);
            this.button32.TabIndex = 86;
            this.button32.Text = "Tilt Bck";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.FR_Tilt_Bck_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(533, 390);
            this.button33.Margin = new System.Windows.Forms.Padding(4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(83, 25);
            this.button33.TabIndex = 85;
            this.button33.Text = "Tilt fwd";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.FR_Tilt_Fwd_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(719, 359);
            this.button34.Margin = new System.Windows.Forms.Padding(4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(83, 25);
            this.button34.TabIndex = 84;
            this.button34.Text = "Pan Right";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.FR_Pan_Right_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(533, 358);
            this.button35.Margin = new System.Windows.Forms.Padding(4);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(83, 25);
            this.button35.TabIndex = 83;
            this.button35.Text = "Pan Left";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.FR_Pan_Left_Click);
            // 
            // FR_Tilt
            // 
            this.FR_Tilt.Location = new System.Drawing.Point(632, 389);
            this.FR_Tilt.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Tilt.Name = "FR_Tilt";
            this.FR_Tilt.Size = new System.Drawing.Size(65, 22);
            this.FR_Tilt.TabIndex = 82;
            this.FR_Tilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Tilt.TextChanged += new System.EventHandler(this.FR_Tilt_TextChanged);
            // 
            // FR_Pan
            // 
            this.FR_Pan.Location = new System.Drawing.Point(632, 359);
            this.FR_Pan.Margin = new System.Windows.Forms.Padding(4);
            this.FR_Pan.Name = "FR_Pan";
            this.FR_Pan.Size = new System.Drawing.Size(65, 22);
            this.FR_Pan.TabIndex = 81;
            this.FR_Pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_Pan.TextChanged += new System.EventHandler(this.FR_Pan_TextChanged);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(719, 222);
            this.button36.Margin = new System.Windows.Forms.Padding(4);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(83, 25);
            this.button36.TabIndex = 80;
            this.button36.Text = "B Up";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.BR_Blue_Up_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(533, 220);
            this.button37.Margin = new System.Windows.Forms.Padding(4);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(83, 25);
            this.button37.TabIndex = 79;
            this.button37.Text = "B Dwn";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.BR_Blue_Dwn_Click);
            // 
            // BR_Blue
            // 
            this.BR_Blue.Location = new System.Drawing.Point(632, 219);
            this.BR_Blue.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Blue.Name = "BR_Blue";
            this.BR_Blue.Size = new System.Drawing.Size(65, 22);
            this.BR_Blue.TabIndex = 78;
            this.BR_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Blue.TextChanged += new System.EventHandler(this.BR_Blue_TextChanged);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(719, 190);
            this.button38.Margin = new System.Windows.Forms.Padding(4);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(83, 25);
            this.button38.TabIndex = 77;
            this.button38.Text = "G Up";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.BR_Green_Up_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(533, 188);
            this.button39.Margin = new System.Windows.Forms.Padding(4);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(83, 25);
            this.button39.TabIndex = 76;
            this.button39.Text = "G Dwn";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.BR_Green_Dwn_Click);
            // 
            // BR_Green
            // 
            this.BR_Green.Location = new System.Drawing.Point(632, 187);
            this.BR_Green.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Green.Name = "BR_Green";
            this.BR_Green.Size = new System.Drawing.Size(65, 22);
            this.BR_Green.TabIndex = 75;
            this.BR_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Green.TextChanged += new System.EventHandler(this.BR_Green_TextChanged);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(719, 158);
            this.button40.Margin = new System.Windows.Forms.Padding(4);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(83, 25);
            this.button40.TabIndex = 74;
            this.button40.Text = "R Up";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.BR_Red_Up_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(533, 156);
            this.button41.Margin = new System.Windows.Forms.Padding(4);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(83, 25);
            this.button41.TabIndex = 73;
            this.button41.Text = "R Dwn";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.BR_Red_Dwn_Click);
            // 
            // BR_Red
            // 
            this.BR_Red.Location = new System.Drawing.Point(632, 155);
            this.BR_Red.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Red.Name = "BR_Red";
            this.BR_Red.Size = new System.Drawing.Size(65, 22);
            this.BR_Red.TabIndex = 72;
            this.BR_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Red.TextChanged += new System.EventHandler(this.BR_Red_TextChanged);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(719, 126);
            this.button42.Margin = new System.Windows.Forms.Padding(4);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(83, 25);
            this.button42.TabIndex = 71;
            this.button42.Text = "All Up";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.BR_Fade_Up_Click);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(533, 124);
            this.button43.Margin = new System.Windows.Forms.Padding(4);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(83, 25);
            this.button43.TabIndex = 70;
            this.button43.Text = "All Dwn";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.BR_Fade_Dwn_Click);
            // 
            // BR_Fade
            // 
            this.BR_Fade.Location = new System.Drawing.Point(632, 123);
            this.BR_Fade.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Fade.Name = "BR_Fade";
            this.BR_Fade.Size = new System.Drawing.Size(65, 22);
            this.BR_Fade.TabIndex = 69;
            this.BR_Fade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Fade.TextChanged += new System.EventHandler(this.BR_Fade_TextChanged);
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(719, 94);
            this.button44.Margin = new System.Windows.Forms.Padding(4);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(83, 25);
            this.button44.TabIndex = 68;
            this.button44.Text = "Tilt Bck";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.BR_Tilt_Bck_Click);
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(533, 92);
            this.button45.Margin = new System.Windows.Forms.Padding(4);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(83, 25);
            this.button45.TabIndex = 67;
            this.button45.Text = "Tilt fwd";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.BR_Tilt_Fwd_Click);
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(719, 62);
            this.button46.Margin = new System.Windows.Forms.Padding(4);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(83, 25);
            this.button46.TabIndex = 66;
            this.button46.Text = "Pan Right";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.BR_Pan_Right_Click);
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(533, 60);
            this.button47.Margin = new System.Windows.Forms.Padding(4);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(83, 25);
            this.button47.TabIndex = 65;
            this.button47.Text = "Pan Left";
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.BR_Pan_Left_Click);
            // 
            // BR_Tilt
            // 
            this.BR_Tilt.Location = new System.Drawing.Point(632, 91);
            this.BR_Tilt.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Tilt.Name = "BR_Tilt";
            this.BR_Tilt.Size = new System.Drawing.Size(65, 22);
            this.BR_Tilt.TabIndex = 64;
            this.BR_Tilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Tilt.TextChanged += new System.EventHandler(this.BR_Tilt_TextChanged);
            // 
            // BR_Pan
            // 
            this.BR_Pan.Location = new System.Drawing.Point(632, 62);
            this.BR_Pan.Margin = new System.Windows.Forms.Padding(4);
            this.BR_Pan.Name = "BR_Pan";
            this.BR_Pan.Size = new System.Drawing.Size(65, 22);
            this.BR_Pan.TabIndex = 63;
            this.BR_Pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_Pan.TextChanged += new System.EventHandler(this.BR_Pan_TextChanged);
            // 
            // DMXStatusLabel
            // 
            this.DMXStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMXStatusLabel.Location = new System.Drawing.Point(282, 649);
            this.DMXStatusLabel.Margin = new System.Windows.Forms.Padding(4);
            this.DMXStatusLabel.Name = "DMXStatusLabel";
            this.DMXStatusLabel.Size = new System.Drawing.Size(291, 30);
            this.DMXStatusLabel.TabIndex = 99;
            this.DMXStatusLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectionstatus
            // 
            this.connectionstatus.AutoSize = true;
            this.connectionstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionstatus.Location = new System.Drawing.Point(340, 608);
            this.connectionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionstatus.Name = "connectionstatus";
            this.connectionstatus.Padding = new System.Windows.Forms.Padding(1);
            this.connectionstatus.Size = new System.Drawing.Size(175, 27);
            this.connectionstatus.TabIndex = 100;
            this.connectionstatus.Text = "Connection Status";
            // 
            // firstpositions
            // 
            this.firstpositions.Location = new System.Drawing.Point(319, 94);
            this.firstpositions.Margin = new System.Windows.Forms.Padding(4);
            this.firstpositions.Name = "firstpositions";
            this.firstpositions.Size = new System.Drawing.Size(100, 28);
            this.firstpositions.TabIndex = 101;
            this.firstpositions.Text = "First Position";
            this.firstpositions.UseVisualStyleBackColor = true;
            this.firstpositions.Click += new System.EventHandler(this.first_scene_click);
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(212, 254);
            this.button48.Margin = new System.Windows.Forms.Padding(4);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(83, 25);
            this.button48.TabIndex = 104;
            this.button48.Text = "W Up";
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.BL_White_Up_Click);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(27, 252);
            this.button49.Margin = new System.Windows.Forms.Padding(4);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(83, 25);
            this.button49.TabIndex = 103;
            this.button49.Text = "W Dwn";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.BL_White_Dwn_Click);
            // 
            // BL_White
            // 
            this.BL_White.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BL_White.Location = new System.Drawing.Point(125, 251);
            this.BL_White.Margin = new System.Windows.Forms.Padding(4);
            this.BL_White.Name = "BL_White";
            this.BL_White.Size = new System.Drawing.Size(65, 22);
            this.BL_White.TabIndex = 102;
            this.BL_White.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(212, 544);
            this.button50.Margin = new System.Windows.Forms.Padding(4);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(83, 25);
            this.button50.TabIndex = 107;
            this.button50.Text = "W Up";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.FL_White_Up_Click);
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(27, 543);
            this.button51.Margin = new System.Windows.Forms.Padding(4);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(83, 25);
            this.button51.TabIndex = 106;
            this.button51.Text = "W Dwn";
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.FL_White_Dwn_Click);
            // 
            // FL_White
            // 
            this.FL_White.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FL_White.Location = new System.Drawing.Point(125, 542);
            this.FL_White.Margin = new System.Windows.Forms.Padding(4);
            this.FL_White.Name = "FL_White";
            this.FL_White.Size = new System.Drawing.Size(65, 22);
            this.FL_White.TabIndex = 105;
            this.FL_White.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(719, 551);
            this.button52.Margin = new System.Windows.Forms.Padding(4);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(83, 25);
            this.button52.TabIndex = 110;
            this.button52.Text = "W Up";
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.FR_White_Up_Click);
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(533, 550);
            this.button53.Margin = new System.Windows.Forms.Padding(4);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(83, 25);
            this.button53.TabIndex = 109;
            this.button53.Text = "W Dwn";
            this.button53.UseVisualStyleBackColor = true;
            this.button53.Click += new System.EventHandler(this.FR_White_Dwn_Click);
            // 
            // FR_White
            // 
            this.FR_White.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FR_White.Location = new System.Drawing.Point(632, 549);
            this.FR_White.Margin = new System.Windows.Forms.Padding(4);
            this.FR_White.Name = "FR_White";
            this.FR_White.Size = new System.Drawing.Size(65, 22);
            this.FR_White.TabIndex = 108;
            this.FR_White.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FR_White.TextChanged += new System.EventHandler(this.FR_White_TextChanged);
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(719, 257);
            this.button54.Margin = new System.Windows.Forms.Padding(4);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(83, 25);
            this.button54.TabIndex = 113;
            this.button54.Text = "W Up";
            this.button54.UseVisualStyleBackColor = true;
            this.button54.Click += new System.EventHandler(this.BR_White_Up_Click);
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(533, 256);
            this.button55.Margin = new System.Windows.Forms.Padding(4);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(83, 25);
            this.button55.TabIndex = 112;
            this.button55.Text = "W Dwn";
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.BR_White_Dwn_Click);
            // 
            // BR_White
            // 
            this.BR_White.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.BR_White.Location = new System.Drawing.Point(632, 255);
            this.BR_White.Margin = new System.Windows.Forms.Padding(4);
            this.BR_White.Name = "BR_White";
            this.BR_White.Size = new System.Drawing.Size(65, 22);
            this.BR_White.TabIndex = 111;
            this.BR_White.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BR_White.TextChanged += new System.EventHandler(this.BR_White_TextChanged);
            // 
            // button56
            // 
            this.button56.Location = new System.Drawing.Point(319, 155);
            this.button56.Margin = new System.Windows.Forms.Padding(4);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(100, 28);
            this.button56.TabIndex = 114;
            this.button56.Text = "Save Current";
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 115;
            this.button1.Text = "All Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FR_Fade_Up_Click);
            // 
            // RoadieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.button54);
            this.Controls.Add(this.button55);
            this.Controls.Add(this.BR_White);
            this.Controls.Add(this.button52);
            this.Controls.Add(this.button53);
            this.Controls.Add(this.FR_White);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.FL_White);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.BL_White);
            this.Controls.Add(this.firstpositions);
            this.Controls.Add(this.connectionstatus);
            this.Controls.Add(this.DMXStatusLabel);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.FR_Blue);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.FR_Green);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.FR_Red);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.FR_Fade);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.FR_Tilt);
            this.Controls.Add(this.FR_Pan);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.BR_Blue);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.BR_Green);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.BR_Red);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.BR_Fade);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.BR_Tilt);
            this.Controls.Add(this.BR_Pan);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.FL_Blue);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.FL_Green);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.FL_Red);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.FL_Fade);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.FL_Tilt);
            this.Controls.Add(this.FL_Pan);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.BL_Blue);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.BL_Green);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BL_Red_Dwn);
            this.Controls.Add(this.BL_Red);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BL_Fade);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPanRight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panleft);
            this.Controls.Add(this.BL_Tilt);
            this.Controls.Add(this.BL_Pan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoadieForm";
            this.Text = "Roadie\'s Form";
            this.Load += new System.EventHandler(this.Connect_DMX);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BL_Pan;
        private System.Windows.Forms.TextBox BL_Tilt;
        private System.Windows.Forms.Button panleft;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPanRight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox BL_Fade;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BL_Red_Dwn;
        private System.Windows.Forms.TextBox BL_Red;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox BL_Green;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox BL_Blue;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox FL_Blue;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox FL_Green;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox FL_Red;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox FL_Fade;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox FL_Tilt;
        private System.Windows.Forms.TextBox FL_Pan;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox FR_Blue;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox FR_Green;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox FR_Red;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox FR_Fade;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.TextBox FR_Tilt;
        private System.Windows.Forms.TextBox FR_Pan;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.TextBox BR_Blue;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.TextBox BR_Green;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.TextBox BR_Red;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.TextBox BR_Fade;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.TextBox BR_Tilt;
        private System.Windows.Forms.TextBox BR_Pan;
        private TextBox DMXStatusLabel;
        private Label connectionstatus;
        private Button firstpositions;
        private Button button48;
        private Button button49;
        private TextBox BL_White;
        private Button button50;
        private Button button51;
        private TextBox FL_White;
        private Button button52;
        private Button button53;
        private TextBox FR_White;
        private Button button54;
        private Button button55;
        private TextBox BR_White;
        private Button button56;
        private Button button1;
    }
}

