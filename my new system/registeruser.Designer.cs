namespace my_new_system
{
    partial class registeruser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewusrman = new System.Windows.Forms.DataGridView();
            this.textid = new System.Windows.Forms.TextBox();
            this.labeljobid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textusrname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textroleid = new System.Windows.Forms.TextBox();
            this.textconfigpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonbackjob = new System.Windows.Forms.Button();
            this.buttondeleteuser = new System.Windows.Forms.Button();
            this.buttonupdateuser = new System.Windows.Forms.Button();
            this.buttoninsertuser = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.btnseruser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusrman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewusrman
            // 
            this.dataGridViewusrman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewusrman.Location = new System.Drawing.Point(540, 259);
            this.dataGridViewusrman.Name = "dataGridViewusrman";
            this.dataGridViewusrman.RowHeadersWidth = 51;
            this.dataGridViewusrman.RowTemplate.Height = 24;
            this.dataGridViewusrman.Size = new System.Drawing.Size(661, 177);
            this.dataGridViewusrman.TabIndex = 13;
            this.dataGridViewusrman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewusrman_CellClick);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(198, 224);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(305, 22);
            this.textid.TabIndex = 22;
            // 
            // labeljobid
            // 
            this.labeljobid.AutoSize = true;
            this.labeljobid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljobid.Location = new System.Drawing.Point(21, 224);
            this.labeljobid.Name = "labeljobid";
            this.labeljobid.Size = new System.Drawing.Size(84, 26);
            this.labeljobid.TabIndex = 21;
            this.labeljobid.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username";
            // 
            // textusrname
            // 
            this.textusrname.Location = new System.Drawing.Point(198, 323);
            this.textusrname.Name = "textusrname";
            this.textusrname.Size = new System.Drawing.Size(305, 22);
            this.textusrname.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(198, 414);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(305, 22);
            this.textpass.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Role ID";
            // 
            // textroleid
            // 
            this.textroleid.Location = new System.Drawing.Point(198, 601);
            this.textroleid.Name = "textroleid";
            this.textroleid.Size = new System.Drawing.Size(305, 22);
            this.textroleid.TabIndex = 28;
            // 
            // textconfigpass
            // 
            this.textconfigpass.Location = new System.Drawing.Point(198, 510);
            this.textconfigpass.Name = "textconfigpass";
            this.textconfigpass.PasswordChar = '*';
            this.textconfigpass.Size = new System.Drawing.Size(305, 22);
            this.textconfigpass.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "conform Password";
            // 
            // buttonbackjob
            // 
            this.buttonbackjob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackjob.Location = new System.Drawing.Point(1067, 694);
            this.buttonbackjob.Name = "buttonbackjob";
            this.buttonbackjob.Size = new System.Drawing.Size(107, 53);
            this.buttonbackjob.TabIndex = 34;
            this.buttonbackjob.Text = "Back";
            this.buttonbackjob.UseVisualStyleBackColor = true;
            this.buttonbackjob.Click += new System.EventHandler(this.buttonbackjob_Click);
            // 
            // buttondeleteuser
            // 
            this.buttondeleteuser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeleteuser.Location = new System.Drawing.Point(447, 694);
            this.buttondeleteuser.Name = "buttondeleteuser";
            this.buttondeleteuser.Size = new System.Drawing.Size(107, 53);
            this.buttondeleteuser.TabIndex = 33;
            this.buttondeleteuser.Text = "Delete";
            this.buttondeleteuser.UseVisualStyleBackColor = true;
            this.buttondeleteuser.Click += new System.EventHandler(this.buttondeleteuser_Click);
            // 
            // buttonupdateuser
            // 
            this.buttonupdateuser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdateuser.Location = new System.Drawing.Point(240, 694);
            this.buttonupdateuser.Name = "buttonupdateuser";
            this.buttonupdateuser.Size = new System.Drawing.Size(107, 53);
            this.buttonupdateuser.TabIndex = 32;
            this.buttonupdateuser.Text = "Update";
            this.buttonupdateuser.UseVisualStyleBackColor = true;
            this.buttonupdateuser.Click += new System.EventHandler(this.buttonupdateuser_Click);
            // 
            // buttoninsertuser
            // 
            this.buttoninsertuser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsertuser.Location = new System.Drawing.Point(30, 694);
            this.buttoninsertuser.Name = "buttoninsertuser";
            this.buttoninsertuser.Size = new System.Drawing.Size(107, 53);
            this.buttoninsertuser.TabIndex = 31;
            this.buttoninsertuser.Text = "Insert";
            this.buttoninsertuser.UseVisualStyleBackColor = true;
            this.buttoninsertuser.Click += new System.EventHandler(this.buttoninsertuser_Click);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(657, 199);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(305, 22);
            this.textsearch.TabIndex = 35;
            // 
            // btnseruser
            // 
            this.btnseruser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseruser.Location = new System.Drawing.Point(1004, 187);
            this.btnseruser.Name = "btnseruser";
            this.btnseruser.Size = new System.Drawing.Size(116, 40);
            this.btnseruser.TabIndex = 36;
            this.btnseruser.Text = "Search";
            this.btnseruser.UseVisualStyleBackColor = true;
            this.btnseruser.Click += new System.EventHandler(this.btnseruser_Click);
            // 
            // registeruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 791);
            this.Controls.Add(this.btnseruser);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.buttonbackjob);
            this.Controls.Add(this.buttondeleteuser);
            this.Controls.Add(this.buttonupdateuser);
            this.Controls.Add(this.buttoninsertuser);
            this.Controls.Add(this.textconfigpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textroleid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textusrname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.labeljobid);
            this.Controls.Add(this.dataGridViewusrman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "registeruser";
            this.Text = "registeruser";
            this.Load += new System.EventHandler(this.registeruser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusrman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewusrman;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label labeljobid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textusrname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textroleid;
        private System.Windows.Forms.TextBox textconfigpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonbackjob;
        private System.Windows.Forms.Button buttondeleteuser;
        private System.Windows.Forms.Button buttonupdateuser;
        private System.Windows.Forms.Button buttoninsertuser;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button btnseruser;
    }
}