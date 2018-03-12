namespace Prj_Reservation_K7
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Reservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_De = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rv_ResPour = new Prj_Object.TextBox();
            this.labelInfo12 = new Prj_Object.LabelInfo();
            this.Rv_NoRes = new Prj_Object.TextBox();
            this.Rv_DatFin = new Prj_Object.TextBox();
            this.labelInfo10 = new Prj_Object.LabelInfo();
            this.Rv_ResLe = new Prj_Object.TextBox();
            this.labelInfo14 = new Prj_Object.LabelInfo();
            this.Rv_DatDeb = new Prj_Object.TextBox();
            this.labelInfo15 = new Prj_Object.LabelInfo();
            this.labelInfo16 = new Prj_Object.LabelInfo();
            this.labelTitle2 = new Prj_Object.LabelTitle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rv_SldDu = new Prj_Object.TextBox();
            this.labelInfo9 = new Prj_Object.LabelInfo();
            this.Rv_Exp = new Prj_Object.TextBox();
            this.labelInfo8 = new Prj_Object.LabelInfo();
            this.Rv_NoCar = new Prj_Object.TextBox();
            this.labelInfo11 = new Prj_Object.LabelInfo();
            this.Rv_Tel = new Prj_Object.TextBox();
            this.labelInfo7 = new Prj_Object.LabelInfo();
            this.Rv_TypCar = new Prj_Object.TextBox();
            this.labelInfo6 = new Prj_Object.LabelInfo();
            this.Rv_Add = new Prj_Object.TextBox();
            this.labelInfo5 = new Prj_Object.LabelInfo();
            this.Rv_NomCli = new Prj_Object.TextBox();
            this.Rv_NoCli = new Prj_Object.TextBox();
            this.labelInfo4 = new Prj_Object.LabelInfo();
            this.labelInfo3 = new Prj_Object.LabelInfo();
            this.labelTitle1 = new Prj_Object.LabelTitle();
            this.BS_Reservation = new System.Windows.Forms.BindingSource(this.components);
            this.TA_De = new Prj_Reservation_K7.DS_ReservationTableAdapters.deTableAdapter();
            this.dS_Reservation1 = new Prj_Reservation_K7.DS_Reservation();
            this.TA_Reservation = new Prj_Reservation_K7.DS_ReservationTableAdapters.reservationTableAdapter();
            this.TA_Client = new Prj_Reservation_K7.DS_ReservationTableAdapters.clientTableAdapter();
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reservation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeDiscard1
            // 
            this.buttonChangeDiscard1.Click += new System.EventHandler(this.ButtonDiscardChange_Click);
            // 
            // buttonChangeRevert1
            // 
            this.buttonChangeRevert1.Click += new System.EventHandler(this.ButtonUndoChange_Click);
            // 
            // buttonFileDelete1
            // 
            this.buttonFileDelete1.Location = new System.Drawing.Point(639, 12);
            this.buttonFileDelete1.Click += new System.EventHandler(this.ButtonDeleteFile_Click);
            // 
            // buttonFileNew1
            // 
            this.buttonFileNew1.Location = new System.Drawing.Point(477, 12);
            this.buttonFileNew1.Click += new System.EventHandler(this.ButtonNewFile_Click);
            // 
            // buttonFileEdit1
            // 
            this.buttonFileEdit1.Location = new System.Drawing.Point(558, 12);
            this.buttonFileEdit1.Click += new System.EventHandler(this.ButtonEditFile_Click);
            // 
            // buttonGoBegin1
            // 
            this.buttonGoBegin1.Location = new System.Drawing.Point(346, 541);
            this.buttonGoBegin1.Click += new System.EventHandler(this.ButtonBegin_Click);
            // 
            // buttonGoNext1
            // 
            this.buttonGoNext1.Location = new System.Drawing.Point(682, 541);
            this.buttonGoNext1.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonGoEnd1
            // 
            this.buttonGoEnd1.Location = new System.Drawing.Point(763, 541);
            this.buttonGoEnd1.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // buttonGoPrevious1
            // 
            this.buttonGoPrevious1.Location = new System.Drawing.Point(427, 541);
            this.buttonGoPrevious1.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // buttonModeConsultation1
            // 
            this.buttonModeConsultation1.Location = new System.Drawing.Point(293, 12);
            this.buttonModeConsultation1.Click += new System.EventHandler(this.ButtonViewMode_Click);
            // 
            // buttonModeEdit1
            // 
            this.buttonModeEdit1.Location = new System.Drawing.Point(374, 12);
            this.buttonModeEdit1.Click += new System.EventHandler(this.ButtonEditMode_Click);
            // 
            // buttonQuit1
            // 
            this.buttonQuit1.Click += new System.EventHandler(this.ButtonLeave_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Click += new System.EventHandler(this.ButtonSave_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DG_Reservation);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.labelTitle2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelTitle1);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 442);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // DG_Reservation
            // 
            this.DG_Reservation.AllowUserToAddRows = false;
            this.DG_Reservation.AllowUserToDeleteRows = false;
            this.DG_Reservation.AutoGenerateColumns = false;
            this.DG_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DG_Reservation.DataSource = this.BS_De;
            this.DG_Reservation.Location = new System.Drawing.Point(34, 286);
            this.DG_Reservation.Name = "DG_Reservation";
            this.DG_Reservation.ReadOnly = true;
            this.DG_Reservation.Size = new System.Drawing.Size(1096, 150);
            this.DG_Reservation.TabIndex = 46;
            this.DG_Reservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Reservation_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "No chambre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.ToolTipText = "Numéro de la chambre réservée";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Prix";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Attribuée";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Rv_ResPour);
            this.groupBox3.Controls.Add(this.labelInfo12);
            this.groupBox3.Controls.Add(this.Rv_NoRes);
            this.groupBox3.Controls.Add(this.Rv_DatFin);
            this.groupBox3.Controls.Add(this.labelInfo10);
            this.groupBox3.Controls.Add(this.Rv_ResLe);
            this.groupBox3.Controls.Add(this.labelInfo14);
            this.groupBox3.Controls.Add(this.Rv_DatDeb);
            this.groupBox3.Controls.Add(this.labelInfo15);
            this.groupBox3.Controls.Add(this.labelInfo16);
            this.groupBox3.Location = new System.Drawing.Point(714, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 215);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // Rv_ResPour
            // 
            this.Rv_ResPour.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_ResPour.Location = new System.Drawing.Point(168, 177);
            this.Rv_ResPour.Name = "Rv_ResPour";
            this.Rv_ResPour.Size = new System.Drawing.Size(167, 25);
            this.Rv_ResPour.TabIndex = 43;
            // 
            // labelInfo12
            // 
            this.labelInfo12.AutoSize = true;
            this.labelInfo12.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo12.Location = new System.Drawing.Point(45, 180);
            this.labelInfo12.Name = "labelInfo12";
            this.labelInfo12.Size = new System.Drawing.Size(97, 18);
            this.labelInfo12.TabIndex = 42;
            this.labelInfo12.Text = "Réservé pour:";
            // 
            // Rv_NoRes
            // 
            this.Rv_NoRes.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_NoRes.Location = new System.Drawing.Point(168, 13);
            this.Rv_NoRes.Name = "Rv_NoRes";
            this.Rv_NoRes.Size = new System.Drawing.Size(167, 25);
            this.Rv_NoRes.TabIndex = 41;
            // 
            // Rv_DatFin
            // 
            this.Rv_DatFin.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_DatFin.Location = new System.Drawing.Point(168, 136);
            this.Rv_DatFin.Name = "Rv_DatFin";
            this.Rv_DatFin.Size = new System.Drawing.Size(167, 25);
            this.Rv_DatFin.TabIndex = 40;
            // 
            // labelInfo10
            // 
            this.labelInfo10.AutoSize = true;
            this.labelInfo10.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo10.Location = new System.Drawing.Point(45, 139);
            this.labelInfo10.Name = "labelInfo10";
            this.labelInfo10.Size = new System.Drawing.Size(86, 18);
            this.labelInfo10.TabIndex = 39;
            this.labelInfo10.Text = "Date de fin:";
            // 
            // Rv_ResLe
            // 
            this.Rv_ResLe.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_ResLe.Location = new System.Drawing.Point(168, 54);
            this.Rv_ResLe.Name = "Rv_ResLe";
            this.Rv_ResLe.Size = new System.Drawing.Size(167, 25);
            this.Rv_ResLe.TabIndex = 32;
            // 
            // labelInfo14
            // 
            this.labelInfo14.AutoSize = true;
            this.labelInfo14.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo14.Location = new System.Drawing.Point(45, 57);
            this.labelInfo14.Name = "labelInfo14";
            this.labelInfo14.Size = new System.Drawing.Size(78, 18);
            this.labelInfo14.TabIndex = 27;
            this.labelInfo14.Text = "Réservé le:";
            // 
            // Rv_DatDeb
            // 
            this.Rv_DatDeb.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_DatDeb.Location = new System.Drawing.Point(168, 95);
            this.Rv_DatDeb.Name = "Rv_DatDeb";
            this.Rv_DatDeb.Size = new System.Drawing.Size(167, 25);
            this.Rv_DatDeb.TabIndex = 26;
            // 
            // labelInfo15
            // 
            this.labelInfo15.AutoSize = true;
            this.labelInfo15.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo15.Location = new System.Drawing.Point(45, 98);
            this.labelInfo15.Name = "labelInfo15";
            this.labelInfo15.Size = new System.Drawing.Size(109, 18);
            this.labelInfo15.TabIndex = 25;
            this.labelInfo15.Text = "Date de début:";
            // 
            // labelInfo16
            // 
            this.labelInfo16.AutoSize = true;
            this.labelInfo16.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo16.Location = new System.Drawing.Point(45, 16);
            this.labelInfo16.Name = "labelInfo16";
            this.labelInfo16.Size = new System.Drawing.Size(114, 18);
            this.labelInfo16.TabIndex = 23;
            this.labelInfo16.Text = "No. Réservation:";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.Location = new System.Drawing.Point(723, 16);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(264, 23);
            this.labelTitle2.TabIndex = 1;
            this.labelTitle2.Text = "Information sur la réservation";
            this.labelTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Rv_SldDu);
            this.groupBox2.Controls.Add(this.labelInfo9);
            this.groupBox2.Controls.Add(this.Rv_Exp);
            this.groupBox2.Controls.Add(this.labelInfo8);
            this.groupBox2.Controls.Add(this.Rv_NoCar);
            this.groupBox2.Controls.Add(this.labelInfo11);
            this.groupBox2.Controls.Add(this.Rv_Tel);
            this.groupBox2.Controls.Add(this.labelInfo7);
            this.groupBox2.Controls.Add(this.Rv_TypCar);
            this.groupBox2.Controls.Add(this.labelInfo6);
            this.groupBox2.Controls.Add(this.Rv_Add);
            this.groupBox2.Controls.Add(this.labelInfo5);
            this.groupBox2.Controls.Add(this.Rv_NomCli);
            this.groupBox2.Controls.Add(this.Rv_NoCli);
            this.groupBox2.Controls.Add(this.labelInfo4);
            this.groupBox2.Controls.Add(this.labelInfo3);
            this.groupBox2.Location = new System.Drawing.Point(34, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 215);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // Rv_SldDu
            // 
            this.Rv_SldDu.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_SldDu.Location = new System.Drawing.Point(122, 177);
            this.Rv_SldDu.Name = "Rv_SldDu";
            this.Rv_SldDu.Size = new System.Drawing.Size(167, 25);
            this.Rv_SldDu.TabIndex = 40;
            // 
            // labelInfo9
            // 
            this.labelInfo9.AutoSize = true;
            this.labelInfo9.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo9.Location = new System.Drawing.Point(6, 180);
            this.labelInfo9.Name = "labelInfo9";
            this.labelInfo9.Size = new System.Drawing.Size(68, 18);
            this.labelInfo9.TabIndex = 39;
            this.labelInfo9.Text = "Solde dû:";
            // 
            // Rv_Exp
            // 
            this.Rv_Exp.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_Exp.Location = new System.Drawing.Point(425, 136);
            this.Rv_Exp.Name = "Rv_Exp";
            this.Rv_Exp.Size = new System.Drawing.Size(167, 25);
            this.Rv_Exp.TabIndex = 38;
            // 
            // labelInfo8
            // 
            this.labelInfo8.AutoSize = true;
            this.labelInfo8.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo8.Location = new System.Drawing.Point(309, 139);
            this.labelInfo8.Name = "labelInfo8";
            this.labelInfo8.Size = new System.Drawing.Size(78, 18);
            this.labelInfo8.TabIndex = 37;
            this.labelInfo8.Text = "Expiration:";
            // 
            // Rv_NoCar
            // 
            this.Rv_NoCar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_NoCar.Location = new System.Drawing.Point(425, 95);
            this.Rv_NoCar.Name = "Rv_NoCar";
            this.Rv_NoCar.Size = new System.Drawing.Size(167, 25);
            this.Rv_NoCar.TabIndex = 36;
            // 
            // labelInfo11
            // 
            this.labelInfo11.AutoSize = true;
            this.labelInfo11.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo11.Location = new System.Drawing.Point(309, 98);
            this.labelInfo11.Name = "labelInfo11";
            this.labelInfo11.Size = new System.Drawing.Size(74, 18);
            this.labelInfo11.TabIndex = 35;
            this.labelInfo11.Text = "No. Carte:";
            // 
            // Rv_Tel
            // 
            this.Rv_Tel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_Tel.Location = new System.Drawing.Point(122, 95);
            this.Rv_Tel.Name = "Rv_Tel";
            this.Rv_Tel.Size = new System.Drawing.Size(167, 25);
            this.Rv_Tel.TabIndex = 32;
            // 
            // labelInfo7
            // 
            this.labelInfo7.AutoSize = true;
            this.labelInfo7.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo7.Location = new System.Drawing.Point(6, 98);
            this.labelInfo7.Name = "labelInfo7";
            this.labelInfo7.Size = new System.Drawing.Size(80, 18);
            this.labelInfo7.TabIndex = 27;
            this.labelInfo7.Text = "Téléphone:";
            // 
            // Rv_TypCar
            // 
            this.Rv_TypCar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_TypCar.Location = new System.Drawing.Point(122, 136);
            this.Rv_TypCar.Name = "Rv_TypCar";
            this.Rv_TypCar.Size = new System.Drawing.Size(167, 25);
            this.Rv_TypCar.TabIndex = 26;
            // 
            // labelInfo6
            // 
            this.labelInfo6.AutoSize = true;
            this.labelInfo6.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo6.Location = new System.Drawing.Point(6, 139);
            this.labelInfo6.Name = "labelInfo6";
            this.labelInfo6.Size = new System.Drawing.Size(110, 18);
            this.labelInfo6.TabIndex = 25;
            this.labelInfo6.Text = "Type de Carte: ";
            // 
            // Rv_Add
            // 
            this.Rv_Add.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_Add.Location = new System.Drawing.Point(122, 54);
            this.Rv_Add.Name = "Rv_Add";
            this.Rv_Add.Size = new System.Drawing.Size(470, 25);
            this.Rv_Add.TabIndex = 24;
            // 
            // labelInfo5
            // 
            this.labelInfo5.AutoSize = true;
            this.labelInfo5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo5.Location = new System.Drawing.Point(6, 57);
            this.labelInfo5.Name = "labelInfo5";
            this.labelInfo5.Size = new System.Drawing.Size(63, 18);
            this.labelInfo5.TabIndex = 23;
            this.labelInfo5.Text = "Adresse:";
            // 
            // Rv_NomCli
            // 
            this.Rv_NomCli.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_NomCli.Location = new System.Drawing.Point(302, 13);
            this.Rv_NomCli.Name = "Rv_NomCli";
            this.Rv_NomCli.Size = new System.Drawing.Size(290, 25);
            this.Rv_NomCli.TabIndex = 22;
            // 
            // Rv_NoCli
            // 
            this.Rv_NoCli.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rv_NoCli.Location = new System.Drawing.Point(122, 13);
            this.Rv_NoCli.Name = "Rv_NoCli";
            this.Rv_NoCli.Size = new System.Drawing.Size(96, 25);
            this.Rv_NoCli.TabIndex = 21;
            // 
            // labelInfo4
            // 
            this.labelInfo4.AutoSize = true;
            this.labelInfo4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo4.Location = new System.Drawing.Point(224, 16);
            this.labelInfo4.Name = "labelInfo4";
            this.labelInfo4.Size = new System.Drawing.Size(44, 18);
            this.labelInfo4.TabIndex = 20;
            this.labelInfo4.Text = "Nom:";
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo3.Location = new System.Drawing.Point(6, 16);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(74, 18);
            this.labelInfo3.TabIndex = 19;
            this.labelInfo3.Text = "No. Client:";
            // 
            // labelTitle1
            // 
            this.labelTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(15, 16);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(309, 23);
            this.labelTitle1.TabIndex = 18;
            this.labelTitle1.Text = "Information sur le client qui réserve";
            this.labelTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TA_De
            // 
            this.TA_De.ClearBeforeFill = true;
            // 
            // dS_Reservation1
            // 
            this.dS_Reservation1.DataSetName = "DS_Reservation";
            this.dS_Reservation1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_Reservation
            // 
            this.TA_Reservation.ClearBeforeFill = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_De)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reservation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Prj_Object.LabelTitle labelTitle2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Prj_Object.TextBox Rv_Tel;
        private Prj_Object.LabelInfo labelInfo7;
        private Prj_Object.TextBox Rv_TypCar;
        private Prj_Object.LabelInfo labelInfo6;
        private Prj_Object.TextBox Rv_Add;
        private Prj_Object.LabelInfo labelInfo5;
        private Prj_Object.TextBox Rv_NomCli;
        private Prj_Object.TextBox Rv_NoCli;
        private Prj_Object.LabelInfo labelInfo4;
        private Prj_Object.LabelInfo labelInfo3;
        private Prj_Object.LabelTitle labelTitle1;
        private Prj_Object.TextBox Rv_SldDu;
        private Prj_Object.LabelInfo labelInfo9;
        private Prj_Object.TextBox Rv_Exp;
        private Prj_Object.LabelInfo labelInfo8;
        private Prj_Object.TextBox Rv_NoCar;
        private Prj_Object.LabelInfo labelInfo11;
        private System.Windows.Forms.GroupBox groupBox3;
        private Prj_Object.TextBox Rv_NoRes;
        private Prj_Object.TextBox Rv_DatFin;
        private Prj_Object.LabelInfo labelInfo10;
        private Prj_Object.TextBox Rv_ResLe;
        private Prj_Object.LabelInfo labelInfo14;
        private Prj_Object.TextBox Rv_DatDeb;
        private Prj_Object.LabelInfo labelInfo15;
        private Prj_Object.LabelInfo labelInfo16;
        private System.Windows.Forms.BindingSource BS_De;
        private System.Windows.Forms.BindingSource BS_Reservation;
        private DS_ReservationTableAdapters.deTableAdapter TA_De;
        private DS_Reservation dS_Reservation1;
        private DS_ReservationTableAdapters.reservationTableAdapter TA_Reservation;
        private System.Windows.Forms.DataGridView DG_Reservation;
        private Prj_Object.TextBox Rv_ResPour;
        private Prj_Object.LabelInfo labelInfo12;
        private DS_ReservationTableAdapters.clientTableAdapter TA_Client;
        private System.Windows.Forms.BindingSource BS_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

