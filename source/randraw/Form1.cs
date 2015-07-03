using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.ShowDialog();
            this.txtInput.Text = open.FileName;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.ShowDialog();
            this.txtOutput.Text = save.FileName;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.lblStatus.Text = "Processing...";
                var random = new RandomDraw();
                random.Run(
                    this.txtKey.Text,
                    this.txtInput.Text,
                    this.txtOutput.Text,
                    this.chkNoHeader.Checked,
                    Convert.ToInt32(this.txtNum.Text));
                this.lblStatus.Text = "Completed.";
            }
            catch (Exception ex)
            {
                this.lblStatus.Text = "ERROR: " + ex.Message;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
