namespace my_new_system
{
    partial class Pilotdash
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
            this.btnviewtrip = new System.Windows.Forms.Button();
            this.dataGridViewpaandtrip = new System.Windows.Forms.DataGridView();
            this.btnpassengers = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpaandtrip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashbord";
            // 
            // btnviewtrip
            // 
            this.btnviewtrip.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewtrip.Location = new System.Drawing.Point(12, 272);
            this.btnviewtrip.Name = "btnviewtrip";
            this.btnviewtrip.Size = new System.Drawing.Size(229, 44);
            this.btnviewtrip.TabIndex = 10;
            this.btnviewtrip.Text = "Trip Details";
            this.btnviewtrip.UseVisualStyleBackColor = true;
            // 
            // dataGridViewpaandtrip
            // 
            this.dataGridViewpaandtrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpaandtrip.Location = new System.Drawing.Point(368, 251);
            this.dataGridViewpaandtrip.Name = "dataGridViewpaandtrip";
            this.dataGridViewpaandtrip.RowHeadersWidth = 51;
            this.dataGridViewpaandtrip.RowTemplate.Height = 24;
            this.dataGridViewpaandtrip.Size = new System.Drawing.Size(713, 215);
            this.dataGridViewpaandtrip.TabIndex = 11;
            // 
            // btnpassengers
            // 
            this.btnpassengers.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpassengers.Location = new System.Drawing.Point(12, 397);
            this.btnpassengers.Name = "btnpassengers";
            this.btnpassengers.Size = new System.Drawing.Size(248, 51);
            this.btnpassengers.TabIndex = 12;
            this.btnpassengers.Text = "Passenger Details";
            this.btnpassengers.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(807, 606);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(229, 44);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // Pilotdash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_new_system.Properties.Resources.Artists_conception_of_a_future_Mars_colony_The_settlement_includes_an_inflated;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 679);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnpassengers);
            this.Controls.Add(this.dataGridViewpaandtrip);
            this.Controls.Add(this.btnviewtrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pilotdash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilotdash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpaandtrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnviewtrip;
        private System.Windows.Forms.DataGridView dataGridViewpaandtrip;
        private System.Windows.Forms.Button btnpassengers;
        private System.Windows.Forms.Button btnlogout;
    }
}