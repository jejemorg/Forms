using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Proxy_Click(object sender, EventArgs e)
        {
         
        ///RegistryKey cle = Registry.CurrentUser;

            try
            {
                RegistryKey cle = cle.OpenSubKey(@"Software\Microsoft\windows\CurrentVersion\Internet Settings", true);
                ///Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\windows\CurrentVersion\Internet Settings", true);

                //String name = cle.GetValue("ProxyEnable", ToString);

                if (cle.GetValue("0"))
                {
                    cle.SetValue(@"ProxyEnable", 1);
                }}
             finally
            {
                this.Close();
            }
             
            }
        
    }
}
