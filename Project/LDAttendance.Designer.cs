namespace Project
{
    partial class LDAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDAttendance));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backfromLDView = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 303);
            this.dataGridView1.TabIndex = 126;
            // 
            // backfromLDView
            // 
            this.backfromLDView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromLDView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromLDView.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromLDView.ForeColor = System.Drawing.Color.Black;
            this.backfromLDView.Location = new System.Drawing.Point(10, 10);
            this.backfromLDView.Margin = new System.Windows.Forms.Padding(1);
            this.backfromLDView.Name = "backfromLDView";
            this.backfromLDView.Size = new System.Drawing.Size(40, 40);
            this.backfromLDView.TabIndex = 125;
            this.backfromLDView.Text = "⬅";
            this.backfromLDView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromLDView.UseVisualStyleBackColor = false;
            this.backfromLDView.Click += new System.EventHandler(this.backfromLDView_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(325, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(430, 90);
            this.Label1.TabIndex = 124;
            this.Label1.Text = "Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-64, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // LDAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backfromLDView);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LDAttendance";
            this.Text = "LDAttendance";
            this.Load += new System.EventHandler(this.LDAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backfromLDView;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}