namespace Project
{
    partial class LDDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.backfromaddaccount = new System.Windows.Forms.Button();
            this.IntDet = new System.Windows.Forms.DataGridView();
            this.AddLD = new System.Windows.Forms.Button();
            this.UpdateLD = new System.Windows.Forms.Button();
            this.DeleteLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(141, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(930, 90);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Lab Demonstrator Details";
            // 
            // backfromaddaccount
            // 
            this.backfromaddaccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromaddaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromaddaccount.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromaddaccount.ForeColor = System.Drawing.Color.Black;
            this.backfromaddaccount.Location = new System.Drawing.Point(31, 10);
            this.backfromaddaccount.Margin = new System.Windows.Forms.Padding(1);
            this.backfromaddaccount.Name = "backfromaddaccount";
            this.backfromaddaccount.Size = new System.Drawing.Size(40, 40);
            this.backfromaddaccount.TabIndex = 54;
            this.backfromaddaccount.Text = "⬅";
            this.backfromaddaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromaddaccount.UseVisualStyleBackColor = false;
            this.backfromaddaccount.Click += new System.EventHandler(this.backfromaddaccount_Click);
            // 
            // IntDet
            // 
            this.IntDet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.IntDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntDet.GridColor = System.Drawing.SystemColors.Window;
            this.IntDet.Location = new System.Drawing.Point(-1, 107);
            this.IntDet.Name = "IntDet";
            this.IntDet.RowHeadersWidth = 51;
            this.IntDet.RowTemplate.Height = 24;
            this.IntDet.Size = new System.Drawing.Size(1184, 338);
            this.IntDet.TabIndex = 55;
            this.IntDet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntDet_CellContentClick);
            // 
            // AddLD
            // 
            this.AddLD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddLD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLD.Location = new System.Drawing.Point(263, 480);
            this.AddLD.Name = "AddLD";
            this.AddLD.Size = new System.Drawing.Size(145, 40);
            this.AddLD.TabIndex = 56;
            this.AddLD.Text = "Add LD";
            this.AddLD.UseVisualStyleBackColor = false;
            this.AddLD.Click += new System.EventHandler(this.AddLD_Click);
            // 
            // UpdateLD
            // 
            this.UpdateLD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateLD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLD.Location = new System.Drawing.Point(496, 480);
            this.UpdateLD.Name = "UpdateLD";
            this.UpdateLD.Size = new System.Drawing.Size(145, 40);
            this.UpdateLD.TabIndex = 57;
            this.UpdateLD.Text = "Update LD";
            this.UpdateLD.UseVisualStyleBackColor = false;
            this.UpdateLD.Click += new System.EventHandler(this.UpdateLD_Click);
            // 
            // DeleteLD
            // 
            this.DeleteLD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteLD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLD.Location = new System.Drawing.Point(742, 480);
            this.DeleteLD.Name = "DeleteLD";
            this.DeleteLD.Size = new System.Drawing.Size(145, 40);
            this.DeleteLD.TabIndex = 58;
            this.DeleteLD.Text = "Delete LD";
            this.DeleteLD.UseVisualStyleBackColor = false;
            this.DeleteLD.Click += new System.EventHandler(this.DeleteLD_Click);
            // 
            // LDDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.DeleteLD);
            this.Controls.Add(this.UpdateLD);
            this.Controls.Add(this.AddLD);
            this.Controls.Add(this.IntDet);
            this.Controls.Add(this.backfromaddaccount);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LDDetails";
            this.Text = "LDDetails";
            this.Load += new System.EventHandler(this.LDDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button backfromaddaccount;
        private System.Windows.Forms.DataGridView IntDet;
        private System.Windows.Forms.Button AddLD;
        private System.Windows.Forms.Button UpdateLD;
        private System.Windows.Forms.Button DeleteLD;
    }
}