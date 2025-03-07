namespace Project
{
    partial class DeleteAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAttendance));
            this.AttendanceGrid = new System.Windows.Forms.DataGridView();
            this.backfromcreateaccount = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceGrid
            // 
            this.AttendanceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceGrid.Location = new System.Drawing.Point(-5, 121);
            this.AttendanceGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AttendanceGrid.Name = "AttendanceGrid";
            this.AttendanceGrid.RowHeadersWidth = 51;
            this.AttendanceGrid.Size = new System.Drawing.Size(639, 435);
            this.AttendanceGrid.TabIndex = 161;
            // 
            // backfromcreateaccount
            // 
            this.backfromcreateaccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromcreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromcreateaccount.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromcreateaccount.ForeColor = System.Drawing.Color.Black;
            this.backfromcreateaccount.Location = new System.Drawing.Point(10, 6);
            this.backfromcreateaccount.Margin = new System.Windows.Forms.Padding(1);
            this.backfromcreateaccount.Name = "backfromcreateaccount";
            this.backfromcreateaccount.Size = new System.Drawing.Size(40, 40);
            this.backfromcreateaccount.TabIndex = 159;
            this.backfromcreateaccount.Text = "⬅";
            this.backfromcreateaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromcreateaccount.UseVisualStyleBackColor = false;
            this.backfromcreateaccount.Click += new System.EventHandler(this.backfromcreateaccount_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Update.Location = new System.Drawing.Point(801, 315);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(172, 43);
            this.Update.TabIndex = 158;
            this.Update.Text = "Delete";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 156;
            this.label2.Text = "Date";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(843, 256);
            this.d.Margin = new System.Windows.Forms.Padding(4);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(303, 22);
            this.d.TabIndex = 154;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(234, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(661, 90);
            this.Label1.TabIndex = 153;
            this.Label1.Text = "Delete Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.AttendanceGrid);
            this.Controls.Add(this.backfromcreateaccount);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAttendance";
            this.Text = "DeleteAttendance";
            this.Load += new System.EventHandler(this.DeleteAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AttendanceGrid;
        private System.Windows.Forms.Button backfromcreateaccount;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox d;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}