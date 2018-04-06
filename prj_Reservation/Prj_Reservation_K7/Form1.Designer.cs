namespace Prj_Reservation_K7
{
    partial class Form_BaseForm_Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Gbx_FormData = new System.Windows.Forms.GroupBox();
            this.Dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attribueeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_De = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reservation = new Prj_Reservation_K7.DS_Reservation();
            this.Gbx_BookingData = new System.Windows.Forms.GroupBox();
            this.Tbx_ResPour = new Prj_Object.TextBox();
            this.Lbl_BookingFor = new Prj_Object.LabelInfo();
            this.Tbx_idBooking = new Prj_Object.TextBox();
            this.Tbx_BookingEndAt = new Prj_Object.TextBox();
            this.Lbl_BookingEndAt = new Prj_Object.LabelInfo();
            this.Tbx_BookingDoneAt = new Prj_Object.TextBox();
            this.Lbl_BookingDoneAt = new Prj_Object.LabelInfo();
            this.Tbx_BookingStartAt = new Prj_Object.TextBox();
            this.Lbl_BookingStartAt = new Prj_Object.LabelInfo();
            this.Lbl_idBooking = new Prj_Object.LabelInfo();
            this.Lbl_BookingData = new Prj_Object.LabelTitle();
            this.Gbx_ClientData = new System.Windows.Forms.GroupBox();
            this.Tbx_BalanceDue = new Prj_Object.TextBox();
            this.Lbl_BalanceDue = new Prj_Object.LabelInfo();
            this.Tbx_CardExp = new Prj_Object.TextBox();
            this.Lbl_CardExp = new Prj_Object.LabelInfo();
            this.Tbx_CardNb = new Prj_Object.TextBox();
            this.Lbl_CardNb = new Prj_Object.LabelInfo();
            this.Tbx_PhoneNb = new Prj_Object.TextBox();
            this.Lbl_PhoneNb = new Prj_Object.LabelInfo();
            this.Tbx_CardType = new Prj_Object.TextBox();
            this.Lbl_CardType = new Prj_Object.LabelInfo();
            this.Tbx_Address = new Prj_Object.TextBox();
            this.Lbl_Address = new Prj_Object.LabelInfo();
            this.Tbx_Name = new Prj_Object.TextBox();
            this.Tbx_idCli = new Prj_Object.TextBox();
            this.Lbl_Name = new Prj_Object.LabelInfo();
            this.Lbl_idCli = new Prj_Object.LabelInfo();
            this.Lbl_ClientDataTitle = new Prj_Object.LabelTitle();
            this.TA_Reservation = new Prj_Reservation_K7.DS_ReservationTableAdapters.reservationTableAdapter();
            this.TA_Client = new Prj_Reservation_K7.DS_ReservationTableAdapters.clientTableAdapter();
            this.TA_De = new Prj_Reservation_K7.DS_ReservationTableAdapters.deTableAdapter();
            this.TA_Chambre = new Prj_Reservation_K7.DS_ReservationTableAdapters.chambreTableAdapter();
            this.BS_Reservation = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Chambre = new System.Windows.Forms.BindingSource(this.components);
            this.Gbx_FormData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reservation)).BeginInit();
            this.Gbx_BookingData.SuspendLayout();
            this.Gbx_ClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeDiscard1
            // 
            this.buttonChangeDiscard1.Click += new System.EventHandler(this.buttonDiscardChange_Click);
            // 
            // buttonChangeRevert1
            // 
            this.buttonChangeRevert1.Click += new System.EventHandler(this.buttonUndoChange_Click);
            // 
            // buttonFileDelete1
            // 
            this.buttonFileDelete1.Location = new System.Drawing.Point(639, 12);
            this.buttonFileDelete1.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // buttonFileNew1
            // 
            this.buttonFileNew1.Location = new System.Drawing.Point(477, 12);
            this.buttonFileNew1.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // buttonFileEdit1
            // 
            this.buttonFileEdit1.Location = new System.Drawing.Point(558, 12);
            this.buttonFileEdit1.Click += new System.EventHandler(this.buttonEditFile_Click);
            // 
            // buttonGoBegin1
            // 
            this.buttonGoBegin1.Location = new System.Drawing.Point(346, 541);
            this.buttonGoBegin1.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonGoNext1
            // 
            this.buttonGoNext1.Location = new System.Drawing.Point(682, 541);
            this.buttonGoNext1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonGoEnd1
            // 
            this.buttonGoEnd1.Location = new System.Drawing.Point(763, 541);
            this.buttonGoEnd1.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonGoPrevious1
            // 
            this.buttonGoPrevious1.Location = new System.Drawing.Point(427, 541);
            this.buttonGoPrevious1.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonModeConsultation1
            // 
            this.buttonModeConsultation1.Location = new System.Drawing.Point(293, 12);
            this.buttonModeConsultation1.Click += new System.EventHandler(this.buttonViewMode_Click);
            // 
            // buttonModeEdit1
            // 
            this.buttonModeEdit1.Location = new System.Drawing.Point(374, 12);
            this.buttonModeEdit1.Click += new System.EventHandler(this.buttonEditMode_Click);
            // 
            // buttonQuit1
            // 
            this.buttonQuit1.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 560);
            // 
            // labelInfo1
            // 
            this.labelInfo1.Location = new System.Drawing.Point(613, 560);
            // 
            // labelInfo2
            // 
            this.labelInfo2.Location = new System.Drawing.Point(579, 560);
            // 
            // Gbx_FormData
            // 
            this.Gbx_FormData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_FormData.Controls.Add(this.Dgv_Rooms);
            this.Gbx_FormData.Controls.Add(this.Gbx_BookingData);
            this.Gbx_FormData.Controls.Add(this.Lbl_BookingData);
            this.Gbx_FormData.Controls.Add(this.Gbx_ClientData);
            this.Gbx_FormData.Controls.Add(this.Lbl_ClientDataTitle);
            this.Gbx_FormData.Location = new System.Drawing.Point(12, 93);
            this.Gbx_FormData.Name = "Gbx_FormData";
            this.Gbx_FormData.Size = new System.Drawing.Size(1160, 442);
            this.Gbx_FormData.TabIndex = 16;
            this.Gbx_FormData.TabStop = false;
            // 
            // Dgv_Rooms
            // 
            this.Dgv_Rooms.AllowUserToAddRows = false;
            this.Dgv_Rooms.AllowUserToDeleteRows = false;
            this.Dgv_Rooms.AutoGenerateColumns = false;
            this.Dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserDataGridViewTextBoxColumn,
            this.noChamDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.attribueeDataGridViewTextBoxColumn});
            this.Dgv_Rooms.DataSource = this.BS_De;
            this.Dgv_Rooms.Location = new System.Drawing.Point(34, 286);
            this.Dgv_Rooms.Name = "Dgv_Rooms";
            this.Dgv_Rooms.ReadOnly = true;
            this.Dgv_Rooms.Size = new System.Drawing.Size(1096, 150);
            this.Dgv_Rooms.TabIndex = 46;
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "idReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "Id Réservation";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            this.idReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "noCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "No. Chambre";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "codTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "Type Chambre";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            this.codTypChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attribueeDataGridViewTextBoxColumn
            // 
            this.attribueeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attribueeDataGridViewTextBoxColumn.DataPropertyName = "attribuee";
            this.attribueeDataGridViewTextBoxColumn.HeaderText = "Attribuée";
            this.attribueeDataGridViewTextBoxColumn.Name = "attribueeDataGridViewTextBoxColumn";
            this.attribueeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_De
            // 
            this.BS_De.DataMember = "de";
            this.BS_De.DataSource = this.DS_Reservation;
            // 
            // DS_Reservation
            // 
            this.DS_Reservation.DataSetName = "DS_Reservation";
            this.DS_Reservation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Gbx_BookingData
            // 
            this.Gbx_BookingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_BookingData.Controls.Add(this.Tbx_ResPour);
            this.Gbx_BookingData.Controls.Add(this.Lbl_BookingFor);
            this.Gbx_BookingData.Controls.Add(this.Tbx_idBooking);
            this.Gbx_BookingData.Controls.Add(this.Tbx_BookingEndAt);
            this.Gbx_BookingData.Controls.Add(this.Lbl_BookingEndAt);
            this.Gbx_BookingData.Controls.Add(this.Tbx_BookingDoneAt);
            this.Gbx_BookingData.Controls.Add(this.Lbl_BookingDoneAt);
            this.Gbx_BookingData.Controls.Add(this.Tbx_BookingStartAt);
            this.Gbx_BookingData.Controls.Add(this.Lbl_BookingStartAt);
            this.Gbx_BookingData.Controls.Add(this.Lbl_idBooking);
            this.Gbx_BookingData.Location = new System.Drawing.Point(714, 42);
            this.Gbx_BookingData.Name = "Gbx_BookingData";
            this.Gbx_BookingData.Size = new System.Drawing.Size(416, 215);
            this.Gbx_BookingData.TabIndex = 41;
            this.Gbx_BookingData.TabStop = false;
            // 
            // Tbx_ResPour
            // 
            this.Tbx_ResPour.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ResPour.Location = new System.Drawing.Point(168, 177);
            this.Tbx_ResPour.Name = "Tbx_ResPour";
            this.Tbx_ResPour.Size = new System.Drawing.Size(167, 25);
            this.Tbx_ResPour.TabIndex = 43;
            // 
            // Lbl_BookingFor
            // 
            this.Lbl_BookingFor.AutoSize = true;
            this.Lbl_BookingFor.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingFor.Location = new System.Drawing.Point(45, 180);
            this.Lbl_BookingFor.Name = "Lbl_BookingFor";
            this.Lbl_BookingFor.Size = new System.Drawing.Size(97, 18);
            this.Lbl_BookingFor.TabIndex = 42;
            this.Lbl_BookingFor.Text = "Réservé pour:";
            // 
            // Tbx_idBooking
            // 
            this.Tbx_idBooking.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_idBooking.Location = new System.Drawing.Point(168, 13);
            this.Tbx_idBooking.Name = "Tbx_idBooking";
            this.Tbx_idBooking.Size = new System.Drawing.Size(167, 25);
            this.Tbx_idBooking.TabIndex = 41;
            this.Tbx_idBooking.TextChanged += new System.EventHandler(this.tbx_idBooking_TextChanged);
            this.Tbx_idBooking.DoubleClick += new System.EventHandler(this.tbx_idBooking_DoubleClick);
            // 
            // Tbx_BookingEndAt
            // 
            this.Tbx_BookingEndAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_BookingEndAt.Location = new System.Drawing.Point(168, 136);
            this.Tbx_BookingEndAt.Name = "Tbx_BookingEndAt";
            this.Tbx_BookingEndAt.Size = new System.Drawing.Size(167, 25);
            this.Tbx_BookingEndAt.TabIndex = 40;
            // 
            // Lbl_BookingEndAt
            // 
            this.Lbl_BookingEndAt.AutoSize = true;
            this.Lbl_BookingEndAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingEndAt.Location = new System.Drawing.Point(45, 139);
            this.Lbl_BookingEndAt.Name = "Lbl_BookingEndAt";
            this.Lbl_BookingEndAt.Size = new System.Drawing.Size(86, 18);
            this.Lbl_BookingEndAt.TabIndex = 39;
            this.Lbl_BookingEndAt.Text = "Date de fin:";
            // 
            // Tbx_BookingDoneAt
            // 
            this.Tbx_BookingDoneAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_BookingDoneAt.Location = new System.Drawing.Point(168, 54);
            this.Tbx_BookingDoneAt.Name = "Tbx_BookingDoneAt";
            this.Tbx_BookingDoneAt.Size = new System.Drawing.Size(167, 25);
            this.Tbx_BookingDoneAt.TabIndex = 32;
            // 
            // Lbl_BookingDoneAt
            // 
            this.Lbl_BookingDoneAt.AutoSize = true;
            this.Lbl_BookingDoneAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingDoneAt.Location = new System.Drawing.Point(45, 57);
            this.Lbl_BookingDoneAt.Name = "Lbl_BookingDoneAt";
            this.Lbl_BookingDoneAt.Size = new System.Drawing.Size(78, 18);
            this.Lbl_BookingDoneAt.TabIndex = 27;
            this.Lbl_BookingDoneAt.Text = "Réservé le:";
            // 
            // Tbx_BookingStartAt
            // 
            this.Tbx_BookingStartAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_BookingStartAt.Location = new System.Drawing.Point(168, 95);
            this.Tbx_BookingStartAt.Name = "Tbx_BookingStartAt";
            this.Tbx_BookingStartAt.Size = new System.Drawing.Size(167, 25);
            this.Tbx_BookingStartAt.TabIndex = 26;
            // 
            // Lbl_BookingStartAt
            // 
            this.Lbl_BookingStartAt.AutoSize = true;
            this.Lbl_BookingStartAt.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingStartAt.Location = new System.Drawing.Point(45, 98);
            this.Lbl_BookingStartAt.Name = "Lbl_BookingStartAt";
            this.Lbl_BookingStartAt.Size = new System.Drawing.Size(109, 18);
            this.Lbl_BookingStartAt.TabIndex = 25;
            this.Lbl_BookingStartAt.Text = "Date de début:";
            // 
            // Lbl_idBooking
            // 
            this.Lbl_idBooking.AutoSize = true;
            this.Lbl_idBooking.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idBooking.Location = new System.Drawing.Point(45, 16);
            this.Lbl_idBooking.Name = "Lbl_idBooking";
            this.Lbl_idBooking.Size = new System.Drawing.Size(114, 18);
            this.Lbl_idBooking.TabIndex = 23;
            this.Lbl_idBooking.Text = "No. Réservation:";
            // 
            // Lbl_BookingData
            // 
            this.Lbl_BookingData.AutoSize = true;
            this.Lbl_BookingData.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingData.Location = new System.Drawing.Point(723, 16);
            this.Lbl_BookingData.Name = "Lbl_BookingData";
            this.Lbl_BookingData.Size = new System.Drawing.Size(264, 23);
            this.Lbl_BookingData.TabIndex = 1;
            this.Lbl_BookingData.Text = "Information sur la réservation";
            this.Lbl_BookingData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gbx_ClientData
            // 
            this.Gbx_ClientData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_ClientData.Controls.Add(this.Tbx_BalanceDue);
            this.Gbx_ClientData.Controls.Add(this.Lbl_BalanceDue);
            this.Gbx_ClientData.Controls.Add(this.Tbx_CardExp);
            this.Gbx_ClientData.Controls.Add(this.Lbl_CardExp);
            this.Gbx_ClientData.Controls.Add(this.Tbx_CardNb);
            this.Gbx_ClientData.Controls.Add(this.Lbl_CardNb);
            this.Gbx_ClientData.Controls.Add(this.Tbx_PhoneNb);
            this.Gbx_ClientData.Controls.Add(this.Lbl_PhoneNb);
            this.Gbx_ClientData.Controls.Add(this.Tbx_CardType);
            this.Gbx_ClientData.Controls.Add(this.Lbl_CardType);
            this.Gbx_ClientData.Controls.Add(this.Tbx_Address);
            this.Gbx_ClientData.Controls.Add(this.Lbl_Address);
            this.Gbx_ClientData.Controls.Add(this.Tbx_Name);
            this.Gbx_ClientData.Controls.Add(this.Tbx_idCli);
            this.Gbx_ClientData.Controls.Add(this.Lbl_Name);
            this.Gbx_ClientData.Controls.Add(this.Lbl_idCli);
            this.Gbx_ClientData.Location = new System.Drawing.Point(34, 42);
            this.Gbx_ClientData.Name = "Gbx_ClientData";
            this.Gbx_ClientData.Size = new System.Drawing.Size(622, 215);
            this.Gbx_ClientData.TabIndex = 18;
            this.Gbx_ClientData.TabStop = false;
            // 
            // Tbx_BalanceDue
            // 
            this.Tbx_BalanceDue.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_BalanceDue.Location = new System.Drawing.Point(122, 177);
            this.Tbx_BalanceDue.Name = "Tbx_BalanceDue";
            this.Tbx_BalanceDue.Size = new System.Drawing.Size(167, 25);
            this.Tbx_BalanceDue.TabIndex = 40;
            // 
            // Lbl_BalanceDue
            // 
            this.Lbl_BalanceDue.AutoSize = true;
            this.Lbl_BalanceDue.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BalanceDue.Location = new System.Drawing.Point(6, 180);
            this.Lbl_BalanceDue.Name = "Lbl_BalanceDue";
            this.Lbl_BalanceDue.Size = new System.Drawing.Size(68, 18);
            this.Lbl_BalanceDue.TabIndex = 39;
            this.Lbl_BalanceDue.Text = "Solde dû:";
            // 
            // Tbx_CardExp
            // 
            this.Tbx_CardExp.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_CardExp.Location = new System.Drawing.Point(425, 136);
            this.Tbx_CardExp.Name = "Tbx_CardExp";
            this.Tbx_CardExp.Size = new System.Drawing.Size(167, 25);
            this.Tbx_CardExp.TabIndex = 38;
            // 
            // Lbl_CardExp
            // 
            this.Lbl_CardExp.AutoSize = true;
            this.Lbl_CardExp.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardExp.Location = new System.Drawing.Point(309, 139);
            this.Lbl_CardExp.Name = "Lbl_CardExp";
            this.Lbl_CardExp.Size = new System.Drawing.Size(78, 18);
            this.Lbl_CardExp.TabIndex = 37;
            this.Lbl_CardExp.Text = "Expiration:";
            // 
            // Tbx_CardNb
            // 
            this.Tbx_CardNb.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_CardNb.Location = new System.Drawing.Point(425, 95);
            this.Tbx_CardNb.Name = "Tbx_CardNb";
            this.Tbx_CardNb.Size = new System.Drawing.Size(167, 25);
            this.Tbx_CardNb.TabIndex = 36;
            // 
            // Lbl_CardNb
            // 
            this.Lbl_CardNb.AutoSize = true;
            this.Lbl_CardNb.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardNb.Location = new System.Drawing.Point(309, 98);
            this.Lbl_CardNb.Name = "Lbl_CardNb";
            this.Lbl_CardNb.Size = new System.Drawing.Size(74, 18);
            this.Lbl_CardNb.TabIndex = 35;
            this.Lbl_CardNb.Text = "No. Carte:";
            // 
            // Tbx_PhoneNb
            // 
            this.Tbx_PhoneNb.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_PhoneNb.Location = new System.Drawing.Point(122, 95);
            this.Tbx_PhoneNb.Name = "Tbx_PhoneNb";
            this.Tbx_PhoneNb.Size = new System.Drawing.Size(167, 25);
            this.Tbx_PhoneNb.TabIndex = 32;
            // 
            // Lbl_PhoneNb
            // 
            this.Lbl_PhoneNb.AutoSize = true;
            this.Lbl_PhoneNb.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PhoneNb.Location = new System.Drawing.Point(6, 98);
            this.Lbl_PhoneNb.Name = "Lbl_PhoneNb";
            this.Lbl_PhoneNb.Size = new System.Drawing.Size(80, 18);
            this.Lbl_PhoneNb.TabIndex = 27;
            this.Lbl_PhoneNb.Text = "Téléphone:";
            // 
            // Tbx_CardType
            // 
            this.Tbx_CardType.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_CardType.Location = new System.Drawing.Point(122, 136);
            this.Tbx_CardType.Name = "Tbx_CardType";
            this.Tbx_CardType.Size = new System.Drawing.Size(167, 25);
            this.Tbx_CardType.TabIndex = 26;
            // 
            // Lbl_CardType
            // 
            this.Lbl_CardType.AutoSize = true;
            this.Lbl_CardType.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardType.Location = new System.Drawing.Point(6, 139);
            this.Lbl_CardType.Name = "Lbl_CardType";
            this.Lbl_CardType.Size = new System.Drawing.Size(110, 18);
            this.Lbl_CardType.TabIndex = 25;
            this.Lbl_CardType.Text = "Type de Carte: ";
            // 
            // Tbx_Address
            // 
            this.Tbx_Address.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Address.Location = new System.Drawing.Point(122, 54);
            this.Tbx_Address.Name = "Tbx_Address";
            this.Tbx_Address.Size = new System.Drawing.Size(470, 25);
            this.Tbx_Address.TabIndex = 24;
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Address.Location = new System.Drawing.Point(6, 57);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(63, 18);
            this.Lbl_Address.TabIndex = 23;
            this.Lbl_Address.Text = "Adresse:";
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Name.Location = new System.Drawing.Point(302, 13);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(290, 25);
            this.Tbx_Name.TabIndex = 22;
            // 
            // Tbx_idCli
            // 
            this.Tbx_idCli.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_idCli.Location = new System.Drawing.Point(122, 13);
            this.Tbx_idCli.Name = "Tbx_idCli";
            this.Tbx_idCli.Size = new System.Drawing.Size(96, 25);
            this.Tbx_idCli.TabIndex = 21;
            this.Tbx_idCli.DoubleClick += new System.EventHandler(this.tbx_idCli_DoubleClick);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(224, 16);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(44, 18);
            this.Lbl_Name.TabIndex = 20;
            this.Lbl_Name.Text = "Nom:";
            // 
            // Lbl_idCli
            // 
            this.Lbl_idCli.AutoSize = true;
            this.Lbl_idCli.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idCli.Location = new System.Drawing.Point(6, 16);
            this.Lbl_idCli.Name = "Lbl_idCli";
            this.Lbl_idCli.Size = new System.Drawing.Size(74, 18);
            this.Lbl_idCli.TabIndex = 19;
            this.Lbl_idCli.Text = "No. Client:";
            // 
            // Lbl_ClientDataTitle
            // 
            this.Lbl_ClientDataTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ClientDataTitle.AutoSize = true;
            this.Lbl_ClientDataTitle.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientDataTitle.Location = new System.Drawing.Point(15, 16);
            this.Lbl_ClientDataTitle.Name = "Lbl_ClientDataTitle";
            this.Lbl_ClientDataTitle.Size = new System.Drawing.Size(309, 23);
            this.Lbl_ClientDataTitle.TabIndex = 18;
            this.Lbl_ClientDataTitle.Text = "Information sur le client qui réserve";
            this.Lbl_ClientDataTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TA_Reservation
            // 
            this.TA_Reservation.ClearBeforeFill = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // TA_De
            // 
            this.TA_De.ClearBeforeFill = true;
            // 
            // TA_Chambre
            // 
            this.TA_Chambre.ClearBeforeFill = true;
            // 
            // Form_BaseForm_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.Gbx_FormData);
            this.Name = "Form_BaseForm_Reservation";
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.form_BaseFormReservation_Load);
            this.Controls.SetChildIndex(this.buttonChangeDiscard1, 0);
            this.Controls.SetChildIndex(this.buttonChangeRevert1, 0);
            this.Controls.SetChildIndex(this.buttonFileDelete1, 0);
            this.Controls.SetChildIndex(this.buttonFileNew1, 0);
            this.Controls.SetChildIndex(this.buttonFileEdit1, 0);
            this.Controls.SetChildIndex(this.buttonGoBegin1, 0);
            this.Controls.SetChildIndex(this.buttonGoNext1, 0);
            this.Controls.SetChildIndex(this.buttonGoEnd1, 0);
            this.Controls.SetChildIndex(this.buttonGoPrevious1, 0);
            this.Controls.SetChildIndex(this.buttonModeConsultation1, 0);
            this.Controls.SetChildIndex(this.buttonModeEdit1, 0);
            this.Controls.SetChildIndex(this.buttonQuit1, 0);
            this.Controls.SetChildIndex(this.buttonSave1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.labelInfo1, 0);
            this.Controls.SetChildIndex(this.labelInfo2, 0);
            this.Controls.SetChildIndex(this.Gbx_FormData, 0);
            this.Gbx_FormData.ResumeLayout(false);
            this.Gbx_FormData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reservation)).EndInit();
            this.Gbx_BookingData.ResumeLayout(false);
            this.Gbx_BookingData.PerformLayout();
            this.Gbx_ClientData.ResumeLayout(false);
            this.Gbx_ClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Chambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_FormData;
        private Prj_Object.LabelTitle Lbl_BookingData;
        private System.Windows.Forms.GroupBox Gbx_ClientData;
        private Prj_Object.TextBox Tbx_PhoneNb;
        private Prj_Object.LabelInfo Lbl_PhoneNb;
        private Prj_Object.TextBox Tbx_CardType;
        private Prj_Object.LabelInfo Lbl_CardType;
        private Prj_Object.TextBox Tbx_Address;
        private Prj_Object.LabelInfo Lbl_Address;
        private Prj_Object.TextBox Tbx_Name;
        private Prj_Object.TextBox Tbx_idCli;
        private Prj_Object.LabelInfo Lbl_Name;
        private Prj_Object.LabelInfo Lbl_idCli;
        private Prj_Object.LabelTitle Lbl_ClientDataTitle;
        private Prj_Object.TextBox Tbx_BalanceDue;
        private Prj_Object.LabelInfo Lbl_BalanceDue;
        private Prj_Object.TextBox Tbx_CardExp;
        private Prj_Object.LabelInfo Lbl_CardExp;
        private Prj_Object.TextBox Tbx_CardNb;
        private Prj_Object.LabelInfo Lbl_CardNb;
        private System.Windows.Forms.GroupBox Gbx_BookingData;
        private Prj_Object.TextBox Tbx_idBooking;
        private Prj_Object.TextBox Tbx_BookingEndAt;
        private Prj_Object.LabelInfo Lbl_BookingEndAt;
        private Prj_Object.TextBox Tbx_BookingDoneAt;
        private Prj_Object.LabelInfo Lbl_BookingDoneAt;
        private Prj_Object.TextBox Tbx_BookingStartAt;
        private Prj_Object.LabelInfo Lbl_BookingStartAt;
        private Prj_Object.LabelInfo Lbl_idBooking;
        private System.Windows.Forms.BindingSource BS_Reservation;
        private DS_Reservation DS_Reservation;
        private DS_ReservationTableAdapters.reservationTableAdapter TA_Reservation;
        private System.Windows.Forms.DataGridView Dgv_Rooms;
        private Prj_Object.TextBox Tbx_ResPour;
        private Prj_Object.LabelInfo Lbl_BookingFor;
        private DS_ReservationTableAdapters.clientTableAdapter TA_Client;
        private System.Windows.Forms.BindingSource BS_Client;
        private DS_ReservationTableAdapters.deTableAdapter TA_De;
        private DS_ReservationTableAdapters.chambreTableAdapter TA_Chambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource BS_De;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attribueeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BS_Chambre;
    }
}

