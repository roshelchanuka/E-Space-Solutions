namespace my_new_system
{
    partial class adminoremp
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
            this.buttonlogifadmin = new System.Windows.Forms.Button();
            this.buttonlogifemp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonlogback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "If you are Admin or Colonist?";
            // 
            // buttonlogifadmin
            // 
            this.buttonlogifadmin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogifadmin.Location = new System.Drawing.Point(24, 248);
            this.buttonlogifadmin.Name = "buttonlogifadmin";
            this.buttonlogifadmin.Size = new System.Drawing.Size(221, 74);
            this.buttonlogifadmin.TabIndex = 10;
            this.buttonlogifadmin.Text = "Admin Login";
            this.buttonlogifadmin.UseVisualStyleBackColor = true;
            this.buttonlogifadmin.Click += new System.EventHandler(this.buttonlogifadmin_Click);
            // 
            // buttonlogifemp
            // 
            this.buttonlogifemp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogifemp.Location = new System.Drawing.Point(485, 240);
            this.buttonlogifemp.Name = "buttonlogifemp";
            this.buttonlogifemp.Size = new System.Drawing.Size(240, 90);
            this.buttonlogifemp.TabIndex = 11;
            this.buttonlogifemp.Text = "Colonist Login";
            this.buttonlogifemp.UseVisualStyleBackColor = true;
            this.buttonlogifemp.Click += new System.EventHandler(this.buttonlogifemp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonlogback
            // 
            this.buttonlogback.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogback.Location = new System.Drawing.Point(574, 378);
            this.buttonlogback.Name = "buttonlogback";
            this.buttonlogback.Size = new System.Drawing.Size(196, 60);
            this.buttonlogback.TabIndex = 12;
            this.buttonlogback.Text = "Back";
            this.buttonlogback.UseVisualStyleBackColor = true;
            this.buttonlogback.Click += new System.EventHandler(this.buttonlogback_Click);
            // 
            // adminoremp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlogback);
            this.Controls.Add(this.buttonlogifemp);
            this.Controls.Add(this.buttonlogifadmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminoremp";
            this.Text = "adminoremp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogifadmin;
        private System.Windows.Forms.Button buttonlogifemp;
        private System.Windows.Forms.Button buttonlogback;
    }
}