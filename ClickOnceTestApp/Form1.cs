using System.Diagnostics;

namespace ClickOnceTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "https://raw.githubusercontent.com/MaikKrijgsman/ClickOnceTestApp/master/README.md";
            proc.Start();
            
        }

        private void Btn_Click_me_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hij is nu aangepast yay");
        }
    }
}