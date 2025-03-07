namespace Project
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.backfromattendance = new System.Windows.Forms.Button();
            this.AttendanceGrid = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddAttendance = new System.Windows.Forms.Button();
            this.attend = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.MaskedTextBox();
            this.dt = new System.Windows.Forms.MaskedTextBox();
            this.FirstName = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backfromattendance
            // 
            this.backfromattendance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromattendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromattendance.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromattendance.ForeColor = System.Drawing.Color.Black;
            this.backfromattendance.Location = new System.Drawing.Point(10, 10);
            this.backfromattendance.Margin = new System.Windows.Forms.Padding(1);
            this.backfromattendance.Name = "backfromattendance";
            this.backfromattendance.Size = new System.Drawing.Size(40, 40);
            this.backfromattendance.TabIndex = 151;
            this.backfromattendance.Text = "⬅";
            this.backfromattendance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromattendance.UseVisualStyleBackColor = false;
            this.backfromattendance.Click += new System.EventHandler(this.backfromattendance_Click);
            // 
            // AttendanceGrid
            // 
            this.AttendanceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceGrid.Location = new System.Drawing.Point(-4, 116);
            this.AttendanceGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceGrid.Name = "AttendanceGrid";
            this.AttendanceGrid.RowHeadersWidth = 51;
            this.AttendanceGrid.Size = new System.Drawing.Size(637, 439);
            this.AttendanceGrid.TabIndex = 150;
            this.AttendanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceGrid_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(345, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(430, 90);
            this.Label1.TabIndex = 149;
            this.Label1.Text = "Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-18, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // AddAttendance
            // 
            this.AddAttendance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddAttendance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.AddAttendance.Location = new System.Drawing.Point(813, 398);
            this.AddAttendance.Name = "AddAttendance";
            this.AddAttendance.Size = new System.Drawing.Size(155, 38);
            this.AddAttendance.TabIndex = 152;
            this.AddAttendance.Text = "Add Attendance";
            this.AddAttendance.UseVisualStyleBackColor = false;
            this.AddAttendance.Click += new System.EventHandler(this.AddAttendance_Click);
            // 
            // attend
            // 
            this.attend.AutoSize = true;
            this.attend.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.attend.Location = new System.Drawing.Point(678, 326);
            this.attend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attend.Name = "attend";
            this.attend.Size = new System.Drawing.Size(128, 25);
            this.attend.TabIndex = 158;
            this.attend.Text = "Attendance";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(672, 281);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(60, 25);
            this.date.TabIndex = 157;
            this.date.Text = "Date";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(675, 237);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 25);
            this.name.TabIndex = 156;
            this.name.Text = "Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(843, 326);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(303, 22);
            this.Email.TabIndex = 155;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(843, 281);
            this.dt.Margin = new System.Windows.Forms.Padding(4);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(303, 22);
            this.dt.TabIndex = 154;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(843, 237);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(303, 22);
            this.FirstName.TabIndex = 153;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.attend);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.AddAttendance);
            this.Controls.Add(this.backfromattendance);
            this.Controls.Add(this.AttendanceGrid);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backfromattendance;
        private System.Windows.Forms.DataGridView AttendanceGrid;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddAttendance;
        private System.Windows.Forms.Label attend;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.MaskedTextBox Email;
        private System.Windows.Forms.MaskedTextBox dt;
        private System.Windows.Forms.MaskedTextBox FirstName;
    }
}