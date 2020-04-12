using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatSize_ADMIN_;

namespace ChatSize_ADMIN_
{
    public partial class ChatAppAdminSize : Form
    {







        //Server Zone ==============================================================================================================

        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 1433;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        private static void SetupServer() //สร้าง Server
        {
            Console.Beep();
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT));
            serverSocket.Listen(5);
            serverSocket.BeginAccept(AcceptCallback, null);
            Console.Beep();
            Console.Beep();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("{0}", socket.RemoteEndPoint + " connected...");
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            Console.WriteLine("Received Text: " + text);

            if (text.ToLower() == "meeting") // Client requested time
            {
                foreach (Socket socket in clientSockets)
                {
                    //current = socket;
                    string message = "meeting";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    socket.Send(data);
                    //socket.BeginSend(data, 0, data.Length, SocketFlags.None, null, null);
                    Console.WriteLine("Meeting invite sent to " + socket.RemoteEndPoint);
                }

            }
            else if (text.ToLower() == "exit") // Client wants to exit gracefully
            {
                // Always Shutdown before closing
                Console.WriteLine(current.RemoteEndPoint + " disconnected");
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                return;
            }
            else
            {
                Console.WriteLine("Invalid request");
                byte[] data = Encoding.ASCII.GetBytes("Invalid request");
                current.Send(data);
                Console.WriteLine("Warning Sent");
            }


            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }



        //Server Zone ==============================================================================================================








        string AN;
        public void ADMINNAME(string Namesend)
        {
            AN = Namesend.ToString();
            UsernameText.Text = Namesend.ToString();
            Console.Beep();
        }
        public ChatAppAdminSize()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChatAppAdminSize_Load(object sender, EventArgs e)
        {

        }
    }
}
