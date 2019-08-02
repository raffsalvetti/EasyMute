namespace EasyMute
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonSelectDevice = new System.Windows.Forms.Button();
            this.comboBoxActiveCaptureDvices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // buttonSelectDevice
            // 
            this.buttonSelectDevice.Location = new System.Drawing.Point(76, 78);
            this.buttonSelectDevice.Name = "buttonSelectDevice";
            this.buttonSelectDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDevice.TabIndex = 0;
            this.buttonSelectDevice.Text = "OK";
            this.buttonSelectDevice.UseVisualStyleBackColor = true;
            // 
            // comboBoxActiveCaptureDvices
            // 
            this.comboBoxActiveCaptureDvices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActiveCaptureDvices.DropDownWidth = 179;
            this.comboBoxActiveCaptureDvices.FormattingEnabled = true;
            this.comboBoxActiveCaptureDvices.Location = new System.Drawing.Point(24, 41);
            this.comboBoxActiveCaptureDvices.Name = "comboBoxActiveCaptureDvices";
            this.comboBoxActiveCaptureDvices.Size = new System.Drawing.Size(179, 21);
            this.comboBoxActiveCaptureDvices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispositivo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxActiveCaptureDvices);
            this.Controls.Add(this.buttonSelectDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyMute";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonSelectDevice;
        private System.Windows.Forms.ComboBox comboBoxActiveCaptureDvices;
        private System.Windows.Forms.Label label1;
    }
}

