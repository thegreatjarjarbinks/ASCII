/*
 * Created by: Alex Mathias
 * Created on: 16-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-11
 * This program displays ASCII numbers from A-Z
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII
{
    public partial class frmASCII : Form
    {
        public frmASCII()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Variables
            const int maxNumber = 91;
            //Process
            for (int loopCounter = 65; loopCounter != maxNumber; loopCounter++)
            {
                this.lstNumbers.Items.Add(Char.ConvertFromUtf32(loopCounter)+ "----->" + loopCounter);
            }
        }
    }
}
