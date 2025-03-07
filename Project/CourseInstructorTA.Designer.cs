namespace Project
{
    partial class CourseInstructorTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInstructorTA));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backfromctTA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 289);
            this.dataGridView1.TabIndex = 130;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(240, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(605, 90);
            this.Label1.TabIndex = 129;
            this.Label1.Text = "Assistant Details";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-30, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // backfromctTA
            // 
            this.backfromctTA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromctTA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromctTA.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromctTA.ForeColor = System.Drawing.Color.Black;
            this.backfromctTA.Location = new System.Drawing.Point(10, 10);
            this.backfromctTA.Margin = new System.Windows.Forms.Padding(1);
            this.backfromctTA.Name = "backfromctTA";
            this.backfromctTA.Size = new System.Drawing.Size(40, 40);
            this.backfromctTA.TabIndex = 131;
            this.backfromctTA.Text = "⬅";
            this.backfromctTA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromctTA.UseVisualStyleBackColor = false;
            this.backfromctTA.Click += new System.EventHandler(this.backfromctTA_Click);
            // 
            // CourseInstructorTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfromctTA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseInstructorTA";
            this.Text = "CourseInstructorTA";
            this.Load += new System.EventHandler(this.CourseInstructorTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backfromctTA;
    }
}