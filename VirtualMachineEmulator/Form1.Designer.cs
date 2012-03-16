namespace VirtualMachineEmulator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterInputButton = new System.Windows.Forms.Button();
            this.VirtualMemoryGroupBox = new System.Windows.Forms.GroupBox();
            this.VirtualMemoryGridView = new System.Windows.Forms.DataGridView();
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelPC = new System.Windows.Forms.Label();
            this.labelCX = new System.Windows.Forms.Label();
            this.labelAX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParamGroupBox = new System.Windows.Forms.GroupBox();
            this.executeAllButton = new System.Windows.Forms.Button();
            this.executeNextButton = new System.Windows.Forms.Button();
            this.nextCommandLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.openTaskButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.VirtualMemoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VirtualMemoryGridView)).BeginInit();
            this.RegisterGroupBox.SuspendLayout();
            this.ParamGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.White;
            this.inputTextBox.Enabled = false;
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputTextBox.Location = new System.Drawing.Point(12, 295);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(387, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // enterInputButton
            // 
            this.enterInputButton.Enabled = false;
            this.enterInputButton.Location = new System.Drawing.Point(405, 295);
            this.enterInputButton.Name = "enterInputButton";
            this.enterInputButton.Size = new System.Drawing.Size(75, 23);
            this.enterInputButton.TabIndex = 1;
            this.enterInputButton.Text = "Enter";
            this.enterInputButton.UseVisualStyleBackColor = true;
            this.enterInputButton.Click += new System.EventHandler(this.enterInputButton_Click);
            // 
            // VirtualMemoryGroupBox
            // 
            this.VirtualMemoryGroupBox.Controls.Add(this.VirtualMemoryGridView);
            this.VirtualMemoryGroupBox.Location = new System.Drawing.Point(12, 18);
            this.VirtualMemoryGroupBox.Name = "VirtualMemoryGroupBox";
            this.VirtualMemoryGroupBox.Size = new System.Drawing.Size(625, 179);
            this.VirtualMemoryGroupBox.TabIndex = 2;
            this.VirtualMemoryGroupBox.TabStop = false;
            this.VirtualMemoryGroupBox.Text = "Virtual Memory";
            // 
            // VirtualMemoryGridView
            // 
            this.VirtualMemoryGridView.AllowUserToAddRows = false;
            this.VirtualMemoryGridView.AllowUserToDeleteRows = false;
            this.VirtualMemoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VirtualMemoryGridView.Location = new System.Drawing.Point(7, 19);
            this.VirtualMemoryGridView.Name = "VirtualMemoryGridView";
            this.VirtualMemoryGridView.ReadOnly = true;
            this.VirtualMemoryGridView.Size = new System.Drawing.Size(612, 154);
            this.VirtualMemoryGridView.TabIndex = 0;
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.Controls.Add(this.labelSF);
            this.RegisterGroupBox.Controls.Add(this.labelPC);
            this.RegisterGroupBox.Controls.Add(this.labelCX);
            this.RegisterGroupBox.Controls.Add(this.labelAX);
            this.RegisterGroupBox.Location = new System.Drawing.Point(643, 18);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Size = new System.Drawing.Size(353, 53);
            this.RegisterGroupBox.TabIndex = 3;
            this.RegisterGroupBox.TabStop = false;
            this.RegisterGroupBox.Text = "Registers";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Location = new System.Drawing.Point(260, 25);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(10, 13);
            this.labelSF.TabIndex = 3;
            this.labelSF.Text = "-";
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Location = new System.Drawing.Point(194, 25);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(10, 13);
            this.labelPC.TabIndex = 2;
            this.labelPC.Text = "-";
            // 
            // labelCX
            // 
            this.labelCX.AutoSize = true;
            this.labelCX.Location = new System.Drawing.Point(110, 25);
            this.labelCX.Name = "labelCX";
            this.labelCX.Size = new System.Drawing.Size(10, 13);
            this.labelCX.TabIndex = 1;
            this.labelCX.Text = "-";
            // 
            // labelAX
            // 
            this.labelAX.AutoSize = true;
            this.labelAX.Location = new System.Drawing.Point(16, 25);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(10, 13);
            this.labelAX.TabIndex = 0;
            this.labelAX.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Table";
            // 
            // ParamGroupBox
            // 
            this.ParamGroupBox.Controls.Add(this.executeAllButton);
            this.ParamGroupBox.Controls.Add(this.executeNextButton);
            this.ParamGroupBox.Controls.Add(this.nextCommandLabel);
            this.ParamGroupBox.Controls.Add(this.taskNameLabel);
            this.ParamGroupBox.Controls.Add(this.openTaskButton);
            this.ParamGroupBox.Location = new System.Drawing.Point(643, 78);
            this.ParamGroupBox.Name = "ParamGroupBox";
            this.ParamGroupBox.Size = new System.Drawing.Size(352, 119);
            this.ParamGroupBox.TabIndex = 5;
            this.ParamGroupBox.TabStop = false;
            this.ParamGroupBox.Text = "Parameters";
            // 
            // executeAllButton
            // 
            this.executeAllButton.Location = new System.Drawing.Point(263, 78);
            this.executeAllButton.Name = "executeAllButton";
            this.executeAllButton.Size = new System.Drawing.Size(75, 23);
            this.executeAllButton.TabIndex = 4;
            this.executeAllButton.Text = "Execute All";
            this.executeAllButton.UseVisualStyleBackColor = true;
            this.executeAllButton.Click += new System.EventHandler(this.executeAllButton_Click);
            // 
            // executeNextButton
            // 
            this.executeNextButton.Location = new System.Drawing.Point(263, 48);
            this.executeNextButton.Name = "executeNextButton";
            this.executeNextButton.Size = new System.Drawing.Size(75, 23);
            this.executeNextButton.TabIndex = 3;
            this.executeNextButton.Text = "Execute";
            this.executeNextButton.UseVisualStyleBackColor = true;
            this.executeNextButton.Click += new System.EventHandler(this.executeNextButton_Click);
            // 
            // nextCommandLabel
            // 
            this.nextCommandLabel.AutoSize = true;
            this.nextCommandLabel.Location = new System.Drawing.Point(16, 53);
            this.nextCommandLabel.Name = "nextCommandLabel";
            this.nextCommandLabel.Size = new System.Drawing.Size(126, 13);
            this.nextCommandLabel.TabIndex = 2;
            this.nextCommandLabel.Text = "Next command = <none>";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(16, 24);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(112, 13);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Current task = <none>";
            // 
            // openTaskButton
            // 
            this.openTaskButton.Location = new System.Drawing.Point(263, 19);
            this.openTaskButton.Name = "openTaskButton";
            this.openTaskButton.Size = new System.Drawing.Size(75, 23);
            this.openTaskButton.TabIndex = 0;
            this.openTaskButton.Text = "Open Task";
            this.openTaskButton.UseVisualStyleBackColor = true;
            this.openTaskButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputTextBox);
            this.outputGroupBox.Location = new System.Drawing.Point(643, 203);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(352, 86);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(7, 19);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(339, 61);
            this.outputTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 325);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.ParamGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RegisterGroupBox);
            this.Controls.Add(this.VirtualMemoryGroupBox);
            this.Controls.Add(this.enterInputButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VirtualMemoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VirtualMemoryGridView)).EndInit();
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.ParamGroupBox.ResumeLayout(false);
            this.ParamGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button enterInputButton;
        private System.Windows.Forms.GroupBox VirtualMemoryGroupBox;
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Label labelCX;
        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView VirtualMemoryGridView;
        private System.Windows.Forms.GroupBox ParamGroupBox;
        private System.Windows.Forms.Button openTaskButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Button executeNextButton;
        private System.Windows.Forms.Label nextCommandLabel;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button executeAllButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

