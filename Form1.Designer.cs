namespace PizzaProjectWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.labToppings = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbExtra = new System.Windows.Forms.CheckBox();
            this.chkbMushrooms = new System.Windows.Forms.CheckBox();
            this.chkbTomatoes = new System.Windows.Forms.CheckBox();
            this.chkbOnion = new System.Windows.Forms.CheckBox();
            this.chkbOlives = new System.Windows.Forms.CheckBox();
            this.chkbGPapper = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labSiz = new System.Windows.Forms.Label();
            this.labCrust = new System.Windows.Forms.Label();
            this.labWhere = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.labT = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.CausesValidation = false;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbSize.Location = new System.Drawing.Point(79, 111);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(149, 144);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Choise Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbLarge.Location = new System.Drawing.Point(7, 97);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(75, 28);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbMedium.Location = new System.Drawing.Point(6, 65);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(93, 28);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbSmall.Location = new System.Drawing.Point(7, 33);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(74, 28);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbCrust.Location = new System.Drawing.Point(79, 276);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(149, 133);
            this.gbCrust.TabIndex = 1;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Choise Crust";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.ForeColor = System.Drawing.Color.Purple;
            this.rbThick.Location = new System.Drawing.Point(6, 84);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(117, 28);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.ForeColor = System.Drawing.Color.Purple;
            this.rbThin.Location = new System.Drawing.Point(7, 33);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(112, 28);
            this.rbThin.TabIndex = 1;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labToppings.Location = new System.Drawing.Point(556, 181);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(64, 19);
            this.labToppings.TabIndex = 4;
            this.labToppings.Text = "Toppings";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labWhereToEat.Location = new System.Drawing.Point(556, 297);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(101, 19);
            this.labWhereToEat.TabIndex = 5;
            this.labWhereToEat.Text = "Where To Eat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(282, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings";
            // 
            // chkbExtra
            // 
            this.chkbExtra.AutoSize = true;
            this.chkbExtra.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbExtra.ForeColor = System.Drawing.Color.Green;
            this.chkbExtra.Location = new System.Drawing.Point(288, 144);
            this.chkbExtra.Name = "chkbExtra";
            this.chkbExtra.Size = new System.Drawing.Size(104, 24);
            this.chkbExtra.TabIndex = 7;
            this.chkbExtra.Text = "Extra Chees";
            this.chkbExtra.UseVisualStyleBackColor = true;
            this.chkbExtra.CheckedChanged += new System.EventHandler(this.chkbExtra_CheckedChanged);
            // 
            // chkbMushrooms
            // 
            this.chkbMushrooms.AutoSize = true;
            this.chkbMushrooms.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbMushrooms.ForeColor = System.Drawing.Color.Green;
            this.chkbMushrooms.Location = new System.Drawing.Point(288, 181);
            this.chkbMushrooms.Name = "chkbMushrooms";
            this.chkbMushrooms.Size = new System.Drawing.Size(106, 24);
            this.chkbMushrooms.TabIndex = 8;
            this.chkbMushrooms.Text = "Mushrooms";
            this.chkbMushrooms.UseVisualStyleBackColor = true;
            this.chkbMushrooms.CheckedChanged += new System.EventHandler(this.chkbMushrooms_CheckedChanged);
            // 
            // chkbTomatoes
            // 
            this.chkbTomatoes.AutoSize = true;
            this.chkbTomatoes.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbTomatoes.ForeColor = System.Drawing.Color.Green;
            this.chkbTomatoes.Location = new System.Drawing.Point(288, 218);
            this.chkbTomatoes.Name = "chkbTomatoes";
            this.chkbTomatoes.Size = new System.Drawing.Size(90, 24);
            this.chkbTomatoes.TabIndex = 9;
            this.chkbTomatoes.Text = "Tomatoes";
            this.chkbTomatoes.UseVisualStyleBackColor = true;
            this.chkbTomatoes.CheckedChanged += new System.EventHandler(this.chkbTomatoes_CheckedChanged);
            // 
            // chkbOnion
            // 
            this.chkbOnion.AutoSize = true;
            this.chkbOnion.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbOnion.ForeColor = System.Drawing.Color.Green;
            this.chkbOnion.Location = new System.Drawing.Point(420, 144);
            this.chkbOnion.Name = "chkbOnion";
            this.chkbOnion.Size = new System.Drawing.Size(66, 24);
            this.chkbOnion.TabIndex = 10;
            this.chkbOnion.Text = "Onion";
            this.chkbOnion.UseVisualStyleBackColor = true;
            this.chkbOnion.CheckedChanged += new System.EventHandler(this.chkbOnion_CheckedChanged);
            // 
            // chkbOlives
            // 
            this.chkbOlives.AutoSize = true;
            this.chkbOlives.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbOlives.ForeColor = System.Drawing.Color.Green;
            this.chkbOlives.Location = new System.Drawing.Point(420, 181);
            this.chkbOlives.Name = "chkbOlives";
            this.chkbOlives.Size = new System.Drawing.Size(64, 24);
            this.chkbOlives.TabIndex = 11;
            this.chkbOlives.Text = "Olives";
            this.chkbOlives.UseVisualStyleBackColor = true;
            this.chkbOlives.CheckedChanged += new System.EventHandler(this.chkbOlives_CheckedChanged);
            // 
            // chkbGPapper
            // 
            this.chkbGPapper.AutoSize = true;
            this.chkbGPapper.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbGPapper.ForeColor = System.Drawing.Color.Green;
            this.chkbGPapper.Location = new System.Drawing.Point(420, 218);
            this.chkbGPapper.Name = "chkbGPapper";
            this.chkbGPapper.Size = new System.Drawing.Size(118, 24);
            this.chkbGPapper.TabIndex = 12;
            this.chkbGPapper.Text = "Green Papper";
            this.chkbGPapper.UseVisualStyleBackColor = true;
            this.chkbGPapper.CheckedChanged += new System.EventHandler(this.chkbGPapper_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(282, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.ForeColor = System.Drawing.Color.Teal;
            this.rbTakeOut.Location = new System.Drawing.Point(420, 319);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(100, 28);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.ForeColor = System.Drawing.Color.Teal;
            this.rbEatIn.Location = new System.Drawing.Point(292, 319);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(78, 28);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMakeOrder.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrder.ForeColor = System.Drawing.Color.Red;
            this.btnMakeOrder.Location = new System.Drawing.Point(275, 364);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(119, 45);
            this.btnMakeOrder.TabIndex = 14;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetForm.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Red;
            this.btnResetForm.Location = new System.Drawing.Point(422, 364);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(119, 45);
            this.btnResetForm.TabIndex = 15;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(535, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order Summary";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labCrustType.Location = new System.Drawing.Point(556, 264);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(75, 19);
            this.labCrustType.TabIndex = 18;
            this.labCrustType.Text = "Crust Type";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labSize.Location = new System.Drawing.Point(556, 148);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(35, 19);
            this.labSize.TabIndex = 17;
            this.labSize.Text = "Size";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label.Location = new System.Drawing.Point(556, 339);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 19);
            this.label.TabIndex = 19;
            this.label.Text = "Total";
            // 
            // labSiz
            // 
            this.labSiz.AutoSize = true;
            this.labSiz.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSiz.ForeColor = System.Drawing.Color.Navy;
            this.labSiz.Location = new System.Drawing.Point(624, 149);
            this.labSiz.Name = "labSiz";
            this.labSiz.Size = new System.Drawing.Size(60, 19);
            this.labSiz.TabIndex = 20;
            this.labSiz.Text = "Medium";
            // 
            // labCrust
            // 
            this.labCrust.AutoSize = true;
            this.labCrust.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrust.ForeColor = System.Drawing.Color.Navy;
            this.labCrust.Location = new System.Drawing.Point(637, 276);
            this.labCrust.Name = "labCrust";
            this.labCrust.Size = new System.Drawing.Size(75, 19);
            this.labCrust.TabIndex = 22;
            this.labCrust.Text = "Thin Crust";
            // 
            // labWhere
            // 
            this.labWhere.AutoSize = true;
            this.labWhere.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhere.ForeColor = System.Drawing.Color.Navy;
            this.labWhere.Location = new System.Drawing.Point(650, 315);
            this.labWhere.Name = "labWhere";
            this.labWhere.Size = new System.Drawing.Size(54, 19);
            this.labWhere.TabIndex = 23;
            this.labWhere.Text = "Eat In";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTotal.Location = new System.Drawing.Point(626, 350);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(68, 59);
            this.labTotal.TabIndex = 24;
            this.labTotal.Text = "40";
            this.labTotal.Click += new System.EventHandler(this.labTotal_Click);
            // 
            // txtTop
            // 
            this.txtTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTop.Location = new System.Drawing.Point(560, 203);
            this.txtTop.Multiline = true;
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(183, 58);
            this.txtTop.TabIndex = 27;
            this.txtTop.TextChanged += new System.EventHandler(this.txtTop_TextChanged);
            // 
            // labT
            // 
            this.labT.AutoSize = true;
            this.labT.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labT.Location = new System.Drawing.Point(594, 350);
            this.labT.Name = "labT";
            this.labT.Size = new System.Drawing.Size(45, 59);
            this.labT.TabIndex = 28;
            this.labT.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(758, 429);
            this.Controls.Add(this.labT);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labWhere);
            this.Controls.Add(this.labCrust);
            this.Controls.Add(this.labSiz);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labCrustType);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.rbTakeOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbEatIn);
            this.Controls.Add(this.chkbGPapper);
            this.Controls.Add(this.chkbOlives);
            this.Controls.Add(this.chkbOnion);
            this.Controls.Add(this.chkbTomatoes);
            this.Controls.Add(this.chkbMushrooms);
            this.Controls.Add(this.chkbExtra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labWhereToEat);
            this.Controls.Add(this.labToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Project ";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbExtra;
        private System.Windows.Forms.CheckBox chkbMushrooms;
        private System.Windows.Forms.CheckBox chkbTomatoes;
        private System.Windows.Forms.CheckBox chkbOnion;
        private System.Windows.Forms.CheckBox chkbOlives;
        private System.Windows.Forms.CheckBox chkbGPapper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labSiz;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label labWhere;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label labT;
    }
}

