namespace my_new_system
{
    partial class job
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeljobid = new System.Windows.Forms.Label();
            this.labelJobtype = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttoninsertjob = new System.Windows.Forms.Button();
            this.buttonupdatejob = new System.Windows.Forms.Button();
            this.buttondeletejob = new System.Windows.Forms.Button();
            this.buttonbackjob = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.texttype = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Job";
            // 
            // labeljobid
            // 
            this.labeljobid.AutoSize = true;
            this.labeljobid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljobid.Location = new System.Drawing.Point(32, 185);
            this.labeljobid.Name = "labeljobid";
            this.labeljobid.Size = new System.Drawing.Size(75, 26);
            this.labeljobid.TabIndex = 10;
            this.labeljobid.Text = "Job ID";
            // 
            // labelJobtype
            // 
            this.labelJobtype.AutoSize = true;
            this.labelJobtype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobtype.Location = new System.Drawing.Point(32, 240);
            this.labelJobtype.Name = "labelJobtype";
            this.labelJobtype.Size = new System.Drawing.Size(90, 26);
            this.labelJobtype.TabIndex = 11;
            this.labelJobtype.Text = "Job type";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(32, 293);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(119, 26);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // buttoninsertjob
            // 
            this.buttoninsertjob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsertjob.Location = new System.Drawing.Point(25, 385);
            this.buttoninsertjob.Name = "buttoninsertjob";
            this.buttoninsertjob.Size = new System.Drawing.Size(107, 53);
            this.buttoninsertjob.TabIndex = 16;
            this.buttoninsertjob.Text = "Insert";
            this.buttoninsertjob.UseVisualStyleBackColor = true;
            // 
            // buttonupdatejob
            // 
            this.buttonupdatejob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdatejob.Location = new System.Drawing.Point(235, 385);
            this.buttonupdatejob.Name = "buttonupdatejob";
            this.buttonupdatejob.Size = new System.Drawing.Size(107, 53);
            this.buttonupdatejob.TabIndex = 17;
            this.buttonupdatejob.Text = "Update";
            this.buttonupdatejob.UseVisualStyleBackColor = true;
            // 
            // buttondeletejob
            // 
            this.buttondeletejob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeletejob.Location = new System.Drawing.Point(442, 385);
            this.buttondeletejob.Name = "buttondeletejob";
            this.buttondeletejob.Size = new System.Drawing.Size(107, 53);
            this.buttondeletejob.TabIndex = 18;
            this.buttondeletejob.Text = "Delete";
            this.buttondeletejob.UseVisualStyleBackColor = true;
            // 
            // buttonbackjob
            // 
            this.buttonbackjob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackjob.Location = new System.Drawing.Point(632, 385);
            this.buttonbackjob.Name = "buttonbackjob";
            this.buttonbackjob.Size = new System.Drawing.Size(107, 53);
            this.buttonbackjob.TabIndex = 19;
            this.buttonbackjob.Text = "Back";
            this.buttonbackjob.UseVisualStyleBackColor = true;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(262, 188);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(305, 22);
            this.textid.TabIndex = 20;
            // 
            // texttype
            // 
            this.texttype.Location = new System.Drawing.Point(262, 244);
            this.texttype.Name = "texttype";
            this.texttype.Size = new System.Drawing.Size(305, 22);
            this.texttype.TabIndex = 21;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(262, 297);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(305, 22);
            this.textDescription.TabIndex = 22;
            // 
            // job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.texttype);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.buttonbackjob);
            this.Controls.Add(this.buttondeletejob);
            this.Controls.Add(this.buttonupdatejob);
            this.Controls.Add(this.buttoninsertjob);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelJobtype);
            this.Controls.Add(this.labeljobid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "job";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeljobid;
        private System.Windows.Forms.Label labelJobtype;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttoninsertjob;
        private System.Windows.Forms.Button buttonupdatejob;
        private System.Windows.Forms.Button buttondeletejob;
        private System.Windows.Forms.Button buttonbackjob;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox texttype;
        private System.Windows.Forms.TextBox textDescription;
    }
}