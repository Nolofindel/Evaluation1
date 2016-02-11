namespace ChasseurDeTetes.Vues
{
    partial class FormInit
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
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCandidat = new System.Windows.Forms.ComboBox();
            this.candidatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(94, 210);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(70, 22);
            this.buttonQuitter.TabIndex = 11;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Veuillez sélectionner un candidat";
            // 
            // comboBoxCandidat
            // 
            this.comboBoxCandidat.DataSource = this.candidatBindingSource;
            this.comboBoxCandidat.DisplayMember = "Nom";
            this.comboBoxCandidat.FormattingEnabled = true;
            this.comboBoxCandidat.Location = new System.Drawing.Point(74, 124);
            this.comboBoxCandidat.Name = "comboBoxCandidat";
            this.comboBoxCandidat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCandidat.TabIndex = 13;
            // 
            // candidatBindingSource
            // 
            this.candidatBindingSource.DataSource = typeof(ChasseurDeTetes.Metier.Candidat);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bienvenue!";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(94, 167);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(73, 21);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 262);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCandidat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Init";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInit_FormClosing);
            this.Load += new System.EventHandler(this.FormInit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCandidat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.BindingSource candidatBindingSource;
    }
}