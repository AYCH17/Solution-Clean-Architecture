namespace SolutionCleanCabloPlus.UI
{
    partial class ConsulterInstallation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterInstallation));
            this.label20 = new System.Windows.Forms.Label();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdresse = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDateProgrammation = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grdInstallation = new System.Windows.Forms.DataGridView();
            this.numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProgrammation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmerInstallation = new System.Windows.Forms.Button();
            this.txtDateRealisation = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstallation)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(320, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(267, 20);
            this.label20.TabIndex = 67;
            this.label20.Text = "Installations en attente par date";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(762, 163);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(161, 44);
            this.btnSelectionner.TabIndex = 66;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.Selectionner_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDateRealisation);
            this.groupBox2.Controls.Add(this.txtAdresse);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDateProgrammation);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(161, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(762, 187);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // txtAdresse
            // 
            this.txtAdresse.AutoSize = true;
            this.txtAdresse.Location = new System.Drawing.Point(469, 66);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(0, 15);
            this.txtAdresse.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(373, 66);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Adresse :";
            // 
            // txtTelephone
            // 
            this.txtTelephone.AutoSize = true;
            this.txtTelephone.Location = new System.Drawing.Point(469, 35);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(0, 15);
            this.txtTelephone.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(356, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 65;
            this.label17.Text = "Téléphone :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 180);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 15);
            this.label16.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 140);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 15);
            this.label15.TabIndex = 64;
            // 
            // txtDateProgrammation
            // 
            this.txtDateProgrammation.AutoSize = true;
            this.txtDateProgrammation.Location = new System.Drawing.Point(248, 107);
            this.txtDateProgrammation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDateProgrammation.Name = "txtDateProgrammation";
            this.txtDateProgrammation.Size = new System.Drawing.Size(0, 15);
            this.txtDateProgrammation.TabIndex = 63;
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(248, 66);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(0, 15);
            this.txtNom.TabIndex = 61;
            // 
            // txtNumero
            // 
            this.txtNumero.AutoSize = true;
            this.txtNumero.Location = new System.Drawing.Point(248, 31);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(0, 15);
            this.txtNumero.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(75, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Date de réalisation :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(66, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date programmation :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(102, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nom du client :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(72, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Numéro du compte :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(-2, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 585);
            this.panel3.TabIndex = 69;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 84);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // grdInstallation
            // 
            this.grdInstallation.AllowUserToDeleteRows = false;
            this.grdInstallation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInstallation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numéro,
            this.dateProgrammation,
            this.adresse});
            this.grdInstallation.Location = new System.Drawing.Point(161, 98);
            this.grdInstallation.Name = "grdInstallation";
            this.grdInstallation.ReadOnly = true;
            this.grdInstallation.RowTemplate.Height = 25;
            this.grdInstallation.Size = new System.Drawing.Size(583, 165);
            this.grdInstallation.TabIndex = 70;
            this.grdInstallation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numéro
            // 
            this.numéro.HeaderText = "Numéro";
            this.numéro.Name = "numéro";
            this.numéro.ReadOnly = true;
            // 
            // dateProgrammation
            // 
            this.dateProgrammation.FillWeight = 300F;
            this.dateProgrammation.HeaderText = "Date de programmation";
            this.dateProgrammation.Name = "dateProgrammation";
            this.dateProgrammation.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.FillWeight = 400F;
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // dateNow
            // 
            this.dateNow.Location = new System.Drawing.Point(234, 66);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(200, 23);
            this.dateNow.TabIndex = 71;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(534, 66);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 23);
            this.dateFin.TabIndex = 72;
            this.dateFin.ValueChanged += new System.EventHandler(this.dateFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "de :";
            // 
            // btnConfirmerInstallation
            // 
            this.btnConfirmerInstallation.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConfirmerInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmerInstallation.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmerInstallation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmerInstallation.Location = new System.Drawing.Point(762, 219);
            this.btnConfirmerInstallation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmerInstallation.Name = "btnConfirmerInstallation";
            this.btnConfirmerInstallation.Size = new System.Drawing.Size(161, 44);
            this.btnConfirmerInstallation.TabIndex = 75;
            this.btnConfirmerInstallation.Text = "Confirmer l\'installation";
            this.btnConfirmerInstallation.UseVisualStyleBackColor = false;
            this.btnConfirmerInstallation.Click += new System.EventHandler(this.btnConfirmerInstallation_Click);
            // 
            // txtDateRealisation
            // 
            this.txtDateRealisation.AutoSize = true;
            this.txtDateRealisation.Location = new System.Drawing.Point(209, 140);
            this.txtDateRealisation.Name = "txtDateRealisation";
            this.txtDateRealisation.Size = new System.Drawing.Size(0, 15);
            this.txtDateRealisation.TabIndex = 67;
            // 
            // ConsulterInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1124, 587);
            this.Controls.Add(this.btnConfirmerInstallation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.grdInstallation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsulterInstallation";
            this.Text = "ConsulterInstallation";
            this.Load += new System.EventHandler(this.ConsulterInstallation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstallation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtAdresse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtTelephone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtDateProgrammation;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView grdInstallation;
        private System.Windows.Forms.DataGridViewTextBoxColumn numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProgrammation;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DateTimePicker dateNow;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmerInstallation;
        private System.Windows.Forms.Label txtDateRealisation;
    }
}