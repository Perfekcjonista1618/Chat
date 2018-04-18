using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Model;

namespace Client
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        private void bttnJoin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNick.Text))
            {
                var newMember = new ChatMember(txtNick.Text);
                Form ChatForm = new ChatForm(newMember, this);
                ChatForm.ShowDialog();
                Hide();
            }
            else
            MessageBox.Show("Enter your name","Chat joining failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void txtNick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bttnJoin.PerformClick();
        }
    }
}
