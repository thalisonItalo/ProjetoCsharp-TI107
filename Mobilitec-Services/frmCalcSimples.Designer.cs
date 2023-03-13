
namespace Mobilitec_Services
{
    partial class frmCalcSimples
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
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.txbV1 = new System.Windows.Forms.TextBox();
            this.txbV2 = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.rbAdicao = new System.Windows.Forms.RadioButton();
            this.rbSubtracao = new System.Windows.Forms.RadioButton();
            this.rbmulti = new System.Windows.Forms.RadioButton();
            this.rbDivi = new System.Windows.Forms.RadioButton();
            this.lblResu = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(106, 82);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(82, 19);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "Variavel 1";
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel2.Location = new System.Drawing.Point(106, 133);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(82, 19);
            this.lblVariavel2.TabIndex = 1;
            this.lblVariavel2.Text = "Variavel 2";
            // 
            // txbV1
            // 
            this.txbV1.Location = new System.Drawing.Point(194, 81);
            this.txbV1.Name = "txbV1";
            this.txbV1.Size = new System.Drawing.Size(110, 20);
            this.txbV1.TabIndex = 2;
            // 
            // txbV2
            // 
            this.txbV2.Location = new System.Drawing.Point(194, 133);
            this.txbV2.Name = "txbV2";
            this.txbV2.Size = new System.Drawing.Size(110, 20);
            this.txbV2.TabIndex = 3;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(381, 81);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(51, 13);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "Operador";
            this.lblOp.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbAdicao
            // 
            this.rbAdicao.AutoSize = true;
            this.rbAdicao.Location = new System.Drawing.Point(384, 111);
            this.rbAdicao.Name = "rbAdicao";
            this.rbAdicao.Size = new System.Drawing.Size(73, 17);
            this.rbAdicao.TabIndex = 5;
            this.rbAdicao.TabStop = true;
            this.rbAdicao.Text = "Adição (+)";
            this.rbAdicao.UseVisualStyleBackColor = true;
            this.rbAdicao.CheckedChanged += new System.EventHandler(this.rbAdicao_CheckedChanged);
            // 
            // rbSubtracao
            // 
            this.rbSubtracao.AutoSize = true;
            this.rbSubtracao.Location = new System.Drawing.Point(384, 136);
            this.rbSubtracao.Name = "rbSubtracao";
            this.rbSubtracao.Size = new System.Drawing.Size(86, 17);
            this.rbSubtracao.TabIndex = 6;
            this.rbSubtracao.TabStop = true;
            this.rbSubtracao.Text = "Subtração (-)";
            this.rbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbmulti
            // 
            this.rbmulti.AutoSize = true;
            this.rbmulti.Location = new System.Drawing.Point(384, 159);
            this.rbmulti.Name = "rbmulti";
            this.rbmulti.Size = new System.Drawing.Size(100, 17);
            this.rbmulti.TabIndex = 7;
            this.rbmulti.TabStop = true;
            this.rbmulti.Text = " Multiplicação(*)";
            this.rbmulti.UseVisualStyleBackColor = true;
            // 
            // rbDivi
            // 
            this.rbDivi.AutoSize = true;
            this.rbDivi.Location = new System.Drawing.Point(384, 182);
            this.rbDivi.Name = "rbDivi";
            this.rbDivi.Size = new System.Drawing.Size(74, 17);
            this.rbDivi.TabIndex = 8;
            this.rbDivi.TabStop = true;
            this.rbDivi.Text = "Divisão (/)";
            this.rbDivi.UseVisualStyleBackColor = true;
            // 
            // lblResu
            // 
            this.lblResu.AutoSize = true;
            this.lblResu.Location = new System.Drawing.Point(554, 71);
            this.lblResu.Name = "lblResu";
            this.lblResu.Size = new System.Drawing.Size(55, 13);
            this.lblResu.TabIndex = 9;
            this.lblResu.Text = "Resultado";
            // 
            // lblResp
            // 
            this.lblResp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(532, 95);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(100, 47);
            this.lblResp.TabIndex = 10;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(178, 288);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 42);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bntLimpar.Location = new System.Drawing.Point(307, 288);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(103, 42);
            this.bntLimpar.TabIndex = 12;
            this.bntLimpar.Text = "&Limpar";
            this.bntLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSair.Location = new System.Drawing.Point(443, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 42);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCalcSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblResu);
            this.Controls.Add(this.rbDivi);
            this.Controls.Add(this.rbmulti);
            this.Controls.Add(this.rbSubtracao);
            this.Controls.Add(this.rbAdicao);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txbV2);
            this.Controls.Add(this.txbV1);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.Name = "frmCalcSimples";
            this.Text = "frmCalcSimples";
            this.Load += new System.EventHandler(this.frmCalcSimples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.TextBox txbV1;
        private System.Windows.Forms.TextBox txbV2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.RadioButton rbAdicao;
        private System.Windows.Forms.RadioButton rbSubtracao;
        private System.Windows.Forms.RadioButton rbmulti;
        private System.Windows.Forms.RadioButton rbDivi;
        private System.Windows.Forms.Label lblResu;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}