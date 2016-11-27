namespace WindowsFormsApplication3
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
            this.Ctext = new System.Windows.Forms.TextBox();
            this.Atext = new System.Windows.Forms.TextBox();
            this.Btext = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ComboMore1 = new System.Windows.Forms.ComboBox();
            this.ComboMore2 = new System.Windows.Forms.ComboBox();
            this.MoreButton = new System.Windows.Forms.Button();
            this.MoreAnswer = new System.Windows.Forms.Label();
            this.ComboInfo = new System.Windows.Forms.ComboBox();
            this.P = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rnumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ctext
            // 
            this.Ctext.Location = new System.Drawing.Point(110, 10);
            this.Ctext.Name = "Ctext";
            this.Ctext.Size = new System.Drawing.Size(45, 20);
            this.Ctext.TabIndex = 0;
            this.Ctext.Text = "c";
            // 
            // Atext
            // 
            this.Atext.Location = new System.Drawing.Point(8, 10);
            this.Atext.Name = "Atext";
            this.Atext.Size = new System.Drawing.Size(45, 20);
            this.Atext.TabIndex = 1;
            this.Atext.Text = "a";
            // 
            // Btext
            // 
            this.Btext.Location = new System.Drawing.Point(59, 10);
            this.Btext.Name = "Btext";
            this.Btext.Size = new System.Drawing.Size(45, 20);
            this.Btext.TabIndex = 2;
            this.Btext.Text = "b";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(178, 10);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 20);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save figure";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ComboMore1
            // 
            this.ComboMore1.FormattingEnabled = true;
            this.ComboMore1.Location = new System.Drawing.Point(13, 65);
            this.ComboMore1.Name = "ComboMore1";
            this.ComboMore1.Size = new System.Drawing.Size(45, 21);
            this.ComboMore1.TabIndex = 4;
            // 
            // ComboMore2
            // 
            this.ComboMore2.FormattingEnabled = true;
            this.ComboMore2.Location = new System.Drawing.Point(72, 63);
            this.ComboMore2.Name = "ComboMore2";
            this.ComboMore2.Size = new System.Drawing.Size(45, 21);
            this.ComboMore2.TabIndex = 5;
            // 
            // MoreButton
            // 
            this.MoreButton.Location = new System.Drawing.Point(178, 64);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(75, 20);
            this.MoreButton.TabIndex = 6;
            this.MoreButton.Text = "More than?";
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // MoreAnswer
            // 
            this.MoreAnswer.AutoSize = true;
            this.MoreAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreAnswer.Location = new System.Drawing.Point(123, 64);
            this.MoreAnswer.Name = "MoreAnswer";
            this.MoreAnswer.Size = new System.Drawing.Size(18, 20);
            this.MoreAnswer.TabIndex = 7;
            this.MoreAnswer.Text = "?";
            // 
            // ComboInfo
            // 
            this.ComboInfo.FormattingEnabled = true;
            this.ComboInfo.Location = new System.Drawing.Point(12, 39);
            this.ComboInfo.Name = "ComboInfo";
            this.ComboInfo.Size = new System.Drawing.Size(46, 21);
            this.ComboInfo.TabIndex = 8;
            this.ComboInfo.SelectedIndexChanged += new System.EventHandler(this.ComboInfo_SelectedIndexChanged);
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P.Location = new System.Drawing.Point(59, 38);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(19, 20);
            this.P.TabIndex = 10;
            this.P.Text = "P";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(123, 38);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(20, 20);
            this.S.TabIndex = 11;
            this.S.Text = "S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ABC);
            this.panel1.Controls.Add(this.Rnumbers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.V);
            this.panel1.Controls.Add(this.P);
            this.panel1.Controls.Add(this.MoreButton);
            this.panel1.Controls.Add(this.S);
            this.panel1.Controls.Add(this.ComboMore2);
            this.panel1.Controls.Add(this.MoreAnswer);
            this.panel1.Controls.Add(this.Atext);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.Ctext);
            this.panel1.Controls.Add(this.Btext);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 91);
            this.panel1.TabIndex = 12;
            // 
            // Rnumbers
            // 
            this.Rnumbers.Location = new System.Drawing.Point(161, 13);
            this.Rnumbers.Name = "Rnumbers";
            this.Rnumbers.Size = new System.Drawing.Size(11, 14);
            this.Rnumbers.TabIndex = 14;
            this.Rnumbers.Text = "button1";
            this.Rnumbers.UseVisualStyleBackColor = true;
            this.Rnumbers.Click += new System.EventHandler(this.Rnumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = ">";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.V.Location = new System.Drawing.Point(185, 38);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(20, 20);
            this.V.TabIndex = 12;
            this.V.Text = "V";
            // 
            // ABC
            // 
            this.ABC.Location = new System.Drawing.Point(241, 42);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(11, 14);
            this.ABC.TabIndex = 15;
            this.ABC.Text = "button1";
            this.ABC.UseVisualStyleBackColor = true;
            this.ABC.Click += new System.EventHandler(this.ABC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 99);
            this.Controls.Add(this.ComboInfo);
            this.Controls.Add(this.ComboMore1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Ctext;
        private System.Windows.Forms.TextBox Atext;
        private System.Windows.Forms.TextBox Btext;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.Label MoreAnswer;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.ComboBox ComboMore1;
        private System.Windows.Forms.ComboBox ComboMore2;
        private System.Windows.Forms.ComboBox ComboInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rnumbers;
        private System.Windows.Forms.Button ABC;
    }
}

