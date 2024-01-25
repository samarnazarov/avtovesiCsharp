using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtovesi
{
    public partial class Zagruzka : Form
    {
        public Zagruzka()
        {
            /*InitializeComponent();
            // Display the ProgressBar control.
            progressBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            progressBar1.Maximum = 100;
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar1.Step = 1;

            // Loop through all files to copy.
            for (int x = 1; x <= 100; x++)
            {

                progressBar1.PerformStep();

            }*/
            Glavnaya glavnaya = new Glavnaya();
            glavnaya.Show();


        }
    }
}

