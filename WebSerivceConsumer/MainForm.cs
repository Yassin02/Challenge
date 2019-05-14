using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSerivceConsumer
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private localhost.ChallengeWebService webService;
        private WaitingForm waitingForm;

        public MainForm()
        {
            InitializeComponent();
            webService = new localhost.ChallengeWebService();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(valueToCompute.Value);

            ShowWaitForm();
            int result = webService.Fibonacci(n);
            HideWaitForm();

            textBoxFibonacciResult.Text = result.ToString();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            ShowWaitForm();
            string result = webService.XmlToJson(textBoxXmlToConvert.Text);
            HideWaitForm();

            textBoxXmlResult.Text = result;
        }

        private void ShowWaitForm()
        {
            if (waitingForm != null && !waitingForm.IsDisposed)
            {
                return;
            }

            waitingForm = new WaitingForm();
            waitingForm.TopMost = true;
            waitingForm.StartPosition = FormStartPosition.CenterScreen;
            waitingForm.Show();
            waitingForm.Refresh();
        }

        private void HideWaitForm()
        {
            waitingForm.Close();
        }
    }
}
