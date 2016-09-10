using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson1B
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You clicked the button!";
        }

        private void ClickMeButton_MouseEnter(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hey!";
        }

        private void ClickMeButton_MouseLeave(object sender, EventArgs e)
        {
            MessageLabel.Text = "Cya!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
