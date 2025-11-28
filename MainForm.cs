using System;
using System.IO;
using System.Windows.Forms;

namespace PlexParser
{
    public partial class Multiplex : Form
    {
        private const string TemplateFileName = "01.mtxcfg";
        private readonly FileProcessor _fileProcessor;
        private readonly Logger _logger;

        public Multiplex()
        {
            InitializeComponent();

            // Setup OpenFileDialog
            openFileDialog.Filter = "MTXCFG files (*.mtxcfg)|*.mtxcfg";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = "";

            // Initialize dependencies
            _logger = new Logger(richTextBox);

            // Assign event handlers
            buttonExit.Click += ButtonExit_Click!;
            buttonCreate.Click += ButtonCreate_Click!;
            buttonSelectFolder.Click += ButtonSelectFolder_Click!;
            buttonSelectFile.Click += ButtonSelectFile_Click!;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string inputFilePath = inputTextBox.Text;
            string outputFolderPath = outputTextBox.Text;

            if (!ValidateInputs(inputFilePath, outputFolderPath))
                return;

            if (!Path.GetFileName(inputFilePath).Equals(TemplateFileName, StringComparison.OrdinalIgnoreCase))
            {
                ShowError("Please select the file named '01.mtxcfg'.");
                return;
            }

            _logger.Log("Create button clicked - processing started.");

            int numOfFiles = (int)numericUpDown.Value;
            for (int i = 2; i <= numOfFiles + 1; i++)
            {
                FileProcessor.ProcessFile(inputFilePath, outputFolderPath, i);
            }

            ShowSuccess("File processing completed.");
            _logger.Log("Processing completed.");
        }

        private static bool ValidateInputs(string inputFilePath, string outputFolderPath)
        {
            if (string.IsNullOrEmpty(inputFilePath) || !File.Exists(inputFilePath))
            {
                ShowError("Please select a valid input file.");
                return false;
            }

            if (string.IsNullOrEmpty(outputFolderPath) || !Directory.Exists(outputFolderPath))
            {
                ShowError("Please select a valid output folder.");
                return false;
            }

            return true;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = folderBrowserDialog1.SelectedPath;
                _logger.Log($"Selected output folder: {folderBrowserDialog1.SelectedPath}");
            }
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputTextBox.Text = openFileDialog.FileName;
                _logger.Log($"Selected file: {openFileDialog.FileName}");
            }
        }
    }

    public class FileProcessor
    {
        public static void ProcessFile(string inputPath, string outputPath, int fileNumber)
        {
            try
            {
                string content = File.ReadAllText(inputPath);
                string newContent = content.Replace("01", fileNumber.ToString("D2"));
                string newFileName = Path.GetFileNameWithoutExtension(inputPath).Replace("01", fileNumber.ToString("D2")) + ".mtxcfg";
                string newFilePath = Path.Combine(outputPath, newFileName);

                File.WriteAllText(newFilePath, newContent);
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class Logger
    {
        private readonly RichTextBox _richTextBox;

        public Logger(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        public void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _richTextBox.AppendText($"[{timestamp}] {message}\n");
        }
    }
}