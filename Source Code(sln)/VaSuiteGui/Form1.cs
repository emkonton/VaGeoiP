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

namespace VaSuiteGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ipadusin_TextChanged(object sender, EventArgs e)
        {
           

           

        }




        private async void gialsb_Click(object sender, EventArgs e)
        {
            string ip = ipadusin.Text.Trim();
            if (string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("Lütfen geçerli bir IP adresi girin.");
                return;
            }

            try
            {
                rtbOutput.Text = "Sorgulanıyor...";

                var output = await Task.Run(() =>
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "python";
                    p.StartInfo.Arguments = $"ipinfo.py {ip}";
                    p.StartInfo.WorkingDirectory = @"C:\Users\pc\source\repos\VaSuiteGui\VaSuiteGui\pythonScripts";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                    string stdOutput = p.StandardOutput.ReadToEnd();
                    string stdError = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    return string.IsNullOrEmpty(stdError) ? stdOutput : stdError;
                });

                rtbOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
