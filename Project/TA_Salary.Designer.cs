namespace Project
{
    partial class TA_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TA_Salary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generate = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.backToTAView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(415, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(261, 90);
            this.Label1.TabIndex = 113;
            this.Label1.Text = "Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 256);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.generate.Location = new System.Drawing.Point(430, 406);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(219, 41);
            this.generate.TabIndex = 115;
            this.generate.Text = "Generate Salary";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(457, 489);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(0, 16);
            this.salaryLabel.TabIndex = 116;
            // 
            // backToTAView
            // 
            this.backToTAView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backToTAView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToTAView.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backToTAView.ForeColor = System.Drawing.Color.Black;
            this.backToTAView.Location = new System.Drawing.Point(10, 10);
            this.backToTAView.Margin = new System.Windows.Forms.Padding(1);
            this.backToTAView.Name = "backToTAView";
            this.backToTAView.Size = new System.Drawing.Size(40, 39);
            this.backToTAView.TabIndex = 117;
            this.backToTAView.Text = "⬅";
            this.backToTAView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backToTAView.UseVisualStyleBackColor = false;
            this.backToTAView.Click += new System.EventHandler(this.backToTAView_Click);
            // 
            // TA_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backToTAView);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TA_Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button backToTAView;
    }
}