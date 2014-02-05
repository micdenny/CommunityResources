namespace MessageBrokerInWindowsForms
{
    partial class Form2
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
            this.sendSomethingDifferentButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendSomethingDifferentButton
            // 
            this.sendSomethingDifferentButton.Location = new System.Drawing.Point(25, 34);
            this.sendSomethingDifferentButton.Name = "sendSomethingDifferentButton";
            this.sendSomethingDifferentButton.Size = new System.Drawing.Size(201, 23);
            this.sendSomethingDifferentButton.TabIndex = 2;
            this.sendSomethingDifferentButton.Text = "Send Something Different";
            this.sendSomethingDifferentButton.UseVisualStyleBackColor = true;
            this.sendSomethingDifferentButton.Click += new System.EventHandler(this.sendSomethingDifferentButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendSomethingDifferentButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendSomethingDifferentButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}