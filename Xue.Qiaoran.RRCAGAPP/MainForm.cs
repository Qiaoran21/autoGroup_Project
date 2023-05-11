/*
 * Name: Qiaoran Xue
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-10
 * Updated: 2023-03-27
 */
using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xue.Qiaoran.Business;

namespace Xue.Qiaoran.RRCAGAPP
{
    public partial class MainForm : Form
    {
        VehicleDataForm form = null;

        public MainForm()
        {
            InitializeComponent();

            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuDataVehicles.Click += MnuDataVehicles_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            
        }

        /// <summary>
        /// Handles the Click event of the about menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the vehicles menu item.
        /// </summary>
        private void MnuDataVehicles_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new VehicleDataForm();

                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        /// <summary>
        /// Handle the Click event of the exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the car wash menu item.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm form = new CarWashForm();

            form.MdiParent = this;

            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the sales quote menu item.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form = new SalesQuoteForm();

            form.MdiParent = this;

            form.Show();
        }
    }
}
