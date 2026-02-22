using SaS2.Save.Editor.Controls;
using SaS2.Save.Editor.Desktop.Properties;

namespace SaS2.Save.Editor.Desktop
{
    public partial class FormRequirementsCheck : Form
    {
        public FormRequirementsCheck()
        {
            InitializeComponent();
        }

        private void CloseAndOpenSaveEditorForm()
        {
            Hide();
            (new FormSaveEditor()).ShowDialog();
            Close();
        }

        private bool CheckGameFolder(string gameFolderPath)
        {
            buttonBrowse.Enabled = false;

            try
            {
                LogLine($"Start game folder \"{gameFolderPath}\" check");

                // Case sensitive?
                var lootFilePath = Path.Combine(gameFolderPath, "Loot", "data", "loot.zls");

                if (!File.Exists(lootFilePath))
                {
                    LogLine($"Loot definitions file {lootFilePath} is not found");

                    return false;
                }

                var itemsXnbFilePath = Path.Combine(gameFolderPath, "Content", "gfx", "items.xnb");

                if (!File.Exists(itemsXnbFilePath))
                {
                    LogLine($"items.xnb file {itemsXnbFilePath} is not found");

                    return false;
                }

                LogLine($"Found {itemsXnbFilePath}");

                var interfaceXnbFilePath = Path.Combine(gameFolderPath, "Content", "gfx", "interface.xnb");

                if (!File.Exists(interfaceXnbFilePath))
                {
                    LogLine($"interface.xnb file {interfaceXnbFilePath} is not found");

                    return false;
                }

                LogLine($"Found {interfaceXnbFilePath}");


                LogLine($"Loading Loot definitions from {lootFilePath}");

                SaS2LootCatalog.Init();
                SaS2LootCatalog.Read(lootFilePath);

                LogLine($"Loaded {SaS2LootCatalog.lootDefs.Count} Loot definitions from {lootFilePath}");

                LogLine($"Loading images from {itemsXnbFilePath} and {interfaceXnbFilePath}. It can take a while");

                EventHandler<ImageSource.ImageSourceOnImageAddEventArgs> onImageAddHandler = (_, args) =>
                {
                    LogLine($"Added {ImageSource.ImageList.Count}/{SaS2LootCatalog.lootDefs.Count + 10 + 12 + 10} image: {args.imageKey}");
                };

                ImageSource.OnImageAdd += onImageAddHandler;

                try
                {
                    var imageLoadTask = Task.Run(() => ImageSource.InitFromXnb(itemsXnbFilePath, interfaceXnbFilePath, SaS2LootCatalog.lootDefs));

                    while (!imageLoadTask.Wait(1000))
                    {
                        if (IsDisposed)
                        {
                            return false;
                        }

                        Application.DoEvents();
                    }
                }
                finally
                {
                    ImageSource.OnImageAdd -= onImageAddHandler;
                }

                LogLine($"Loaded {ImageSource.ImageList.Count} images");

                Settings.Default.GameFolderPath = gameFolderPath;
                Settings.Default.Save();

                return true;
            }
            catch (Exception ex)
            {
                LogLine($"Error during game folder {gameFolderPath} check");
                LogLine($"Error message: {ex.Message}");

                // Uncomment for debug
                // throw;
            }
            finally
            {
                buttonBrowse.Enabled = true;
            }

            return false;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowseGameFolderPath.ShowDialog() == DialogResult.OK)
            {
                textGameFolderPath.Text = folderBrowseGameFolderPath.SelectedPath;

                if (CheckGameFolder(folderBrowseGameFolderPath.SelectedPath))
                {
                    CloseAndOpenSaveEditorForm();
                }
            }
        }
        private void LogLine(string line)
        {
            var logMessage = $"[{DateTime.Now:T}]: {line.Trim()}\r\n";

            if (textLogs.InvokeRequired)
            {
                textLogs.Invoke(() =>
                {
                    if (textLogs.IsDisposed)
                    {
                        return;
                    }

                    textLogs.AppendText(logMessage);
                });
            }
            else
            {
                if (textLogs.IsDisposed)
                {
                    return;
                }

                textLogs.AppendText(logMessage);
            }
        }

        private void FormRequirementsCheck_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.GameFolderPath))
            {
                LogLine($"Game folder is specified: {Settings.Default.GameFolderPath}");

                textGameFolderPath.Text = Settings.Default.GameFolderPath;
                folderBrowseGameFolderPath.SelectedPath = Settings.Default.GameFolderPath;

                if (CheckGameFolder(Settings.Default.GameFolderPath))
                {
                    CloseAndOpenSaveEditorForm();
                }
            }
            else
            {
                LogLine($"Game folder is not specified. Click Browse to select Salt and Sacrifice (v2.0.0.1) folder");
            }
        }
    }
}
