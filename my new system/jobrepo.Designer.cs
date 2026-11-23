namespace my_new_system
{
    partial class jobrepo
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
            this.dataGridViewcolorepo = new System.Windows.Forms.DataGridView();
            this.btnbackjobrepo = new System.Windows.Forms.Button();
            this.btnviewjobrepo = new System.Windows.Forms.Button();
            this.btnexpojobrepo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcolorepo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Job Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewcolorepo
            // 
            this.dataGridViewcolorepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcolorepo.Location = new System.Drawing.Point(269, 161);
            this.dataGridViewcolorepo.Name = "dataGridViewcolorepo";
            this.dataGridViewcolorepo.RowHeadersWidth = 51;
            this.dataGridViewcolorepo.RowTemplate.Height = 24;
            this.dataGridViewcolorepo.Size = new System.Drawing.Size(617, 227);
            this.dataGridViewcolorepo.TabIndex = 12;
            // 
            // btnbackjobrepo
            // 
            this.btnbackjobrepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackjobrepo.Location = new System.Drawing.Point(1070, 563);
            this.btnbackjobrepo.Name = "btnbackjobrepo";
            this.btnbackjobrepo.Size = new System.Drawing.Size(153, 42);
            this.btnbackjobrepo.TabIndex = 21;
            this.btnbackjobrepo.Text = "Back";
            this.btnbackjobrepo.UseVisualStyleBackColor = true;
            this.btnbackjobrepo.Click += new System.EventHandler(this.btnbackjobrepo_Click);
            // 
            // btnviewjobrepo
            // 
            this.btnviewjobrepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewjobrepo.Location = new System.Drawing.Point(86, 442);
            this.btnviewjobrepo.Name = "btnviewjobrepo";
            this.btnviewjobrepo.Size = new System.Drawing.Size(153, 42);
            this.btnviewjobrepo.TabIndex = 20;
            this.btnviewjobrepo.Text = "View";
            this.btnviewjobrepo.UseVisualStyleBackColor = true;
            this.btnviewjobrepo.Click += new System.EventHandler(this.btnviewjobrepo_Click);
            // 
            // btnexpojobrepo
            // 
            this.btnexpojobrepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexpojobrepo.Location = new System.Drawing.Point(804, 440);
            this.btnexpojobrepo.Name = "btnexpojobrepo";
            this.btnexpojobrepo.Size = new System.Drawing.Size(229, 44);
            this.btnexpojobrepo.TabIndex = 19;
            this.btnexpojobrepo.Text = "Export";
            this.btnexpojobrepo.UseVisualStyleBackColor = true;
            this.btnexpojobrepo.Click += new System.EventHandler(this.btnexpojobrepo_Click);
            // 
            // jobrepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 617);
            this.Controls.Add(this.btnbackjobrepo);
            this.Controls.Add(this.btnviewjobrepo);
            this.Controls.Add(this.btnexpojobrepo);
            this.Controls.Add(this.dataGridViewcolorepo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "jobrepo";
            this.Text = "jobrepo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcolorepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewcolorepo;
        private System.Windows.Forms.Button btnbackjobrepo;
        private System.Windows.Forms.Button btnviewjobrepo;
        private System.Windows.Forms.Button btnexpojobrepo;
    }
}