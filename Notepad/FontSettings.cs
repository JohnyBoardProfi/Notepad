using System.Windows.Forms;
using System.Drawing;

namespace Notepad
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;

        public FontSettings()
        {
            InitializeComponent();
            cbFont.SelectedItem = cbFont.Items[0];
            cbStyle.SelectedItem = cbStyle.Items[0];
        }

        private void cbFont_SelectedValueChanged(object sender, System.EventArgs e)
        {
            lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), lblExample.Font.Style);
            fontSize = int.Parse(cbFont.SelectedItem.ToString());
        }

        private void cbStyle_SelectedValueChanged(object sender, System.EventArgs e)
        {
            switch(cbStyle.SelectedItem.ToString())
            {
                case "regular":
                    lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "italic":
                    lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "bold":
                    lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), FontStyle.Bold);
                    break;
                case "strikeout":
                    lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), FontStyle.Strikeout);
                    break;
                case "underline":
                    lblExample.Font = new Font(ExampleLabel.Font.FontFamily, int.Parse(cbFont.SelectedItem.ToString()), FontStyle.Underline);
                    break;
            }
            fs = lblExample.Font.Style;
        }
        
        private void btnOK_Click(object sender, System.EventArgs e) => this.Hide();
    }
}