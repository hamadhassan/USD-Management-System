using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UniversityStudentDiaryManagementSystem.Forms
{
    public partial class frmMessage : Form
    {
        //191.168.1.1
        Socket socket;
        EndPoint endPointLocal,endPointRemote;
        byte[] buffer; //it will send or recived messages 
        public frmMessage()
        {
            InitializeComponent();
        }
        private void frmMessage_Load(object sender, EventArgs e)
        {
            //set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //get local IP
            txtbxLocalIP.Text = getLocalIP();
            txtbxRemoteIP.Text = getLocalIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //binding socket
            endPointLocal = new IPEndPoint(IPAddress.Parse(txtbxLocalIP.Text), Convert.ToInt32(txtbxLocalPort.Text));
            socket.Bind(endPointLocal);
            //conncet with remoate ip
            endPointRemote = new IPEndPoint(IPAddress.Parse(txtbxRemoteIP.Text), Convert.ToInt32(txtbxRemortPort.Text));
            //connect with socket
            socket.Connect(endPointRemote);
            //listening the specfic port
            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,ref endPointRemote, new AsyncCallback(messageCallBack), buffer); ; ;
        }
        private void messageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                byte[] recivedData = new byte[1500];
                recivedData = (byte[])asyncResult.AsyncState;
                //Coverting byte[] to string 
                ASCIIEncoding encoding = new ASCIIEncoding();
                string revivedMessage = encoding.GetString(recivedData);
                //Adding this message into list box
                listbxMessage.Items.Add("Parent: " + revivedMessage);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch
            {

            }
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = encoding.GetBytes(txtbxMessage.Text);
            //Sending the encoded message
            socket.Send(sendingMessage);
            //Adding message to the listbox
            listbxMessage.Items.Add("Student: "+txtbxMessage.Text);
            txtbxMessage.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());//it will provide the all host ip address
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";//local defult host 
        }
    }
}
