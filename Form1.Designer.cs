namespace Fractal
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
            this.Fractal_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fractal_2 = new System.Windows.Forms.Button();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.clear_Button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Fractal_1
            // 
            this.Fractal_1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fractal_1.Location = new System.Drawing.Point(44, 52);
            this.Fractal_1.Name = "Fractal_1";
            this.Fractal_1.Size = new System.Drawing.Size(183, 71);
            this.Fractal_1.TabIndex = 0;
            this.Fractal_1.Text = "Треугольник Серпинского";
            this.Fractal_1.UseVisualStyleBackColor = true;
            this.Fractal_1.Click += new System.EventHandler(this.Fractal_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фрактал";
            // 
            // Fractal_2
            // 
            this.Fractal_2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Fractal_2.Location = new System.Drawing.Point(772, 52);
            this.Fractal_2.Name = "Fractal_2";
            this.Fractal_2.Size = new System.Drawing.Size(197, 71);
            this.Fractal_2.TabIndex = 2;
            this.Fractal_2.Text = "Снежинка Коха";
            this.Fractal_2.UseVisualStyleBackColor = true;
            this.Fractal_2.Click += new System.EventHandler(this.Fractal_2_Click);
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.Location = new System.Drawing.Point(267, 171);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(466, 393);
            this.FractalPictureBox.TabIndex = 3;
            this.FractalPictureBox.TabStop = false;
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(319, 597);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(320, 23);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Стереть все";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(809, 151);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 632);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.FractalPictureBox);
            this.Controls.Add(this.Fractal_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fractal_1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fractal_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fractal_2;
        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}