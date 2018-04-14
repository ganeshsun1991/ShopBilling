using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Billing.message_box
{
    class messageboxtype
    {
        public void CallMessageBox(string body, string title, string type)
        {

            if (type == "information")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type == "ex")
            {
                MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
