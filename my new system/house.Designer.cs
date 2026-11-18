namespace my_new_system
{
    partial class house
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
            this.labellotnum = new System.Windows.Forms.Label();
            this.labelfamilymem = new System.Windows.Forms.Label();
            this.labelfeet = new System.Windows.Forms.Label();
            this.textBoxlot = new System.Windows.Forms.TextBox();
            this.textBoxmembers = new System.Windows.Forms.TextBox();
            this.textBoxfeet = new System.Windows.Forms.TextBox();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttonup = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttondasback = new System.Windows.Forms.Button();
            this.dataGridViewhouse = new System.Windows.Forms.DataGridView();
            this.btnviewhouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::my_new_system.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-Space Solutions (Pvt.) Ltd ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "House";
            // 
            // labellotnum
            // 
            this.labellotnum.AutoSize = true;
            this.labellotnum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellotnum.Location = new System.Drawing.Point(7, 189);
            this.labellotnum.Name = "labellotnum";
            this.labellotnum.Size = new System.Drawing.Size(183, 26);
            this.labellotnum.TabIndex = 7;
            this.labellotnum.Text = "Coloni lot number";
            // 
            // labelfamilymem
            // 
            this.labelfamilymem.AutoSize = true;
            this.labelfamilymem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfamilymem.Location = new System.Drawing.Point(7, 263);
            this.labelfamilymem.Name = "labelfamilymem";
            this.labelfamilymem.Size = new System.Drawing.Size(271, 26);
            this.labelfamilymem.TabIndex = 8;
            this.labelfamilymem.Text = "Number of family members";
            // 
            // labelfeet
            // 
            this.labelfeet.AutoSize = true;
            this.labelfeet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfeet.Location = new System.Drawing.Point(7, 341);
            this.labelfeet.Name = "labelfeet";
            this.labelfeet.Size = new System.Drawing.Size(117, 26);
            this.labelfeet.TabIndex = 9;
            this.labelfeet.Text = "Square feet";
            // 
            // textBoxlot
            // 
            this.textBoxlot.Location = new System.Drawing.Point(323, 192);
            this.textBoxlot.Name = "textBoxlot";
            this.textBoxlot.Size = new System.Drawing.Size(358, 22);
            this.textBoxlot.TabIndex = 10;
            // 
            // textBoxmembers
            // 
            this.textBoxmembers.Location = new System.Drawing.Point(323, 267);
            this.textBoxmembers.Name = "textBoxmembers";
            this.textBoxmembers.Size = new System.Drawing.Size(358, 22);
            this.textBoxmembers.TabIndex = 11;
            // 
            // textBoxfeet
            // 
            this.textBoxfeet.Location = new System.Drawing.Point(323, 345);
            this.textBoxfeet.Name = "textBoxfeet";
            this.textBoxfeet.Size = new System.Drawing.Size(358, 22);
            this.textBoxfeet.TabIndex = 12;
            // 
            // buttoninsert
            // 
            this.buttoninsert.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(18, 430);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(136, 42);
            this.buttoninsert.TabIndex = 26;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttonup
            // 
            this.buttonup.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonup.Location = new System.Drawing.Point(277, 430);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(136, 42);
            this.buttonup.TabIndex = 27;
            this.buttonup.Text = "Update";
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.buttonup_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(545, 430);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(136, 42);
            this.buttondelete.TabIndex = 28;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttondasback
            // 
            this.buttondasback.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondasback.Location = new System.Drawing.Point(775, 430);
            this.buttondasback.Name = "buttondasback";
            this.buttondasback.Size = new System.Drawing.Size(136, 42);
            this.buttondasback.TabIndex = 29;
            this.buttondasback.Text = "Back";
            this.buttondasback.UseVisualStyleBackColor = true;
            // 
            // dataGridViewhouse
            // 
            this.dataGridViewhouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewhouse.Location = new System.Drawing.Point(715, 219);
            this.dataGridViewhouse.Name = "dataGridViewhouse";
            this.dataGridViewhouse.RowHeadersWidth = 51;
            this.dataGridViewhouse.RowTemplate.Height = 24;
            this.dataGridViewhouse.Size = new System.Drawing.Size(527, 137);
            this.dataGridViewhouse.TabIndex = 30;
            // 
            // btnviewhouse
            // 
            this.btnviewhouse.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewhouse.Location = new System.Drawing.Point(740, 131);
            this.btnviewhouse.Name = "btnviewhouse";
            this.btnviewhouse.Size = new System.Drawing.Size(136, 42);
            this.btnviewhouse.TabIndex = 31;
            this.btnviewhouse.Text = "View";
            this.btnviewhouse.UseVisualStyleBackColor = true;
            this.btnviewhouse.Click += new System.EventHandler(this.btnviewhouse_Click);
            // 
            // house
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 503);
            this.Controls.Add(this.btnviewhouse);
            this.Controls.Add(this.dataGridViewhouse);
            this.Controls.Add(this.buttondasback);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonup);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.textBoxfeet);
            this.Controls.Add(this.textBoxmembers);
            this.Controls.Add(this.textBoxlot);
            this.Controls.Add(this.labelfeet);
            this.Controls.Add(this.labelfamilymem);
            this.Controls.Add(this.labellotnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "house";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "house";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labellotnum;
        private System.Windows.Forms.Label labelfamilymem;
        private System.Windows.Forms.Label labelfeet;
        private System.Windows.Forms.TextBox textBoxlot;
        private System.Windows.Forms.TextBox textBoxmembers;
        private System.Windows.Forms.TextBox textBoxfeet;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttondasback;
        private System.Windows.Forms.DataGridView dataGridViewhouse;
        private System.Windows.Forms.Button btnviewhouse;
    }
}