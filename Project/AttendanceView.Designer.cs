namespace Project
{
    partial class AttendanceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceView));
            this.AttendanceGrid = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backfromattendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceGrid
            // 
            this.AttendanceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceGrid.Location = new System.Drawing.Point(-4, 116);
            this.AttendanceGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceGrid.Name = "AttendanceGrid";
            this.AttendanceGrid.RowHeadersWidth = 51;
            this.AttendanceGrid.Size = new System.Drawing.Size(1189, 283);
            this.AttendanceGrid.TabIndex = 142;
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
            this.Label1.TabIndex = 140;
            this.Label1.Text = "Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-18, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
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
            this.backfromattendance.TabIndex = 147;
            this.backfromattendance.Text = "⬅";
            this.backfromattendance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromattendance.UseVisualStyleBackColor = false;
            this.backfromattendance.Click += new System.EventHandler(this.backfromattendance_Click);
            // 
            // AttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfromattendance);
            this.Controls.Add(this.AttendanceGrid);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceView";
            this.Text = "AttendanceView";
            this.Load += new System.EventHandler(this.AttendanceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AttendanceGrid;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backfromattendance;
    }
}