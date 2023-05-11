namespace Xue.Qiaoran.RRCAGAPP
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.txtVehicleSalesPrice = new System.Windows.Forms.TextBox();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentBox = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.nudNumberOfYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDueBox = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeInBox = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotalBox = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTaxBox = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotalBox = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptionsBox = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSummaryVehicleSalePriceBox = new System.Windows.Forms.Label();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).BeginInit();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(16, 24);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(106, 13);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = " Vehicle\'s Sale Price:";
            // 
            // txtVehicleSalesPrice
            // 
            this.txtVehicleSalesPrice.Location = new System.Drawing.Point(128, 21);
            this.txtVehicleSalesPrice.Name = "txtVehicleSalesPrice";
            this.txtVehicleSalesPrice.Size = new System.Drawing.Size(133, 20);
            this.txtVehicleSalesPrice.TabIndex = 1;
            this.txtVehicleSalesPrice.Text = "123";
            this.txtVehicleSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblTradeInValue.Location = new System.Drawing.Point(43, 56);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(79, 13);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(128, 53);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(133, 20);
            this.txtTradeInValue.TabIndex = 3;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.BackColor = System.Drawing.SystemColors.Control;
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(19, 107);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(242, 143);
            this.grpAccessories.TabIndex = 4;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(24, 104);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(24, 66);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(24, 28);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.BackColor = System.Drawing.SystemColors.Control;
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(19, 285);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(242, 157);
            this.grpExteriorFinish.TabIndex = 5;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(24, 114);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(123, 17);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.TabStop = true;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(24, 76);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(24, 38);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // grpFinance
            // 
            this.grpFinance.BackColor = System.Drawing.SystemColors.Control;
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblMonthlyPaymentBox);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblNumberOfYears);
            this.grpFinance.Controls.Add(this.nudNumberOfYears);
            this.grpFinance.Location = new System.Drawing.Point(303, 338);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(314, 104);
            this.grpFinance.TabIndex = 6;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(206, 40);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 7;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // lblMonthlyPaymentBox
            // 
            this.lblMonthlyPaymentBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPaymentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPaymentBox.Location = new System.Drawing.Point(209, 60);
            this.lblMonthlyPaymentBox.Name = "lblMonthlyPaymentBox";
            this.lblMonthlyPaymentBox.Size = new System.Drawing.Size(84, 19);
            this.lblMonthlyPaymentBox.TabIndex = 5;
            this.lblMonthlyPaymentBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(114, 60);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(64, 20);
            this.nudAnnualInterestRate.TabIndex = 3;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(114, 26);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(74, 34);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(17, 40);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(66, 13);
            this.lblNumberOfYears.TabIndex = 1;
            this.lblNumberOfYears.Text = "No. of Years";
            // 
            // nudNumberOfYears
            // 
            this.nudNumberOfYears.Location = new System.Drawing.Point(20, 60);
            this.nudNumberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfYears.Name = "nudNumberOfYears";
            this.nudNumberOfYears.Size = new System.Drawing.Size(63, 20);
            this.nudNumberOfYears.TabIndex = 0;
            this.nudNumberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(502, 460);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(115, 23);
            this.btnCalculateQuote.TabIndex = 7;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.SystemColors.Control;
            this.grpSummary.Controls.Add(this.lblAmountDueBox);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeInBox);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.lblTotalBox);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTaxBox);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtotalBox);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptionsBox);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblSummaryVehicleSalePriceBox);
            this.grpSummary.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.grpSummary.Location = new System.Drawing.Point(303, 24);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(314, 308);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblAmountDueBox
            // 
            this.lblAmountDueBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDueBox.Location = new System.Drawing.Point(141, 254);
            this.lblAmountDueBox.Name = "lblAmountDueBox";
            this.lblAmountDueBox.Size = new System.Drawing.Size(133, 20);
            this.lblAmountDueBox.TabIndex = 13;
            this.lblAmountDueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(66, 258);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradeInBox
            // 
            this.lblTradeInBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInBox.Location = new System.Drawing.Point(141, 217);
            this.lblTradeInBox.Name = "lblTradeInBox";
            this.lblTradeInBox.Size = new System.Drawing.Size(133, 20);
            this.lblTradeInBox.TabIndex = 11;
            this.lblTradeInBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(86, 221);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(49, 13);
            this.lblTradeIn.TabIndex = 10;
            this.lblTradeIn.Text = "Trade-in:";
            // 
            // lblTotalBox
            // 
            this.lblTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBox.Location = new System.Drawing.Point(141, 180);
            this.lblTotalBox.Name = "lblTotalBox";
            this.lblTotalBox.Size = new System.Drawing.Size(133, 20);
            this.lblTotalBox.TabIndex = 9;
            this.lblTotalBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(101, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblSalesTaxBox
            // 
            this.lblSalesTaxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxBox.Location = new System.Drawing.Point(141, 143);
            this.lblSalesTaxBox.Name = "lblSalesTaxBox";
            this.lblSalesTaxBox.Size = new System.Drawing.Size(133, 20);
            this.lblSalesTaxBox.TabIndex = 7;
            this.lblSalesTaxBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(49, 147);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 6;
            this.lblSalesTax.Text = "Sales Tax (12%):";
            // 
            // lblSubtotalBox
            // 
            this.lblSubtotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotalBox.Location = new System.Drawing.Point(141, 106);
            this.lblSubtotalBox.Name = "lblSubtotalBox";
            this.lblSubtotalBox.Size = new System.Drawing.Size(133, 20);
            this.lblSubtotalBox.TabIndex = 5;
            this.lblSubtotalBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(86, 110);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptionsBox
            // 
            this.lblOptionsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptionsBox.Location = new System.Drawing.Point(141, 68);
            this.lblOptionsBox.Name = "lblOptionsBox";
            this.lblOptionsBox.Size = new System.Drawing.Size(133, 20);
            this.lblOptionsBox.TabIndex = 3;
            this.lblOptionsBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(89, 72);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options:";
            // 
            // lblSummaryVehicleSalePriceBox
            // 
            this.lblSummaryVehicleSalePriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryVehicleSalePriceBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSummaryVehicleSalePriceBox.Location = new System.Drawing.Point(141, 31);
            this.lblSummaryVehicleSalePriceBox.Name = "lblSummaryVehicleSalePriceBox";
            this.lblSummaryVehicleSalePriceBox.Size = new System.Drawing.Size(133, 20);
            this.lblSummaryVehicleSalePriceBox.TabIndex = 1;
            this.lblSummaryVehicleSalePriceBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.AutoSize = true;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(32, 35);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblSummaryVehicleSalePrice.TabIndex = 0;
            this.lblSummaryVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 493);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.txtVehicleSalesPrice);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.TextBox txtVehicleSalesPrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.NumericUpDown nudNumberOfYears;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.Label lblMonthlyPaymentBox;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblSummaryVehicleSalePriceBox;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.Label lblOptionsBox;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblTradeInBox;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotalBox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTaxBox;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotalBox;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblAmountDueBox;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblMonthlyPayment;
    }
}