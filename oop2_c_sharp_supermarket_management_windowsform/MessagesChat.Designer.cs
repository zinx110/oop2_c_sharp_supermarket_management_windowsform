﻿
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class MessagesChat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.messagesBox = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 64);
            this.panel1.TabIndex = 0;
            // 
            // messagesBox
            // 
            this.messagesBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.messagesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesBox.Location = new System.Drawing.Point(0, 0);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.Size = new System.Drawing.Size(550, 616);
            this.messagesBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Location = new System.Drawing.Point(388, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(162, 64);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 64);
            this.textBox1.TabIndex = 1;
            // 
            // MessagesChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 680);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagesChat";
            this.Text = "MessagesChat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Panel messagesBox;
    }
}