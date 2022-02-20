namespace Static_Class
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
            this.btn_factorial = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cubic = new System.Windows.Forms.TextBox();
            this.btn_cubic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_factorial
            // 
            this.btn_factorial.Location = new System.Drawing.Point(33, 98);
            this.btn_factorial.Name = "btn_factorial";
            this.btn_factorial.Size = new System.Drawing.Size(116, 44);
            this.btn_factorial.TabIndex = 0;
            this.btn_factorial.Text = "Calculate";
            this.btn_factorial.UseVisualStyleBackColor = true;
            this.btn_factorial.Click += new System.EventHandler(this.btn_factorial_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(33, 51);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(116, 31);
            this.txt_number.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_result);
            this.groupBox1.Controls.Add(this.txt_number);
            this.groupBox1.Controls.Add(this.btn_factorial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factorial Calculation";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(184, 108);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 25);
            this.lbl_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cubic);
            this.groupBox2.Controls.Add(this.txt_cubic);
            this.groupBox2.Location = new System.Drawing.Point(305, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cubic Calculation";
            // 
            // txt_cubic
            // 
            this.txt_cubic.Location = new System.Drawing.Point(57, 51);
            this.txt_cubic.Name = "txt_cubic";
            this.txt_cubic.Size = new System.Drawing.Size(115, 31);
            this.txt_cubic.TabIndex = 0;
            // 
            // btn_cubic
            // 
            this.btn_cubic.Location = new System.Drawing.Point(57, 98);
            this.btn_cubic.Name = "btn_cubic";
            this.btn_cubic.Size = new System.Drawing.Size(115, 44);
            this.btn_cubic.TabIndex = 1;
            this.btn_cubic.Text = "Calculate";
            this.btn_cubic.UseVisualStyleBackColor = true;
            this.btn_cubic.Click += new System.EventHandler(this.btn_cubic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_factorial;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cubic;
        private System.Windows.Forms.TextBox txt_cubic;
    }
}

