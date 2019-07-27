namespace Ex3_19003409
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
            this.WeatherInfoLabel = new System.Windows.Forms.Label();
            this.LongTermAvgLabel = new System.Windows.Forms.Label();
            this.LongTermAvgListbox = new System.Windows.Forms.ListBox();
            this.TempVarListbox = new System.Windows.Forms.ListBox();
            this.TempVarLabel = new System.Windows.Forms.Label();
            this.CurrentDailyAvgLabel = new System.Windows.Forms.Label();
            this.CurDailyAvgListbox = new System.Windows.Forms.ListBox();
            this.HighTempLabel = new System.Windows.Forms.Label();
            this.LowTempLabel = new System.Windows.Forms.Label();
            this.GetAvgBtn = new System.Windows.Forms.Button();
            this.GetDiffBtn = new System.Windows.Forms.Button();
            this.GetHiLowBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HiTempResLabel = new System.Windows.Forms.Label();
            this.LowTempResLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeatherInfoLabel
            // 
            this.WeatherInfoLabel.AutoSize = true;
            this.WeatherInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherInfoLabel.Location = new System.Drawing.Point(208, 50);
            this.WeatherInfoLabel.Name = "WeatherInfoLabel";
            this.WeatherInfoLabel.Size = new System.Drawing.Size(121, 13);
            this.WeatherInfoLabel.TabIndex = 0;
            this.WeatherInfoLabel.Text = "Weather information";
            // 
            // LongTermAvgLabel
            // 
            this.LongTermAvgLabel.AutoSize = true;
            this.LongTermAvgLabel.Location = new System.Drawing.Point(85, 94);
            this.LongTermAvgLabel.Name = "LongTermAvgLabel";
            this.LongTermAvgLabel.Size = new System.Drawing.Size(101, 13);
            this.LongTermAvgLabel.TabIndex = 1;
            this.LongTermAvgLabel.Text = "Long Term Average";
            // 
            // LongTermAvgListbox
            // 
            this.LongTermAvgListbox.FormattingEnabled = true;
            this.LongTermAvgListbox.Location = new System.Drawing.Point(88, 111);
            this.LongTermAvgListbox.Name = "LongTermAvgListbox";
            this.LongTermAvgListbox.Size = new System.Drawing.Size(109, 82);
            this.LongTermAvgListbox.TabIndex = 2;
            // 
            // TempVarListbox
            // 
            this.TempVarListbox.FormattingEnabled = true;
            this.TempVarListbox.Location = new System.Drawing.Point(256, 111);
            this.TempVarListbox.Name = "TempVarListbox";
            this.TempVarListbox.Size = new System.Drawing.Size(108, 121);
            this.TempVarListbox.TabIndex = 3;
            // 
            // TempVarLabel
            // 
            this.TempVarLabel.AutoSize = true;
            this.TempVarLabel.Location = new System.Drawing.Point(256, 94);
            this.TempVarLabel.Name = "TempVarLabel";
            this.TempVarLabel.Size = new System.Drawing.Size(111, 13);
            this.TempVarLabel.TabIndex = 4;
            this.TempVarLabel.Text = "Temperature Variation";
            // 
            // CurrentDailyAvgLabel
            // 
            this.CurrentDailyAvgLabel.AutoSize = true;
            this.CurrentDailyAvgLabel.Location = new System.Drawing.Point(88, 205);
            this.CurrentDailyAvgLabel.Name = "CurrentDailyAvgLabel";
            this.CurrentDailyAvgLabel.Size = new System.Drawing.Size(110, 13);
            this.CurrentDailyAvgLabel.TabIndex = 5;
            this.CurrentDailyAvgLabel.Text = "Current Daily Average";
            // 
            // CurDailyAvgListbox
            // 
            this.CurDailyAvgListbox.FormattingEnabled = true;
            this.CurDailyAvgListbox.Location = new System.Drawing.Point(88, 222);
            this.CurDailyAvgListbox.Name = "CurDailyAvgListbox";
            this.CurDailyAvgListbox.Size = new System.Drawing.Size(110, 95);
            this.CurDailyAvgListbox.TabIndex = 6;
            // 
            // HighTempLabel
            // 
            this.HighTempLabel.AutoSize = true;
            this.HighTempLabel.Location = new System.Drawing.Point(256, 267);
            this.HighTempLabel.Name = "HighTempLabel";
            this.HighTempLabel.Size = new System.Drawing.Size(106, 13);
            this.HighTempLabel.TabIndex = 7;
            this.HighTempLabel.Text = "Highest Temperature";
            // 
            // LowTempLabel
            // 
            this.LowTempLabel.AutoSize = true;
            this.LowTempLabel.Location = new System.Drawing.Point(256, 289);
            this.LowTempLabel.Name = "LowTempLabel";
            this.LowTempLabel.Size = new System.Drawing.Size(104, 13);
            this.LowTempLabel.TabIndex = 8;
            this.LowTempLabel.Text = "Lowest Temperature";
            // 
            // GetAvgBtn
            // 
            this.GetAvgBtn.Location = new System.Drawing.Point(465, 111);
            this.GetAvgBtn.Name = "GetAvgBtn";
            this.GetAvgBtn.Size = new System.Drawing.Size(106, 23);
            this.GetAvgBtn.TabIndex = 9;
            this.GetAvgBtn.Text = "Get Daily Averages";
            this.GetAvgBtn.UseVisualStyleBackColor = true;
            this.GetAvgBtn.Click += new System.EventHandler(this.GetAvgBtn_Click);
            // 
            // GetDiffBtn
            // 
            this.GetDiffBtn.Location = new System.Drawing.Point(465, 141);
            this.GetDiffBtn.Name = "GetDiffBtn";
            this.GetDiffBtn.Size = new System.Drawing.Size(106, 23);
            this.GetDiffBtn.TabIndex = 10;
            this.GetDiffBtn.Text = "Get Differences";
            this.GetDiffBtn.UseVisualStyleBackColor = true;
            this.GetDiffBtn.Click += new System.EventHandler(this.GetDiffBtn_Click);
            // 
            // GetHiLowBtn
            // 
            this.GetHiLowBtn.Location = new System.Drawing.Point(465, 171);
            this.GetHiLowBtn.Name = "GetHiLowBtn";
            this.GetHiLowBtn.Size = new System.Drawing.Size(106, 23);
            this.GetHiLowBtn.TabIndex = 11;
            this.GetHiLowBtn.Text = "Get High/Low";
            this.GetHiLowBtn.UseVisualStyleBackColor = true;
            this.GetHiLowBtn.Click += new System.EventHandler(this.GetHiLowBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(465, 200);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(106, 23);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HiTempResLabel
            // 
            this.HiTempResLabel.AutoSize = true;
            this.HiTempResLabel.Location = new System.Drawing.Point(368, 267);
            this.HiTempResLabel.Name = "HiTempResLabel";
            this.HiTempResLabel.Size = new System.Drawing.Size(0, 13);
            this.HiTempResLabel.TabIndex = 13;
            // 
            // LowTempResLabel
            // 
            this.LowTempResLabel.AutoSize = true;
            this.LowTempResLabel.Location = new System.Drawing.Point(368, 289);
            this.LowTempResLabel.Name = "LowTempResLabel";
            this.LowTempResLabel.Size = new System.Drawing.Size(0, 13);
            this.LowTempResLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LowTempResLabel);
            this.Controls.Add(this.HiTempResLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.GetHiLowBtn);
            this.Controls.Add(this.GetDiffBtn);
            this.Controls.Add(this.GetAvgBtn);
            this.Controls.Add(this.LowTempLabel);
            this.Controls.Add(this.HighTempLabel);
            this.Controls.Add(this.CurDailyAvgListbox);
            this.Controls.Add(this.CurrentDailyAvgLabel);
            this.Controls.Add(this.TempVarLabel);
            this.Controls.Add(this.TempVarListbox);
            this.Controls.Add(this.LongTermAvgListbox);
            this.Controls.Add(this.LongTermAvgLabel);
            this.Controls.Add(this.WeatherInfoLabel);
            this.Name = "Form1";
            this.Text = "Arvind Iyer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeatherInfoLabel;
        private System.Windows.Forms.Label LongTermAvgLabel;
        private System.Windows.Forms.ListBox LongTermAvgListbox;
        private System.Windows.Forms.ListBox TempVarListbox;
        private System.Windows.Forms.Label TempVarLabel;
        private System.Windows.Forms.Label CurrentDailyAvgLabel;
        private System.Windows.Forms.ListBox CurDailyAvgListbox;
        private System.Windows.Forms.Label HighTempLabel;
        private System.Windows.Forms.Label LowTempLabel;
        private System.Windows.Forms.Button GetAvgBtn;
        private System.Windows.Forms.Button GetDiffBtn;
        private System.Windows.Forms.Button GetHiLowBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label HiTempResLabel;
        private System.Windows.Forms.Label LowTempResLabel;
    }
}

