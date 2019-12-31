using System.Windows;
using System.Windows.Controls;
using ZeroMQ;
namespace Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (var requester = new ZSocket(ZSocketType.REQ))
            {
                requester.Connect("tcp://127.0.0.1:5858"); // Connect
                string requestText = text.Text; 

                requester.Send(new ZFrame(requestText)); // Send

                using (ZFrame reply = requester.ReceiveFrame()) // Receive
                {
                    label.Content = reply.ReadString();
                }
            }
        }
    }
}