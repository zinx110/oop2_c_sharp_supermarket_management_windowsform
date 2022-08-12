
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class AdminPageEditUserPanel
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addressTextBoxLabel = new System.Windows.Forms.Label();
            this.genderTextBoxLabel = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBoxLabel = new System.Windows.Forms.Label();
            this.usernameTextBoxLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.confiemPasswordTextBoxLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBoxLabel = new System.Windows.Forms.Label();
            this.salaryTextBoxLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PageHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 680);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteButton);
            this.panel5.Controls.Add(this.editUserButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 620);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 60);
            this.panel5.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 60);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.editUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserButton.Location = new System.Drawing.Point(560, 0);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(190, 60);
            this.editUserButton.TabIndex = 8;
            this.editUserButton.Text = "Edit";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 580);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.addressTextBoxLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.genderTextBoxLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.roleTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBoxLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBoxLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.confiemPasswordTextBoxLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.roleTextBoxLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.salaryTextBoxLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.salaryTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.genderTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.addressTextBox, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 412);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // addressTextBoxLabel
            // 
            this.addressTextBoxLabel.AccessibleName = "";
            this.addressTextBoxLabel.AutoSize = true;
            this.addressTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressTextBoxLabel.Location = new System.Drawing.Point(3, 348);
            this.addressTextBoxLabel.Name = "addressTextBoxLabel";
            this.addressTextBoxLabel.Size = new System.Drawing.Size(97, 64);
            this.addressTextBoxLabel.TabIndex = 15;
            this.addressTextBoxLabel.Text = "Address";
            this.addressTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderTextBoxLabel
            // 
            this.genderTextBoxLabel.AccessibleName = "";
            this.genderTextBoxLabel.AutoSize = true;
            this.genderTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.genderTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderTextBoxLabel.Location = new System.Drawing.Point(3, 290);
            this.genderTextBoxLabel.Name = "genderTextBoxLabel";
            this.genderTextBoxLabel.Size = new System.Drawing.Size(89, 58);
            this.genderTextBoxLabel.TabIndex = 12;
            this.genderTextBoxLabel.Text = "Gender";
            this.genderTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleTextBox
            // 
            this.roleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roleTextBox.Location = new System.Drawing.Point(270, 187);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(372, 32);
            this.roleTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(270, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(372, 32);
            this.passwordTextBox.TabIndex = 5;
            // 
            // passwordTextBoxLabel
            // 
            this.passwordTextBoxLabel.AccessibleName = "";
            this.passwordTextBoxLabel.AutoSize = true;
            this.passwordTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.passwordTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBoxLabel.Location = new System.Drawing.Point(3, 58);
            this.passwordTextBoxLabel.Name = "passwordTextBoxLabel";
            this.passwordTextBoxLabel.Size = new System.Drawing.Size(112, 58);
            this.passwordTextBoxLabel.TabIndex = 3;
            this.passwordTextBoxLabel.Text = "Password";
            this.passwordTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBoxLabel
            // 
            this.usernameTextBoxLabel.AccessibleName = "";
            this.usernameTextBoxLabel.AutoSize = true;
            this.usernameTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBoxLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            this.usernameTextBoxLabel.Size = new System.Drawing.Size(117, 58);
            this.usernameTextBoxLabel.TabIndex = 2;
            this.usernameTextBoxLabel.Text = "Username";
            this.usernameTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(270, 13);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(372, 32);
            this.usernameTextBox.TabIndex = 4;
            // 
            // confiemPasswordTextBoxLabel
            // 
            this.confiemPasswordTextBoxLabel.AccessibleName = "";
            this.confiemPasswordTextBoxLabel.AutoSize = true;
            this.confiemPasswordTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.confiemPasswordTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confiemPasswordTextBoxLabel.Location = new System.Drawing.Point(3, 116);
            this.confiemPasswordTextBoxLabel.Name = "confiemPasswordTextBoxLabel";
            this.confiemPasswordTextBoxLabel.Size = new System.Drawing.Size(201, 58);
            this.confiemPasswordTextBoxLabel.TabIndex = 6;
            this.confiemPasswordTextBoxLabel.Text = "Confirm Password";
            this.confiemPasswordTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(270, 129);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(372, 32);
            this.confirmPasswordTextBox.TabIndex = 7;
            // 
            // roleTextBoxLabel
            // 
            this.roleTextBoxLabel.AccessibleName = "";
            this.roleTextBoxLabel.AutoSize = true;
            this.roleTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.roleTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roleTextBoxLabel.Location = new System.Drawing.Point(3, 174);
            this.roleTextBoxLabel.Name = "roleTextBoxLabel";
            this.roleTextBoxLabel.Size = new System.Drawing.Size(57, 58);
            this.roleTextBoxLabel.TabIndex = 8;
            this.roleTextBoxLabel.Text = "Role";
            this.roleTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryTextBoxLabel
            // 
            this.salaryTextBoxLabel.AccessibleName = "";
            this.salaryTextBoxLabel.AutoSize = true;
            this.salaryTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.salaryTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salaryTextBoxLabel.Location = new System.Drawing.Point(3, 232);
            this.salaryTextBoxLabel.Name = "salaryTextBoxLabel";
            this.salaryTextBoxLabel.Size = new System.Drawing.Size(77, 58);
            this.salaryTextBoxLabel.TabIndex = 9;
            this.salaryTextBoxLabel.Text = "Salary";
            this.salaryTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salaryTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salaryTextBox.Location = new System.Drawing.Point(270, 245);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(372, 32);
            this.salaryTextBox.TabIndex = 10;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderTextBox.Location = new System.Drawing.Point(270, 303);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(372, 32);
            this.genderTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTextBox.Location = new System.Drawing.Point(270, 364);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(372, 32);
            this.addressTextBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PageHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 100);
            this.panel2.TabIndex = 0;
            // 
            // PageHeader
            // 
            this.PageHeader.AccessibleName = "";
            this.PageHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageHeader.AutoSize = true;
            this.PageHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageHeader.Location = new System.Drawing.Point(292, 33);
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Size = new System.Drawing.Size(107, 30);
            this.PageHeader.TabIndex = 3;
            this.PageHeader.Text = "Edit User";
            this.PageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPageEditUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPageEditUserPanel";
            this.Text = "AdminPageEditUserPanel";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label addressTextBoxLabel;
        private System.Windows.Forms.Label genderTextBoxLabel;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordTextBoxLabel;
        private System.Windows.Forms.Label usernameTextBoxLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label confiemPasswordTextBoxLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label roleTextBoxLabel;
        private System.Windows.Forms.Label salaryTextBoxLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PageHeader;
        private System.Windows.Forms.Button deleteButton;
    }
}