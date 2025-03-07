namespace Project
{
    partial class InstructorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorDetails));
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IntDet = new System.Windows.Forms.DataGridView();
            this.AddInstructor = new System.Windows.Forms.Button();
            this.UpdateInstructor = new System.Windows.Forms.Button();
            this.DeleteInstructor = new System.Windows.Forms.Button();
            this.backfrominstructordetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(268, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(645, 90);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Instructor Details";
            this.Label1.Click += new System.EventHandler(this.HOME_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // IntDet
            // 
            this.IntDet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.IntDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntDet.GridColor = System.Drawing.SystemColors.Window;
            this.IntDet.Location = new System.Drawing.Point(-1, 120);
            this.IntDet.Name = "IntDet";
            this.IntDet.RowHeadersWidth = 51;
            this.IntDet.RowTemplate.Height = 24;
            this.IntDet.Size = new System.Drawing.Size(1184, 338);
            this.IntDet.TabIndex = 9;
            this.IntDet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntDet_CellContentClick);
            // 
            // AddInstructor
            // 
            this.AddInstructor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddInstructor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInstructor.Location = new System.Drawing.Point(272, 485);
            this.AddInstructor.Name = "AddInstructor";
            this.AddInstructor.Size = new System.Drawing.Size(145, 40);
            this.AddInstructor.TabIndex = 10;
            this.AddInstructor.Text = "Add Instructor";
            this.AddInstructor.UseVisualStyleBackColor = false;
            this.AddInstructor.Click += new System.EventHandler(this.AddInstructor_Click);
            // 
            // UpdateInstructor
            // 
            this.UpdateInstructor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateInstructor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInstructor.Location = new System.Drawing.Point(526, 485);
            this.UpdateInstructor.Name = "UpdateInstructor";
            this.UpdateInstructor.Size = new System.Drawing.Size(145, 40);
            this.UpdateInstructor.TabIndex = 11;
            this.UpdateInstructor.Text = "Update Instructor";
            this.UpdateInstructor.UseVisualStyleBackColor = false;
            this.UpdateInstructor.Click += new System.EventHandler(this.UpdateInstructor_Click);
            // 
            // DeleteInstructor
            // 
            this.DeleteInstructor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteInstructor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInstructor.Location = new System.Drawing.Point(773, 485);
            this.DeleteInstructor.Name = "DeleteInstructor";
            this.DeleteInstructor.Size = new System.Drawing.Size(145, 40);
            this.DeleteInstructor.TabIndex = 12;
            this.DeleteInstructor.Text = "Delete Instructor";
            this.DeleteInstructor.UseVisualStyleBackColor = false;
            this.DeleteInstructor.Click += new System.EventHandler(this.DeleteInstructor_Click);
            // 
            // backfrominstructordetails
            // 
            this.backfrominstructordetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfrominstructordetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfrominstructordetails.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfrominstructordetails.ForeColor = System.Drawing.Color.Black;
            this.backfrominstructordetails.Location = new System.Drawing.Point(10, 10);
            this.backfrominstructordetails.Margin = new System.Windows.Forms.Padding(1);
            this.backfrominstructordetails.Name = "backfrominstructordetails";
            this.backfrominstructordetails.Size = new System.Drawing.Size(40, 40);
            this.backfrominstructordetails.TabIndex = 53;
            this.backfrominstructordetails.Text = "⬅";
            this.backfrominstructordetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfrominstructordetails.UseVisualStyleBackColor = false;
            this.backfrominstructordetails.Click += new System.EventHandler(this.backfrominstructordetails_Click);
            // 
            // InstructorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfrominstructordetails);
            this.Controls.Add(this.DeleteInstructor);
            this.Controls.Add(this.UpdateInstructor);
            this.Controls.Add(this.AddInstructor);
            this.Controls.Add(this.IntDet);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructorDetails";
            this.Text = "InstructorDetails";
            this.Load += new System.EventHandler(this.InstructorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView IntDet;
        private System.Windows.Forms.Button AddInstructor;
        private System.Windows.Forms.Button UpdateInstructor;
        private System.Windows.Forms.Button DeleteInstructor;
        private System.Windows.Forms.Button backfrominstructordetails;
    }
}