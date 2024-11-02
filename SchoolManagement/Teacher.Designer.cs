namespace SchoolManagement
{
    partial class Teacher
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textteacherid = new System.Windows.Forms.TextBox();
            this.textteachername = new System.Windows.Forms.TextBox();
            this.textteachergender = new System.Windows.Forms.TextBox();
            this.textteacherphone = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnNew2 = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 66);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(523, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TeacherId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "TeacherName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "phone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SchoolManagement.Properties.Resources.WhatsApp_Image_2024_10_02_at_18_39_03_953fccff;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(538, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 218);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textteacherid
            // 
            this.textteacherid.Location = new System.Drawing.Point(285, 114);
            this.textteacherid.Name = "textteacherid";
            this.textteacherid.Size = new System.Drawing.Size(186, 22);
            this.textteacherid.TabIndex = 24;
            // 
            // textteachername
            // 
            this.textteachername.Location = new System.Drawing.Point(285, 155);
            this.textteachername.Name = "textteachername";
            this.textteachername.Size = new System.Drawing.Size(186, 22);
            this.textteachername.TabIndex = 25;
            // 
            // textteachergender
            // 
            this.textteachergender.Location = new System.Drawing.Point(285, 194);
            this.textteachergender.Name = "textteachergender";
            this.textteachergender.Size = new System.Drawing.Size(186, 22);
            this.textteachergender.TabIndex = 26;
            this.textteachergender.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textteacherphone
            // 
            this.textteacherphone.Location = new System.Drawing.Point(285, 233);
            this.textteacherphone.Name = "textteacherphone";
            this.textteacherphone.Size = new System.Drawing.Size(186, 22);
            this.textteacherphone.TabIndex = 27;
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.Silver;
            this.btnSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(91, 279);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(139, 36);
            this.btnSave2.TabIndex = 28;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.Silver;
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(236, 279);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(139, 36);
            this.btnAdd2.TabIndex = 29;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate2.Location = new System.Drawing.Point(381, 279);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(139, 36);
            this.btnUpdate2.TabIndex = 30;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.Silver;
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.Location = new System.Drawing.Point(91, 321);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(139, 36);
            this.btnDelete2.TabIndex = 31;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnNew2
            // 
            this.btnNew2.BackColor = System.Drawing.Color.Silver;
            this.btnNew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew2.Location = new System.Drawing.Point(236, 321);
            this.btnNew2.Name = "btnNew2";
            this.btnNew2.Size = new System.Drawing.Size(139, 36);
            this.btnNew2.TabIndex = 32;
            this.btnNew2.Text = "New";
            this.btnNew2.UseVisualStyleBackColor = false;
            this.btnNew2.Click += new System.EventHandler(this.btnNew2_Click);
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.BackColor = System.Drawing.Color.Silver;
            this.btnDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay2.Location = new System.Drawing.Point(381, 321);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(139, 36);
            this.btnDisplay2.TabIndex = 33;
            this.btnDisplay2.Text = "Display";
            this.btnDisplay2.UseVisualStyleBackColor = false;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(0, 364);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(979, 167);
            this.dataGridView3.TabIndex = 34;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 531);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnNew2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.textteacherphone);
            this.Controls.Add(this.textteachergender);
            this.Controls.Add(this.textteachername);
            this.Controls.Add(this.textteacherid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textteacherid;
        private System.Windows.Forms.TextBox textteachername;
        private System.Windows.Forms.TextBox textteachergender;
        private System.Windows.Forms.TextBox textteacherphone;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnNew2;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}