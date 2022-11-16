namespace AirthmeticFrameworkApp
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.l1.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(943, 86);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(191, 62);
            this.l1.TabIndex = 0;
            this.l1.Text = "Calculator";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(409, 279);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(224, 32);
            this.l2.TabIndex = 1;
            this.l2.Text = "Enter First Number";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(1081, 285);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(256, 32);
            this.l3.TabIndex = 2;
            this.l3.Text = "Enter Second Number";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(662, 285);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(297, 26);
            this.tb1.TabIndex = 3;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(1367, 285);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(293, 26);
            this.tb2.TabIndex = 4;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn1.Location = new System.Drawing.Point(878, 491);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(137, 43);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Addition";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn2.Location = new System.Drawing.Point(878, 560);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(137, 43);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Substraction";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn3.Location = new System.Drawing.Point(878, 632);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(137, 43);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "Multiplication";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn4.Location = new System.Drawing.Point(878, 709);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(137, 43);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "Division";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(1063, 499);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(297, 26);
            this.tb3.TabIndex = 9;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(1063, 568);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(297, 26);
            this.tb4.TabIndex = 10;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(1063, 640);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(297, 26);
            this.tb5.TabIndex = 11;
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(1063, 717);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(297, 26);
            this.tb6.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 835);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb6;
    }
}

