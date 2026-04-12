namespace WindowsFormsApp3
{
    partial class FormOrderPizzaOrder
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
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbLSizeName = new System.Windows.Forms.Label();
            this.pnSize = new System.Windows.Forms.Panel();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnWhereEat = new System.Windows.Forms.Panel();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLTopping = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLEat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.chkExtraChess = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chktomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.LbEat = new System.Windows.Forms.Label();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.pnCrustType = new System.Windows.Forms.Panel();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnTopping = new System.Windows.Forms.Panel();
            this.pnSize.SuspendLayout();
            this.pnWhereEat.SuspendLayout();
            this.pnCrustType.SuspendLayout();
            this.pnTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(339, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPizza.Location = new System.Drawing.Point(455, 557);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(165, 41);
            this.btOrderPizza.TabIndex = 16;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(755, 557);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(165, 41);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "Reset Form";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Topping";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(974, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1000, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Size:";
            // 
            // LbLSizeName
            // 
            this.LbLSizeName.AutoSize = true;
            this.LbLSizeName.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLSizeName.Location = new System.Drawing.Point(1074, 181);
            this.LbLSizeName.Name = "LbLSizeName";
            this.LbLSizeName.Size = new System.Drawing.Size(0, 27);
            this.LbLSizeName.TabIndex = 23;
            // 
            // pnSize
            // 
            this.pnSize.Controls.Add(this.rbLarg);
            this.pnSize.Controls.Add(this.rbMedium);
            this.pnSize.Controls.Add(this.rbSmall);
            this.pnSize.Controls.Add(this.label5);
            this.pnSize.Location = new System.Drawing.Point(57, 159);
            this.pnSize.Name = "pnSize";
            this.pnSize.Size = new System.Drawing.Size(183, 209);
            this.pnSize.TabIndex = 24;
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarg.Location = new System.Drawing.Point(74, 169);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(81, 28);
            this.rbLarg.TabIndex = 9;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "Large";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(74, 113);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(101, 28);
            this.rbMedium.TabIndex = 8;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(74, 58);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(80, 28);
            this.rbSmall.TabIndex = 7;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Where To Eat";
            // 
            // pnWhereEat
            // 
            this.pnWhereEat.Controls.Add(this.rbTakeOut);
            this.pnWhereEat.Controls.Add(this.rbEatIn);
            this.pnWhereEat.Location = new System.Drawing.Point(534, 458);
            this.pnWhereEat.Name = "pnWhereEat";
            this.pnWhereEat.Size = new System.Drawing.Size(298, 69);
            this.pnWhereEat.TabIndex = 28;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(168, 17);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(113, 28);
            this.rbTakeOut.TabIndex = 8;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(23, 17);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(84, 28);
            this.rbEatIn.TabIndex = 7;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1000, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Topping:";
            // 
            // LBLTopping
            // 
            this.LBLTopping.AutoSize = true;
            this.LBLTopping.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTopping.Location = new System.Drawing.Point(1022, 292);
            this.LBLTopping.Name = "LBLTopping";
            this.LBLTopping.Size = new System.Drawing.Size(102, 21);
            this.LBLTopping.TabIndex = 31;
            this.LBLTopping.Text = "No Toppings";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(1074, 356);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(0, 27);
            this.lblCrustType.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1000, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "Crust:";
            // 
            // LBLEat
            // 
            this.LBLEat.AutoSize = true;
            this.LBLEat.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEat.Location = new System.Drawing.Point(1074, 467);
            this.LBLEat.Name = "LBLEat";
            this.LBLEat.Size = new System.Drawing.Size(0, 27);
            this.LBLEat.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1000, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 27);
            this.label10.TabIndex = 35;
            this.label10.Text = "Where To Eat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1000, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(1142, 557);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(118, 73);
            this.lblTotalPrice.TabIndex = 38;
            this.lblTotalPrice.Text = "$0";
            // 
            // chkExtraChess
            // 
            this.chkExtraChess.AutoSize = true;
            this.chkExtraChess.Location = new System.Drawing.Point(37, 61);
            this.chkExtraChess.Name = "chkExtraChess";
            this.chkExtraChess.Size = new System.Drawing.Size(104, 21);
            this.chkExtraChess.TabIndex = 39;
            this.chkExtraChess.Tag = "5";
            this.chkExtraChess.Text = "Extra Chees";
            this.chkExtraChess.UseVisualStyleBackColor = true;
            this.chkExtraChess.CheckedChanged += new System.EventHandler(this.chkExtraChess_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Location = new System.Drawing.Point(37, 102);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(100, 21);
            this.chkMashrooms.TabIndex = 40;
            this.chkMashrooms.Tag = "10";
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.chkMashrooms_CheckedChanged);
            // 
            // chktomatoes
            // 
            this.chktomatoes.AutoSize = true;
            this.chktomatoes.Location = new System.Drawing.Point(37, 141);
            this.chktomatoes.Name = "chktomatoes";
            this.chktomatoes.Size = new System.Drawing.Size(88, 21);
            this.chktomatoes.TabIndex = 41;
            this.chktomatoes.Tag = "1";
            this.chktomatoes.Text = "tomatoes";
            this.chktomatoes.UseVisualStyleBackColor = true;
            this.chktomatoes.CheckedChanged += new System.EventHandler(this.chktomatoes_CheckedChanged);
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Location = new System.Drawing.Point(183, 141);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(119, 21);
            this.chkGreenPappers.TabIndex = 44;
            this.chkGreenPappers.Tag = "1";
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(183, 102);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(65, 21);
            this.chkOlives.TabIndex = 43;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(183, 61);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(66, 21);
            this.chkOnion.TabIndex = 42;
            this.chkOnion.Tag = "3";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // LbEat
            // 
            this.LbEat.AutoSize = true;
            this.LbEat.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEat.Location = new System.Drawing.Point(1170, 425);
            this.LbEat.Name = "LbEat";
            this.LbEat.Size = new System.Drawing.Size(0, 27);
            this.LbEat.TabIndex = 46;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(45, 65);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(122, 28);
            this.rbThinCrust.TabIndex = 48;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // pnCrustType
            // 
            this.pnCrustType.Controls.Add(this.rbThickCrust);
            this.pnCrustType.Controls.Add(this.rbThinCrust);
            this.pnCrustType.Controls.Add(this.label6);
            this.pnCrustType.Location = new System.Drawing.Point(57, 425);
            this.pnCrustType.Name = "pnCrustType";
            this.pnCrustType.Size = new System.Drawing.Size(183, 164);
            this.pnCrustType.TabIndex = 50;
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(45, 121);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(130, 28);
            this.rbThickCrust.TabIndex = 49;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "5";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Crust Type";
            // 
            // pnTopping
            // 
            this.pnTopping.Controls.Add(this.label2);
            this.pnTopping.Controls.Add(this.chkOlives);
            this.pnTopping.Controls.Add(this.chkExtraChess);
            this.pnTopping.Controls.Add(this.chkGreenPappers);
            this.pnTopping.Controls.Add(this.chkMashrooms);
            this.pnTopping.Controls.Add(this.chktomatoes);
            this.pnTopping.Controls.Add(this.chkOnion);
            this.pnTopping.Location = new System.Drawing.Point(515, 159);
            this.pnTopping.Name = "pnTopping";
            this.pnTopping.Size = new System.Drawing.Size(317, 185);
            this.pnTopping.TabIndex = 51;
            // 
            // FormOrderPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1456, 654);
            this.Controls.Add(this.pnTopping);
            this.Controls.Add(this.pnCrustType);
            this.Controls.Add(this.LbEat);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LBLEat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LBLTopping);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnWhereEat);
            this.Controls.Add(this.pnSize);
            this.Controls.Add(this.LbLSizeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderPizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.FormOrderPizzaOrder_Load);
            this.pnSize.ResumeLayout(false);
            this.pnSize.PerformLayout();
            this.pnWhereEat.ResumeLayout(false);
            this.pnWhereEat.PerformLayout();
            this.pnCrustType.ResumeLayout(false);
            this.pnCrustType.PerformLayout();
            this.pnTopping.ResumeLayout(false);
            this.pnTopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbLSizeName;
        private System.Windows.Forms.Panel pnSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnWhereEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLTopping;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBLEat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.CheckBox chkExtraChess;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chktomatoes;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Label LbEat;
        private System.Windows.Forms.RadioButton rbThinCrustrbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.Panel pnCrustType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnTopping;
        private System.Windows.Forms.RadioButton rbThickCrust;
    }
}

