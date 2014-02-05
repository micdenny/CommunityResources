namespace MessageBrokerInWindowsForms
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
            this.openForm2Button = new System.Windows.Forms.Button();
            this.sendSomethingButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openForm2Button
            // 
            this.openForm2Button.Location = new System.Drawing.Point(32, 36);
            this.openForm2Button.Name = "openForm2Button";
            this.openForm2Button.Size = new System.Drawing.Size(111, 23);
            this.openForm2Button.TabIndex = 0;
            this.openForm2Button.Text = "Open Form2";
            this.openForm2Button.UseVisualStyleBackColor = true;
            this.openForm2Button.Click += new System.EventHandler(this.openForm2Button_Click);
            // 
            // sendSomethingButton
            // 
            this.sendSomethingButton.Location = new System.Drawing.Point(32, 86);
            this.sendSomethingButton.Name = "sendSomethingButton";
            this.sendSomethingButton.Size = new System.Drawing.Size(132, 23);
            this.sendSomethingButton.TabIndex = 1;
            this.sendSomethingButton.Text = "Send Something";
            this.sendSomethingButton.UseVisualStyleBackColor = true;
            this.sendSomethingButton.Click += new System.EventHandler(this.sendSomethingButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendSomethingButton);
            this.Controls.Add(this.openForm2Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openForm2Button;
        private System.Windows.Forms.Button sendSomethingButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

