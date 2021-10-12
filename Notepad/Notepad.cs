using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public string filename;
        public bool isFileChanged;
        FontSettings f;
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;

        public Notepad()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
            f = new FontSettings();
        }

        private void SaveFile(string f)
        {
            if (f == "" && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                f = saveFileDialog.FileName;            
            }
            try
            {
                StreamWriter sw = new StreamWriter(f + ".txt");
                sw.Write(tB.Text);
                sw.Close();
                filename = f;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Cannot find the file!");
            }
            UpdateTextWithTitle();
        }
      
        private void CreateFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            tB.Text = "";
            filename = "";
            UpdateTextWithTitle();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    tB.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Cannot find the file!");
                }
            }
            UpdateTextWithTitle();
        }

        private void Save(object sender, EventArgs e) => SaveFile(filename);

        private void SaveAs(object sender, EventArgs e) => SaveFile("");

        private void tB_TextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }

        public void UpdateTextWithTitle() => this.Text = filename != "" ? filename + " - Notepad" : filename + "Untitled - Notepad";

        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult r = MessageBox.Show("Save changes?", "Saving the file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        private void CopyText(object sender, EventArgs e) => Clipboard.SetText(tB.SelectedText);

        private void CutText(object sender, EventArgs e)
        {
            Clipboard.SetText(tB.SelectedText);
            tB.Text = tB.Text.Remove(tB.SelectionStart, tB.SelectionLength);
        }

        private void PasteText(object sender, EventArgs e) => tB.Text = tB.Text.Substring(0, tB.SelectionStart) + Clipboard.GetText() + tB.Text.Substring(tB.SelectionStart, tB.Text.Length - tB.SelectionStart);

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e) => SaveUnsavedFile();

        private void FontClick(object sender, EventArgs e) => f.Show();

        private void Notepad_Activated(object sender, EventArgs e)
        {
            if (f != null)
            {
                fontSize = f.fontSize;
                fs = f.fs;
                tB.Font = new Font(tB.Font.FontFamily, fontSize, fs);
                f.Close();
            }
        }
    }
}