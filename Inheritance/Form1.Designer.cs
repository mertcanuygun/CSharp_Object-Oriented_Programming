namespace Inheritance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_television = new System.Windows.Forms.Button();
            this.btn_computer = new System.Windows.Forms.Button();
            this.btn_car = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_car);
            this.groupBox1.Controls.Add(this.btn_computer);
            this.groupBox1.Controls.Add(this.btn_television);
            this.groupBox1.Location = new System.Drawing.Point(36, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // btn_television
            // 
            this.btn_television.Location = new System.Drawing.Point(38, 51);
            this.btn_television.Name = "btn_television";
            this.btn_television.Size = new System.Drawing.Size(203, 52);
            this.btn_television.TabIndex = 0;
            this.btn_television.Text = "TV Product";
            this.btn_television.UseVisualStyleBackColor = true;
            this.btn_television.Click += new System.EventHandler(this.btn_television_Click);
            // 
            // btn_computer
            // 
            this.btn_computer.Location = new System.Drawing.Point(38, 191);
            this.btn_computer.Name = "btn_computer";
            this.btn_computer.Size = new System.Drawing.Size(203, 52);
            this.btn_computer.TabIndex = 1;
            this.btn_computer.Text = "Computer Product";
            this.btn_computer.UseVisualStyleBackColor = true;
            this.btn_computer.Click += new System.EventHandler(this.btn_computer_Click);
            // 
            // btn_car
            // 
            this.btn_car.Location = new System.Drawing.Point(38, 122);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(203, 52);
            this.btn_car.TabIndex = 1;
            this.btn_car.Text = "Car Product";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Click += new System.EventHandler(this.btn_car_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Button btn_computer;
        private System.Windows.Forms.Button btn_television;
    }
}

