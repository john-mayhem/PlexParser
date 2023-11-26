namespace PlexParser
{
    partial class Multiplex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonExit = new Button();
            buttonCreate = new Button();
            openFileDialog = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextBox = new RichTextBox();
            numericUpDown = new NumericUpDown();
            labelInput = new Label();
            labelOutput = new Label();
            labelNumOfFiles = new Label();
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            buttonSelectFile = new Button();
            buttonSelectFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 252);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(211, 54);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(368, 252);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(211, 54);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.WindowText;
            richTextBox.ForeColor = SystemColors.Window;
            richTextBox.Location = new Point(12, 100);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(567, 146);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(319, 270);
            numericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(43, 23);
            numericUpDown.TabIndex = 3;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 5);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(35, 15);
            labelInput.TabIndex = 4;
            labelInput.Text = "Input";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(12, 53);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(45, 15);
            labelOutput.TabIndex = 5;
            labelOutput.Text = "Output";
            // 
            // labelNumOfFiles
            // 
            labelNumOfFiles.AutoSize = true;
            labelNumOfFiles.Location = new Point(225, 272);
            labelNumOfFiles.Name = "labelNumOfFiles";
            labelNumOfFiles.Size = new Size(89, 15);
            labelNumOfFiles.TabIndex = 6;
            labelNumOfFiles.Text = "Number of files";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 23);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(443, 23);
            inputTextBox.TabIndex = 7;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(12, 71);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(443, 23);
            outputTextBox.TabIndex = 8;
            outputTextBox.TextChanged += outputTextBox_TextChanged;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(461, 23);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(118, 23);
            buttonSelectFile.TabIndex = 9;
            buttonSelectFile.Text = "Select File";
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.Location = new Point(461, 70);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new Size(118, 23);
            buttonSelectFolder.TabIndex = 10;
            buttonSelectFolder.Text = "Select Folder";
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // Multiplex
            // 
            AcceptButton = buttonCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(591, 311);
            Controls.Add(buttonSelectFolder);
            Controls.Add(buttonSelectFile);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(labelNumOfFiles);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(numericUpDown);
            Controls.Add(richTextBox);
            Controls.Add(buttonCreate);
            Controls.Add(buttonExit);
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(607, 350);
            MinimizeBox = false;
            MinimumSize = new Size(607, 350);
            Name = "Multiplex";
            Text = "MKVToolNix Multiplier";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button buttonCreate;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox richTextBox;
        private NumericUpDown numericUpDown;
        private Label labelInput;
        private Label labelOutput;
        private Label labelNumOfFiles;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button buttonSelectFile;
        private Button buttonSelectFolder;
    }
}