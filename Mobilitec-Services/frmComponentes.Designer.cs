
namespace Mobilitec_Services
{
    partial class frmComponentes
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
            this.cbblivro = new System.Windows.Forms.CheckBox();
            this.cbCidades = new System.Windows.Forms.ComboBox();
            this.cbbAcademia = new System.Windows.Forms.CheckBox();
            this.lbPreferecias = new System.Windows.Forms.CheckedListBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.cbbCultura = new System.Windows.Forms.CheckBox();
            this.cbbEsporte = new System.Windows.Forms.CheckBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblEstadps = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPreferencias = new System.Windows.Forms.Label();
            this.bntSelecione = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLImpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbblivro
            // 
            this.cbblivro.AutoSize = true;
            this.cbblivro.Location = new System.Drawing.Point(158, 168);
            this.cbblivro.Name = "cbblivro";
            this.cbblivro.Size = new System.Drawing.Size(45, 17);
            this.cbblivro.TabIndex = 0;
            this.cbblivro.Text = "livro";
            this.cbblivro.UseVisualStyleBackColor = true;
            this.cbblivro.CheckedChanged += new System.EventHandler(this.cbblivro_CheckedChanged);
            // 
            // cbCidades
            // 
            this.cbCidades.FormattingEnabled = true;
            this.cbCidades.Items.AddRange(new object[] {
            "Sao Paulo",
            "Rio de Janeiro",
            "Minas Gerais"});
            this.cbCidades.Location = new System.Drawing.Point(325, 174);
            this.cbCidades.Name = "cbCidades";
            this.cbCidades.Size = new System.Drawing.Size(121, 21);
            this.cbCidades.TabIndex = 6;
            this.cbCidades.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbAcademia
            // 
            this.cbbAcademia.AutoSize = true;
            this.cbbAcademia.Location = new System.Drawing.Point(158, 191);
            this.cbbAcademia.Name = "cbbAcademia";
            this.cbbAcademia.Size = new System.Drawing.Size(73, 17);
            this.cbbAcademia.TabIndex = 1;
            this.cbbAcademia.Text = "Academia";
            this.cbbAcademia.UseVisualStyleBackColor = true;
            this.cbbAcademia.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lbPreferecias
            // 
            this.lbPreferecias.FormattingEnabled = true;
            this.lbPreferecias.Items.AddRange(new object[] {
            "amarelo",
            "vermelho",
            "azul",
            "cinza",
            "preto"});
            this.lbPreferecias.Location = new System.Drawing.Point(325, 239);
            this.lbPreferecias.Name = "lbPreferecias";
            this.lbPreferecias.Size = new System.Drawing.Size(120, 79);
            this.lbPreferecias.TabIndex = 7;
            this.lbPreferecias.SelectedIndexChanged += new System.EventHandler(this.lbPreferecias_SelectedIndexChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(158, 301);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 4;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbbCultura
            // 
            this.cbbCultura.AutoSize = true;
            this.cbbCultura.Location = new System.Drawing.Point(158, 214);
            this.cbbCultura.Name = "cbbCultura";
            this.cbbCultura.Size = new System.Drawing.Size(59, 17);
            this.cbbCultura.TabIndex = 2;
            this.cbbCultura.Text = "Cultura";
            this.cbbCultura.UseVisualStyleBackColor = true;
            // 
            // cbbEsporte
            // 
            this.cbbEsporte.AutoSize = true;
            this.cbbEsporte.Location = new System.Drawing.Point(158, 237);
            this.cbbEsporte.Name = "cbbEsporte";
            this.cbbEsporte.Size = new System.Drawing.Size(67, 17);
            this.cbbEsporte.TabIndex = 3;
            this.cbbEsporte.Text = "Esportes";
            this.cbbEsporte.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(158, 324);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 5;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // lblEstadps
            // 
            this.lblEstadps.AutoSize = true;
            this.lblEstadps.Location = new System.Drawing.Point(323, 158);
            this.lblEstadps.Name = "lblEstadps";
            this.lblEstadps.Size = new System.Drawing.Size(45, 13);
            this.lblEstadps.TabIndex = 8;
            this.lblEstadps.Text = "Estados";
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(149, 139);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(54, 13);
            this.lblSelecione.TabIndex = 9;
            this.lblSelecione.Text = "Selecione";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(149, 273);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPreferencias
            // 
            this.lblPreferencias.AutoSize = true;
            this.lblPreferencias.Location = new System.Drawing.Point(322, 218);
            this.lblPreferencias.Name = "lblPreferencias";
            this.lblPreferencias.Size = new System.Drawing.Size(66, 13);
            this.lblPreferencias.TabIndex = 11;
            this.lblPreferencias.Text = "Preferencias";
            // 
            // bntSelecione
            // 
            this.bntSelecione.Location = new System.Drawing.Point(496, 174);
            this.bntSelecione.Name = "bntSelecione";
            this.bntSelecione.Size = new System.Drawing.Size(101, 45);
            this.bntSelecione.TabIndex = 9;
            this.bntSelecione.Text = "&Selecione";
            this.bntSelecione.UseVisualStyleBackColor = true;
            this.bntSelecione.Click += new System.EventHandler(this.bntSelecione_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(496, 275);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 43);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLImpar
            // 
            this.btnLImpar.Location = new System.Drawing.Point(496, 225);
            this.btnLImpar.Name = "btnLImpar";
            this.btnLImpar.Size = new System.Drawing.Size(101, 44);
            this.btnLImpar.TabIndex = 10;
            this.btnLImpar.Text = "&Limpar";
            this.btnLImpar.UseVisualStyleBackColor = true;
            this.btnLImpar.Click += new System.EventHandler(this.btnLImpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "COMPONENTES";
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLImpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntSelecione);
            this.Controls.Add(this.lblPreferencias);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.lblEstadps);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.cbbEsporte);
            this.Controls.Add(this.cbbCultura);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.lbPreferecias);
            this.Controls.Add(this.cbbAcademia);
            this.Controls.Add(this.cbCidades);
            this.Controls.Add(this.cbblivro);
            this.Name = "frmComponentes";
            this.Text = "frmComponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbblivro;
        private System.Windows.Forms.ComboBox cbCidades;
        private System.Windows.Forms.CheckBox cbbAcademia;
        private System.Windows.Forms.CheckedListBox lbPreferecias;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.CheckBox cbbCultura;
        private System.Windows.Forms.CheckBox cbbEsporte;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblEstadps;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPreferencias;
        private System.Windows.Forms.Button bntSelecione;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLImpar;
        private System.Windows.Forms.Label label1;
    }
}