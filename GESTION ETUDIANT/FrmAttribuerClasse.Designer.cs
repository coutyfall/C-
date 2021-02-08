namespace GESTION_ETUDIANT
{
    partial class FrmAttribuerClasse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddClasse = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAttribuer = new System.Windows.Forms.Button();
            this.cboClasse = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboModulesEnseignes = new System.Windows.Forms.ListBox();
            this.btnAddModules = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModules = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboClassesEnseignees = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClasse);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAttribuer);
            this.groupBox1.Controls.Add(this.cboClasse);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.txtNomPrenom);
            this.groupBox1.Controls.Add(this.txtMatricule);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donnees Professeur";
            // 
            // btnAddClasse
            // 
            this.btnAddClasse.Location = new System.Drawing.Point(663, 55);
            this.btnAddClasse.Name = "btnAddClasse";
            this.btnAddClasse.Size = new System.Drawing.Size(75, 23);
            this.btnAddClasse.TabIndex = 10;
            this.btnAddClasse.Text = "Add";
            this.btnAddClasse.UseVisualStyleBackColor = true;
            this.btnAddClasse.Click += new System.EventHandler(this.btnAddClasse_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(771, 66);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAttribuer
            // 
            this.btnAttribuer.Location = new System.Drawing.Point(771, 24);
            this.btnAttribuer.Name = "btnAttribuer";
            this.btnAttribuer.Size = new System.Drawing.Size(75, 23);
            this.btnAttribuer.TabIndex = 12;
            this.btnAttribuer.Text = "Attribuer";
            this.btnAttribuer.UseVisualStyleBackColor = true;
            // 
            // cboClasse
            // 
            this.cboClasse.FormattingEnabled = true;
            this.cboClasse.Location = new System.Drawing.Point(536, 57);
            this.cboClasse.Name = "cboClasse";
            this.cboClasse.Size = new System.Drawing.Size(121, 21);
            this.cboClasse.TabIndex = 9;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(536, 24);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 21);
            this.cboGrade.TabIndex = 7;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(107, 69);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtNomPrenom.TabIndex = 6;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(107, 36);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 20);
            this.txtMatricule.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboModulesEnseignes);
            this.groupBox2.Controls.Add(this.btnAddModules);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboModules);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(44, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // lboModulesEnseignes
            // 
            this.lboModulesEnseignes.FormattingEnabled = true;
            this.lboModulesEnseignes.Location = new System.Drawing.Point(20, 122);
            this.lboModulesEnseignes.Name = "lboModulesEnseignes";
            this.lboModulesEnseignes.Size = new System.Drawing.Size(262, 186);
            this.lboModulesEnseignes.TabIndex = 10;
            // 
            // btnAddModules
            // 
            this.btnAddModules.Location = new System.Drawing.Point(122, 86);
            this.btnAddModules.Name = "btnAddModules";
            this.btnAddModules.Size = new System.Drawing.Size(75, 23);
            this.btnAddModules.TabIndex = 9;
            this.btnAddModules.Text = "Add";
            this.btnAddModules.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modules";
            // 
            // cboModules
            // 
            this.cboModules.FormattingEnabled = true;
            this.cboModules.Location = new System.Drawing.Point(77, 42);
            this.cboModules.Name = "cboModules";
            this.cboModules.Size = new System.Drawing.Size(121, 21);
            this.cboModules.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modules Enseignes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboClassesEnseignees);
            this.groupBox3.Location = new System.Drawing.Point(421, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 313);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classe enseignees";
            // 
            // lboClassesEnseignees
            // 
            this.lboClassesEnseignees.FormattingEnabled = true;
            this.lboClassesEnseignees.Location = new System.Drawing.Point(19, 62);
            this.lboClassesEnseignees.Name = "lboClassesEnseignees";
            this.lboClassesEnseignees.Size = new System.Drawing.Size(314, 251);
            this.lboClassesEnseignees.TabIndex = 11;
            // 
            // FrmAttribuerClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAttribuerClasse";
            this.Text = "GESTION ETUDIANT";
            this.Load += new System.EventHandler(this.FrmAttribuerClasse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClasse;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboModules;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddClasse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAttribuer;
        private System.Windows.Forms.ListBox lboModulesEnseignes;
        private System.Windows.Forms.Button btnAddModules;
        private System.Windows.Forms.ListBox lboClassesEnseignees;
    }
}