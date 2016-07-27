using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.Forms;

namespace WpfApplicationEncTest
{
    
    class start : Form
    {
        Button btStart;

        public start()
        {
            this.Load += new EventHandler(Start_Load);
            this.Unload += new EventHandler(Start_Unload);
        }

        private void Start_Unload(object sender, EventArgs e)
        {
            btStart.Click -= new EventHandler(BtStart_Click);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            btStart = this.Controls.Find("btStart") as Button;
            btStart.Click += new EventHandler( BtStart_Click);
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            MainWindow m = new WpfApplicationEncTest.MainWindow();
            m.Show();
            
        }
    }
}
