using System;
using System.Windows.Forms;

namespace WebSerivceConsumer
{
    public partial class MainForm : Form
    {
        
        private WaitingForm waitingForm;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private async void buttonCompute_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(int.Parse(textBoxValueToCompute.Text));

            ShowWaitForm();
            //int result = webService.Fibonacci(n);
            int result = await AsyncMethods.FibonacciToAsync(n);
            HideWaitForm();

            textBoxFibonacciResult.Text = result.ToString();
        }

        private async void buttonConvert_Click(object sender, EventArgs e)
        {
            ShowWaitForm();
            //string result = webService.XmlToJson(textBoxXmlToConvert.Text);
            string result = await AsyncMethods.ConvertXmlToAsync(textBoxXmlToConvert.Text);
            HideWaitForm();

            textBoxXmlResult.Text = result;
        }

        private void ShowWaitForm()
        {
            if (waitingForm != null && !waitingForm.IsDisposed)
                return;

            waitingForm = new WaitingForm
            {
                TopMost = true,
                StartPosition = FormStartPosition.CenterScreen
            };
            waitingForm.Show();
            waitingForm.Refresh();
        }

        private void HideWaitForm()
        {
            waitingForm.Close();
        }
    }
}
