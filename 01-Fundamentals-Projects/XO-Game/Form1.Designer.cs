namespace XO_Game
{
    partial class frmXO
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(564, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 103);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(158, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 71);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Lavender;
            this.lblTurn.Location = new System.Drawing.Point(101, 272);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(307, 71);
            this.lblTurn.TabIndex = 11;
            this.lblTurn.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(121, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 71);
            this.label4.TabIndex = 12;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblWinner.Location = new System.Drawing.Point(31, 466);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(446, 77);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRestartGame.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Indigo;
            this.btnRestartGame.Location = new System.Drawing.Point(108, 569);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(293, 69);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button1.Location = new System.Drawing.Point(618, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 104);
            this.button1.TabIndex = 15;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button2.Location = new System.Drawing.Point(892, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 104);
            this.button2.TabIndex = 16;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button3.Location = new System.Drawing.Point(1166, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 104);
            this.button3.TabIndex = 17;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.ForeColor = System.Drawing.Color.DeepPink;
            this.button4.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button4.Location = new System.Drawing.Point(618, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 104);
            this.button4.TabIndex = 18;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Indigo;
            this.button5.ForeColor = System.Drawing.Color.DeepPink;
            this.button5.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button5.Location = new System.Drawing.Point(888, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 104);
            this.button5.TabIndex = 19;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Indigo;
            this.button6.ForeColor = System.Drawing.Color.DeepPink;
            this.button6.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button6.Location = new System.Drawing.Point(1166, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 104);
            this.button6.TabIndex = 20;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Indigo;
            this.button7.ForeColor = System.Drawing.Color.DeepPink;
            this.button7.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button7.Location = new System.Drawing.Point(618, 616);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 104);
            this.button7.TabIndex = 21;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Indigo;
            this.button8.ForeColor = System.Drawing.Color.DeepPink;
            this.button8.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button8.Location = new System.Drawing.Point(888, 616);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 104);
            this.button8.TabIndex = 22;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Indigo;
            this.button9.ForeColor = System.Drawing.Color.DeepPink;
            this.button9.Image = global::XO_Game.Properties.Resources.question_sign1;
            this.button9.Location = new System.Drawing.Point(1166, 616);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 104);
            this.button9.TabIndex = 23;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1689, 749);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.Name = "frmXO";
            this.Text = "XO-Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

