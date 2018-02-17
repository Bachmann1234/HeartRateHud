using System;
using System.IO;
using System.Windows.Forms;
using HeartRateApp.Properties;


using System.Net;
using System.Net.Sockets;
using uhttpsharp;
using uhttpsharp.Handlers;
using uhttpsharp.Listeners;
using uhttpsharp.RequestProviders;
using System.Text;
using System.Threading.Tasks;
using uhttpsharp.Headers;

namespace HeartRateApp
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();
            using (var httpServer = new HttpServer(new HttpRequestProvider()))
            {
                httpServer.Use(new TcpListenerAdapter(new TcpListener(IPAddress.Any, 5000)));
                httpServer.Use(new HttpRouter().With(string.Empty, new IndexHandler(form1.HeartRateDisplay())));
                httpServer.Start();
            }
            Application.Run(form1);
        }
    }
    public class IndexHandler : IHttpRequestHandler
    {
        private readonly HttpResponse _response;
        private readonly HttpResponse _keepAliveResponse;
        private Label hrLabel;

        public IndexHandler(Label hrLabel)
        {
            byte[] contents = Encoding.UTF8.GetBytes("Welcome to the Index.");
            _keepAliveResponse = new HttpResponse(HttpResponseCode.Ok, contents, true);
            _response = new HttpResponse(HttpResponseCode.Ok, "ok", false);
            this.hrLabel = hrLabel;
        }

        private void SetText(string text)
        {
            if (this.hrLabel.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                this.hrLabel.Invoke(d, new object[] { text });
            }
            else
            {
                this.hrLabel.Text = text;
            }
        }

        public Task Handle(IHttpContext context, Func<Task> next)
        {
            context.Response = context.Request.Headers.KeepAliveConnection() ? _keepAliveResponse : _response;
            SetText(context.Request.QueryString.GetByNameOrDefault("hr", "-1"));
            return Task.Factory.GetCompleted();
        }
    }
}

