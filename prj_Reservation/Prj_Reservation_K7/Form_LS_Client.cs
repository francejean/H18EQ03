using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Reservation_K7
{
    public partial class Form_LS_Client : Form
    {
        public Form_LS_Client()
        {
            InitializeComponent();
        }

        private void Form_LS_Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Reservation.client' table. You can move, or remove it, as needed.
            this.TA_Client.Fill(this.dS_Reservation.client);
            this.CenterToParent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public DataGridView Dgv_ClientListF
        {
            set
            {
                Dgv_ClientList = value;
            }
            get
            {
                return Dgv_ClientList;
            }
        }
    }
}
