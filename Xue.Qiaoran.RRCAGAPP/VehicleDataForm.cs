/*
 * Name: Qiaoran Xue
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-17
 * Updated: 2023-03-27
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.Forms;

namespace Xue.Qiaoran.RRCAGAPP
{
    public partial class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        public VehicleDataForm()
        {
            this.Load += VehicleDataForm_Load;
        }

        /// <summary>
        /// Handles the Load event of this form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            this.Text = "Vehicle Data Form";
        }
    }
}
