namespace Project
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HOME = new System.Windows.Forms.Label();
            this.InstructorDetails = new System.Windows.Forms.Button();
            this.TADetails = new System.Windows.Forms.Button();
            this.LDDetails = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.AdminDetailsTable = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HOME
            // 
            this.HOME.AutoSize = true;
            this.HOME.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HOME.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME.Location = new System.Drawing.Point(434, 18);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(291, 90);
            this.HOME.TabIndex = 1;
            this.HOME.Text = "HOME";
            // 
            // InstructorDetails
            // 
            this.InstructorDetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.InstructorDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorDetails.Location = new System.Drawing.Point(94, 189);
            this.InstructorDetails.Name = "InstructorDetails";
            this.InstructorDetails.Size = new System.Drawing.Size(170, 40);
            this.InstructorDetails.TabIndex = 2;
            this.InstructorDetails.Text = "Instructor Details";
            this.InstructorDetails.UseVisualStyleBackColor = false;
            this.InstructorDetails.Click += new System.EventHandler(this.InstructorDetails_Click);
            // 
            // TADetails
            // 
            this.TADetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TADetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TADetails.Location = new System.Drawing.Point(94, 267);
            this.TADetails.Name = "TADetails";
            this.TADetails.Size = new System.Drawing.Size(170, 40);
            this.TADetails.TabIndex = 3;
            this.TADetails.Text = "TA Details";
            this.TADetails.UseVisualStyleBackColor = false;
            this.TADetails.Click += new System.EventHandler(this.TADetails_Click);
            // 
            // LDDetails
            // 
            this.LDDetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LDDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDDetails.Location = new System.Drawing.Point(94, 346);
            this.LDDetails.Name = "LDDetails";
            this.LDDetails.Size = new System.Drawing.Size(170, 40);
            this.LDDetails.TabIndex = 4;
            this.LDDetails.Text = "LD Details";
            this.LDDetails.UseVisualStyleBackColor = false;
            this.LDDetails.Click += new System.EventHandler(this.LDDetails_Click);
            // 
            // AddAccount
            // 
            this.AddAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddAccount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccount.Location = new System.Drawing.Point(94, 420);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(170, 40);
            this.AddAccount.TabIndex = 5;
            this.AddAccount.Text = "Add Account";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // AdminDetailsTable
            // 
            this.AdminDetailsTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AdminDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDetailsTable.GridColor = System.Drawing.SystemColors.Window;
            this.AdminDetailsTable.Location = new System.Drawing.Point(341, 121);
            this.AdminDetailsTable.Name = "AdminDetailsTable";
            this.AdminDetailsTable.RowHeadersWidth = 51;
            this.AdminDetailsTable.RowTemplate.Height = 24;
            this.AdminDetailsTable.Size = new System.Drawing.Size(848, 432);
            this.AdminDetailsTable.TabIndex = 6;
            this.AdminDetailsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminDetailsTable_CellContentClick);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(10, 10);
            this.logout.Margin = new System.Windows.Forms.Padding(1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(82, 30);
            this.logout.TabIndex = 135;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.AdminDetailsTable);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.LDDetails);
            this.Controls.Add(this.TADetails);
            this.Controls.Add(this.InstructorDetails);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDetailsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HOME;
        private System.Windows.Forms.Button InstructorDetails;
        private System.Windows.Forms.Button TADetails;
        private System.Windows.Forms.Button LDDetails;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.DataGridView AdminDetailsTable;
        private System.Windows.Forms.Button logout;
    }
}