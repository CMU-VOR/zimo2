using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;  
using System.Collections;  
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]  
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);


        private void button1_Click(object sender, EventArgs e)
        {
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            record("save recsound c:\\temp\\111.wav", "", 0, 0);
            record("close recsound", "", 0, 0);
            MessageBox.Show("OK");

        }
    }
}
