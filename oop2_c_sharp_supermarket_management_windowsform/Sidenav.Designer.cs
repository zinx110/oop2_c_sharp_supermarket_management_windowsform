
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class Sidenav
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.allUserButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.addUserButton);
            this.panel1.Controls.Add(this.editUserButton);
            this.panel1.Controls.Add(this.allUserButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 477);
            this.panel1.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addUserButton.Location = new System.Drawing.Point(0, 120);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(5);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(265, 60);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editUserButton.Location = new System.Drawing.Point(0, 60);
            this.editUserButton.Margin = new System.Windows.Forms.Padding(5);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(265, 60);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = false;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // allUserButton
            // 
            this.allUserButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.allUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allUserButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allUserButton.Location = new System.Drawing.Point(0, 0);
            this.allUserButton.Margin = new System.Windows.Forms.Padding(5);
            this.allUserButton.Name = "allUserButton";
            this.allUserButton.Size = new System.Drawing.Size(265, 60);
            this.allUserButton.TabIndex = 0;
            this.allUserButton.Text = "All Users";
            this.allUserButton.UseVisualStyleBackColor = false;
            this.allUserButton.Click += new System.EventHandler(this.allUserButton_Click);
            // 
            // Sidenav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sidenav";
            this.Text = "Sidenav";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
    }
}