using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;

namespace PortMonitorAlert
{
    public partial class AlertWindow : Form
    {
        private IPEndPoint listeningIpPort;
        private IPEndPoint remoteIpPort;

        public AlertWindow(IPEndPoint ListeningIpPort, IPEndPoint RemoteIpPort)
        {
            InitializeComponent();
            listeningIpPort = ListeningIpPort;
            remoteIpPort = RemoteIpPort;

        }

        private void ExcludeListeningSocketButton_Click(object sender, EventArgs e)
        {
            Form1.addIpExclusion(listeningIpPort);
            this.Dispose();
            this.Close();
        }

        private void AlertWindow_Load(object sender, EventArgs e)
        {
            eventDateTimeLabel.Text = DateTime.Now.ToString();
            ListeningSocketTextBox.Text = listeningIpPort.Address.ToString() + ":" + listeningIpPort.Port.ToString();
            RemoteSocketTextBox.Text = remoteIpPort.Address.ToString() + ":" + remoteIpPort.Port.ToString();
        }
    }
}
