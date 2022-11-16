namespace AirthmeticCoreApp
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(807, 448);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(151, 58);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Addition";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(807, 534);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(151, 58);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Substraction";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(807, 613);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(151, 58);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Multiplication";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(807, 691);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(151, 58);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Division";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l1.Location = new System.Drawing.Point(887, 87);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(248, 53);
            this.l1.TabIndex = 4;
            this.l1.Text = "Calculator";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l2.Location = new System.Drawing.Point(455, 283);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(224, 32);
            this.l2.TabIndex = 5;
            this.l2.Text = "Enter First Number";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l3.Location = new System.Drawing.Point(983, 285);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(256, 32);
            this.l3.TabIndex = 6;
            this.l3.Text = "Enter Second Number";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(714, 285);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(223, 31);
            this.tb1.TabIndex = 7;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(1262, 287);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(228, 31);
            this.tb2.TabIndex = 8;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(994, 462);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(202, 31);
            this.tb3.TabIndex = 9;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(994, 548);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(202, 31);
            this.tb4.TabIndex = 10;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(994, 627);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(202, 31);
            this.tb5.TabIndex = 11;
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(994, 705);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(202, 31);
            this.tb6.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 813);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label l1;
        private Label l2;
        private Label l3;
        private TextBox tb1;
        private TextBox tb2;
        private TextBox tb3;
        private TextBox tb4;
        private TextBox tb5;
        private TextBox tb6;
    }
}