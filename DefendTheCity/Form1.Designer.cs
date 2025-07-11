namespace DefendTheCity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.selectcitycombobox = new System.Windows.Forms.ComboBox();
            this.selectcitylabel = new System.Windows.Forms.Label();
            this.cityattacklabel = new System.Windows.Forms.Label();
            this.cityhealthlabel = new System.Windows.Forms.Label();
            this.cityattackvalue = new System.Windows.Forms.Label();
            this.cityhealthvalue = new System.Windows.Forms.Label();
            this.selectedcitydata = new System.Windows.Forms.GroupBox();
            this.availablepoints = new System.Windows.Forms.Label();
            this.availablepointslabel = new System.Windows.Forms.Label();
            this.cityremaininghealth = new System.Windows.Forms.Label();
            this.cityremaininghealthlabel = new System.Windows.Forms.Label();
            this.citypicture = new System.Windows.Forms.PictureBox();
            this.separationline = new System.Windows.Forms.PictureBox();
            this.defensespotslabel = new System.Windows.Forms.Label();
            this.citydefensespots = new System.Windows.Forms.Label();
            this.pointspersecondlabel = new System.Windows.Forms.Label();
            this.pointspersecond = new System.Windows.Forms.Label();
            this.countdowntimerlabel = new System.Windows.Forms.Label();
            this.countdowntimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.citylockbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gamedurationcombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.SequenceArrow1 = new System.Windows.Forms.PictureBox();
            this.SequenceArrow2 = new System.Windows.Forms.PictureBox();
            this.SequenceArrow3 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.selectedcitydata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citypicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separationline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defend The City!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startbutton
            // 
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startbutton.FlatAppearance.BorderSize = 0;
            this.startbutton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startbutton.Image = ((System.Drawing.Image)(resources.GetObject("startbutton.Image")));
            this.startbutton.Location = new System.Drawing.Point(213, 577);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(185, 72);
            this.startbutton.TabIndex = 1;
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // selectcitycombobox
            // 
            this.selectcitycombobox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcitycombobox.FormattingEnabled = true;
            this.selectcitycombobox.Location = new System.Drawing.Point(202, 110);
            this.selectcitycombobox.Name = "selectcitycombobox";
            this.selectcitycombobox.Size = new System.Drawing.Size(229, 26);
            this.selectcitycombobox.TabIndex = 2;
            this.selectcitycombobox.SelectedIndexChanged += new System.EventHandler(this.selectcitycombobox_SelectedIndexChanged);
            // 
            // selectcitylabel
            // 
            this.selectcitylabel.AutoSize = true;
            this.selectcitylabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcitylabel.Location = new System.Drawing.Point(261, 79);
            this.selectcitylabel.Name = "selectcitylabel";
            this.selectcitylabel.Size = new System.Drawing.Size(98, 24);
            this.selectcitylabel.TabIndex = 3;
            this.selectcitylabel.Text = "City Data";
            // 
            // cityattacklabel
            // 
            this.cityattacklabel.AutoSize = true;
            this.cityattacklabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityattacklabel.Location = new System.Drawing.Point(261, 153);
            this.cityattacklabel.Name = "cityattacklabel";
            this.cityattacklabel.Size = new System.Drawing.Size(52, 18);
            this.cityattacklabel.TabIndex = 4;
            this.cityattacklabel.Text = "Attack";
            // 
            // cityhealthlabel
            // 
            this.cityhealthlabel.AutoSize = true;
            this.cityhealthlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityhealthlabel.Location = new System.Drawing.Point(261, 215);
            this.cityhealthlabel.Name = "cityhealthlabel";
            this.cityhealthlabel.Size = new System.Drawing.Size(52, 18);
            this.cityhealthlabel.TabIndex = 5;
            this.cityhealthlabel.Text = "Health";
            // 
            // cityattackvalue
            // 
            this.cityattackvalue.AutoSize = true;
            this.cityattackvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityattackvalue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityattackvalue.Location = new System.Drawing.Point(265, 177);
            this.cityattackvalue.Name = "cityattackvalue";
            this.cityattackvalue.Size = new System.Drawing.Size(19, 20);
            this.cityattackvalue.TabIndex = 6;
            this.cityattackvalue.Text = "0";
            this.cityattackvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityhealthvalue
            // 
            this.cityhealthvalue.AutoSize = true;
            this.cityhealthvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityhealthvalue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityhealthvalue.Location = new System.Drawing.Point(265, 239);
            this.cityhealthvalue.Name = "cityhealthvalue";
            this.cityhealthvalue.Size = new System.Drawing.Size(19, 20);
            this.cityhealthvalue.TabIndex = 7;
            this.cityhealthvalue.Text = "0";
            this.cityhealthvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedcitydata
            // 
            this.selectedcitydata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.selectedcitydata.Controls.Add(this.availablepoints);
            this.selectedcitydata.Controls.Add(this.availablepointslabel);
            this.selectedcitydata.Controls.Add(this.cityremaininghealth);
            this.selectedcitydata.Controls.Add(this.cityremaininghealthlabel);
            this.selectedcitydata.Controls.Add(this.citypicture);
            this.selectedcitydata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedcitydata.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedcitydata.Location = new System.Drawing.Point(662, 127);
            this.selectedcitydata.Name = "selectedcitydata";
            this.selectedcitydata.Size = new System.Drawing.Size(298, 212);
            this.selectedcitydata.TabIndex = 9;
            this.selectedcitydata.TabStop = false;
            this.selectedcitydata.Text = "selected city";
            this.selectedcitydata.Enter += new System.EventHandler(this.selectedcitydata_Enter);
            // 
            // availablepoints
            // 
            this.availablepoints.AutoSize = true;
            this.availablepoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availablepoints.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablepoints.Location = new System.Drawing.Point(222, 154);
            this.availablepoints.Name = "availablepoints";
            this.availablepoints.Size = new System.Drawing.Size(19, 20);
            this.availablepoints.TabIndex = 12;
            this.availablepoints.Text = "0";
            this.availablepoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availablepointslabel
            // 
            this.availablepointslabel.AutoSize = true;
            this.availablepointslabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablepointslabel.Location = new System.Drawing.Point(51, 154);
            this.availablepointslabel.Name = "availablepointslabel";
            this.availablepointslabel.Size = new System.Drawing.Size(120, 18);
            this.availablepointslabel.TabIndex = 11;
            this.availablepointslabel.Text = "Available Points";
            // 
            // cityremaininghealth
            // 
            this.cityremaininghealth.AutoSize = true;
            this.cityremaininghealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityremaininghealth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityremaininghealth.Location = new System.Drawing.Point(222, 178);
            this.cityremaininghealth.Name = "cityremaininghealth";
            this.cityremaininghealth.Size = new System.Drawing.Size(19, 20);
            this.cityremaininghealth.TabIndex = 10;
            this.cityremaininghealth.Text = "0";
            this.cityremaininghealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityremaininghealthlabel
            // 
            this.cityremaininghealthlabel.AutoSize = true;
            this.cityremaininghealthlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityremaininghealthlabel.Location = new System.Drawing.Point(51, 180);
            this.cityremaininghealthlabel.Name = "cityremaininghealthlabel";
            this.cityremaininghealthlabel.Size = new System.Drawing.Size(131, 18);
            this.cityremaininghealthlabel.TabIndex = 10;
            this.cityremaininghealthlabel.Text = "Remaining Health";
            // 
            // citypicture
            // 
            this.citypicture.Image = ((System.Drawing.Image)(resources.GetObject("citypicture.Image")));
            this.citypicture.Location = new System.Drawing.Point(46, 31);
            this.citypicture.Name = "citypicture";
            this.citypicture.Size = new System.Drawing.Size(204, 113);
            this.citypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.citypicture.TabIndex = 10;
            this.citypicture.TabStop = false;
            // 
            // separationline
            // 
            this.separationline.BackColor = System.Drawing.Color.Black;
            this.separationline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separationline.Location = new System.Drawing.Point(534, 60);
            this.separationline.Name = "separationline";
            this.separationline.Size = new System.Drawing.Size(11, 589);
            this.separationline.TabIndex = 10;
            this.separationline.TabStop = false;
            // 
            // defensespotslabel
            // 
            this.defensespotslabel.AutoSize = true;
            this.defensespotslabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defensespotslabel.Location = new System.Drawing.Point(387, 153);
            this.defensespotslabel.Name = "defensespotslabel";
            this.defensespotslabel.Size = new System.Drawing.Size(112, 18);
            this.defensespotslabel.TabIndex = 11;
            this.defensespotslabel.Text = "Defense Spots";
            // 
            // citydefensespots
            // 
            this.citydefensespots.AutoSize = true;
            this.citydefensespots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.citydefensespots.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citydefensespots.Location = new System.Drawing.Point(392, 177);
            this.citydefensespots.Name = "citydefensespots";
            this.citydefensespots.Size = new System.Drawing.Size(19, 20);
            this.citydefensespots.TabIndex = 12;
            this.citydefensespots.Text = "0";
            this.citydefensespots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointspersecondlabel
            // 
            this.pointspersecondlabel.AutoSize = true;
            this.pointspersecondlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointspersecondlabel.Location = new System.Drawing.Point(387, 215);
            this.pointspersecondlabel.Name = "pointspersecondlabel";
            this.pointspersecondlabel.Size = new System.Drawing.Size(118, 18);
            this.pointspersecondlabel.TabIndex = 13;
            this.pointspersecondlabel.Text = "Points / Second";
            // 
            // pointspersecond
            // 
            this.pointspersecond.AutoSize = true;
            this.pointspersecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointspersecond.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointspersecond.Location = new System.Drawing.Point(392, 239);
            this.pointspersecond.Name = "pointspersecond";
            this.pointspersecond.Size = new System.Drawing.Size(19, 20);
            this.pointspersecond.TabIndex = 14;
            this.pointspersecond.Text = "0";
            this.pointspersecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdowntimerlabel
            // 
            this.countdowntimerlabel.AutoSize = true;
            this.countdowntimerlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdowntimerlabel.Location = new System.Drawing.Point(757, 83);
            this.countdowntimerlabel.Name = "countdowntimerlabel";
            this.countdowntimerlabel.Size = new System.Drawing.Size(129, 18);
            this.countdowntimerlabel.TabIndex = 15;
            this.countdowntimerlabel.Text = "Countdown Timer";
            // 
            // countdowntimer
            // 
            this.countdowntimer.AutoSize = true;
            this.countdowntimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdowntimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdowntimer.Location = new System.Drawing.Point(760, 101);
            this.countdowntimer.Name = "countdowntimer";
            this.countdowntimer.Size = new System.Drawing.Size(19, 20);
            this.countdowntimer.TabIndex = 16;
            this.countdowntimer.Text = "0";
            this.countdowntimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // citylockbutton
            // 
            this.citylockbutton.BackColor = System.Drawing.Color.White;
            this.citylockbutton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylockbutton.ForeColor = System.Drawing.Color.Black;
            this.citylockbutton.Image = ((System.Drawing.Image)(resources.GetObject("citylockbutton.Image")));
            this.citylockbutton.Location = new System.Drawing.Point(209, 319);
            this.citylockbutton.Name = "citylockbutton";
            this.citylockbutton.Size = new System.Drawing.Size(162, 99);
            this.citylockbutton.TabIndex = 17;
            this.citylockbutton.UseVisualStyleBackColor = false;
            this.citylockbutton.Click += new System.EventHandler(this.citylockbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Game Duration";
            // 
            // gamedurationcombobox
            // 
            this.gamedurationcombobox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamedurationcombobox.FormattingEnabled = true;
            this.gamedurationcombobox.Location = new System.Drawing.Point(213, 494);
            this.gamedurationcombobox.Name = "gamedurationcombobox";
            this.gamedurationcombobox.Size = new System.Drawing.Size(161, 26);
            this.gamedurationcombobox.TabIndex = 19;
            this.gamedurationcombobox.Text = "0";
            this.gamedurationcombobox.SelectedIndexChanged += new System.EventHandler(this.gamedurationcombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "City Lock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(332, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 42);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 78);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1006, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 78);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1006, 583);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(78, 78);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-1, 583);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(78, 78);
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // SequenceArrow1
            // 
            this.SequenceArrow1.Image = ((System.Drawing.Image)(resources.GetObject("SequenceArrow1.Image")));
            this.SequenceArrow1.Location = new System.Drawing.Point(111, 176);
            this.SequenceArrow1.Name = "SequenceArrow1";
            this.SequenceArrow1.Size = new System.Drawing.Size(75, 123);
            this.SequenceArrow1.TabIndex = 29;
            this.SequenceArrow1.TabStop = false;
            // 
            // SequenceArrow2
            // 
            this.SequenceArrow2.Image = ((System.Drawing.Image)(resources.GetObject("SequenceArrow2.Image")));
            this.SequenceArrow2.Location = new System.Drawing.Point(111, 341);
            this.SequenceArrow2.Name = "SequenceArrow2";
            this.SequenceArrow2.Size = new System.Drawing.Size(75, 123);
            this.SequenceArrow2.TabIndex = 30;
            this.SequenceArrow2.TabStop = false;
            // 
            // SequenceArrow3
            // 
            this.SequenceArrow3.Image = ((System.Drawing.Image)(resources.GetObject("SequenceArrow3.Image")));
            this.SequenceArrow3.Location = new System.Drawing.Point(111, 507);
            this.SequenceArrow3.Name = "SequenceArrow3";
            this.SequenceArrow3.Size = new System.Drawing.Size(75, 123);
            this.SequenceArrow3.TabIndex = 31;
            this.SequenceArrow3.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(74, 98);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(114, 50);
            this.pictureBox12.TabIndex = 32;
            this.pictureBox12.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.SequenceArrow3);
            this.Controls.Add(this.SequenceArrow2);
            this.Controls.Add(this.SequenceArrow1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gamedurationcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citylockbutton);
            this.Controls.Add(this.countdowntimer);
            this.Controls.Add(this.countdowntimerlabel);
            this.Controls.Add(this.pointspersecond);
            this.Controls.Add(this.pointspersecondlabel);
            this.Controls.Add(this.citydefensespots);
            this.Controls.Add(this.defensespotslabel);
            this.Controls.Add(this.separationline);
            this.Controls.Add(this.selectedcitydata);
            this.Controls.Add(this.cityhealthvalue);
            this.Controls.Add(this.cityattackvalue);
            this.Controls.Add(this.cityhealthlabel);
            this.Controls.Add(this.cityattacklabel);
            this.Controls.Add(this.selectcitylabel);
            this.Controls.Add(this.selectcitycombobox);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "City Defense Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.selectedcitydata.ResumeLayout(false);
            this.selectedcitydata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citypicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separationline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenceArrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.ComboBox selectcitycombobox;
        private System.Windows.Forms.Label selectcitylabel;
        private System.Windows.Forms.Label cityattacklabel;
        private System.Windows.Forms.Label cityhealthlabel;
        private System.Windows.Forms.Label cityattackvalue;
        private System.Windows.Forms.Label cityhealthvalue;
        private System.Windows.Forms.GroupBox selectedcitydata;
        private System.Windows.Forms.PictureBox citypicture;
        private System.Windows.Forms.Label cityremaininghealth;
        private System.Windows.Forms.Label cityremaininghealthlabel;
        private System.Windows.Forms.PictureBox separationline;
        private System.Windows.Forms.Label defensespotslabel;
        private System.Windows.Forms.Label citydefensespots;
        private System.Windows.Forms.Label pointspersecondlabel;
        private System.Windows.Forms.Label pointspersecond;
        private System.Windows.Forms.Label countdowntimerlabel;
        private System.Windows.Forms.Label countdowntimer;
        private System.Windows.Forms.Label availablepoints;
        private System.Windows.Forms.Label availablepointslabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button citylockbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gamedurationcombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox SequenceArrow1;
        private System.Windows.Forms.PictureBox SequenceArrow2;
        private System.Windows.Forms.PictureBox SequenceArrow3;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

