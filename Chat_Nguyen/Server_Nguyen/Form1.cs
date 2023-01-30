using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Nguyen
{
    public partial class Form1 : Form
    {
        private List<Socket> s;
        private List<string> s2;
        public Form1(List<Socket> s, List<string> s2)
        {
            InitializeComponent();
            this.s = s;
            this.s2 = s2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            for(int i = 0; i < )
            {

            }    
            */
        }
    }
}
