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
    public partial class Form_BaseForm_Reservation : BaseForm
    {
        public void wip_Message()
        {
            MessageBox.Show("En développement", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void setViewMode()
        {
            this.Tbx_Address.ReadOnly = true;
            this.Tbx_BalanceDue.ReadOnly = true;
            this.Tbx_BookingDoneAt.ReadOnly = true;
            this.Tbx_BookingEndAt.ReadOnly = true;
            this.Tbx_BookingStartAt.ReadOnly = true;
            this.Tbx_CardExp.ReadOnly = true;
            this.Tbx_CardNb.ReadOnly = true;
            this.Tbx_CardType.ReadOnly = true;
            this.Tbx_idBooking.ReadOnly = true;
            this.Tbx_idCli.ReadOnly = true;
            this.Tbx_Name.ReadOnly = true;
            this.Tbx_PhoneNb.ReadOnly = true;
            this.Tbx_ResPour.ReadOnly = true;
            this.Controls["buttonModeConsultation1"].Enabled = false;
            this.Controls["buttonModeEdit1"].Enabled = true;
            this.Controls["buttonFileNew1"].Enabled = false;
            this.Controls["buttonFileEdit1"].Enabled = false;
            this.Controls["buttonFileDelete1"].Enabled = false;
        }

        private void setEditMode()
        {
            this.Tbx_Address.ReadOnly = false;
            this.Tbx_BalanceDue.ReadOnly = false;
            this.Tbx_BookingDoneAt.ReadOnly = false;
            this.Tbx_BookingEndAt.ReadOnly = false;
            this.Tbx_BookingStartAt.ReadOnly = false;
            this.Tbx_CardExp.ReadOnly = false;
            this.Tbx_CardNb.ReadOnly = false;
            this.Tbx_CardType.ReadOnly = false;
            this.Tbx_idBooking.ReadOnly = false;
            this.Tbx_Name.ReadOnly = false;
            this.Tbx_PhoneNb.ReadOnly = false;
            this.Tbx_idCli.ReadOnly = false;
            this.Tbx_ResPour.ReadOnly = false;
            this.Controls["buttonModeConsultation1"].Enabled = true;
            this.Controls["buttonModeEdit1"].Enabled = false;
            this.Controls["buttonFileNew1"].Enabled = true;
            this.Controls["buttonFileEdit1"].Enabled = true;
            this.Controls["buttonFileDelete1"].Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            wip_Message();
        }

        private void buttonDiscardChange_Click(object sender, EventArgs e)
        {
            //wip_Message();
            rebind_stuff();
            this.buttonGoBegin1.Enabled = true;
            this.buttonGoPrevious1.Enabled = true;
            this.buttonGoNext1.Enabled = true;
            this.buttonGoEnd1.Enabled = true;
            this.textBox1.Enabled = true;

            //undo_prepare_stuff()
            this.Tbx_idBooking.Enabled = true;
            this.Tbx_BookingDoneAt.Enabled = true;
        }

        private void buttonUndoChange_Click(object sender, EventArgs e)
        {
            wip_Message();
        }

        private void buttonViewMode_Click(object sender, EventArgs e)
        {
            //wip_Message();
            setViewMode();
        }

        private void buttonEditMode_Click(object sender, EventArgs e)
        {
            //wip_Message();
            setEditMode();
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            //wip_Message();
            unbind_stuff();
            clear_stuff();
            prepare_stuff();
        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            wip_Message();
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            wip_Message();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            //WIP_Message();
            BS_Reservation.MoveFirst();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //WIP_Message();
            BS_Reservation.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //WIP_Message();
            BS_Reservation.MoveNext();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            //WIP_Message();
            BS_Reservation.MoveLast();
        }

        public Form_BaseForm_Reservation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            setViewMode();
        }

        private void form_BaseFormReservation_Load(object sender, EventArgs e)
        {
           
            fill();
            link_Reservation();
            //Link_ReservationFK();
        }

        private void fill()
        {
            try
            {
                // TODO: This line of code loads data into the 'dS_Reservation1.chambre' table. You can move, or remove it, as needed.
                TA_Chambre.Fill(DS_Reservation.chambre);
                TA_De.Fill(DS_Reservation.de);
                TA_Client.Fill(DS_Reservation.client);
                TA_Reservation.Fill(DS_Reservation.reservation);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void link_Reservation()
        {

            //BS_Reservation.DataMember = "Reservation";
            BS_Reservation.DataSource = DS_Reservation.reservation;
            labelInfo1.Text = BS_Reservation.Count.ToString();

            BS_Reservation.MoveFirst();
            BS_Client.DataMember = "Client";
            BS_Client.DataSource = DS_Reservation.client;

            try
            {
                BS_De.DataSource = BS_Reservation;
                BS_De.DataMember = "FK1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Dgv_Rooms.DataSource = BS_De;

            rebind_stuff();
        }

        private void unbind_stuff()
        {
            Tbx_idCli.DataBindings.Clear();
            Tbx_Address.DataBindings.Clear();
            Tbx_PhoneNb.DataBindings.Clear();
            Tbx_CardType.DataBindings.Clear();
            Tbx_BalanceDue.DataBindings.Clear();
            Tbx_Name.DataBindings.Clear();
            Tbx_CardNb.DataBindings.Clear();
            Tbx_CardExp.DataBindings.Clear();

            Tbx_idBooking.DataBindings.Clear();
            Tbx_BookingDoneAt.DataBindings.Clear();
            Tbx_BookingStartAt.DataBindings.Clear();
            Tbx_BookingEndAt.DataBindings.Clear();
        }

        private void clear_stuff()
        {
            Tbx_idCli.Text = "";
            Tbx_Address.Text = "";
            Tbx_PhoneNb.Text = "";
            Tbx_CardType.Text = "";
            Tbx_BalanceDue.Text = "";
            Tbx_Name.Text = "";
            Tbx_CardNb.Text = "";
            Tbx_CardExp.Text = "";

            Tbx_idBooking.Text = "";
            Tbx_BookingDoneAt.Text = "";
            Tbx_BookingStartAt.Text = "";
            Tbx_BookingEndAt.Text = "";
        }

        private void prepare_stuff()
        {
            Tbx_idBooking.Enabled = false;
            Tbx_idBooking.Text = "Will be generated";
            Tbx_BookingDoneAt.Enabled = false;
            Tbx_BookingDoneAt.Text = DateTime.Now.ToString();

            this.buttonGoBegin1.Enabled = false;
            this.buttonGoPrevious1.Enabled = false;
            this.buttonGoNext1.Enabled = false;
            this.buttonGoEnd1.Enabled = false;
            this.textBox1.Enabled = false;
        }

        private void rebind_stuff()
        {
            Tbx_idCli.DataBindings.Add("Text", BS_Reservation, "idCli");

            BS_Client.Position = BS_Client.Find("idCli", DS_Reservation.Tables["reservation"].Rows[BS_Reservation.Position]["idCli"]);

            Tbx_Address.DataBindings.Add("Text", BS_Client, "adresse");
            Tbx_PhoneNb.DataBindings.Add("Text", BS_Client, "telephone");
            Tbx_CardType.DataBindings.Add("Text", BS_Client, "typeCarte");
            Tbx_BalanceDue.DataBindings.Add("Text", BS_Client, "soldeDu");
            Tbx_Name.DataBindings.Add("Text", BS_Client, "nom");
            Tbx_CardNb.DataBindings.Add("Text", BS_Client, "noCarte");
            Tbx_CardExp.DataBindings.Add("Text", BS_Client, "datExp");

            Tbx_idBooking.DataBindings.Add("Text", BS_Reservation, "idReser");
            Tbx_BookingDoneAt.DataBindings.Add("Text", BS_Reservation, "dateReser");
            Tbx_BookingStartAt.DataBindings.Add("Text", BS_Reservation, "dateDebut");
            Tbx_BookingEndAt.DataBindings.Add("Text", BS_Reservation, "dateFin");
            //Rv_ResPour.DataBindings.Add();
        }

        private void link_ReservationFK()
        {
            //Tbx_idCli.Text = DS_Reservation.Tables["client"].Rows[BS_Reservation.Position].GetParentRow("idCli")["nom"].ToString();
        }

        private void tbx_idBooking_TextChanged(object sender, EventArgs e)
        {
            BS_Client.Position = BS_Client.Find("idCli", DS_Reservation.Tables["reservation"].Rows[BS_Reservation.Position]["idCli"]);
            textBox1.Text = (BS_Reservation.Position + 1).ToString();
        }

        private void tbx_idCli_DoubleClick(object sender, EventArgs e)
        {
            if (!Tbx_idCli.ReadOnly)
            {
                int temp = BS_Client.Position;

                Form_LS_Client lsForm = new Form_LS_Client();
                ((DataGridView)lsForm.Controls["Dgv_ClientList"]).DataSource = BS_Client;
                //lsForm.Dgv_ClientListF.DataSource = BS_Client;

                if (lsForm.ShowDialog() == DialogResult.Cancel)
                    BS_Client.Position = temp;
                else
                {
                    Tbx_idCli.Text = ((DataRowView)BS_Client.Current).Row["idCli"].ToString();
                }
            }
        }

        private void showRoom(/*object sender, EventArgs e*/)
        {
            //if (!Tbx_idBooking.ReadOnly)
            //{
            int temp = BS_Chambre.Position;

            Form_LS_Chambre lsForm = new Form_LS_Chambre();
            ((DataGridView)lsForm.Controls["Dgv_RoomList"]).DataSource = BS_Chambre;
            //lsForm.Dgv_ClientListF.DataSource = BS_Client;

            /*if (lsForm.ShowDialog() == DialogResult.Cancel)
                BS_Reservation.Position = temp;
            else
            {
                //Tbx_idBooking.Text = ((DataRowView)BS_Reservation.Current).Row["idCli"].ToString();
            }*/
            //}
        }

        private void tbx_idBooking_DoubleClick(object sender, EventArgs e)
        {
            //if (!Tbx_idBooking.ReadOnly)
            //{
                int temp = BS_Reservation.Position;

                Form_LS_Reservation lsForm = new Form_LS_Reservation();
                ((DataGridView)lsForm.Controls["Dgv_BookingList"]).DataSource = BS_Reservation;
                //lsForm.Dgv_ClientListF.DataSource = BS_Client;

                if (lsForm.ShowDialog() == DialogResult.Cancel)
                    BS_Reservation.Position = temp;
                /*else
                {
                    Tbx_idBooking.Text = ((DataRowView)BS_Reservation.Current).Row["idCli"].ToString();
                }*/
            //}
        }
    }
}
