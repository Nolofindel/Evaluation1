namespace ChasseurDeTetes.Vues
{
    partial class FormExperiences
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.panelChamps = new System.Windows.Forms.Panel();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.entrepriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.comboBoxQualif = new System.Windows.Forms.ComboBox();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBoxDateF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDateD = new System.Windows.Forms.MaskedTextBox();
            this.labelEntreprise = new System.Windows.Forms.Label();
            this.labelQualification = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dataGridViewExperiences = new System.Windows.Forms.DataGridView();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laQualifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Détails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.experienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBoxDetail.SuspendLayout();
            this.panelChamps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(53, 294);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(73, 21);
            this.buttonValider.TabIndex = 14;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.panelChamps);
            this.groupBoxDetail.Controls.Add(this.labelEntreprise);
            this.groupBoxDetail.Controls.Add(this.labelQualification);
            this.groupBoxDetail.Controls.Add(this.labelDateFin);
            this.groupBoxDetail.Controls.Add(this.labelDateDebut);
            this.groupBoxDetail.Location = new System.Drawing.Point(179, 275);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(541, 148);
            this.groupBoxDetail.TabIndex = 13;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Expérience";
            // 
            // panelChamps
            // 
            this.panelChamps.Controls.Add(this.comboBoxEntreprise);
            this.panelChamps.Controls.Add(this.textBoxCommentaire);
            this.panelChamps.Controls.Add(this.labelCommentaire);
            this.panelChamps.Controls.Add(this.comboBoxQualif);
            this.panelChamps.Controls.Add(this.maskedTextBoxDateF);
            this.panelChamps.Controls.Add(this.maskedTextBoxDateD);
            this.panelChamps.Location = new System.Drawing.Point(92, 19);
            this.panelChamps.Name = "panelChamps";
            this.panelChamps.Size = new System.Drawing.Size(443, 123);
            this.panelChamps.TabIndex = 10;
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.DataSource = this.entrepriseBindingSource;
            this.comboBoxEntreprise.DisplayMember = "RaisonSociale";
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(4, 87);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(134, 21);
            this.comboBoxEntreprise.TabIndex = 8;
            this.comboBoxEntreprise.ValueMember = "IdEntreprise";
            // 
            // entrepriseBindingSource
            // 
            this.entrepriseBindingSource.DataSource = typeof(ChasseurDeTetes.Metier.Entreprise);
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Location = new System.Drawing.Point(177, 26);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(252, 79);
            this.textBoxCommentaire.TabIndex = 3;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(174, 6);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(68, 13);
            this.labelCommentaire.TabIndex = 7;
            this.labelCommentaire.Text = "Commentaire";
            // 
            // comboBoxQualif
            // 
            this.comboBoxQualif.DataSource = this.qualificationBindingSource;
            this.comboBoxQualif.DisplayMember = "LibelleQualification";
            this.comboBoxQualif.FormattingEnabled = true;
            this.comboBoxQualif.Location = new System.Drawing.Point(4, 55);
            this.comboBoxQualif.Name = "comboBoxQualif";
            this.comboBoxQualif.Size = new System.Drawing.Size(134, 21);
            this.comboBoxQualif.TabIndex = 2;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(ChasseurDeTetes.Metier.Qualification);
            // 
            // maskedTextBoxDateF
            // 
            this.maskedTextBoxDateF.Location = new System.Drawing.Point(3, 29);
            this.maskedTextBoxDateF.Mask = "00/00/0000";
            this.maskedTextBoxDateF.Name = "maskedTextBoxDateF";
            this.maskedTextBoxDateF.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxDateF.TabIndex = 1;
            this.maskedTextBoxDateF.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDateF.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxDateF_TypeValidationCompleted);
            // 
            // maskedTextBoxDateD
            // 
            this.maskedTextBoxDateD.Location = new System.Drawing.Point(3, 3);
            this.maskedTextBoxDateD.Mask = "00/00/0000";
            this.maskedTextBoxDateD.Name = "maskedTextBoxDateD";
            this.maskedTextBoxDateD.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxDateD.TabIndex = 0;
            this.maskedTextBoxDateD.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDateD.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxDateD_TypeValidationCompleted);
            // 
            // labelEntreprise
            // 
            this.labelEntreprise.AutoSize = true;
            this.labelEntreprise.Location = new System.Drawing.Point(6, 111);
            this.labelEntreprise.Name = "labelEntreprise";
            this.labelEntreprise.Size = new System.Drawing.Size(54, 13);
            this.labelEntreprise.TabIndex = 9;
            this.labelEntreprise.Text = "Entreprise";
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Location = new System.Drawing.Point(6, 79);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(65, 13);
            this.labelQualification.TabIndex = 6;
            this.labelQualification.Text = "Qualification";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(6, 52);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(59, 13);
            this.labelDateFin.TabIndex = 5;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(6, 26);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(75, 13);
            this.labelDateDebut.TabIndex = 4;
            this.labelDateDebut.Text = "Date de début";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(12, 13);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(73, 21);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridViewExperiences
            // 
            this.dataGridViewExperiences.AllowUserToAddRows = false;
            this.dataGridViewExperiences.AllowUserToDeleteRows = false;
            this.dataGridViewExperiences.AllowUserToResizeColumns = false;
            this.dataGridViewExperiences.AllowUserToResizeRows = false;
            this.dataGridViewExperiences.AutoGenerateColumns = false;
            this.dataGridViewExperiences.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewExperiences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperiences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.laQualifDataGridViewTextBoxColumn,
            this.Détails,
            this.Modifier,
            this.Supprimer});
            this.dataGridViewExperiences.DataSource = this.experienceBindingSource;
            this.dataGridViewExperiences.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewExperiences.MultiSelect = false;
            this.dataGridViewExperiences.Name = "dataGridViewExperiences";
            this.dataGridViewExperiences.ReadOnly = true;
            this.dataGridViewExperiences.Size = new System.Drawing.Size(708, 199);
            this.dataGridViewExperiences.TabIndex = 11;
            this.dataGridViewExperiences.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExperiences_CellClick);
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            this.dateDebutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDebutDataGridViewTextBoxColumn.Width = 111;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateFinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateFinDataGridViewTextBoxColumn.Width = 111;
            // 
            // laQualifDataGridViewTextBoxColumn
            // 
            this.laQualifDataGridViewTextBoxColumn.DataPropertyName = "LaQualif";
            this.laQualifDataGridViewTextBoxColumn.DataSource = this.qualificationBindingSource;
            this.laQualifDataGridViewTextBoxColumn.DisplayMember = "LibelleQualification";
            this.laQualifDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.laQualifDataGridViewTextBoxColumn.Name = "laQualifDataGridViewTextBoxColumn";
            this.laQualifDataGridViewTextBoxColumn.ReadOnly = true;
            this.laQualifDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.laQualifDataGridViewTextBoxColumn.ValueMember = "Self";
            this.laQualifDataGridViewTextBoxColumn.Width = 111;
            // 
            // Détails
            // 
            this.Détails.HeaderText = "";
            this.Détails.Name = "Détails";
            this.Détails.ReadOnly = true;
            this.Détails.Text = "Détails";
            this.Détails.ToolTipText = "Détails";
            this.Détails.UseColumnTextForButtonValue = true;
            this.Détails.Width = 110;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.ToolTipText = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 111;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.ToolTipText = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 111;
            // 
            // experienceBindingSource
            // 
            this.experienceBindingSource.DataSource = typeof(ChasseurDeTetes.Metier.Experience);
            this.experienceBindingSource.Sort = "";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(644, 13);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(70, 22);
            this.buttonQuitter.TabIndex = 10;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(53, 354);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(70, 22);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // FormExperiences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 484);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewExperiences);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormExperiences";
            this.Text = "Expériences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExperiences_FormClosing);
            this.Load += new System.EventHandler(this.FormExperiences_Load);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.panelChamps.ResumeLayout(false);
            this.panelChamps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperiences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Label labelEntreprise;
        private System.Windows.Forms.ComboBox comboBoxEntreprise;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelQualification;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.ComboBox comboBoxQualif;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateD;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridView dataGridViewExperiences;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.BindingSource experienceBindingSource;
        private System.Windows.Forms.BindingSource entrepriseBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        /// <summary>
        /// Contients tout les champs de l'expérience
        /// </summary>
        private System.Windows.Forms.Panel panelChamps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn laQualifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Détails;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}

