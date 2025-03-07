namespace Project
{
    partial class CourseInstructorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInstructorView));
            this.viewTasks = new System.Windows.Forms.Button();
            this.viewSection = new System.Windows.Forms.Button();
            this.viewTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backfromCourseIntView = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewTasks
            // 
            this.viewTasks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewTasks.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTasks.Location = new System.Drawing.Point(31, 423);
            this.viewTasks.Margin = new System.Windows.Forms.Padding(4);
            this.viewTasks.Name = "viewTasks";
            this.viewTasks.Size = new System.Drawing.Size(205, 41);
            this.viewTasks.TabIndex = 130;
            this.viewTasks.Text = "Assistant Tasks";
            this.viewTasks.UseVisualStyleBackColor = false;
            this.viewTasks.Click += new System.EventHandler(this.viewTasks_Click);
            // 
            // viewSection
            // 
            this.viewSection.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewSection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSection.Location = new System.Drawing.Point(31, 204);
            this.viewSection.Margin = new System.Windows.Forms.Padding(4);
            this.viewSection.Name = "viewSection";
            this.viewSection.Size = new System.Drawing.Size(205, 43);
            this.viewSection.TabIndex = 129;
            this.viewSection.Text = "View Section";
            this.viewSection.UseVisualStyleBackColor = false;
            this.viewSection.Click += new System.EventHandler(this.viewSection_Click);
            // 
            // viewTask
            // 
            this.viewTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTask.Location = new System.Drawing.Point(31, 315);
            this.viewTask.Margin = new System.Windows.Forms.Padding(4);
            this.viewTask.Name = "viewTask";
            this.viewTask.Size = new System.Drawing.Size(205, 43);
            this.viewTask.TabIndex = 128;
            this.viewTask.Text = "View TA Details";
            this.viewTask.UseVisualStyleBackColor = false;
            this.viewTask.Click += new System.EventHandler(this.viewTA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(908, 438);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backfromCourseIntView
            // 
            this.backfromCourseIntView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromCourseIntView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromCourseIntView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backfromCourseIntView.ForeColor = System.Drawing.Color.Black;
            this.backfromCourseIntView.Location = new System.Drawing.Point(21, 12);
            this.backfromCourseIntView.Margin = new System.Windows.Forms.Padding(1);
            this.backfromCourseIntView.Name = "backfromCourseIntView";
            this.backfromCourseIntView.Size = new System.Drawing.Size(76, 39);
            this.backfromCourseIntView.TabIndex = 126;
            this.backfromCourseIntView.Text = "Logout";
            this.backfromCourseIntView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromCourseIntView.UseVisualStyleBackColor = false;
            this.backfromCourseIntView.Click += new System.EventHandler(this.backfromCourseIntView_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(401, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(241, 90);
            this.Label1.TabIndex = 125;
            this.Label1.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // CourseInstructorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.viewTasks);
            this.Controls.Add(this.viewSection);
            this.Controls.Add(this.viewTask);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backfromCourseIntView);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseInstructorView";
            this.Text = "CourseInstructorView";
            this.Load += new System.EventHandler(this.CourseInstructorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewTasks;
        private System.Windows.Forms.Button viewSection;
        private System.Windows.Forms.Button viewTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backfromCourseIntView;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}