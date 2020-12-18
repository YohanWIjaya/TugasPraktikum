namespace WindowsFormsApp4
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
            this.Input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Reverse = new System.Windows.Forms.Button();
            this.Urutkan = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Font = new System.Drawing.Font("Permanent Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.Lime;
            this.Input.Location = new System.Drawing.Point(83, 60);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(80, 35);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Reverse
            // 
            this.Reverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reverse.Location = new System.Drawing.Point(89, 175);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(89, 23);
            this.Reverse.TabIndex = 2;
            this.Reverse.Text = "REVERSE";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Urutkan
            // 
            this.Urutkan.ForeColor = System.Drawing.Color.Red;
            this.Urutkan.Location = new System.Drawing.Point(211, 175);
            this.Urutkan.Name = "Urutkan";
            this.Urutkan.Size = new System.Drawing.Size(91, 23);
            this.Urutkan.TabIndex = 3;
            this.Urutkan.Text = "URUTKAN";
            this.Urutkan.UseVisualStyleBackColor = true;
            this.Urutkan.Click += new System.EventHandler(this.Urutkan_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Russo One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(131, 297);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(242, 73);
            this.Output.TabIndex = 4;
            this.Output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(965, 608);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Urutkan);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Input);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Urutkan;
        private System.Windows.Forms.Label Output;
    }
}

