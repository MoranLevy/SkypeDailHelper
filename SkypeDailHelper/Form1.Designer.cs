namespace SkypeDailHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrigPhone = new System.Windows.Forms.TextBox();
            this.textBoxSkypePhone = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skype phone";
            // 
            // textBoxOrigPhone
            // 
            this.textBoxOrigPhone.Location = new System.Drawing.Point(129, 13);
            this.textBoxOrigPhone.Name = "textBoxOrigPhone";
            this.textBoxOrigPhone.Size = new System.Drawing.Size(157, 20);
            this.textBoxOrigPhone.TabIndex = 1;
            this.textBoxOrigPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOrigPhone_KeyDown);
            // 
            // textBoxSkypePhone
            // 
            this.textBoxSkypePhone.Location = new System.Drawing.Point(129, 39);
            this.textBoxSkypePhone.Name = "textBoxSkypePhone";
            this.textBoxSkypePhone.Size = new System.Drawing.Size(157, 20);
            this.textBoxSkypePhone.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(211, 65);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Call";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxSkypePhone);
            this.Controls.Add(this.textBoxOrigPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SkypeDailHelper 1.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrigPhone;
        private System.Windows.Forms.TextBox textBoxSkypePhone;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button button1;
    }
}

