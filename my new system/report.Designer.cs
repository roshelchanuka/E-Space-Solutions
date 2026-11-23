namespace my_new_system
{
    partial class report
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
            this.dataGridViewreport = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnbarepo = new System.Windows.Forms.Button();
            this.btnadminrepo = new System.Windows.Forms.Button();
            this.btnexporepo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewreport
            // 
            this.dataGridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreport.Location = new System.Drawing.Point(218, 276);
            this.dataGridViewreport.Name = "dataGridViewreport";
            this.dataGridViewreport.RowHeadersWidth = 51;
            this.dataGridViewreport.RowTemplate.Height = 24;
            this.dataGridViewreport.Size = new System.Drawing.Size(857, 253);
            this.dataGridViewreport.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Colonist Report",
            "Dependent Report",
            "House Report",
            "Pilot Report",
            "E-Jet Report",
            "Trip Report",
            "Job Report"});
            this.comboBox1.Location = new System.Drawing.Point(71, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // btnbarepo
            // 
            this.btnbarepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbarepo.Location = new System.Drawing.Point(1063, 782);
            this.btnbarepo.Name = "btnbarepo";
            this.btnbarepo.Size = new System.Drawing.Size(153, 42);
            this.btnbarepo.TabIndex = 24;
            this.btnbarepo.Text = "Back";
            this.btnbarepo.UseVisualStyleBackColor = true;
            this.btnbarepo.Click += new System.EventHandler(this.btnbarepo_Click);
            // 
            // btnadminrepo
            // 
            this.btnadminrepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminrepo.Location = new System.Drawing.Point(83, 628);
            this.btnadminrepo.Name = "btnadminrepo";
            this.btnadminrepo.Size = new System.Drawing.Size(153, 42);
            this.btnadminrepo.TabIndex = 23;
            this.btnadminrepo.Text = "View";
            this.btnadminrepo.UseVisualStyleBackColor = true;
            this.btnadminrepo.Click += new System.EventHandler(this.btnadminrepo_Click);
            // 
            // btnexporepo
            // 
            this.btnexporepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexporepo.Location = new System.Drawing.Point(961, 628);
            this.btnexporepo.Name = "btnexporepo";
            this.btnexporepo.Size = new System.Drawing.Size(229, 44);
            this.btnexporepo.TabIndex = 22;
            this.btnexporepo.Text = "Export";
            this.btnexporepo.UseVisualStyleBackColor = true;
            this.btnexporepo.Click += new System.EventHandler(this.btnexporepo_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 836);
            this.Controls.Add(this.btnbarepo);
            this.Controls.Add(this.btnadminrepo);
            this.Controls.Add(this.btnexporepo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewreport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "report";
            this.Text = "report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewreport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnbarepo;
        private System.Windows.Forms.Button btnadminrepo;
        private System.Windows.Forms.Button btnexporepo;
    }
}