namespace Project
{
    partial class TA_Tasks_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TA_Tasks_View));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.backfromcreateaccount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(251, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(554, 90);
            this.Label1.TabIndex = 114;
            this.Label1.Text = "Assigned Tasks";
            // 
            // backfromcreateaccount
            // 
            this.backfromcreateaccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromcreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromcreateaccount.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromcreateaccount.ForeColor = System.Drawing.Color.Black;
            this.backfromcreateaccount.Location = new System.Drawing.Point(10, 10);
            this.backfromcreateaccount.Margin = new System.Windows.Forms.Padding(1);
            this.backfromcreateaccount.Name = "backfromcreateaccount";
            this.backfromcreateaccount.Size = new System.Drawing.Size(40, 39);
            this.backfromcreateaccount.TabIndex = 116;
            this.backfromcreateaccount.Text = "⬅";
            this.backfromcreateaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromcreateaccount.UseVisualStyleBackColor = false;
            this.backfromcreateaccount.Click += new System.EventHandler(this.backfromcreateaccount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 283);
            this.dataGridView1.TabIndex = 115;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TA_Tasks_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.backfromcreateaccount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TA_Tasks_View";
            this.Text = "TA_Tasks_View";
            this.Load += new System.EventHandler(this.TA_Tasks_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button backfromcreateaccount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}