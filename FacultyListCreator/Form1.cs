using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FacultyListCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.PromptText = "New faculty name:";
            dialog.InputText = txtFaculty.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFaculty.Text = dialog.InputText;
            }
        }

        private void deansNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.PromptText = "New Dean's name:";
            dialog.InputText = txtDean.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDean.Text = dialog.InputText;
            }
        }

        private void abbreviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.PromptText = "New abbreviation:";
            dialog.InputText = txtAbbrev.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtAbbrev.Text = dialog.InputText;
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            
            string textToSave = "Факультет: " + txtFaculty.Text + "\r\n" +
                                "Декан: " + txtDean.Text + "\r\n" +
                                "Аббревиатура: " + txtAbbrev.Text + "\r\n" +
                                "- - - - - - - - - - - - - - - - - - - -\r\n";

            try
            {
                
                
                
                File.AppendAllText(fileName, textToSave, Encoding.Unicode);
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }
    }
}
