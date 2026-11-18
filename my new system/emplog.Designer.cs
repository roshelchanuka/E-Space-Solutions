namespace my_new_system
{
    partial class emplog
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
            this.labelusernameemp = new System.Windows.Forms.Label();
            this.textusernameemp = new System.Windows.Forms.TextBox();
            this.labelpassemp = new System.Windows.Forms.Label();
            this.textpassemp = new System.Windows.Forms.TextBox();
            this.buttonlogemp = new System.Windows.Forms.Button();
            this.buttonlogbackemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // labelusernameemp
            // 
            this.labelusernameemp.AutoSize = true;
            this.labelusernameemp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernameemp.Location = new System.Drawing.Point(8, 187);
            this.labelusernameemp.Name = "labelusernameemp";
            this.labelusernameemp.Size = new System.Drawing.Size(135, 34);
            this.labelusernameemp.TabIndex = 5;
            this.labelusernameemp.Text = "Username";
            // 
            // textusernameemp
            // 
            this.textusernameemp.Location = new System.Drawing.Point(235, 198);
            this.textusernameemp.Name = "textusernameemp";
            this.textusernameemp.Size = new System.Drawing.Size(442, 22);
            this.textusernameemp.TabIndex = 6;
            // 
            // labelpassemp
            // 
            this.labelpassemp.AutoSize = true;
            this.labelpassemp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassemp.Location = new System.Drawing.Point(15, 285);
            this.labelpassemp.Name = "labelpassemp";
            this.labelpassemp.Size = new System.Drawing.Size(128, 34);
            this.labelpassemp.TabIndex = 7;
            this.labelpassemp.Text = "Password";
            // 
            // textpassemp
            // 
            this.textpassemp.Location = new System.Drawing.Point(235, 297);
            this.textpassemp.Name = "textpassemp";
            this.textpassemp.Size = new System.Drawing.Size(442, 22);
            this.textpassemp.TabIndex = 8;
            // 
            // buttonlogemp
            // 
            this.buttonlogemp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogemp.Location = new System.Drawing.Point(205, 380);
            this.buttonlogemp.Name = "buttonlogemp";
            this.buttonlogemp.Size = new System.Drawing.Size(189, 58);
            this.buttonlogemp.TabIndex = 9;
            this.buttonlogemp.Text = "Login";
            this.buttonlogemp.UseVisualStyleBackColor = true;
            this.buttonlogemp.Click += new System.EventHandler(this.buttonlogemp_Click);
            // 
            // buttonlogbackemp
            // 
            this.buttonlogbackemp.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogbackemp.Location = new System.Drawing.Point(586, 380);
            this.buttonlogbackemp.Name = "buttonlogbackemp";
            this.buttonlogbackemp.Size = new System.Drawing.Size(189, 58);
            this.buttonlogbackemp.TabIndex = 10;
            this.buttonlogbackemp.Text = "Back";
            this.buttonlogbackemp.UseVisualStyleBackColor = true;
            this.buttonlogbackemp.Click += new System.EventHandler(this.buttonlogbackemp_Click);
            // 
            // emplog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlogbackemp);
            this.Controls.Add(this.buttonlogemp);
            this.Controls.Add(this.textpassemp);
            this.Controls.Add(this.labelpassemp);
            this.Controls.Add(this.textusernameemp);
            this.Controls.Add(this.labelusernameemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "emplog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emplog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelusernameemp;
        private System.Windows.Forms.TextBox textusernameemp;
        private System.Windows.Forms.Label labelpassemp;
        private System.Windows.Forms.TextBox textpassemp;
        private System.Windows.Forms.Button buttonlogemp;
        private System.Windows.Forms.Button buttonlogbackemp;
    }
}