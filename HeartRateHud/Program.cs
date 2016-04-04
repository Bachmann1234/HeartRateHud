using System;
using System.IO;
using System.Windows.Forms;
using HeartRateApp.Properties;

namespace HeartRateApp
{
    class Program
    {

        private static bool successfullyConnected(Cms50D device)
        {
            for (var i = 0; i < 3; i++)
            {
                try
                {
                    device.startReading();
                    return true;
                }
                catch (IOException)
                {
                    MessageBox.Show(Resources.Program_Main_Failed_to_connect_to_device__Retrying);
                }

            }
            return false;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();
            var port = System.Environment.GetEnvironmentVariable("CMSPort", EnvironmentVariableTarget.User);
            if (port == null)
            {
                MessageBox.Show(Resources.Program_Main_Must_set_environment_Variable_CMSPort);
            }
            else
            {
                var hrDevice = new Cms50D(port, form1.HeartRateDisplay());
                if (successfullyConnected(hrDevice))
                {
                    Application.Run(form1);
                }
                else
                {
                    MessageBox.Show(Resources.Program_Main_Failed_to_connect_to_device);
                }
            }
        }
    }
}

