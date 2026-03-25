using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyListCreator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string PromptText
        {
            get { return lblPrompt.Text; }
            set { lblPrompt.Text = value; }
        }
        public string InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }
    }
}
