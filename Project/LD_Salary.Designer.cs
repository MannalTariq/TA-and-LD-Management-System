﻿namespace Project
{
    partial class LD_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LD_Salary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backToLDView = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LDSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-53, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.Label1.Location = new System.Drawing.Point(401, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(261, 90);
            this.Label1.TabIndex = 114;
            this.Label1.Text = "Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 256);
            this.dataGridView1.TabIndex = 115;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backToLDView
            // 
            this.backToLDView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backToLDView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToLDView.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backToLDView.ForeColor = System.Drawing.Color.Black;
            this.backToLDView.Location = new System.Drawing.Point(10, 10);
            this.backToLDView.Margin = new System.Windows.Forms.Padding(1);
            this.backToLDView.Name = "backToLDView";
            this.backToLDView.Size = new System.Drawing.Size(40, 39);
            this.backToLDView.TabIndex = 117;
            this.backToLDView.Text = "⬅";
            this.backToLDView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backToLDView.UseVisualStyleBackColor = false;
            this.backToLDView.Click += new System.EventHandler(this.backToLDView_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.generate.Location = new System.Drawing.Point(419, 422);
            this.generate.Margin = new System.Windows.Forms.Padding(4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(219, 41);
            this.generate.TabIndex = 118;
            this.generate.Text = "Generate Salary";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 507);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 119;
            // 
            // LDSalary
            // 
            this.LDSalary.AutoSize = true;
            this.LDSalary.Location = new System.Drawing.Point(508, 491);
            this.LDSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDSalary.Name = "LDSalary";
            this.LDSalary.Size = new System.Drawing.Size(0, 16);
            this.LDSalary.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 121;
            // 
            // LD_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LDSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.backToLDView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LD_Salary";
            this.Text = "LD_Salary";
            this.Load += new System.EventHandler(this.LD_Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backToLDView;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LDSalary;
        private System.Windows.Forms.Label label3;
    }
}