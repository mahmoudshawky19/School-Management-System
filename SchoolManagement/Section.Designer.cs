namespace SchoolManagement
{
    partial class Section
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textsectionid = new System.Windows.Forms.TextBox();
            this.textstudentnamesec = new System.Windows.Forms.TextBox();
            this.textsection = new System.Windows.Forms.TextBox();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.btnNew2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView4.Location = new System.Drawing.Point(0, 351);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(904, 162);
            this.dataGridView4.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "SectionId";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Section information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "StudentName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Section";
            // 
            // textsectionid
            // 
            this.textsectionid.Location = new System.Drawing.Point(233, 83);
            this.textsectionid.Name = "textsectionid";
            this.textsectionid.Size = new System.Drawing.Size(186, 22);
            this.textsectionid.TabIndex = 40;
            // 
            // textstudentnamesec
            // 
            this.textstudentnamesec.Location = new System.Drawing.Point(233, 125);
            this.textstudentnamesec.Name = "textstudentnamesec";
            this.textstudentnamesec.Size = new System.Drawing.Size(186, 22);
            this.textstudentnamesec.TabIndex = 41;
            // 
            // textsection
            // 
            this.textsection.Location = new System.Drawing.Point(233, 163);
            this.textsection.Name = "textsection";
            this.textsection.Size = new System.Drawing.Size(186, 22);
            this.textsection.TabIndex = 42;
            this.textsection.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplay2.Location = new System.Drawing.Point(330, 277);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(139, 36);
            this.btnDisplay2.TabIndex = 49;
            this.btnDisplay2.Text = "Display";
            this.btnDisplay2.UseVisualStyleBackColor = false;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // btnNew2
            // 
            this.btnNew2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew2.Location = new System.Drawing.Point(185, 277);
            this.btnNew2.Name = "btnNew2";
            this.btnNew2.Size = new System.Drawing.Size(139, 36);
            this.btnNew2.TabIndex = 48;
            this.btnNew2.Text = "New";
            this.btnNew2.UseVisualStyleBackColor = false;
            this.btnNew2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete2.Location = new System.Drawing.Point(40, 277);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(139, 36);
            this.btnDelete2.TabIndex = 47;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate2.Location = new System.Drawing.Point(330, 235);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(139, 36);
            this.btnUpdate2.TabIndex = 46;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd2.Location = new System.Drawing.Point(185, 235);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(139, 36);
            this.btnAdd2.TabIndex = 45;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave2.Location = new System.Drawing.Point(40, 235);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(139, 36);
            this.btnSave2.TabIndex = 44;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SchoolManagement.Properties.Resources.WhatsApp_Image_2024_10_02_at_21_37_20_3d435d35;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(500, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 218);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnNew2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textsection);
            this.Controls.Add(this.textstudentnamesec);
            this.Controls.Add(this.textsectionid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.panel1);
            this.Name = "Section";
            this.Text = "Section";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textsectionid;
        private System.Windows.Forms.TextBox textstudentnamesec;
        private System.Windows.Forms.TextBox textsection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Button btnNew2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnSave2;
    }
}