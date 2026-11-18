namespace my_new_system
{
    partial class login
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
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.buttonlog = new System.Windows.Forms.Button();
            this.buttonlogback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(27, 199);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(135, 34);
            this.labelusername.TabIndex = 3;
            this.labelusername.Text = "Username";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.Location = new System.Drawing.Point(27, 287);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(128, 34);
            this.labelpass.TabIndex = 4;
            this.labelpass.Text = "Password";
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(220, 210);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(442, 22);
            this.textusername.TabIndex = 5;
            this.textusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(220, 298);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(442, 22);
            this.textpass.TabIndex = 6;
            // 
            // buttonlog
            // 
            this.buttonlog.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlog.Location = new System.Drawing.Point(321, 399);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(189, 58);
            this.buttonlog.TabIndex = 7;
            this.buttonlog.Text = "Login";
            this.buttonlog.UseVisualStyleBackColor = true;
            this.buttonlog.Click += new System.EventHandler(this.buttonlog_Click);
            // 
            // buttonlogback
            // 
            this.buttonlogback.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogback.Location = new System.Drawing.Point(660, 399);
            this.buttonlogback.Name = "buttonlogback";
            this.buttonlogback.Size = new System.Drawing.Size(189, 58);
            this.buttonlogback.TabIndex = 8;
            this.buttonlogback.Text = "Back";
            this.buttonlogback.UseVisualStyleBackColor = true;
            this.buttonlogback.Click += new System.EventHandler(this.buttonlogback_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 482);
            this.Controls.Add(this.buttonlogback);
            this.Controls.Add(this.buttonlog);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button buttonlog;
        private System.Windows.Forms.Button buttonlogback;
    }
}