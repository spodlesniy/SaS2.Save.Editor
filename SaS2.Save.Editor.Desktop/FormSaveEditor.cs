using SaS2.Save.Editor.Desktop.Properties;

namespace SaS2.Save.Editor.Desktop
{
    public partial class FormSaveEditor : Form
    {
        private string fileName = string.Empty;
        private SaS2Save? saS2Save;

        public FormSaveEditor()
        {
            InitializeComponent();

            textGameDir.Text = Settings.Default.GameFolderPath;
        }

        private void buttonOpenSaveFile_Click(object sender, EventArgs e)
        {
            if (dialogOpenSaveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = dialogOpenSaveFile.FileName;
                textSaveFilePath.Text = fileName;

                LogLine($"Selected file: {fileName}");

                buttonOpenSaveFile.Enabled = false;
                labelNoSaveFileSelected.Text = "Reading save file";
                labelNoSaveFileSelected.Visible = true;


                SuspendLayout();

                try
                {
                    ReadSaveFile();

                    if (saS2Save != null)
                    {
                        saveDetails.LoadSaveDetails(saS2Save);
                        saveDetails.Visible = true;
                    }

                    buttonOpenWriteFile.Enabled = true;
                }
                finally
                {
                    ResumeLayout();

                    labelNoSaveFileSelected.Visible = false;
                    labelNoSaveFileSelected.Text = "Save file is not selected";
                    buttonOpenSaveFile.Enabled = true;
                }
            }
        }

        private void ClearLogs()
        {
            textLogs.Clear();
        }

        private void LogLine(string line)
        {
            textLogs.AppendText($"[{DateTime.Now:T}]: {line.Trim()}\r\n");
        }

        private void ReadSaveFile()
        {
            try
            {
                if (String.IsNullOrEmpty(fileName))
                {
                    throw new Exception("File name null or empty");
                }

                LogLine("Start reading file");

                saS2Save = new SaS2Save();
                saS2Save.Read(fileName);
            }
            catch (Exception ex)
            {
                LogLine($"Read file error: {ex.Message}");

                throw;
            }
        }

        private void buttonOpenWriteFile_Click(object sender, EventArgs e)
        {
            if (saS2Save == null)
            {
                LogLine($"Can't write file: empy data");

                return;
            }

            if (dialogOpenWriteFile.ShowDialog() == DialogResult.OK)
            {
                var writeFileName = dialogOpenWriteFile.FileName;

                LogLine($"Selected file for writing: {writeFileName}");

                buttonOpenSaveFile.Enabled = false;
                buttonOpenWriteFile.Enabled = false;
                saveDetails.Enabled = false;

                try
                {
                    using var binaryWriter = new BinaryWriter(File.OpenWrite(writeFileName));

                    LogLine("Start writing file");

                    binaryWriter.BaseStream.SetLength(0);

                    saS2Save.Write(binaryWriter);

                    saveDetails.LoadSaveDetails(saS2Save);

                    LogLine("Writing finished");
                }
                finally
                {
                    saveDetails.Enabled = true;
                    buttonOpenWriteFile.Enabled = true;
                    buttonOpenSaveFile.Enabled = true;
                }
            }
        }
    }
}
