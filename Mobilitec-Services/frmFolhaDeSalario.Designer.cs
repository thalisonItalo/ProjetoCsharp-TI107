
namespace Mobilitec_Services
{
    partial class frmFolhaDeSalario
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
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.cbLazer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalariofolha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLazer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(61, 89);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(71, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data da folha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPlanoDeSaude
            // 
            this.cbPlanoDeSaude.AutoSize = true;
            this.cbPlanoDeSaude.Location = new System.Drawing.Point(67, 190);
            this.cbPlanoDeSaude.Name = "cbPlanoDeSaude";
            this.cbPlanoDeSaude.Size = new System.Drawing.Size(102, 17);
            this.cbPlanoDeSaude.TabIndex = 2;
            this.cbPlanoDeSaude.Text = "Plano de Saude";
            this.cbPlanoDeSaude.UseVisualStyleBackColor = true;
            this.cbPlanoDeSaude.CheckedChanged += new System.EventHandler(this.cbPlanoDeSaude_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(64, 164);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 4;
            this.txtsalario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbLazer
            // 
            this.cbLazer.FormattingEnabled = true;
            this.cbLazer.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbLazer.Location = new System.Drawing.Point(64, 235);
            this.cbLazer.Name = "cbLazer";
            this.cbLazer.Size = new System.Drawing.Size(121, 21);
            this.cbLazer.TabIndex = 5;
            this.cbLazer.SelectedIndexChanged += new System.EventHandler(this.cbLazer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salario folha";
            // 
            // txtsalariofolha
            // 
            this.txtsalariofolha.Location = new System.Drawing.Point(281, 106);
            this.txtsalariofolha.Name = "txtsalariofolha";
            this.txtsalariofolha.Size = new System.Drawing.Size(100, 20);
            this.txtsalariofolha.TabIndex = 7;
            this.txtsalariofolha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Imposto de renda";
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(281, 164);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(100, 20);
            this.txtImposto.TabIndex = 9;
            this.txtImposto.TextChanged += new System.EventHandler(this.txtImposto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salario liquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(281, 235);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "&Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblLazer
            // 
            this.lblLazer.AutoSize = true;
            this.lblLazer.Location = new System.Drawing.Point(61, 219);
            this.lblLazer.Name = "lblLazer";
            this.lblLazer.Size = new System.Drawing.Size(74, 13);
            this.lblLazer.TabIndex = 15;
            this.lblLazer.Text = "Clube de lazer";
            // 
            // frmFolhaDeSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLazer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsalariofolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLazer);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbPlanoDeSaude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.Name = "frmFolhaDeSalario";
            this.Text = "frmFolhaDeSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPlanoDeSaude;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.ComboBox cbLazer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalariofolha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLazer;
    }
}