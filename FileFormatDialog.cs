using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L55
{
    public enum DialogMode
    {
        Save,
        Load
    }

    public partial class FileFormatDialog : Form
    {
        public DialogMode Mode { get; set; }

        public event Action<string> FormatSelected;

        public FileFormatDialog(DialogMode mode)
        {
            InitializeComponent();
            Mode = mode;
            if (mode == DialogMode.Save)
            {
                btnCsv.Text = "Save to *.csv (*.txt) file";
                btnJson.Text = "Save to *.json file";
            }
            else
            {
                btnCsv.Text = "Load from *.csv (*.txt) file";
                btnJson.Text = "Load from *.json file";
            }
        }

        public FileFormatDialog()
        {
            InitializeComponent();
        }

        private void FileFormatDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnJson_Click_1(object sender, EventArgs e)
        {
            FormatSelected?.Invoke(".json");
            Close();
        }

        private void btnCsv_Click_1(object sender, EventArgs e)
        {
            FormatSelected?.Invoke(".csv");
            Close();
        }
    }

}
