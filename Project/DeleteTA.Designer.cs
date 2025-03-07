namespace Project
{
    partial class DeleteTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTA));
            this.backfromcreateaccount = new System.Windows.Forms.Button();
            this.DeletaTA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.MaskedTextBox();
            this.FirstName = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.backfromcreateaccount.Size = new System.Drawing.Size(40, 40);
            this.backfromcreateaccount.TabIndex = 107;
            this.backfromcreateaccount.Text = "⬅";
            this.backfromcreateaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromcreateaccount.UseVisualStyleBackColor = false;
            this.backfromcreateaccount.Click += new System.EventHandler(this.backfromcreateaccount_Click);
            // 
            // DeletaTA
            // 
            this.DeletaTA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeletaTA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.DeletaTA.Location = new System.Drawing.Point(449, 448);
            this.DeletaTA.Margin = new System.Windows.Forms.Padding(4);
            this.DeletaTA.Name = "DeletaTA";
            this.DeletaTA.Size = new System.Drawing.Size(172, 43);
            this.DeletaTA.TabIndex = 106;
            this.DeletaTA.Text = "Delete";
            this.DeletaTA.UseVisualStyleBackColor = false;
            this.DeletaTA.Click += new System.EventHandler(this.DeleteTA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(495, 284);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(303, 22);
            this.LastName.TabIndex = 95;
            this.LastName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.LastName_MaskInputRejected);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(495, 227);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(303, 22);
            this.FirstName.TabIndex = 94;
            this.FirstName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FirstName_MaskInputRejected);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(233, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(674, 90);
            this.Label1.TabIndex = 93;
            this.Label1.Text = "Delete TA Account";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(336, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 109;
            this.label6.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(495, 344);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(303, 22);
            this.Username.TabIndex = 108;
            // 
            // DeleteTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.backfromcreateaccount);
            this.Controls.Add(this.DeletaTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteTA";
            this.Text = "DeleteTA";
            this.Load += new System.EventHandler(this.DeleteTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backfromcreateaccount;
        private System.Windows.Forms.Button DeletaTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox LastName;
        private System.Windows.Forms.MaskedTextBox FirstName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Username;
    }
}