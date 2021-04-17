using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiPascalC3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EditorInput(string msn) => textBox1.Text = msn;

        private string EditorOutput() => textBox1.Text;

        private void Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    EditorInput(reader.ReadToEnd());
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, EditorOutput());
            }
        }
        
        private void ClearConsole_Click(object sender, EventArgs e)
        {

        }

        private void ReportTS_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {

        }

        private void Optimize_Click(object sender, EventArgs e)
        {

        }
    }
}
