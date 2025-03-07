namespace Project
{
    partial class CourseInstructorTATasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInstructorTATasks));
            this.backfromctsec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backfromctsec
            // 
            this.backfromctsec.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromctsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromctsec.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromctsec.ForeColor = System.Drawing.Color.Black;
            this.backfromctsec.Location = new System.Drawing.Point(10, 10);
            this.backfromctsec.Margin = new System.Windows.Forms.Padding(1);
            this.backfromctsec.Name = "backfromctsec";
            this.backfromctsec.Size = new System.Drawing.Size(40, 40);
            this.backfromctsec.TabIndex = 128;
            this.backfromctsec.Text = "⬅";
            this.backfromctsec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromctsec.UseVisualStyleBackColor = false;
            this.backfromctsec.Click += new System.EventHandler(this.backfromctsec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 270);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(297, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(559, 90);
            this.Label1.TabIndex = 126;
            this.Label1.Text = "Assistant Tasks";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-30, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTask.Location = new System.Drawing.Point(438, 451);
            this.AddTask.Margin = new System.Windows.Forms.Padding(4);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(205, 43);
            this.AddTask.TabIndex = 130;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = false;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // CourseInstructorTATasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.backfromctsec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseInstructorTATasks";
            this.Text = "CourseInstructorTATasks";
            this.Load += new System.EventHandler(this.CourseInstructorTATasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backfromctsec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddTask;
    }
}