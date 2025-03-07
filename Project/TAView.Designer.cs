namespace Project
{
    partial class TAView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.viewTask = new System.Windows.Forms.Button();
            this.viewSection = new System.Windows.Forms.Button();
            this.viewSalary = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backfromTAView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-63, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(361, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(241, 90);
            this.Label1.TabIndex = 112;
            this.Label1.Text = "Home";
            // 
            // viewTask
            // 
            this.viewTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTask.Location = new System.Drawing.Point(55, 212);
            this.viewTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewTask.Name = "viewTask";
            this.viewTask.Size = new System.Drawing.Size(173, 46);
            this.viewTask.TabIndex = 113;
            this.viewTask.Text = "View Task";
            this.viewTask.UseVisualStyleBackColor = false;
            this.viewTask.Click += new System.EventHandler(this.viewTask_Click);
            // 
            // viewSection
            // 
            this.viewSection.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewSection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSection.Location = new System.Drawing.Point(55, 298);
            this.viewSection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewSection.Name = "viewSection";
            this.viewSection.Size = new System.Drawing.Size(173, 46);
            this.viewSection.TabIndex = 114;
            this.viewSection.Text = "View Section";
            this.viewSection.UseVisualStyleBackColor = false;
            this.viewSection.Click += new System.EventHandler(this.viewSection_Click);
            // 
            // viewSalary
            // 
            this.viewSalary.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalary.Location = new System.Drawing.Point(55, 398);
            this.viewSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewSalary.Name = "viewSalary";
            this.viewSalary.Size = new System.Drawing.Size(173, 43);
            this.viewSalary.TabIndex = 115;
            this.viewSalary.Text = "View salary";
            this.viewSalary.UseVisualStyleBackColor = false;
            this.viewSalary.Click += new System.EventHandler(this.viewSalary_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(279, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(901, 436);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backfromTAView
            // 
            this.backfromTAView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromTAView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromTAView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backfromTAView.ForeColor = System.Drawing.Color.Black;
            this.backfromTAView.Location = new System.Drawing.Point(13, 12);
            this.backfromTAView.Margin = new System.Windows.Forms.Padding(1);
            this.backfromTAView.Name = "backfromTAView";
            this.backfromTAView.Size = new System.Drawing.Size(100, 28);
            this.backfromTAView.TabIndex = 118;
            this.backfromTAView.Text = "Logout";
            this.backfromTAView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromTAView.UseVisualStyleBackColor = false;
            this.backfromTAView.Click += new System.EventHandler(this.backfromTAView_Click);
            // 
            // TAView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.backfromTAView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewSalary);
            this.Controls.Add(this.viewSection);
            this.Controls.Add(this.viewTask);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TAView";
            this.Text = "TAView";
            this.Load += new System.EventHandler(this.TAView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button viewTask;
        private System.Windows.Forms.Button viewSection;
        private System.Windows.Forms.Button viewSalary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backfromTAView;
    }
}