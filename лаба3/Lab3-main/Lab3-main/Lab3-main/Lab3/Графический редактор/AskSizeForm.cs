using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Графический_редактор
{
    public partial class AskSizeForm : Form
    {
        public AskSizeForm()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                string text = tbFileName.Text;
                return text;
            }
            set { }

        }
        public int W
        {
            get
            {
                string text = tbW.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = tbH.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        bool _canceled = false;
        public bool Canceled { get { return _canceled; } }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _canceled = true;
            Close();
        }
    }
}
