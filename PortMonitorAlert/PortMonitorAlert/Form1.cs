
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;

namespace PortMonitorAlert
{
    public partial class Form1 : Form
    {
        private static bool MonitoringIsActive = false;
        private static List<IPEndPoint> excludeLocalEndpoints = new List<IPEndPoint>() { };

        public Form1()
        {
            InitializeComponent();
        }

        private void MonitoringIsActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MonitoringIsActive = MonitoringIsActiveCheckBox.Checked;
            if (MonitoringIsActiveCheckBox.Checked)
            {
                ActiavteMonitoring();
            }

        }


        private void ActiavteMonitoring()
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            MonitoringConnectionsTextBox.Clear();
            do
            {
                var activeTcpListeners = ipProperties.GetActiveTcpListeners();

                var activeTcpConnections = ipProperties.GetActiveTcpConnections();

                foreach (var activeConnection in activeTcpConnections)
                {
                    if (excludeLocalEndpoints.Contains(activeConnection.LocalEndPoint))
                    {
                        continue;
                    }
                    if (activeTcpListeners.Contains(activeConnection.LocalEndPoint))
                    {
                        string additional = "1: Local: " + activeConnection.LocalEndPoint.ToString() + "| Remote: " + activeConnection.RemoteEndPoint.ToString() + Environment.NewLine;
                        MonitoringConnectionsTextBox.AppendText(additional);
                        AlertWindow newAlert = new AlertWindow(activeConnection.LocalEndPoint, activeConnection.RemoteEndPoint);
                        newAlert.ShowDialog();
                    }
                }
                Application.DoEvents();
            } while (true);
        }

        internal static void addIpExclusion(IPEndPoint ipEndPoint)
        {
            excludeLocalEndpoints.Add(ipEndPoint);
        }
    }
}