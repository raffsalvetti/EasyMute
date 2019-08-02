using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using NAudio.CoreAudioApi;

namespace EasyMute
{
    public partial class Form1 : Form
    {
        private List<Device> devices;

        public Form1()
        {
            InitializeComponent();
            devices = new List<Device>();

            string selectedDeviceID = "";
            
            MMDeviceEnumerator MMDE = new MMDeviceEnumerator();
            MMDeviceCollection DevCol = MMDE.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            
            Device d;
            Graphics g = comboBoxActiveCaptureDvices.CreateGraphics();

            foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
            {
                try
                {
                    d = new Device(dev);
                    comboBoxActiveCaptureDvices.DropDownWidth = Math.Max((int)g.MeasureString(d.ToString(), comboBoxActiveCaptureDvices.Font).Width, comboBoxActiveCaptureDvices.DropDownWidth);
                    devices.Add(d);
                }
                catch (Exception ex)
                {
                }
            }

            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = Resource1.mic;
            notifyIcon1.MouseClick += new MouseEventHandler(tray_MouseClick);
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Sair", Sair), new MenuItem("Configurar", Configurar) });

            comboBoxActiveCaptureDvices.SelectedIndexChanged += new EventHandler(comboBoxActiveCaptureDvices_SelectedIndexChanged);
            comboBoxActiveCaptureDvices.DataSource = devices;

            buttonSelectDevice.Click += new EventHandler(buttonSelectDevice_Click);

            selectedDeviceID = Properties.Settings.Default["SelectedDeviceID"].ToString().Trim();
            if (selectedDeviceID != "")
            {
                for (int i = 0; i < comboBoxActiveCaptureDvices.Items.Count; i++)
                {
                    Device device = (Device)comboBoxActiveCaptureDvices.Items[i];
                    if (device.Dev.ID.Equals(selectedDeviceID))
                    {
                        comboBoxActiveCaptureDvices.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                Visible = true;
            }
        }

        void buttonSelectDevice_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["SelectedDeviceID"] = ((Device)comboBoxActiveCaptureDvices.SelectedItem).Dev.ID;
            Properties.Settings.Default.Save();
            Hide();
        }

        void comboBoxActiveCaptureDvices_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIcon();
        }

        void tray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Device)comboBoxActiveCaptureDvices.SelectedItem).Mute = !((Device)comboBoxActiveCaptureDvices.SelectedItem).Mute;
                changeIcon();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Visible = !Visible;
            }
        }

        private void changeIcon()
        {
            if (((Device)comboBoxActiveCaptureDvices.SelectedItem).Mute)
            {
                notifyIcon1.Icon = Resource1.mic_off;
            }
            else
            {
                notifyIcon1.Icon = Resource1.mic;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = false;
        }

        private void Sair(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Configurar(object sender, EventArgs e)
        {
            Visible = true;
        }
    }
}
