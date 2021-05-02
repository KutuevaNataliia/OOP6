
namespace OOP6
{
    partial class FormMain : Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(659, 277);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 29);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mode1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(659, 338);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 29);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "mode2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 401);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 37);
            this.progressBar1.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}