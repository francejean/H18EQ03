namespace Prj_Reservation_K7
{
    partial class Form_LS_Client
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
            this.Dgv_ClientList = new System.Windows.Forms.DataGridView();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Client = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reservation = new Prj_Reservation_K7.DS_Reservation();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.TA_Client = new Prj_Reservation_K7.DS_ReservationTableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ClientList
            // 
            this.Dgv_ClientList.AllowUserToAddRows = false;
            this.Dgv_ClientList.AllowUserToDeleteRows = false;
            this.Dgv_ClientList.AutoGenerateColumns = false;
            this.Dgv_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.Dgv_ClientList.DataSource = this.BS_Client;
            this.Dgv_ClientList.Location = new System.Drawing.Point(12, 12);
            this.Dgv_ClientList.Name = "Dgv_ClientList";
            this.Dgv_ClientList.ReadOnly = true;
            this.Dgv_ClientList.Size = new System.Drawing.Size(446, 237);
            this.Dgv_ClientList.TabIndex = 0;
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "idCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "idCli";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            this.idCliDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCliDataGridViewTextBoxColumn.Width = 30;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_Client
            // 
            this.BS_Client.DataMember = "client";
            this.BS_Client.DataSource = this.dS_Reservation;
            // 
            // dS_Reservation
            // 
            this.dS_Reservation.DataSetName = "DS_Reservation";
            this.dS_Reservation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Location = new System.Drawing.Point(13, 256);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(383, 256);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // TA_Client
            // 
            this.TA_Client.ClearBeforeFill = true;
            // 
            // Form_LS_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 287);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Dgv_ClientList);
            this.MaximizeBox = false;
            this.Name = "Form_LS_Client";
            this.Text = "Liste de sélection du client";
            this.Load += new System.EventHandler(this.Form_LS_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_ClientList;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private DS_Reservation dS_Reservation;
        private System.Windows.Forms.BindingSource BS_Client;
        private DS_ReservationTableAdapters.clientTableAdapter TA_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
    }
}