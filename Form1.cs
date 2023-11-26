namespace PlexParser
{
    public partial class Multiplex : Form
    {
        public Multiplex()
        {
            InitializeComponent();

            // Setup OpenFileDialog
            openFileDialog.Filter = "MTXCFG files (*.mtxcfg)|*.mtxcfg"; // Filters files to show only .mtxcfg
            openFileDialog.CheckFileExists = true; // Checks the file exists before returning from the dialog
            openFileDialog.CheckPathExists = true; // Checks the directory exists before returning from the dialog
            openFileDialog.Multiselect = false; // Allow only one file to be selected
            openFileDialog.FileName = ""; // Clear any pre-populated filenames
                                          // ... any other setup for the OpenFileDialog

            // Assign event handlers
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // If you need to handle events for other controls like openFileDialog or folderBrowserDialog, add them here
        }


        // Event handler for the 'Exit' button
        private void buttonExit_Click(object? sender, EventArgs e)
        {
            this.Close(); // Close the current form.
        }




        // Event handler for the 'Create' button
        private void buttonCreate_Click(object? sender, EventArgs e)
        {
            Log("Create button clicked - processing started."); // Log when processing starts

            string selectedFilePath = inputTextBox.Text; // Get the file path from the input field.
            string outputFolder = outputTextBox.Text; // Get the folder path from the output field.

            // Validate the selected file and output folder before proceeding.
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Please select a valid input file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method here.
            }

            if (string.IsNullOrEmpty(outputFolder) || !Directory.Exists(outputFolder))
            {
                MessageBox.Show("Please select a valid output folder.", "Invalid Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method here.
            }

            // If the selected file is '01.mtxcfg', we can proceed.
            if (Path.GetFileName(selectedFilePath).Equals("01.mtxcfg", StringComparison.OrdinalIgnoreCase))
            {
                int numOfFiles = (int)numericUpDown.Value; // Get the number of files to create.

                // Process the file the specified number of times.
                for (int i = 2; i <= numOfFiles + 1; i++) // Start from 2 because we are creating files from "02"
                {
                    ProcessFile(selectedFilePath, outputFolder, i);
                }

                MessageBox.Show("File processing completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select the file named '01.mtxcfg'.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Log("Processing completed."); // Log when processing ends

        }

        private void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            richTextBox.AppendText($"[{timestamp}] {message}\n");
        }



        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folder = folderBrowserDialog1.SelectedPath;
                outputTextBox.Text = folder;
                Log($"Selected output folder: {folder}");
            }
        }


        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                inputTextBox.Text = file;
                Log($"Selected file: {file}");
            }
        }


        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void ProcessFile(string inputPath, string outputPath, int fileNumber)
        {
            try
            {
                // Read the contents of the original file.
                string content = File.ReadAllText(inputPath);

                // Replace all occurrences of "01" with the new number, formatted with a leading zero if necessary.
                string newContent = content.Replace("01", fileNumber.ToString("D2"));

                // Construct the new file name based on the original file.
                string newFileName = Path.GetFileNameWithoutExtension(inputPath).Replace("01", fileNumber.ToString("D2")) + ".mtxcfg";

                // Combine the new file name with the output path.
                string newFilePath = Path.Combine(outputPath, newFileName);

                // Write the modified content to the new file.
                File.WriteAllText(newFilePath, newContent);

                Log($"Created file: {newFilePath}");
            }
            catch (Exception ex)
            {
                Log($"Error: {ex.Message}");
            }

        }
    }
}
