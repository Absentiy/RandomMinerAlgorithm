namespace RandomMinerAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MakeFile_BTN = new System.Windows.Forms.Button();
            this.RTMax_NUD = new System.Windows.Forms.NumericUpDown();
            this.RTMin_NUD = new System.Windows.Forms.NumericUpDown();
            this.SplitCh_NUD = new System.Windows.Forms.NumericUpDown();
            this.MaxStep_NUD = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.status_label = new System.Windows.Forms.Label();
            this.logRTB = new System.Windows.Forms.RichTextBox();
            this.Height_NUD = new System.Windows.Forms.NumericUpDown();
            this.Width_NUD = new System.Windows.Forms.NumericUpDown();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.MainCanvas = new System.Windows.Forms.PictureBox();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTMax_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTMin_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCh_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStep_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(139, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 4;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(139, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 5;
            label2.Text = "Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(99, 191);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 13);
            label3.TabIndex = 11;
            label3.Text = "Max steps";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(99, 218);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 13);
            label4.TabIndex = 12;
            label4.Text = "Split chance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(66, 270);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 15;
            label5.Text = "Rotation timer min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(66, 294);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 13);
            label6.TabIndex = 16;
            label6.Text = "Rotation timer max";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MakeFile_BTN);
            this.splitContainer1.Panel1.Controls.Add(label6);
            this.splitContainer1.Panel1.Controls.Add(label5);
            this.splitContainer1.Panel1.Controls.Add(this.RTMax_NUD);
            this.splitContainer1.Panel1.Controls.Add(this.RTMin_NUD);
            this.splitContainer1.Panel1.Controls.Add(label4);
            this.splitContainer1.Panel1.Controls.Add(label3);
            this.splitContainer1.Panel1.Controls.Add(this.SplitCh_NUD);
            this.splitContainer1.Panel1.Controls.Add(this.MaxStep_NUD);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.status_label);
            this.splitContainer1.Panel1.Controls.Add(this.logRTB);
            this.splitContainer1.Panel1.Controls.Add(label2);
            this.splitContainer1.Panel1.Controls.Add(label1);
            this.splitContainer1.Panel1.Controls.Add(this.Height_NUD);
            this.splitContainer1.Panel1.Controls.Add(this.Width_NUD);
            this.splitContainer1.Panel1.Controls.Add(this.Start_BTN);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(784, 461);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // MakeFile_BTN
            // 
            this.MakeFile_BTN.Location = new System.Drawing.Point(3, 330);
            this.MakeFile_BTN.Name = "MakeFile_BTN";
            this.MakeFile_BTN.Size = new System.Drawing.Size(198, 23);
            this.MakeFile_BTN.TabIndex = 17;
            this.MakeFile_BTN.Text = "Make file";
            this.MakeFile_BTN.UseVisualStyleBackColor = true;
            this.MakeFile_BTN.Click += new System.EventHandler(this.MakeFile_BTN_Click);
            // 
            // RTMax_NUD
            // 
            this.RTMax_NUD.Location = new System.Drawing.Point(13, 294);
            this.RTMax_NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RTMax_NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RTMax_NUD.Name = "RTMax_NUD";
            this.RTMax_NUD.Size = new System.Drawing.Size(46, 20);
            this.RTMax_NUD.TabIndex = 14;
            this.RTMax_NUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // RTMin_NUD
            // 
            this.RTMin_NUD.Location = new System.Drawing.Point(13, 268);
            this.RTMin_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RTMin_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RTMin_NUD.Name = "RTMin_NUD";
            this.RTMin_NUD.Size = new System.Drawing.Size(46, 20);
            this.RTMin_NUD.TabIndex = 13;
            this.RTMin_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SplitCh_NUD
            // 
            this.SplitCh_NUD.Location = new System.Drawing.Point(13, 216);
            this.SplitCh_NUD.Name = "SplitCh_NUD";
            this.SplitCh_NUD.Size = new System.Drawing.Size(80, 20);
            this.SplitCh_NUD.TabIndex = 10;
            this.SplitCh_NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MaxStep_NUD
            // 
            this.MaxStep_NUD.Location = new System.Drawing.Point(13, 189);
            this.MaxStep_NUD.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.MaxStep_NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxStep_NUD.Name = "MaxStep_NUD";
            this.MaxStep_NUD.Size = new System.Drawing.Size(80, 20);
            this.MaxStep_NUD.TabIndex = 9;
            this.MaxStep_NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(13, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Build rooms";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(58, 18);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(35, 13);
            this.status_label.TabIndex = 7;
            this.status_label.Text = "label3";
            // 
            // logRTB
            // 
            this.logRTB.Location = new System.Drawing.Point(13, 96);
            this.logRTB.Name = "logRTB";
            this.logRTB.Size = new System.Drawing.Size(188, 62);
            this.logRTB.TabIndex = 6;
            this.logRTB.Text = "";
            // 
            // Height_NUD
            // 
            this.Height_NUD.Location = new System.Drawing.Point(13, 69);
            this.Height_NUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Height_NUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Height_NUD.Name = "Height_NUD";
            this.Height_NUD.Size = new System.Drawing.Size(120, 20);
            this.Height_NUD.TabIndex = 3;
            this.Height_NUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Width_NUD
            // 
            this.Width_NUD.Location = new System.Drawing.Point(13, 43);
            this.Width_NUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Width_NUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Width_NUD.Name = "Width_NUD";
            this.Width_NUD.Size = new System.Drawing.Size(120, 20);
            this.Width_NUD.TabIndex = 2;
            this.Width_NUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Start_BTN
            // 
            this.Start_BTN.Location = new System.Drawing.Point(13, 13);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(39, 23);
            this.Start_BTN.TabIndex = 0;
            this.Start_BTN.Text = "Start";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.MainCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCanvas.Location = new System.Drawing.Point(0, 0);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(576, 461);
            this.MainCanvas.TabIndex = 0;
            this.MainCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTMax_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTMin_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCh_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStep_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.PictureBox MainCanvas;
        private System.Windows.Forms.NumericUpDown Height_NUD;
        private System.Windows.Forms.NumericUpDown Width_NUD;
        private System.Windows.Forms.RichTextBox logRTB;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown SplitCh_NUD;
        private System.Windows.Forms.NumericUpDown MaxStep_NUD;
        private System.Windows.Forms.NumericUpDown RTMax_NUD;
        private System.Windows.Forms.NumericUpDown RTMin_NUD;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Button MakeFile_BTN;
    }
}

