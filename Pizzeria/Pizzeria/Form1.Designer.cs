namespace Pizzeria
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.alm1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addFam1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.alm2 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.addFam2 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.alm3 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.addFam3 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.ordre = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.alm1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.addFam1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.alm2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.addFam2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.alm3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.addFam3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox6);
            this.flowLayoutPanel1.Controls.Add(this.ordre);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(607, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 325);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // alm1
            // 
            this.alm1.Location = new System.Drawing.Point(3, 35);
            this.alm1.Name = "alm1";
            this.alm1.Size = new System.Drawing.Size(75, 23);
            this.alm1.TabIndex = 0;
            this.alm1.Text = "Almindelig";
            this.alm1.UseVisualStyleBackColor = true;
            this.alm1.Click += new System.EventHandler(this.alm1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Fuldkornsbund";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addFam1
            // 
            this.addFam1.Location = new System.Drawing.Point(3, 64);
            this.addFam1.Name = "addFam1";
            this.addFam1.Size = new System.Drawing.Size(75, 23);
            this.addFam1.TabIndex = 1;
            this.addFam1.Text = "Familie";
            this.addFam1.UseVisualStyleBackColor = true;
            this.addFam1.Click += new System.EventHandler(this.addFam1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(84, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Fuldkornsbund";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // alm2
            // 
            this.alm2.Location = new System.Drawing.Point(3, 93);
            this.alm2.Name = "alm2";
            this.alm2.Size = new System.Drawing.Size(75, 23);
            this.alm2.TabIndex = 6;
            this.alm2.Text = "Almindelig";
            this.alm2.UseVisualStyleBackColor = true;
            this.alm2.Click += new System.EventHandler(this.alm2_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(84, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Fuldkornsbund";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // addFam2
            // 
            this.addFam2.Location = new System.Drawing.Point(3, 122);
            this.addFam2.Name = "addFam2";
            this.addFam2.Size = new System.Drawing.Size(75, 23);
            this.addFam2.TabIndex = 4;
            this.addFam2.Text = "Familie";
            this.addFam2.UseVisualStyleBackColor = true;
            this.addFam2.Click += new System.EventHandler(this.addFam2_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(84, 122);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Fuldkornsbund";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // alm3
            // 
            this.alm3.Location = new System.Drawing.Point(3, 151);
            this.alm3.Name = "alm3";
            this.alm3.Size = new System.Drawing.Size(75, 23);
            this.alm3.TabIndex = 7;
            this.alm3.Text = "Almindelig";
            this.alm3.UseVisualStyleBackColor = true;
            this.alm3.Click += new System.EventHandler(this.alm3_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(84, 151);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(96, 17);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Fuldkornsbund";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // addFam3
            // 
            this.addFam3.Location = new System.Drawing.Point(3, 180);
            this.addFam3.Name = "addFam3";
            this.addFam3.Size = new System.Drawing.Size(75, 23);
            this.addFam3.TabIndex = 5;
            this.addFam3.Text = "Familie";
            this.addFam3.UseVisualStyleBackColor = true;
            this.addFam3.Click += new System.EventHandler(this.addFam3_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(84, 180);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(96, 17);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "Fuldkornsbund";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // ordre
            // 
            this.ordre.Location = new System.Drawing.Point(3, 209);
            this.ordre.Name = "ordre";
            this.ordre.Size = new System.Drawing.Size(75, 25);
            this.ordre.TabIndex = 8;
            this.ordre.Text = "Se Ordre";
            this.ordre.UseVisualStyleBackColor = true;
            this.ordre.Click += new System.EventHandler(this.ordre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button alm1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addFam1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button alm2;
        private System.Windows.Forms.Button addFam2;
        private System.Windows.Forms.Button alm3;
        private System.Windows.Forms.Button addFam3;
        private System.Windows.Forms.Button ordre;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox2;
    }
}

