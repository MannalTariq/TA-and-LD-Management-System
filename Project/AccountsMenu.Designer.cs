namespace Project
{
    partial class AccountsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsMenu));
            this.Int = new System.Windows.Forms.Button();
            this.TA = new System.Windows.Forms.Button();
            this.LD = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backfromaddaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Int
            // 
            this.Int.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Int.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Int.Location = new System.Drawing.Point(408, 360);
            this.Int.Margin = new System.Windows.Forms.Padding(4);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(316, 53);
            this.Int.TabIndex = 12;
            this.Int.Text = "Instructor";
            this.Int.UseVisualStyleBackColor = false;
            this.Int.Click += new System.EventHandler(this.Int_Click);
            // 
            // TA
            // 
            this.TA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TA.Location = new System.Drawing.Point(408, 271);
            this.TA.Margin = new System.Windows.Forms.Padding(4);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(316, 53);
            this.TA.TabIndex = 11;
            this.TA.Text = "Teacher Assistant";
            this.TA.UseVisualStyleBackColor = false;
            this.TA.Click += new System.EventHandler(this.TA_Click);
            // 
            // LD
            // 
            this.LD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LD.Location = new System.Drawing.Point(408, 186);
            this.LD.Margin = new System.Windows.Forms.Padding(4);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(316, 53);
            this.LD.TabIndex = 10;
            this.LD.Text = "Lab Demonstrator";
            this.LD.UseVisualStyleBackColor = false;
            this.LD.Click += new System.EventHandler(this.LD_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(319, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(485, 90);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Add Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // backfromaddaccount
            // 
            this.backfromaddaccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromaddaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromaddaccount.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromaddaccount.ForeColor = System.Drawing.Color.Black;
            this.backfromaddaccount.Location = new System.Drawing.Point(10, 10);
            this.backfromaddaccount.Margin = new System.Windows.Forms.Padding(1);
            this.backfromaddaccount.Name = "backfromaddaccount";
            this.backfromaddaccount.Size = new System.Drawing.Size(40, 40);
            this.backfromaddaccount.TabIndex = 52;
            this.backfromaddaccount.Text = "⬅";
            this.backfromaddaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromaddaccount.UseVisualStyleBackColor = false;
            this.backfromaddaccount.Click += new System.EventHandler(this.backfromaddaccount_Click);
            // 
            // AccountsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfromaddaccount);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.LD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountsMenu";
            this.Text = "AccountsMenu";
            this.Load += new System.EventHandler(this.AccountsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Int;
        private System.Windows.Forms.Button TA;
        private System.Windows.Forms.Button LD;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backfromaddaccount;
    }
}