using System;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;
using uhttpsharp;
using uhttpsharp.Handlers;
using uhttpsharp.Listeners;
using uhttpsharp.RequestProviders;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeartRateApp
{
    delegate void SetTextCallback(string text);

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var display = new hrDisplay();
            using (var httpServer = new HttpServer(new HttpRequestProvider()))
            {
                httpServer.Use(new TcpListenerAdapter(new TcpListener(IPAddress.Any, 5000)));
                httpServer.Use(new HttpRouter().With(string.Empty, new IndexHandler(display.HeartRateDisplay())));
                httpServer.Start();
            }
            Application.Run(display);
        }
    }

    class HrRequest
    {
        public string Hr { get; set; }
        public string Timestamp { get; set; }
        public string UserId { get; set; }
    }

    public class IndexHandler : IHttpRequestHandler
    {
        private readonly HttpResponse _response;
        private Label hrLabel;

        public IndexHandler(Label hrLabel)
        {
            _response = new HttpResponse(HttpResponseCode.Ok, "ok", true);
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
            context.Response = _response;
            HrRequest requestdata = JsonConvert.DeserializeObject<HrRequest>(
                System.Text.Encoding.Default.GetString(context.Request.Post.Raw)
            );
  
            SetText(requestdata.Hr);
            return Task.Factory.GetCompleted();
        }
    }
}

