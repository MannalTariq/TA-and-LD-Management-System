namespace Project
{
    partial class TADetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TADetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.IntDet = new System.Windows.Forms.DataGridView();
            this.AddTA = new System.Windows.Forms.Button();
            this.UpdateTA = new System.Windows.Forms.Button();
            this.DeleteTA = new System.Windows.Forms.Button();
            this.backfromaddaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(183, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(894, 90);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Teacher Assistant Details";
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
            this.IntDet.TabIndex = 11;
            // 
            // AddTA
            // 
            this.AddTA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddTA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTA.Location = new System.Drawing.Point(267, 487);
            this.AddTA.Name = "AddTA";
            this.AddTA.Size = new System.Drawing.Size(145, 40);
            this.AddTA.TabIndex = 12;
            this.AddTA.Text = "Add TA";
            this.AddTA.UseVisualStyleBackColor = false;
            this.AddTA.Click += new System.EventHandler(this.AddTA_Click);
            // 
            // UpdateTA
            // 
            this.UpdateTA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateTA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTA.Location = new System.Drawing.Point(504, 487);
            this.UpdateTA.Name = "UpdateTA";
            this.UpdateTA.Size = new System.Drawing.Size(145, 40);
            this.UpdateTA.TabIndex = 13;
            this.UpdateTA.Text = "Update TA";
            this.UpdateTA.UseVisualStyleBackColor = false;
            this.UpdateTA.Click += new System.EventHandler(this.UpdateTA_Click);
            // 
            // DeleteTA
            // 
            this.DeleteTA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteTA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTA.Location = new System.Drawing.Point(750, 487);
            this.DeleteTA.Name = "DeleteTA";
            this.DeleteTA.Size = new System.Drawing.Size(145, 40);
            this.DeleteTA.TabIndex = 14;
            this.DeleteTA.Text = "Delete TA";
            this.DeleteTA.UseVisualStyleBackColor = false;
            this.DeleteTA.Click += new System.EventHandler(this.DeleteTA_Click);
            // 
            // backfromaddaccount
            // 
            this.backfromaddaccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromaddaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromaddaccount.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromaddaccount.ForeColor = System.Drawing.Color.Black;
            this.backfromaddaccount.Location = new System.Drawing.Point(21, 10);
            this.backfromaddaccount.Margin = new System.Windows.Forms.Padding(1);
            this.backfromaddaccount.Name = "backfromaddaccount";
            this.backfromaddaccount.Size = new System.Drawing.Size(40, 40);
            this.backfromaddaccount.TabIndex = 53;
            this.backfromaddaccount.Text = "⬅";
            this.backfromaddaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromaddaccount.UseVisualStyleBackColor = false;
            this.backfromaddaccount.Click += new System.EventHandler(this.backfromaddaccount_Click);
            // 
            // TADetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfromaddaccount);
            this.Controls.Add(this.DeleteTA);
            this.Controls.Add(this.UpdateTA);
            this.Controls.Add(this.AddTA);
            this.Controls.Add(this.IntDet);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TADetails";
            this.Text = "TADetails";
            this.Load += new System.EventHandler(this.TADetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView IntDet;
        private System.Windows.Forms.Button AddTA;
        private System.Windows.Forms.Button UpdateTA;
        private System.Windows.Forms.Button DeleteTA;
        private System.Windows.Forms.Button backfromaddaccount;
    }
}