using System;
using System.Windows.Forms;

namespace RobloxExecutorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Membuat tombol Execute sederhana
            Button executeBtn = new Button();
            executeBtn.Text = "Execute Script";
            executeBtn.Click += (sender, e) => {
                MessageBox.Show("Memasukkan Script ke Roblox...");
            };
            
            this.Controls.Add(executeBtn);
        }
    }
}
