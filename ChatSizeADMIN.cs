using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatSize_ADMIN_;

namespace ChatSize_ADMIN_
{
    public partial class ChatAppAdminSize : Form
    {

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
    }
}
