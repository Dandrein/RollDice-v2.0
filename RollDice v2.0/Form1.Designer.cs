
namespace RollDice_v2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.bStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudD100 = new System.Windows.Forms.NumericUpDown();
            this.nudD20 = new System.Windows.Forms.NumericUpDown();
            this.nudD12 = new System.Windows.Forms.NumericUpDown();
            this.nudD10 = new System.Windows.Forms.NumericUpDown();
            this.nudD8 = new System.Windows.Forms.NumericUpDown();
            this.nudD6 = new System.Windows.Forms.NumericUpDown();
            this.nudD4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudD100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loading);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bStart);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.nudD100);
            this.splitContainer1.Panel2.Controls.Add(this.nudD20);
            this.splitContainer1.Panel2.Controls.Add(this.nudD12);
            this.splitContainer1.Panel2.Controls.Add(this.nudD10);
            this.splitContainer1.Panel2.Controls.Add(this.nudD8);
            this.splitContainer1.Panel2.Controls.Add(this.nudD6);
            this.splitContainer1.Panel2.Controls.Add(this.nudD4);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(634, 211);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 0;
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(630, 35);
            this.loading.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(25, 78);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(582, 76);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Кинуть кубы!";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(525, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "D100";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(441, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "D20";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(357, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "D12";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "D10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(193, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "D8";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "D6";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "D4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudD100
            // 
            this.nudD100.Location = new System.Drawing.Point(529, 37);
            this.nudD100.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD100.Name = "nudD100";
            this.nudD100.Size = new System.Drawing.Size(78, 26);
            this.nudD100.TabIndex = 0;
            this.nudD100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD20
            // 
            this.nudD20.Location = new System.Drawing.Point(445, 37);
            this.nudD20.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD20.Name = "nudD20";
            this.nudD20.Size = new System.Drawing.Size(78, 26);
            this.nudD20.TabIndex = 0;
            this.nudD20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD12
            // 
            this.nudD12.Location = new System.Drawing.Point(361, 37);
            this.nudD12.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD12.Name = "nudD12";
            this.nudD12.Size = new System.Drawing.Size(78, 26);
            this.nudD12.TabIndex = 0;
            this.nudD12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD10
            // 
            this.nudD10.Location = new System.Drawing.Point(277, 37);
            this.nudD10.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD10.Name = "nudD10";
            this.nudD10.Size = new System.Drawing.Size(78, 26);
            this.nudD10.TabIndex = 0;
            this.nudD10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD8
            // 
            this.nudD8.Location = new System.Drawing.Point(193, 37);
            this.nudD8.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD8.Name = "nudD8";
            this.nudD8.Size = new System.Drawing.Size(78, 26);
            this.nudD8.TabIndex = 0;
            this.nudD8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD6
            // 
            this.nudD6.Location = new System.Drawing.Point(109, 37);
            this.nudD6.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD6.Name = "nudD6";
            this.nudD6.Size = new System.Drawing.Size(78, 26);
            this.nudD6.TabIndex = 0;
            this.nudD6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudD4
            // 
            this.nudD4.Location = new System.Drawing.Point(25, 37);
            this.nudD4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudD4.Name = "nudD4";
            this.nudD4.Size = new System.Drawing.Size(78, 26);
            this.nudD4.TabIndex = 0;
            this.nudD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 211);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll Dice v2.0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudD100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudD100;
        private System.Windows.Forms.NumericUpDown nudD20;
        private System.Windows.Forms.NumericUpDown nudD12;
        private System.Windows.Forms.NumericUpDown nudD10;
        private System.Windows.Forms.NumericUpDown nudD8;
        private System.Windows.Forms.NumericUpDown nudD6;
        private System.Windows.Forms.NumericUpDown nudD4;
    }
}

