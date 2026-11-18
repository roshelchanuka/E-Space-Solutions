namespace my_new_system
{
    partial class pilot
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
            this.labelpilotid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelSpacehours = new System.Windows.Forms.Label();
            this.buttoninsertpilot = new System.Windows.Forms.Button();
            this.buttonupdatepilot = new System.Windows.Forms.Button();
            this.buttondeletepilot = new System.Windows.Forms.Button();
            this.buttonbackpilot = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.texthours = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewpilot = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpilot)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pilot";
            // 
            // labelpilotid
            // 
            this.labelpilotid.AutoSize = true;
            this.labelpilotid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpilotid.Location = new System.Drawing.Point(31, 198);
            this.labelpilotid.Name = "labelpilotid";
            this.labelpilotid.Size = new System.Drawing.Size(85, 26);
            this.labelpilotid.TabIndex = 11;
            this.labelpilotid.Text = "Pilot ID";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(31, 268);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(72, 26);
            this.labelname.TabIndex = 12;
            this.labelname.Text = " Name";
            // 
            // labelSpacehours
            // 
            this.labelSpacehours.AutoSize = true;
            this.labelSpacehours.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpacehours.Location = new System.Drawing.Point(31, 331);
            this.labelSpacehours.Name = "labelSpacehours";
            this.labelSpacehours.Size = new System.Drawing.Size(126, 26);
            this.labelSpacehours.TabIndex = 13;
            this.labelSpacehours.Text = "Space hours";
            // 
            // buttoninsertpilot
            // 
            this.buttoninsertpilot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsertpilot.Location = new System.Drawing.Point(36, 416);
            this.buttoninsertpilot.Name = "buttoninsertpilot";
            this.buttoninsertpilot.Size = new System.Drawing.Size(107, 53);
            this.buttoninsertpilot.TabIndex = 17;
            this.buttoninsertpilot.Text = "Insert";
            this.buttoninsertpilot.UseVisualStyleBackColor = true;
            this.buttoninsertpilot.Click += new System.EventHandler(this.buttoninsertpilot_Click);
            // 
            // buttonupdatepilot
            // 
            this.buttonupdatepilot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdatepilot.Location = new System.Drawing.Point(222, 416);
            this.buttonupdatepilot.Name = "buttonupdatepilot";
            this.buttonupdatepilot.Size = new System.Drawing.Size(107, 53);
            this.buttonupdatepilot.TabIndex = 18;
            this.buttonupdatepilot.Text = "Update";
            this.buttonupdatepilot.UseVisualStyleBackColor = true;
            this.buttonupdatepilot.Click += new System.EventHandler(this.buttonupdatepilot_Click);
            // 
            // buttondeletepilot
            // 
            this.buttondeletepilot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeletepilot.Location = new System.Drawing.Point(421, 416);
            this.buttondeletepilot.Name = "buttondeletepilot";
            this.buttondeletepilot.Size = new System.Drawing.Size(107, 53);
            this.buttondeletepilot.TabIndex = 19;
            this.buttondeletepilot.Text = "Delete";
            this.buttondeletepilot.UseVisualStyleBackColor = true;
            this.buttondeletepilot.Click += new System.EventHandler(this.buttondeletepilot_Click);
            // 
            // buttonbackpilot
            // 
            this.buttonbackpilot.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackpilot.Location = new System.Drawing.Point(615, 416);
            this.buttonbackpilot.Name = "buttonbackpilot";
            this.buttonbackpilot.Size = new System.Drawing.Size(107, 53);
            this.buttonbackpilot.TabIndex = 20;
            this.buttonbackpilot.Text = "Back";
            this.buttonbackpilot.UseVisualStyleBackColor = true;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(271, 201);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(305, 22);
            this.textid.TabIndex = 21;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(271, 272);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(305, 22);
            this.textname.TabIndex = 22;
            // 
            // texthours
            // 
            this.texthours.Location = new System.Drawing.Point(271, 335);
            this.texthours.Name = "texthours";
            this.texthours.Size = new System.Drawing.Size(305, 22);
            this.texthours.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewpilot
            // 
            this.dataGridViewpilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpilot.Location = new System.Drawing.Point(711, 159);
            this.dataGridViewpilot.Name = "dataGridViewpilot";
            this.dataGridViewpilot.RowHeadersWidth = 51;
            this.dataGridViewpilot.RowTemplate.Height = 24;
            this.dataGridViewpilot.Size = new System.Drawing.Size(522, 198);
            this.dataGridViewpilot.TabIndex = 24;
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(711, 98);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(150, 42);
            this.btnview.TabIndex = 25;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // pilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 537);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridViewpilot);
            this.Controls.Add(this.texthours);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.buttonbackpilot);
            this.Controls.Add(this.buttondeletepilot);
            this.Controls.Add(this.buttonupdatepilot);
            this.Controls.Add(this.buttoninsertpilot);
            this.Controls.Add(this.labelSpacehours);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelpilotid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "pilot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pilot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpilot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpilotid;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelSpacehours;
        private System.Windows.Forms.Button buttoninsertpilot;
        private System.Windows.Forms.Button buttonupdatepilot;
        private System.Windows.Forms.Button buttondeletepilot;
        private System.Windows.Forms.Button buttonbackpilot;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox texthours;
        private System.Windows.Forms.DataGridView dataGridViewpilot;
        private System.Windows.Forms.Button btnview;
    }
}