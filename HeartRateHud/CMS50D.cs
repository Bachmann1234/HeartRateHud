using System;
using System.IO.Ports;

delegate void SetTextCallback(string text);
namespace HeartRateApp
{
    internal class Cms50D
    {
        private HeartRatePacket packet = new HeartRatePacket();
        private System.Windows.Forms.Label label;
        private SerialPort portConnection;
        public Cms50D(String port, System.Windows.Forms.Label label)
        {
            portConnection = new SerialPort(
                   port,
                   19200,
                   Parity.Odd,
                   8,
                   StopBits.One
            );
            this.label = label;
            portConnection.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

        }

        public void startReading()
        {
            portConnection.Open();
        }

        private void port_DataReceived(
          object sender,
          SerialDataReceivedEventArgs e)
        {
            var bytesToRead = portConnection.BytesToRead;
            var data = new byte[bytesToRead];
            portConnection.Read(data, 0, bytesToRead);
            foreach (var c in data)
            {
                var hrReading = packet.SetByte(c);
                if (hrReading != null)
                {
                    SetText(hrReading);
                }
            }
        }

        private void SetText(string text)
        {
            if (this.label.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                this.label.Invoke(d, new object[] { text });
            }
            else
            {
                this.label.Text = text;
            }
        }

    }
}
