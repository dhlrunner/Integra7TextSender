using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Multimedia;

namespace integraTextSender
{
    public partial class Form1 : Form
    {
        private OutputDevice outputDeviceA = null;
        private string lasttxt = string.Empty;
        private bool isInitstate = true;
        public Form1()
        {
            InitializeComponent();
            cmbMididev.SelectedIndex = -1;
        }

        private byte checksum(byte[] data)
        {
            uint sum = 0;
            foreach(byte b in data)
            {
                sum = sum + b;
            }
            return (byte)(128 - (sum % 128)); 
        }

        private void sendText(string txt, byte channel)
        {
            string sendtxt = txt.PadRight(12, ' ');
            List<byte> data = new List<byte>();
            byte[] head = { 0x41, 0x10, 0, 0, 0x64, 0x12 };
            byte[] chan = new byte[2];
            switch (channel)
            {
                case 1:
                    chan = new byte[] { 0x19, 0x02 };
                    break;
                case 2:
                    chan = new byte[] { 0x19, 0x22 };
                    break ;
                case 3:
                    chan = new byte[] { 0x19, 0x42 };
                    break;
                case 4:
                    chan = new byte[] { 0x19, 0x62 };
                    break;
                case 5:
                    chan = new byte[] { 0x1A, 0x02 };
                    break;
                case 6:
                    chan = new byte[] { 0x1A, 0x22 };
                    break;
                case 7:
                    chan = new byte[] { 0x1A, 0x42 };
                    break;
                case 8:
                    chan = new byte[] { 0x1A, 0x60 };
                    break;
                case 9:
                    chan = new byte[] { 0x1B, 0x02 };
                    break;
                case 10:
                    chan = new byte[] { 0x1B, 0x23 };
                    break;
                case 11:
                    chan = new byte[] { 0x1B, 0x43 };
                    break;
                case 12:
                    chan = new byte[] { 0x1B, 0x62 };
                    break;
                case 13:
                    chan = new byte[] { 0x1C, 0x02 };
                    break;
                case 14:
                    chan = new byte[] { 0x1C, 0x21 };
                    break;
                case 15:
                    chan = new byte[] { 0x1C, 0x41 };
                    break;
                case 16:
                    chan = new byte[] { 0x1C, 0x61 };
                    break;
                default:
                    throw new Exception("invalid midi channel");
            }    
            
            data.AddRange(chan);
            data.Add(0x00);
            data.Add(0x00);
            data.AddRange(Encoding.ASCII.GetBytes(sendtxt));
            data.Add(checksum(data.ToArray()));
            data.Add(0xF7);
            data.InsertRange(0, head);

            outputDeviceA.SendEvent(new NormalSysExEvent(data.ToArray()));

            StringBuilder sb = new StringBuilder();
            sb.Append("F0 ");
            foreach(byte b in data)
            {
                sb.Append($" {b.ToString("X2")}");
            }
            llblSysEx.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbMididev.DataSource = OutputDevice.GetAll();
            cmbMididev.DisplayMember = "Name";
            cmbMididev.SelectedIndex = -1;
            //cmbMididev.Text = "-Select midi device-";
            isInitstate = false;
        }

        private void cmbMididev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isInitstate)
            {
                try
                {
                    outputDeviceA = (OutputDevice)cmbMididev.SelectedItem;
                    numChan.Enabled = true;
                    tbxText.Enabled = true;
                    cbxAutoSend.Enabled = true;
                    btnSend.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Failed to open midi device{Environment.NewLine}{ex}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        private void tbxText_TextChanged(object sender, EventArgs e)
        {
            
            if(tbxText.Text.Length > 12)
            {
                tbxText.Text = lasttxt;
                tbxText.SelectionStart = tbxText.TextLength;
                tbxText.SelectionLength = 0;
            }
            else
            {

                lasttxt = tbxText.Text;
            }

            if (cbxAutoSend.Checked)
            {
                sendText(tbxText.Text, (byte)numChan.Value);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendText(tbxText.Text, (byte)numChan.Value);
        }

        private void llblSysEx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(llblSysEx.Text);
        }
    }
}
