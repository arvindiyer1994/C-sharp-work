namespace Test1
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.HeadingSubLabel = new System.Windows.Forms.Label();
            this.GardenSizeLabel = new System.Windows.Forms.Label();
            this.GardenListBox = new System.Windows.Forms.ListBox();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.MowingCheckBox = new System.Windows.Forms.CheckBox();
            this.EdgingCheckBox = new System.Windows.Forms.CheckBox();
            this.PruningCheckBox = new System.Windows.Forms.CheckBox();
            this.GardenWasteCheckBox = new System.Windows.Forms.CheckBox();
            this.TreePruningCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServCostResLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(112, 47);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(346, 24);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Your garden maintainance estimator";
            // 
            // HeadingSubLabel
            // 
            this.HeadingSubLabel.AutoSize = true;
            this.HeadingSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingSubLabel.Location = new System.Drawing.Point(113, 82);
            this.HeadingSubLabel.Name = "HeadingSubLabel";
            this.HeadingSubLabel.Size = new System.Drawing.Size(334, 16);
            this.HeadingSubLabel.TabIndex = 1;
            this.HeadingSubLabel.Text = "Please provide information as requested below";
            // 
            // GardenSizeLabel
            // 
            this.GardenSizeLabel.AutoSize = true;
            this.GardenSizeLabel.Location = new System.Drawing.Point(113, 127);
            this.GardenSizeLabel.Name = "GardenSizeLabel";
            this.GardenSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.GardenSizeLabel.TabIndex = 2;
            this.GardenSizeLabel.Text = "Garden Size";
            // 
            // GardenListBox
            // 
            this.GardenListBox.FormattingEnabled = true;
            this.GardenListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.GardenListBox.Location = new System.Drawing.Point(116, 158);
            this.GardenListBox.Name = "GardenListBox";
            this.GardenListBox.Size = new System.Drawing.Size(162, 108);
            this.GardenListBox.TabIndex = 3;
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(323, 127);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(130, 13);
            this.TaskLabel.TabIndex = 4;
            this.TaskLabel.Text = "Choose the tasks required";
            // 
            // MowingCheckBox
            // 
            this.MowingCheckBox.AutoSize = true;
            this.MowingCheckBox.Location = new System.Drawing.Point(326, 158);
            this.MowingCheckBox.Name = "MowingCheckBox";
            this.MowingCheckBox.Size = new System.Drawing.Size(63, 17);
            this.MowingCheckBox.TabIndex = 5;
            this.MowingCheckBox.Text = "Mowing";
            this.MowingCheckBox.UseVisualStyleBackColor = true;
            // 
            // EdgingCheckBox
            // 
            this.EdgingCheckBox.AutoSize = true;
            this.EdgingCheckBox.Location = new System.Drawing.Point(326, 181);
            this.EdgingCheckBox.Name = "EdgingCheckBox";
            this.EdgingCheckBox.Size = new System.Drawing.Size(59, 17);
            this.EdgingCheckBox.TabIndex = 6;
            this.EdgingCheckBox.Text = "Edging";
            this.EdgingCheckBox.UseVisualStyleBackColor = true;
            // 
            // PruningCheckBox
            // 
            this.PruningCheckBox.AutoSize = true;
            this.PruningCheckBox.Location = new System.Drawing.Point(326, 204);
            this.PruningCheckBox.Name = "PruningCheckBox";
            this.PruningCheckBox.Size = new System.Drawing.Size(62, 17);
            this.PruningCheckBox.TabIndex = 7;
            this.PruningCheckBox.Text = "Pruning";
            this.PruningCheckBox.UseVisualStyleBackColor = true;
            // 
            // GardenWasteCheckBox
            // 
            this.GardenWasteCheckBox.AutoSize = true;
            this.GardenWasteCheckBox.Location = new System.Drawing.Point(326, 227);
            this.GardenWasteCheckBox.Name = "GardenWasteCheckBox";
            this.GardenWasteCheckBox.Size = new System.Drawing.Size(138, 17);
            this.GardenWasteCheckBox.TabIndex = 8;
            this.GardenWasteCheckBox.Text = "Garden Waste Disposal";
            this.GardenWasteCheckBox.UseVisualStyleBackColor = true;
            // 
            // TreePruningCheckBox
            // 
            this.TreePruningCheckBox.AutoSize = true;
            this.TreePruningCheckBox.Location = new System.Drawing.Point(326, 250);
            this.TreePruningCheckBox.Name = "TreePruningCheckBox";
            this.TreePruningCheckBox.Size = new System.Drawing.Size(87, 17);
            this.TreePruningCheckBox.TabIndex = 9;
            this.TreePruningCheckBox.Text = "Tree Pruning";
            this.TreePruningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total service cost:";
            // 
            // ServCostResLabel
            // 
            this.ServCostResLabel.AutoSize = true;
            this.ServCostResLabel.Location = new System.Drawing.Point(289, 293);
            this.ServCostResLabel.Name = "ServCostResLabel";
            this.ServCostResLabel.Size = new System.Drawing.Size(0, 13);
            this.ServCostResLabel.TabIndex = 11;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(116, 327);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 12;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(236, 327);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 13;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(331, 327);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 392);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.ServCostResLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TreePruningCheckBox);
            this.Controls.Add(this.GardenWasteCheckBox);
            this.Controls.Add(this.PruningCheckBox);
            this.Controls.Add(this.EdgingCheckBox);
            this.Controls.Add(this.MowingCheckBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.GardenListBox);
            this.Controls.Add(this.GardenSizeLabel);
            this.Controls.Add(this.HeadingSubLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "Form1";
            this.Text = "Garden Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label HeadingSubLabel;
        private System.Windows.Forms.Label GardenSizeLabel;
        private System.Windows.Forms.ListBox GardenListBox;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.CheckBox MowingCheckBox;
        private System.Windows.Forms.CheckBox EdgingCheckBox;
        private System.Windows.Forms.CheckBox PruningCheckBox;
        private System.Windows.Forms.CheckBox GardenWasteCheckBox;
        private System.Windows.Forms.CheckBox TreePruningCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ServCostResLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

