namespace Project
{
    partial class AddLabTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLabTask));
            this.label6 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.MaskedTextBox();
            this.LDinfo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TA = new System.Windows.Forms.MaskedTextBox();
            this.tdead = new System.Windows.Forms.MaskedTextBox();
            this.tdesc = new System.Windows.Forms.MaskedTextBox();
            this.tName = new System.Windows.Forms.MaskedTextBox();
            this.AddTask = new System.Windows.Forms.Button();
            this.backfromctsec = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LDinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(539, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 163;
            this.label6.Text = "Section";
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(739, 388);
            this.sec.Margin = new System.Windows.Forms.Padding(4);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(303, 22);
            this.sec.TabIndex = 162;
            // 
            // LDinfo
            // 
            this.LDinfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.LDinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LDinfo.Location = new System.Drawing.Point(0, 119);
            this.LDinfo.Name = "LDinfo";
            this.LDinfo.RowHeadersWidth = 51;
            this.LDinfo.RowTemplate.Height = 24;
            this.LDinfo.Size = new System.Drawing.Size(481, 436);
            this.LDinfo.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(539, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 160;
            this.label5.Text = "Assistant ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(539, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 158;
            this.label3.Text = "Task Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 157;
            this.label2.Text = "Task Name";
            // 
            // TA
            // 
            this.TA.Location = new System.Drawing.Point(739, 343);
            this.TA.Margin = new System.Windows.Forms.Padding(4);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(303, 22);
            this.TA.TabIndex = 156;
            // 
            // tdead
            // 
            this.tdead.Location = new System.Drawing.Point(739, 301);
            this.tdead.Margin = new System.Windows.Forms.Padding(4);
            this.tdead.Name = "tdead";
            this.tdead.Size = new System.Drawing.Size(303, 22);
            this.tdead.TabIndex = 155;
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(739, 256);
            this.tdesc.Margin = new System.Windows.Forms.Padding(4);
            this.tdesc.Name = "tdesc";
            this.tdesc.Size = new System.Drawing.Size(303, 22);
            this.tdesc.TabIndex = 154;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(739, 212);
            this.tName.Margin = new System.Windows.Forms.Padding(4);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(303, 22);
            this.tName.TabIndex = 153;
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTask.Location = new System.Drawing.Point(662, 444);
            this.AddTask.Margin = new System.Windows.Forms.Padding(4);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(205, 43);
            this.AddTask.TabIndex = 152;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = false;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // backfromctsec
            // 
            this.backfromctsec.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backfromctsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backfromctsec.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.backfromctsec.ForeColor = System.Drawing.Color.Black;
            this.backfromctsec.Location = new System.Drawing.Point(10, 10);
            this.backfromctsec.Margin = new System.Windows.Forms.Padding(1);
            this.backfromctsec.Name = "backfromctsec";
            this.backfromctsec.Size = new System.Drawing.Size(40, 40);
            this.backfromctsec.TabIndex = 151;
            this.backfromctsec.Text = "⬅";
            this.backfromctsec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backfromctsec.UseVisualStyleBackColor = false;
            this.backfromctsec.Click += new System.EventHandler(this.backfromctsec_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(375, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(385, 90);
            this.Label1.TabIndex = 150;
            this.Label1.Text = "Lab Tasks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-30, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 126);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // AddLabTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.LDinfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.tdead);
            this.Controls.Add(this.tdesc);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.backfromctsec);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLabTask";
            this.Text = "AddLabTask";
            this.Load += new System.EventHandler(this.AddLabTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LDinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox sec;
        private System.Windows.Forms.DataGridView LDinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TA;
        private System.Windows.Forms.MaskedTextBox tdead;
        private System.Windows.Forms.MaskedTextBox tdesc;
        private System.Windows.Forms.MaskedTextBox tName;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Button backfromctsec;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}