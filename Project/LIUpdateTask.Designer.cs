namespace Project
{
    partial class LIUpdateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIUpdateTask));
            this.backfromcreateaccount = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Deadline = new System.Windows.Forms.Label();
            this.TaskDesc = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.Label();
            this.tdead = new System.Windows.Forms.MaskedTextBox();
            this.tdesc = new System.Windows.Forms.MaskedTextBox();
            this.tname = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.backfromcreateaccount.TabIndex = 118;
            this.backfromcreateaccount.Text = "⬅";
            this.backfromcreateaccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromcreateaccount.UseVisualStyleBackColor = false;
            this.backfromcreateaccount.Click += new System.EventHandler(this.backfromcreateaccount_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Update.Location = new System.Drawing.Point(478, 398);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(172, 43);
            this.Update.TabIndex = 117;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Deadline.Location = new System.Drawing.Point(317, 315);
            this.Deadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(99, 25);
            this.Deadline.TabIndex = 116;
            this.Deadline.Text = "Deadline";
            // 
            // TaskDesc
            // 
            this.TaskDesc.AutoSize = true;
            this.TaskDesc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDesc.Location = new System.Drawing.Point(313, 270);
            this.TaskDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.Size = new System.Drawing.Size(178, 25);
            this.TaskDesc.TabIndex = 115;
            this.TaskDesc.Text = "Task Description";
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(313, 226);
            this.TaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(123, 25);
            this.TaskName.TabIndex = 114;
            this.TaskName.Text = "Task Name";
            // 
            // tdead
            // 
            this.tdead.Location = new System.Drawing.Point(554, 315);
            this.tdead.Margin = new System.Windows.Forms.Padding(4);
            this.tdead.Name = "tdead";
            this.tdead.Size = new System.Drawing.Size(303, 22);
            this.tdead.TabIndex = 113;
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(554, 270);
            this.tdesc.Margin = new System.Windows.Forms.Padding(4);
            this.tdesc.Name = "tdesc";
            this.tdesc.Size = new System.Drawing.Size(303, 22);
            this.tdesc.TabIndex = 112;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(554, 226);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(303, 22);
            this.tname.TabIndex = 111;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(213, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(793, 90);
            this.Label1.TabIndex = 110;
            this.Label1.Text = "Update Assistant Task";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 126);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // LIUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backfromcreateaccount);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.TaskDesc);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.tdead);
            this.Controls.Add(this.tdesc);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LIUpdateTask";
            this.Text = "LIUpdateTask";
            this.Load += new System.EventHandler(this.LIUpdateTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backfromcreateaccount;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label Deadline;
        private System.Windows.Forms.Label TaskDesc;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.MaskedTextBox tdead;
        private System.Windows.Forms.MaskedTextBox tdesc;
        private System.Windows.Forms.MaskedTextBox tname;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}