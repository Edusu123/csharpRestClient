using System.Diagnostics;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient();
            client.EndPoint = txtRestURI.Text;
            //client.AuthTechnique = AuthenticationTechnique.RollYourOwn;
            client.AuthType = AuthenticationType.Basic;
            client.UserName = txtUserName.Text;
            client.Password = txtPassword.Text;

            DebugOutput("Rest Client Created");

            string response = client.MakeRequest();

            DebugOutput(response);
        }

        private void DebugOutput(string debugText)
        {
            try
            {
                Debug.Write(debugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + debugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}