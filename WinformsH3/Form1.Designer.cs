namespace WinformsH3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGasStation = new System.Windows.Forms.GroupBox();
            this.lblGasToPay = new System.Windows.Forms.Label();
            this.lblGasStationPayment = new System.Windows.Forms.Label();
            this.panelGasPayment = new System.Windows.Forms.Panel();
            this.txtByPrice = new System.Windows.Forms.TextBox();
            this.rbByPrice = new System.Windows.Forms.RadioButton();
            this.txtByVolume = new System.Windows.Forms.TextBox();
            this.rbByVolume = new System.Windows.Forms.RadioButton();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.lblGasPrice = new System.Windows.Forms.Label();
            this.lblGasType = new System.Windows.Forms.Label();
            this.combobGasType = new System.Windows.Forms.ComboBox();
            this.gbTotalAmount = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.gbMiniCafe = new System.Windows.Forms.GroupBox();
            this.lblMiniCafeToPay = new System.Windows.Forms.Label();
            this.lblMiniCafePayment = new System.Windows.Forms.Label();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panelSnickers = new System.Windows.Forms.Panel();
            this.txtSnickers = new System.Windows.Forms.TextBox();
            this.lblSnickers = new System.Windows.Forms.Label();
            this.checkBoxSnickers = new System.Windows.Forms.CheckBox();
            this.panelCofe = new System.Windows.Forms.Panel();
            this.lblCofe = new System.Windows.Forms.Label();
            this.txtCofe = new System.Windows.Forms.TextBox();
            this.checkBoxCofe = new System.Windows.Forms.CheckBox();
            this.panelCola = new System.Windows.Forms.Panel();
            this.lblCola = new System.Windows.Forms.Label();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.panelHamburger = new System.Windows.Forms.Panel();
            this.lblHamburger = new System.Windows.Forms.Label();
            this.checkBoxHamburger = new System.Windows.Forms.CheckBox();
            this.txtHamburger = new System.Windows.Forms.TextBox();
            this.panelHotDog = new System.Windows.Forms.Panel();
            this.lblHotDog = new System.Windows.Forms.Label();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.txtHotDog = new System.Windows.Forms.TextBox();
            this.gbGasStation.SuspendLayout();
            this.panelGasPayment.SuspendLayout();
            this.gbTotalAmount.SuspendLayout();
            this.gbMiniCafe.SuspendLayout();
            this.panelSnickers.SuspendLayout();
            this.panelCofe.SuspendLayout();
            this.panelCola.SuspendLayout();
            this.panelHamburger.SuspendLayout();
            this.panelHotDog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGasStation
            // 
            this.gbGasStation.Controls.Add(this.lblGasToPay);
            this.gbGasStation.Controls.Add(this.lblGasStationPayment);
            this.gbGasStation.Controls.Add(this.panelGasPayment);
            this.gbGasStation.Controls.Add(this.txtGasPrice);
            this.gbGasStation.Controls.Add(this.lblGasPrice);
            this.gbGasStation.Controls.Add(this.lblGasType);
            this.gbGasStation.Controls.Add(this.combobGasType);
            this.gbGasStation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbGasStation.Location = new System.Drawing.Point(12, 12);
            this.gbGasStation.Name = "gbGasStation";
            this.gbGasStation.Size = new System.Drawing.Size(246, 308);
            this.gbGasStation.TabIndex = 0;
            this.gbGasStation.TabStop = false;
            this.gbGasStation.Text = "Gas Station";
            // 
            // lblGasToPay
            // 
            this.lblGasToPay.AutoSize = true;
            this.lblGasToPay.Location = new System.Drawing.Point(9, 252);
            this.lblGasToPay.Name = "lblGasToPay";
            this.lblGasToPay.Size = new System.Drawing.Size(52, 19);
            this.lblGasToPay.TabIndex = 6;
            this.lblGasToPay.Text = "To Pay";
            // 
            // lblGasStationPayment
            // 
            this.lblGasStationPayment.AutoSize = true;
            this.lblGasStationPayment.Location = new System.Drawing.Point(201, 252);
            this.lblGasStationPayment.Name = "lblGasStationPayment";
            this.lblGasStationPayment.Size = new System.Drawing.Size(25, 19);
            this.lblGasStationPayment.TabIndex = 5;
            this.lblGasStationPayment.Text = "0$";
            // 
            // panelGasPayment
            // 
            this.panelGasPayment.Controls.Add(this.txtByPrice);
            this.panelGasPayment.Controls.Add(this.rbByPrice);
            this.panelGasPayment.Controls.Add(this.txtByVolume);
            this.panelGasPayment.Controls.Add(this.rbByVolume);
            this.panelGasPayment.Location = new System.Drawing.Point(6, 104);
            this.panelGasPayment.Name = "panelGasPayment";
            this.panelGasPayment.Size = new System.Drawing.Size(229, 111);
            this.panelGasPayment.TabIndex = 4;
            // 
            // txtByPrice
            // 
            this.txtByPrice.Location = new System.Drawing.Point(96, 62);
            this.txtByPrice.Name = "txtByPrice";
            this.txtByPrice.ReadOnly = true;
            this.txtByPrice.Size = new System.Drawing.Size(124, 26);
            this.txtByPrice.TabIndex = 4;
            this.txtByPrice.TextChanged += new System.EventHandler(this.txtGasStation_TextChanged);
            // 
            // rbByPrice
            // 
            this.rbByPrice.AutoSize = true;
            this.rbByPrice.Location = new System.Drawing.Point(3, 63);
            this.rbByPrice.Name = "rbByPrice";
            this.rbByPrice.Size = new System.Drawing.Size(79, 23);
            this.rbByPrice.TabIndex = 3;
            this.rbByPrice.TabStop = true;
            this.rbByPrice.Text = "By Price";
            this.rbByPrice.UseVisualStyleBackColor = true;
            this.rbByPrice.CheckedChanged += new System.EventHandler(this.rbByPrice_CheckedChanged);
            // 
            // txtByVolume
            // 
            this.txtByVolume.Location = new System.Drawing.Point(96, 21);
            this.txtByVolume.Name = "txtByVolume";
            this.txtByVolume.ReadOnly = true;
            this.txtByVolume.Size = new System.Drawing.Size(124, 26);
            this.txtByVolume.TabIndex = 4;
            this.txtByVolume.TextChanged += new System.EventHandler(this.txtGasStation_TextChanged);
            // 
            // rbByVolume
            // 
            this.rbByVolume.AutoSize = true;
            this.rbByVolume.Location = new System.Drawing.Point(3, 22);
            this.rbByVolume.Name = "rbByVolume";
            this.rbByVolume.Size = new System.Drawing.Size(93, 23);
            this.rbByVolume.TabIndex = 3;
            this.rbByVolume.TabStop = true;
            this.rbByVolume.Text = "By Volume";
            this.rbByVolume.UseVisualStyleBackColor = true;
            this.rbByVolume.CheckedChanged += new System.EventHandler(this.rbByVolume_CheckedChanged);
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Location = new System.Drawing.Point(79, 72);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.ReadOnly = true;
            this.txtGasPrice.Size = new System.Drawing.Size(121, 26);
            this.txtGasPrice.TabIndex = 2;
            this.txtGasPrice.Text = "0$";
            // 
            // lblGasPrice
            // 
            this.lblGasPrice.AutoSize = true;
            this.lblGasPrice.Location = new System.Drawing.Point(6, 75);
            this.lblGasPrice.Name = "lblGasPrice";
            this.lblGasPrice.Size = new System.Drawing.Size(40, 19);
            this.lblGasPrice.TabIndex = 1;
            this.lblGasPrice.Text = "Price";
            // 
            // lblGasType
            // 
            this.lblGasType.AutoSize = true;
            this.lblGasType.Location = new System.Drawing.Point(6, 25);
            this.lblGasType.Name = "lblGasType";
            this.lblGasType.Size = new System.Drawing.Size(67, 19);
            this.lblGasType.TabIndex = 1;
            this.lblGasType.Text = "Gas Type";
            // 
            // combobGasType
            // 
            this.combobGasType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobGasType.FormattingEnabled = true;
            this.combobGasType.Items.AddRange(new object[] {
            "Diesel",
            "A-72",
            "A-92",
            "A-95",
            "A-100"});
            this.combobGasType.Location = new System.Drawing.Point(79, 22);
            this.combobGasType.Name = "combobGasType";
            this.combobGasType.Size = new System.Drawing.Size(121, 27);
            this.combobGasType.TabIndex = 0;
            this.combobGasType.SelectedIndexChanged += new System.EventHandler(this.combobGasType_SelectedIndexChanged);
            // 
            // gbTotalAmount
            // 
            this.gbTotalAmount.Controls.Add(this.btnPay);
            this.gbTotalAmount.Controls.Add(this.lblTotalAmount);
            this.gbTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbTotalAmount.Location = new System.Drawing.Point(12, 326);
            this.gbTotalAmount.Name = "gbTotalAmount";
            this.gbTotalAmount.Size = new System.Drawing.Size(518, 123);
            this.gbTotalAmount.TabIndex = 1;
            this.gbTotalAmount.TabStop = false;
            this.gbTotalAmount.Text = "Total Amount";
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.Location = new System.Drawing.Point(215, 81);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 31);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(238, 25);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(28, 21);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "0$";
            // 
            // gbMiniCafe
            // 
            this.gbMiniCafe.Controls.Add(this.lblMiniCafeToPay);
            this.gbMiniCafe.Controls.Add(this.lblMiniCafePayment);
            this.gbMiniCafe.Controls.Add(this.lblPAmount);
            this.gbMiniCafe.Controls.Add(this.lblPPrice);
            this.gbMiniCafe.Controls.Add(this.lblProduct);
            this.gbMiniCafe.Controls.Add(this.panelSnickers);
            this.gbMiniCafe.Controls.Add(this.panelCofe);
            this.gbMiniCafe.Controls.Add(this.panelCola);
            this.gbMiniCafe.Controls.Add(this.panelHamburger);
            this.gbMiniCafe.Controls.Add(this.panelHotDog);
            this.gbMiniCafe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMiniCafe.Location = new System.Drawing.Point(269, 12);
            this.gbMiniCafe.Name = "gbMiniCafe";
            this.gbMiniCafe.Size = new System.Drawing.Size(261, 308);
            this.gbMiniCafe.TabIndex = 2;
            this.gbMiniCafe.TabStop = false;
            this.gbMiniCafe.Text = "Mini Cafe";
            // 
            // lblMiniCafeToPay
            // 
            this.lblMiniCafeToPay.AutoSize = true;
            this.lblMiniCafeToPay.Location = new System.Drawing.Point(6, 252);
            this.lblMiniCafeToPay.Name = "lblMiniCafeToPay";
            this.lblMiniCafeToPay.Size = new System.Drawing.Size(52, 19);
            this.lblMiniCafeToPay.TabIndex = 6;
            this.lblMiniCafeToPay.Text = "To Pay";
            // 
            // lblMiniCafePayment
            // 
            this.lblMiniCafePayment.AutoSize = true;
            this.lblMiniCafePayment.Location = new System.Drawing.Point(67, 252);
            this.lblMiniCafePayment.Name = "lblMiniCafePayment";
            this.lblMiniCafePayment.Size = new System.Drawing.Size(25, 19);
            this.lblMiniCafePayment.TabIndex = 5;
            this.lblMiniCafePayment.Text = "0$";
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.Location = new System.Drawing.Point(186, 25);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(57, 19);
            this.lblPAmount.TabIndex = 1;
            this.lblPAmount.Text = "Amount";
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Location = new System.Drawing.Point(111, 22);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(40, 19);
            this.lblPPrice.TabIndex = 1;
            this.lblPPrice.Text = "Price";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(22, 22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 19);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // panelSnickers
            // 
            this.panelSnickers.AutoSize = true;
            this.panelSnickers.Controls.Add(this.txtSnickers);
            this.panelSnickers.Controls.Add(this.lblSnickers);
            this.panelSnickers.Controls.Add(this.checkBoxSnickers);
            this.panelSnickers.Location = new System.Drawing.Point(3, 188);
            this.panelSnickers.Name = "panelSnickers";
            this.panelSnickers.Size = new System.Drawing.Size(247, 29);
            this.panelSnickers.TabIndex = 0;
            // 
            // txtSnickers
            // 
            this.txtSnickers.Location = new System.Drawing.Point(189, 0);
            this.txtSnickers.Name = "txtSnickers";
            this.txtSnickers.ReadOnly = true;
            this.txtSnickers.Size = new System.Drawing.Size(55, 26);
            this.txtSnickers.TabIndex = 2;
            this.txtSnickers.Text = "0";
            this.txtSnickers.TextChanged += new System.EventHandler(this.txtMiniCafe_TextChanged);
            // 
            // lblSnickers
            // 
            this.lblSnickers.AutoSize = true;
            this.lblSnickers.Location = new System.Drawing.Point(113, 3);
            this.lblSnickers.Name = "lblSnickers";
            this.lblSnickers.Size = new System.Drawing.Size(37, 19);
            this.lblSnickers.TabIndex = 1;
            this.lblSnickers.Text = "3,00";
            // 
            // checkBoxSnickers
            // 
            this.checkBoxSnickers.AutoSize = true;
            this.checkBoxSnickers.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSnickers.Name = "checkBoxSnickers";
            this.checkBoxSnickers.Size = new System.Drawing.Size(80, 23);
            this.checkBoxSnickers.TabIndex = 0;
            this.checkBoxSnickers.Text = "Snickers";
            this.checkBoxSnickers.UseVisualStyleBackColor = true;
            this.checkBoxSnickers.CheckedChanged += new System.EventHandler(this.checkBoxMiniCafe_CheckedChanged);
            // 
            // panelCofe
            // 
            this.panelCofe.AutoSize = true;
            this.panelCofe.Controls.Add(this.lblCofe);
            this.panelCofe.Controls.Add(this.txtCofe);
            this.panelCofe.Controls.Add(this.checkBoxCofe);
            this.panelCofe.Location = new System.Drawing.Point(3, 153);
            this.panelCofe.Name = "panelCofe";
            this.panelCofe.Size = new System.Drawing.Size(247, 29);
            this.panelCofe.TabIndex = 0;
            // 
            // lblCofe
            // 
            this.lblCofe.AutoSize = true;
            this.lblCofe.Location = new System.Drawing.Point(113, 4);
            this.lblCofe.Name = "lblCofe";
            this.lblCofe.Size = new System.Drawing.Size(37, 19);
            this.lblCofe.TabIndex = 1;
            this.lblCofe.Text = "2,70";
            // 
            // txtCofe
            // 
            this.txtCofe.Location = new System.Drawing.Point(189, 0);
            this.txtCofe.Name = "txtCofe";
            this.txtCofe.ReadOnly = true;
            this.txtCofe.Size = new System.Drawing.Size(55, 26);
            this.txtCofe.TabIndex = 2;
            this.txtCofe.Text = "0";
            this.txtCofe.TextChanged += new System.EventHandler(this.txtMiniCafe_TextChanged);
            // 
            // checkBoxCofe
            // 
            this.checkBoxCofe.AutoSize = true;
            this.checkBoxCofe.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCofe.Name = "checkBoxCofe";
            this.checkBoxCofe.Size = new System.Drawing.Size(58, 23);
            this.checkBoxCofe.TabIndex = 0;
            this.checkBoxCofe.Text = "Cofe";
            this.checkBoxCofe.UseVisualStyleBackColor = true;
            this.checkBoxCofe.CheckedChanged += new System.EventHandler(this.checkBoxMiniCafe_CheckedChanged);
            // 
            // panelCola
            // 
            this.panelCola.AutoSize = true;
            this.panelCola.Controls.Add(this.lblCola);
            this.panelCola.Controls.Add(this.checkBoxCola);
            this.panelCola.Controls.Add(this.txtCola);
            this.panelCola.Location = new System.Drawing.Point(3, 118);
            this.panelCola.Name = "panelCola";
            this.panelCola.Size = new System.Drawing.Size(247, 29);
            this.panelCola.TabIndex = 0;
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(113, 3);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(37, 19);
            this.lblCola.TabIndex = 1;
            this.lblCola.Text = "2,20";
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(96, 23);
            this.checkBoxCola.TabIndex = 0;
            this.checkBoxCola.Text = "Coca-Cola";
            this.checkBoxCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.CheckedChanged += new System.EventHandler(this.checkBoxMiniCafe_CheckedChanged);
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(189, 0);
            this.txtCola.Name = "txtCola";
            this.txtCola.ReadOnly = true;
            this.txtCola.Size = new System.Drawing.Size(55, 26);
            this.txtCola.TabIndex = 2;
            this.txtCola.Text = "0";
            this.txtCola.TextChanged += new System.EventHandler(this.txtMiniCafe_TextChanged);
            // 
            // panelHamburger
            // 
            this.panelHamburger.AutoSize = true;
            this.panelHamburger.Controls.Add(this.lblHamburger);
            this.panelHamburger.Controls.Add(this.checkBoxHamburger);
            this.panelHamburger.Controls.Add(this.txtHamburger);
            this.panelHamburger.Location = new System.Drawing.Point(3, 83);
            this.panelHamburger.Name = "panelHamburger";
            this.panelHamburger.Size = new System.Drawing.Size(247, 29);
            this.panelHamburger.TabIndex = 0;
            // 
            // lblHamburger
            // 
            this.lblHamburger.AutoSize = true;
            this.lblHamburger.Location = new System.Drawing.Point(113, 4);
            this.lblHamburger.Name = "lblHamburger";
            this.lblHamburger.Size = new System.Drawing.Size(37, 19);
            this.lblHamburger.TabIndex = 1;
            this.lblHamburger.Text = "5,40";
            // 
            // checkBoxHamburger
            // 
            this.checkBoxHamburger.AutoSize = true;
            this.checkBoxHamburger.Location = new System.Drawing.Point(3, 2);
            this.checkBoxHamburger.Name = "checkBoxHamburger";
            this.checkBoxHamburger.Size = new System.Drawing.Size(96, 23);
            this.checkBoxHamburger.TabIndex = 0;
            this.checkBoxHamburger.Text = "Hamburger";
            this.checkBoxHamburger.UseVisualStyleBackColor = true;
            this.checkBoxHamburger.CheckedChanged += new System.EventHandler(this.checkBoxMiniCafe_CheckedChanged);
            // 
            // txtHamburger
            // 
            this.txtHamburger.Location = new System.Drawing.Point(189, 0);
            this.txtHamburger.Name = "txtHamburger";
            this.txtHamburger.ReadOnly = true;
            this.txtHamburger.Size = new System.Drawing.Size(55, 26);
            this.txtHamburger.TabIndex = 2;
            this.txtHamburger.Text = "0";
            this.txtHamburger.TextChanged += new System.EventHandler(this.txtMiniCafe_TextChanged);
            // 
            // panelHotDog
            // 
            this.panelHotDog.AutoSize = true;
            this.panelHotDog.Controls.Add(this.lblHotDog);
            this.panelHotDog.Controls.Add(this.checkBoxHotDog);
            this.panelHotDog.Controls.Add(this.txtHotDog);
            this.panelHotDog.Location = new System.Drawing.Point(3, 48);
            this.panelHotDog.Name = "panelHotDog";
            this.panelHotDog.Size = new System.Drawing.Size(247, 29);
            this.panelHotDog.TabIndex = 0;
            // 
            // lblHotDog
            // 
            this.lblHotDog.AutoSize = true;
            this.lblHotDog.Location = new System.Drawing.Point(113, 3);
            this.lblHotDog.Name = "lblHotDog";
            this.lblHotDog.Size = new System.Drawing.Size(37, 19);
            this.lblHotDog.TabIndex = 1;
            this.lblHotDog.Text = "4,00";
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(3, 3);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(83, 23);
            this.checkBoxHotDog.TabIndex = 0;
            this.checkBoxHotDog.Text = "Hot-Dog";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxMiniCafe_CheckedChanged);
            // 
            // txtHotDog
            // 
            this.txtHotDog.Location = new System.Drawing.Point(189, 0);
            this.txtHotDog.Name = "txtHotDog";
            this.txtHotDog.ReadOnly = true;
            this.txtHotDog.Size = new System.Drawing.Size(55, 26);
            this.txtHotDog.TabIndex = 2;
            this.txtHotDog.Text = "0";
            this.txtHotDog.TextChanged += new System.EventHandler(this.txtMiniCafe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMiniCafe);
            this.Controls.Add(this.gbTotalAmount);
            this.Controls.Add(this.gbGasStation);
            this.Name = "Form1";
            this.Text = "KepaMaxOil";
            this.gbGasStation.ResumeLayout(false);
            this.gbGasStation.PerformLayout();
            this.panelGasPayment.ResumeLayout(false);
            this.panelGasPayment.PerformLayout();
            this.gbTotalAmount.ResumeLayout(false);
            this.gbTotalAmount.PerformLayout();
            this.gbMiniCafe.ResumeLayout(false);
            this.gbMiniCafe.PerformLayout();
            this.panelSnickers.ResumeLayout(false);
            this.panelSnickers.PerformLayout();
            this.panelCofe.ResumeLayout(false);
            this.panelCofe.PerformLayout();
            this.panelCola.ResumeLayout(false);
            this.panelCola.PerformLayout();
            this.panelHamburger.ResumeLayout(false);
            this.panelHamburger.PerformLayout();
            this.panelHotDog.ResumeLayout(false);
            this.panelHotDog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbGasStation;
        private ComboBox combobGasType;
        private TextBox txtGasPrice;
        private Label lblGasPrice;
        private Label lblGasType;
        private Panel panelGasPayment;
        private RadioButton rbByVolume;
        private TextBox txtByVolume;
        private TextBox txtByPrice;
        private RadioButton rbByPrice;
        private Label lblGasStationPayment;
        private Label lblGasToPay;
        private GroupBox gbTotalAmount;
        private Label lblTotalAmount;
        private GroupBox gbMiniCafe;
        private Panel panelSnickers;
        private TextBox txtSnickers;
        private Label lblSnickers;
        private CheckBox checkBoxSnickers;
        private Panel panelCofe;
        private TextBox txtCofe;
        private Label lblCofe;
        private CheckBox checkBoxCofe;
        private Panel panelCola;
        private TextBox txtCola;
        private Label lblCola;
        private CheckBox checkBoxCola;
        private Panel panelHamburger;
        private TextBox txtHamburger;
        private Label lblHamburger;
        private CheckBox checkBoxHamburger;
        private Panel panelHotDog;
        private TextBox txtHotDog;
        private Label lblHotDog;
        private CheckBox checkBoxHotDog;
        private Label lblPAmount;
        private Label lblPPrice;
        private Label lblProduct;
        private Label lblMiniCafeToPay;
        private Label lblMiniCafePayment;
        private Button btnPay;
    }
}