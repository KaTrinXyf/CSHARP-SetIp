using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetIP
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"])
                    continue;
                //設置ip位址和子網路遮罩
                inPar = mo.GetMethodParameters("EnableStatic");
                inPar["IPAddress"] = new string[] { IPAddress.Text };
                inPar["SubnetMask"] = new string[] { SubnetMask.Text };
                outPar = mo.InvokeMethod("EnableStatic", inPar, null);

                //設置閘道位址
                inPar = mo.GetMethodParameters("SetGateways");
                inPar["DefaultIPGateway"] = new string[] { DefaultIPGateway.Text };
                outPar = mo.InvokeMethod("SetGateways", inPar, null);

                //設置DNS
                inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                inPar["DNSServerSearchOrder"] = new string[] { DNSServerSearchOrder.Text };
                outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myDesc = "Intel(R) Dual Band Wireless-AC 7265";
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        adapter.InvokeMethod("EnableDHCP", null);

                        Console.WriteLine("Updated Dynamic address!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to Set IP : " + ex.Message);
                    }
                }
            }
        }
    }
}
