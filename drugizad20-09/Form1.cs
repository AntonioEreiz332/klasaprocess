using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace drugizad20_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplorer.exe");

        }

        private void ButtonWord_Click(object sender, EventArgs e)
        {
            Process.Start("wimword.exe");
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void ButtonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplorer.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
               
        }
    }
}
