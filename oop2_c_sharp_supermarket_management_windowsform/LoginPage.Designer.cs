
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class LoginPage
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
            this.pageHeaderContainer = new System.Windows.Forms.Panel();
            this.pageHeaderLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBoxLabel = new System.Windows.Forms.Label();
            this.usernameTextBoxLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.textBoxContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pageHeaderContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.textBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeaderContainer
            // 
            this.pageHeaderContainer.Controls.Add(this.pageHeaderLabel);
            this.pageHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.pageHeaderContainer.Name = "pageHeaderContainer";
            this.pageHeaderContainer.Size = new System.Drawing.Size(588, 100);
            this.pageHeaderContainer.TabIndex = 0;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageHeaderLabel.AutoSize = true;
            this.pageHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageHeaderLabel.Location = new System.Drawing.Point(225, 24);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Size = new System.Drawing.Size(127, 54);
            this.pageHeaderLabel.TabIndex = 1;
            this.pageHeaderLabel.Text = "Login";
            this.pageHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(60, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(427, 27);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(89, 45);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.loginButton);
            this.buttonsContainer.Controls.Add(this.exitButton);
            this.buttonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsContainer.Location = new System.Drawing.Point(0, 424);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(588, 100);
            this.buttonsContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBoxLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBoxLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(165, 96);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(372, 32);
            this.passwordTextBox.TabIndex = 5;
            // 
            // passwordTextBoxLabel
            // 
            this.passwordTextBoxLabel.AccessibleName = "";
            this.passwordTextBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBoxLabel.AutoSize = true;
            this.passwordTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBoxLabel.Location = new System.Drawing.Point(25, 97);
            this.passwordTextBoxLabel.Name = "passwordTextBoxLabel";
            this.passwordTextBoxLabel.Size = new System.Drawing.Size(112, 30);
            this.passwordTextBoxLabel.TabIndex = 3;
            this.passwordTextBoxLabel.Text = "Password";
            this.passwordTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBoxLabel
            // 
            this.usernameTextBoxLabel.AccessibleName = "";
            this.usernameTextBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBoxLabel.AutoSize = true;
            this.usernameTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBoxLabel.Location = new System.Drawing.Point(22, 22);
            this.usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            this.usernameTextBoxLabel.Size = new System.Drawing.Size(117, 30);
            this.usernameTextBoxLabel.TabIndex = 2;
            this.usernameTextBoxLabel.Text = "Username";
            this.usernameTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(165, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(372, 32);
            this.usernameTextBox.TabIndex = 4;
            // 
            // textBoxContainer
            // 
            this.textBoxContainer.Controls.Add(this.button4);
            this.textBoxContainer.Controls.Add(this.button3);
            this.textBoxContainer.Controls.Add(this.button2);
            this.textBoxContainer.Controls.Add(this.button1);
            this.textBoxContainer.Controls.Add(this.tableLayoutPanel1);
            this.textBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContainer.Location = new System.Drawing.Point(0, 100);
            this.textBoxContainer.Name = "textBoxContainer";
            this.textBoxContainer.Size = new System.Drawing.Size(588, 424);
            this.textBoxContainer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(26, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(112, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "inventory manager";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(285, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "supervisor";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(427, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "checkout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 524);
            this.Controls.Add(this.buttonsContainer);
            this.Controls.Add(this.textBoxContainer);
            this.Controls.Add(this.pageHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pageHeaderContainer.ResumeLayout(false);
            this.pageHeaderContainer.PerformLayout();
            this.buttonsContainer.ResumeLayout(false);
            this.buttonsContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.textBoxContainer.ResumeLayout(false);
            this.textBoxContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageHeaderContainer;
        private System.Windows.Forms.Label pageHeaderLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel buttonsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label passwordTextBoxLabel;
        private System.Windows.Forms.Label usernameTextBoxLabel;
        private System.Windows.Forms.Panel textBoxContainer;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}