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
            this.alm1 = new System.Windows.Forms.Button();
            this.fam1 = new System.Windows.Forms.Button();
            this.alm2 = new System.Windows.Forms.Button();
            this.fam2 = new System.Windows.Forms.Button();
            this.alm3 = new System.Windows.Forms.Button();
            this.fam3 = new System.Windows.Forms.Button();
            this.ordre = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(715, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(82, 325);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.alm1);
            this.flowLayoutPanel2.Controls.Add(this.fam1);
            this.flowLayoutPanel2.Controls.Add(this.alm2);
            this.flowLayoutPanel2.Controls.Add(this.fam2);
            this.flowLayoutPanel2.Controls.Add(this.alm3);
            this.flowLayoutPanel2.Controls.Add(this.fam3);
            this.flowLayoutPanel2.Controls.Add(this.ordre);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(81, 205);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // alm1
            // 
            this.alm1.Location = new System.Drawing.Point(3, 3);
            this.alm1.Name = "alm1";
            this.alm1.Size = new System.Drawing.Size(75, 23);
            this.alm1.TabIndex = 0;
            this.alm1.Text = "Almindelig";
            this.alm1.UseVisualStyleBackColor = true;
            this.alm1.Click += new System.EventHandler(this.alm1_Click);
            // 
            // fam1
            // 
            this.fam1.Location = new System.Drawing.Point(3, 32);
            this.fam1.Name = "fam1";
            this.fam1.Size = new System.Drawing.Size(75, 23);
            this.fam1.TabIndex = 1;
            this.fam1.Text = "Familie";
            this.fam1.UseVisualStyleBackColor = true;
            // 
            // alm2
            // 
            this.alm2.Location = new System.Drawing.Point(3, 61);
            this.alm2.Name = "alm2";
            this.alm2.Size = new System.Drawing.Size(75, 23);
            this.alm2.TabIndex = 6;
            this.alm2.Text = "Almindelig";
            this.alm2.UseVisualStyleBackColor = true;
            this.alm2.Click += new System.EventHandler(this.alm2_Click);
            // 
            // fam2
            // 
            this.fam2.Location = new System.Drawing.Point(3, 90);
            this.fam2.Name = "fam2";
            this.fam2.Size = new System.Drawing.Size(75, 23);
            this.fam2.TabIndex = 4;
            this.fam2.Text = "Familie";
            this.fam2.UseVisualStyleBackColor = true;
            // 
            // alm3
            // 
            this.alm3.Location = new System.Drawing.Point(3, 119);
            this.alm3.Name = "alm3";
            this.alm3.Size = new System.Drawing.Size(75, 23);
            this.alm3.TabIndex = 7;
            this.alm3.Text = "Almindelig";
            this.alm3.UseVisualStyleBackColor = true;
            this.alm3.Click += new System.EventHandler(this.alm3_Click);
            // 
            // fam3
            // 
            this.fam3.Location = new System.Drawing.Point(3, 148);
            this.fam3.Name = "fam3";
            this.fam3.Size = new System.Drawing.Size(75, 23);
            this.fam3.TabIndex = 5;
            this.fam3.Text = "Familie";
            this.fam3.UseVisualStyleBackColor = true;
            // 
            // ordre
            // 
            this.ordre.Location = new System.Drawing.Point(3, 177);
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
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button alm1;
        private System.Windows.Forms.Button fam1;
        private System.Windows.Forms.Button fam2;
        private System.Windows.Forms.Button fam3;
        private System.Windows.Forms.Button alm2;
        private System.Windows.Forms.Button alm3;
        private System.Windows.Forms.Button ordre;
    }
}

