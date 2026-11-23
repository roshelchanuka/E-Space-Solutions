namespace my_new_system
{
    partial class colorepo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewcolorepo = new System.Windows.Forms.DataGridView();
            this.btnexpocolorepo = new System.Windows.Forms.Button();
            this.btnviewcolorepo = new System.Windows.Forms.Button();
            this.btnbackcolorepo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcolorepo)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colony Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // dataGridViewcolorepo
            // 
            this.dataGridViewcolorepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcolorepo.Location = new System.Drawing.Point(135, 188);
            this.dataGridViewcolorepo.Name = "dataGridViewcolorepo";
            this.dataGridViewcolorepo.RowHeadersWidth = 51;
            this.dataGridViewcolorepo.RowTemplate.Height = 24;
            this.dataGridViewcolorepo.Size = new System.Drawing.Size(1067, 227);
            this.dataGridViewcolorepo.TabIndex = 9;
            this.dataGridViewcolorepo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnexpocolorepo
            // 
            this.btnexpocolorepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexpocolorepo.Location = new System.Drawing.Point(877, 474);
            this.btnexpocolorepo.Name = "btnexpocolorepo";
            this.btnexpocolorepo.Size = new System.Drawing.Size(229, 44);
            this.btnexpocolorepo.TabIndex = 16;
            this.btnexpocolorepo.Text = "Export";
            this.btnexpocolorepo.UseVisualStyleBackColor = true;
            this.btnexpocolorepo.Click += new System.EventHandler(this.btnexpocolorepo_Click);
            // 
            // btnviewcolorepo
            // 
            this.btnviewcolorepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewcolorepo.Location = new System.Drawing.Point(159, 476);
            this.btnviewcolorepo.Name = "btnviewcolorepo";
            this.btnviewcolorepo.Size = new System.Drawing.Size(153, 42);
            this.btnviewcolorepo.TabIndex = 17;
            this.btnviewcolorepo.Text = "View";
            this.btnviewcolorepo.UseVisualStyleBackColor = true;
            this.btnviewcolorepo.Click += new System.EventHandler(this.btnviewcolorepo_Click);
            // 
            // btnbackcolorepo
            // 
            this.btnbackcolorepo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackcolorepo.Location = new System.Drawing.Point(1076, 628);
            this.btnbackcolorepo.Name = "btnbackcolorepo";
            this.btnbackcolorepo.Size = new System.Drawing.Size(153, 42);
            this.btnbackcolorepo.TabIndex = 18;
            this.btnbackcolorepo.Text = "Back";
            this.btnbackcolorepo.UseVisualStyleBackColor = true;
            // 
            // colorepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 682);
            this.Controls.Add(this.btnbackcolorepo);
            this.Controls.Add(this.btnviewcolorepo);
            this.Controls.Add(this.btnexpocolorepo);
            this.Controls.Add(this.dataGridViewcolorepo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "colorepo";
            this.Text = "colorepo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcolorepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewcolorepo;
        private System.Windows.Forms.Button btnexpocolorepo;
        private System.Windows.Forms.Button btnviewcolorepo;
        private System.Windows.Forms.Button btnbackcolorepo;
    }
}