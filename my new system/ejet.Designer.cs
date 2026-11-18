namespace my_new_system
{
    partial class ejet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeljetid = new System.Windows.Forms.Label();
            this.labelPowersource = new System.Windows.Forms.Label();
            this.labelSeats = new System.Windows.Forms.Label();
            this.labelEnginpower = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonbackejet = new System.Windows.Forms.Button();
            this.textBoxjetid = new System.Windows.Forms.TextBox();
            this.textPower = new System.Windows.Forms.TextBox();
            this.textSeats = new System.Windows.Forms.TextBox();
            this.textEnginpower = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewejet = new System.Windows.Forms.DataGridView();
            this.btnviewejet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewejet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "E Jet";
            // 
            // labeljetid
            // 
            this.labeljetid.AutoSize = true;
            this.labeljetid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljetid.Location = new System.Drawing.Point(40, 188);
            this.labeljetid.Name = "labeljetid";
            this.labeljetid.Size = new System.Drawing.Size(67, 26);
            this.labeljetid.TabIndex = 8;
            this.labeljetid.Text = "Jet ID";
            // 
            // labelPowersource
            // 
            this.labelPowersource.AutoSize = true;
            this.labelPowersource.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPowersource.Location = new System.Drawing.Point(40, 243);
            this.labelPowersource.Name = "labelPowersource";
            this.labelPowersource.Size = new System.Drawing.Size(139, 26);
            this.labelPowersource.TabIndex = 9;
            this.labelPowersource.Text = "Power source";
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeats.Location = new System.Drawing.Point(40, 295);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(60, 26);
            this.labelSeats.TabIndex = 10;
            this.labelSeats.Text = "Seats";
            // 
            // labelEnginpower
            // 
            this.labelEnginpower.AutoSize = true;
            this.labelEnginpower.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnginpower.Location = new System.Drawing.Point(40, 347);
            this.labelEnginpower.Name = "labelEnginpower";
            this.labelEnginpower.Size = new System.Drawing.Size(131, 26);
            this.labelEnginpower.TabIndex = 11;
            this.labelEnginpower.Text = "Engin power";
            this.labelEnginpower.Click += new System.EventHandler(this.labelEnginpower_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(40, 402);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(54, 26);
            this.labelYear.TabIndex = 12;
            this.labelYear.Text = "Year";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(40, 469);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(76, 26);
            this.labelWeight.TabIndex = 13;
            this.labelWeight.Text = "Weight";
            // 
            // buttoninsert
            // 
            this.buttoninsert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(24, 526);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(107, 53);
            this.buttoninsert.TabIndex = 14;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(259, 526);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(107, 53);
            this.buttonupdate.TabIndex = 15;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(492, 526);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(107, 53);
            this.buttondelete.TabIndex = 16;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonbackejet
            // 
            this.buttonbackejet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackejet.Location = new System.Drawing.Point(717, 526);
            this.buttonbackejet.Name = "buttonbackejet";
            this.buttonbackejet.Size = new System.Drawing.Size(107, 53);
            this.buttonbackejet.TabIndex = 17;
            this.buttonbackejet.Text = "Back";
            this.buttonbackejet.UseVisualStyleBackColor = true;
            this.buttonbackejet.Click += new System.EventHandler(this.buttonbackejet_Click);
            // 
            // textBoxjetid
            // 
            this.textBoxjetid.Location = new System.Drawing.Point(259, 191);
            this.textBoxjetid.Name = "textBoxjetid";
            this.textBoxjetid.Size = new System.Drawing.Size(386, 22);
            this.textBoxjetid.TabIndex = 18;
            // 
            // textPower
            // 
            this.textPower.Location = new System.Drawing.Point(259, 247);
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(386, 22);
            this.textPower.TabIndex = 19;
            // 
            // textSeats
            // 
            this.textSeats.Location = new System.Drawing.Point(259, 299);
            this.textSeats.Name = "textSeats";
            this.textSeats.Size = new System.Drawing.Size(386, 22);
            this.textSeats.TabIndex = 20;
            // 
            // textEnginpower
            // 
            this.textEnginpower.Location = new System.Drawing.Point(259, 351);
            this.textEnginpower.Name = "textEnginpower";
            this.textEnginpower.Size = new System.Drawing.Size(386, 22);
            this.textEnginpower.TabIndex = 21;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(259, 406);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(386, 22);
            this.textYear.TabIndex = 22;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(259, 473);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(386, 22);
            this.textWeight.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewejet
            // 
            this.dataGridViewejet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewejet.Location = new System.Drawing.Point(708, 263);
            this.dataGridViewejet.Name = "dataGridViewejet";
            this.dataGridViewejet.RowHeadersWidth = 51;
            this.dataGridViewejet.RowTemplate.Height = 24;
            this.dataGridViewejet.Size = new System.Drawing.Size(570, 144);
            this.dataGridViewejet.TabIndex = 24;
            // 
            // btnviewejet
            // 
            this.btnviewejet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewejet.Location = new System.Drawing.Point(729, 173);
            this.btnviewejet.Name = "btnviewejet";
            this.btnviewejet.Size = new System.Drawing.Size(183, 52);
            this.btnviewejet.TabIndex = 25;
            this.btnviewejet.Text = "View";
            this.btnviewejet.UseVisualStyleBackColor = true;
            this.btnviewejet.Click += new System.EventHandler(this.btnviewejet_Click);
            // 
            // ejet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 622);
            this.Controls.Add(this.btnviewejet);
            this.Controls.Add(this.dataGridViewejet);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textEnginpower);
            this.Controls.Add(this.textSeats);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.textBoxjetid);
            this.Controls.Add(this.buttonbackejet);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelEnginpower);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.labelPowersource);
            this.Controls.Add(this.labeljetid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ejet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ejet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewejet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeljetid;
        private System.Windows.Forms.Label labelPowersource;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.Label labelEnginpower;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonbackejet;
        private System.Windows.Forms.TextBox textBoxjetid;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.TextBox textSeats;
        private System.Windows.Forms.TextBox textEnginpower;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.DataGridView dataGridViewejet;
        private System.Windows.Forms.Button btnviewejet;
    }
}