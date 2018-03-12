using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Object;

namespace Prj_Reservation_K7
{
    public partial class Form1 : BaseForm
    {
        public void WIP_Message()
        {
            MessageBox.Show("En développement", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonDiscardChange_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonUndoChange_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonViewMode_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonEditMode_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonNewFile_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonEditFile_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonDeleteFile_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBegin_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            WIP_Message();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill();
            Link_Reservation();
        }

        private void Fill()
        {
            TA_De.Fill(dS_Reservation1.de);
            TA_Reservation.Fill(dS_Reservation1.reservation);
            TA_Client.Fill(dS_Reservation1.client);
        }

        private void Link_Reservation()
        {
            BS_Reservation.DataMember = "Reservation";
            BS_Reservation.DataSource = dS_Reservation1.reservation;
            BS_Client.DataMember = "Client";
            BS_Client.DataSource = dS_Reservation1.client;

            Rv_NoCli.DataBindings.Add("Text", BS_Client, "idCli");
            Rv_Add.DataBindings.Add("Text", BS_Client, "adresse");
            Rv_Tel.DataBindings.Add("Text", BS_Client, "telephone");
            Rv_TypCar.DataBindings.Add("Text", BS_Client, "typeCarte");
            Rv_SldDu.DataBindings.Add("Text", BS_Client, "soldeDu");
            Rv_NomCli.DataBindings.Add("Text", BS_Client, "nom");
            Rv_NoCar.DataBindings.Add("Text", BS_Client, "noCarte");
            Rv_Exp.DataBindings.Add("Text", BS_Client, "datExp");

            Rv_NoRes.DataBindings.Add("Text", BS_Reservation, "idReser");
            Rv_ResLe.DataBindings.Add("Text", BS_Reservation, "dateReser");
            Rv_DatDeb.DataBindings.Add("Text", BS_Reservation, "dateDebut");
            Rv_DatFin.DataBindings.Add("Text", BS_Reservation, "dateFin");
            //Rv_ResPour.DataBindings.Add();


        }

        private void DG_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
