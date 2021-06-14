using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_CPUT1
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> sentences = new List<string>()
        {
            "Hey ,  How you doing today?", // English
            "Bonjour , Salut comment ça va" , // French
            "Hey wie geht es dir" , // German
            "Hey hoe gaat het met je" // Dutch
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AssignSentences()
        {

        }


    }
}
