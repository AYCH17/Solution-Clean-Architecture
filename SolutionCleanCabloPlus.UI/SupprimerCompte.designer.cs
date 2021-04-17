namespace SolutionCleanCabloPlus.UI
{
    partial class SupprimerCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerCompte));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.errMontantDu = new System.Windows.Forms.Label();
            this.pmtConfirmation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNon = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtMontantDu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuméroCompte = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox7.SuspendLayout();
            this.pmtConfirmation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.errMontantDu);
            this.groupBox7.Controls.Add(this.pmtConfirmation);
            this.groupBox7.Controls.Add(this.btnSupprimer);
            this.groupBox7.Controls.Add(this.txtMontantDu);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtNuméroCompte);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox7.Location = new System.Drawing.Point(132, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(724, 447);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            // 
            // errMontantDu
            // 
            this.errMontantDu.AutoSize = true;
            this.errMontantDu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errMontantDu.ForeColor = System.Drawing.Color.DarkRed;
            this.errMontantDu.Location = new System.Drawing.Point(147, 210);
            this.errMontantDu.Name = "errMontantDu";
            this.errMontantDu.Size = new System.Drawing.Size(429, 21);
            this.errMontantDu.TabIndex = 12;
            this.errMontantDu.Text = "Compte ne peut pas être supprimé ! Il faut règler les factures";
            this.errMontantDu.Visible = false;
            // 
            // pmtConfirmation
            // 
            this.pmtConfirmation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pmtConfirmation.Controls.Add(this.label2);
            this.pmtConfirmation.Controls.Add(this.btnNon);
            this.pmtConfirmation.Controls.Add(this.btnOui);
            this.pmtConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pmtConfirmation.Location = new System.Drawing.Point(43, 248);
            this.pmtConfirmation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pmtConfirmation.Name = "pmtConfirmation";
            this.pmtConfirmation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pmtConfirmation.Size = new System.Drawing.Size(648, 132);
            this.pmtConfirmation.TabIndex = 11;
            this.pmtConfirmation.TabStop = false;
            this.pmtConfirmation.Visible = false;
            this.pmtConfirmation.Enter += new System.EventHandler(this.pmtConfirmation_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vous etes sur le point de supprimer le compte. Voulez-vous continuer?";
            // 
            // btnNon
            // 
            this.btnNon.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNon.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNon.ForeColor = System.Drawing.Color.White;
            this.btnNon.Location = new System.Drawing.Point(343, 83);
            this.btnNon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(190, 42);
            this.btnNon.TabIndex = 3;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // btnOui
            // 
            this.btnOui.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOui.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOui.ForeColor = System.Drawing.Color.White;
            this.btnOui.Location = new System.Drawing.Point(164, 83);
            this.btnOui.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(148, 42);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "oui";
            this.btnOui.UseVisualStyleBackColor = false;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSupprimer.Location = new System.Drawing.Point(415, 111);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(229, 42);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtMontantDu
            // 
            this.txtMontantDu.AutoSize = true;
            this.txtMontantDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontantDu.Location = new System.Drawing.Point(234, 160);
            this.txtMontantDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMontantDu.Name = "txtMontantDu";
            this.txtMontantDu.Size = new System.Drawing.Size(18, 20);
            this.txtMontantDu.TabIndex = 10;
            this.txtMontantDu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero du compte :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant dû :";
            // 
            // txtNuméroCompte
            // 
            this.txtNuméroCompte.Location = new System.Drawing.Point(226, 107);
            this.txtNuméroCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuméroCompte.Name = "txtNuméroCompte";
            this.txtNuméroCompte.Size = new System.Drawing.Size(52, 23);
            this.txtNuméroCompte.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 457);
            this.panel1.TabIndex = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 84);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // SupprimerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SupprimerCompte";
            this.Text = "SupprimerCompte";
            this.Load += new System.EventHandler(this.supprimerCompte_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pmtConfirmation.ResumeLayout(false);
            this.pmtConfirmation.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox pmtConfirmation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label txtMontantDu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuméroCompte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label errMontantDu;
    }
}