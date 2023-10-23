namespace ScanGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbComport = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnet = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbBarcodeReader = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort6 = new System.IO.Ports.SerialPort(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn COM";
            // 
            // cbComport
            // 
            this.cbComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComport.FormattingEnabled = true;
            this.cbComport.Location = new System.Drawing.Point(72, 3);
            this.cbComport.Name = "cbComport";
            this.cbComport.Size = new System.Drawing.Size(89, 21);
            this.cbComport.TabIndex = 1;
            this.cbComport.SelectedIndexChanged += new System.EventHandler(this.cbComport_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.tbStatus);
            this.panel1.Controls.Add(this.btnConnet);
            this.panel1.Controls.Add(this.cbComport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 83);
            this.panel1.TabIndex = 3;
            // 
            // btnConnet
            // 
            this.btnConnet.Location = new System.Drawing.Point(10, 56);
            this.btnConnet.Name = "btnConnet";
            this.btnConnet.Size = new System.Drawing.Size(89, 23);
            this.btnConnet.TabIndex = 2;
            this.btnConnet.Text = "Connect";
            this.btnConnet.UseVisualStyleBackColor = true;
            this.btnConnet.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.Red;
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(72, 30);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(89, 20);
            this.tbStatus.TabIndex = 3;
            this.tbStatus.Text = "Disconnected";
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBarcodeReader
            // 
            this.tbBarcodeReader.Location = new System.Drawing.Point(10, 17);
            this.tbBarcodeReader.Name = "tbBarcodeReader";
            this.tbBarcodeReader.Size = new System.Drawing.Size(202, 20);
            this.tbBarcodeReader.TabIndex = 4;
            this.tbBarcodeReader.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbBarcodeReader);
            this.panel2.Location = new System.Drawing.Point(7, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 51);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reader";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(105, 56);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(89, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disonnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 144);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Scaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbComport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnet;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbBarcodeReader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.IO.Ports.SerialPort serialPort6;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

