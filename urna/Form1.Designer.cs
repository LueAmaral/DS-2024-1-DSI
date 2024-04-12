namespace urna
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLVotosA = new System.Windows.Forms.Label();
            this.LBLPVotosA = new System.Windows.Forms.Label();
            this.LBLVotosB = new System.Windows.Forms.Label();
            this.LBLPVotosB = new System.Windows.Forms.Label();
            this.LBLVotosC = new System.Windows.Forms.Label();
            this.LBLPVotosC = new System.Windows.Forms.Label();
            this.LBLVotosD = new System.Windows.Forms.Label();
            this.LBLPVotosD = new System.Windows.Forms.Label();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.LBLVENCEDOR = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnCandA = new System.Windows.Forms.Button();
            this.BtnCandB = new System.Windows.Forms.Button();
            this.BtnCandC = new System.Windows.Forms.Button();
            this.BtnCandD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Terminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique no botão correspondente ao seu voto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado da eleição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(115, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Candidato A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Votos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLVotosA
            // 
            this.LBLVotosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLVotosA.Location = new System.Drawing.Point(118, 202);
            this.LBLVotosA.Margin = new System.Windows.Forms.Padding(5);
            this.LBLVotosA.Name = "LBLVotosA";
            this.LBLVotosA.Size = new System.Drawing.Size(100, 25);
            this.LBLVotosA.TabIndex = 8;
            // 
            // LBLPVotosA
            // 
            this.LBLPVotosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLPVotosA.Location = new System.Drawing.Point(118, 250);
            this.LBLPVotosA.Name = "LBLPVotosA";
            this.LBLPVotosA.Size = new System.Drawing.Size(100, 23);
            this.LBLPVotosA.TabIndex = 9;
            // 
            // LBLVotosB
            // 
            this.LBLVotosB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLVotosB.Location = new System.Drawing.Point(256, 204);
            this.LBLVotosB.Name = "LBLVotosB";
            this.LBLVotosB.Size = new System.Drawing.Size(100, 23);
            this.LBLVotosB.TabIndex = 10;
            // 
            // LBLPVotosB
            // 
            this.LBLPVotosB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLPVotosB.Location = new System.Drawing.Point(256, 250);
            this.LBLPVotosB.Name = "LBLPVotosB";
            this.LBLPVotosB.Size = new System.Drawing.Size(100, 23);
            this.LBLPVotosB.TabIndex = 11;
            // 
            // LBLVotosC
            // 
            this.LBLVotosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLVotosC.Location = new System.Drawing.Point(392, 204);
            this.LBLVotosC.Name = "LBLVotosC";
            this.LBLVotosC.Size = new System.Drawing.Size(100, 23);
            this.LBLVotosC.TabIndex = 12;
            // 
            // LBLPVotosC
            // 
            this.LBLPVotosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLPVotosC.Location = new System.Drawing.Point(392, 250);
            this.LBLPVotosC.Name = "LBLPVotosC";
            this.LBLPVotosC.Size = new System.Drawing.Size(100, 23);
            this.LBLPVotosC.TabIndex = 13;
            // 
            // LBLVotosD
            // 
            this.LBLVotosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLVotosD.Location = new System.Drawing.Point(529, 204);
            this.LBLVotosD.Name = "LBLVotosD";
            this.LBLVotosD.Size = new System.Drawing.Size(100, 23);
            this.LBLVotosD.TabIndex = 14;
            // 
            // LBLPVotosD
            // 
            this.LBLPVotosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLPVotosD.Location = new System.Drawing.Point(529, 250);
            this.LBLPVotosD.Name = "LBLPVotosD";
            this.LBLPVotosD.Size = new System.Drawing.Size(100, 23);
            this.LBLPVotosD.TabIndex = 15;
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLTOTAL.Location = new System.Drawing.Point(256, 317);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(100, 23);
            this.LBLTOTAL.TabIndex = 16;
            // 
            // LBLVENCEDOR
            // 
            this.LBLVENCEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLVENCEDOR.Location = new System.Drawing.Point(529, 317);
            this.LBLVENCEDOR.Name = "LBLVENCEDOR";
            this.LBLVENCEDOR.Size = new System.Drawing.Size(100, 23);
            this.LBLVENCEDOR.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(115, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "Total de Eleitores";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(389, 317);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 23);
            this.label20.TabIndex = 19;
            this.label20.Text = "Vencedor";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCandA
            // 
            this.BtnCandA.BackgroundImage = global::urna.Properties.Resources._52o_2LY__400x400;
            this.BtnCandA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCandA.Location = new System.Drawing.Point(118, 32);
            this.BtnCandA.Name = "BtnCandA";
            this.BtnCandA.Size = new System.Drawing.Size(100, 100);
            this.BtnCandA.TabIndex = 20;
            this.BtnCandA.UseVisualStyleBackColor = true;
            this.BtnCandA.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCandB
            // 
            this.BtnCandB.BackgroundImage = global::urna.Properties.Resources._52o_2LY__400x400;
            this.BtnCandB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCandB.Location = new System.Drawing.Point(255, 32);
            this.BtnCandB.Name = "BtnCandB";
            this.BtnCandB.Size = new System.Drawing.Size(100, 100);
            this.BtnCandB.TabIndex = 21;
            this.BtnCandB.UseVisualStyleBackColor = true;
            this.BtnCandB.Click += new System.EventHandler(this.BtnCandB_Click);
            // 
            // BtnCandC
            // 
            this.BtnCandC.BackgroundImage = global::urna.Properties.Resources._52o_2LY__400x400;
            this.BtnCandC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCandC.Location = new System.Drawing.Point(392, 32);
            this.BtnCandC.Name = "BtnCandC";
            this.BtnCandC.Size = new System.Drawing.Size(100, 100);
            this.BtnCandC.TabIndex = 22;
            this.BtnCandC.UseVisualStyleBackColor = true;
            this.BtnCandC.Click += new System.EventHandler(this.BtnCandC_Click_1);
            // 
            // BtnCandD
            // 
            this.BtnCandD.BackgroundImage = global::urna.Properties.Resources._52o_2LY__400x400;
            this.BtnCandD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCandD.Location = new System.Drawing.Point(529, 32);
            this.BtnCandD.Name = "BtnCandD";
            this.BtnCandD.Size = new System.Drawing.Size(100, 100);
            this.BtnCandD.TabIndex = 24;
            this.BtnCandD.UseVisualStyleBackColor = true;
            this.BtnCandD.Click += new System.EventHandler(this.BtnCandD_Click_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(252, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Candidato B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(389, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Candidato C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(526, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Candidato D";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Terminar
            // 
            this.Terminar.Location = new System.Drawing.Point(255, 368);
            this.Terminar.Name = "Terminar";
            this.Terminar.Size = new System.Drawing.Size(237, 23);
            this.Terminar.TabIndex = 28;
            this.Terminar.Text = "Termina Eleição";
            this.Terminar.UseVisualStyleBackColor = true;
            this.Terminar.Click += new System.EventHandler(this.Terminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 414);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCandD);
            this.Controls.Add(this.BtnCandC);
            this.Controls.Add(this.BtnCandB);
            this.Controls.Add(this.BtnCandA);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LBLVENCEDOR);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.LBLPVotosD);
            this.Controls.Add(this.LBLVotosD);
            this.Controls.Add(this.LBLPVotosC);
            this.Controls.Add(this.LBLVotosC);
            this.Controls.Add(this.LBLPVotosB);
            this.Controls.Add(this.LBLVotosB);
            this.Controls.Add(this.LBLPVotosA);
            this.Controls.Add(this.LBLVotosA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLVotosA;
        private System.Windows.Forms.Label LBLPVotosA;
        private System.Windows.Forms.Label LBLVotosB;
        private System.Windows.Forms.Label LBLPVotosB;
        private System.Windows.Forms.Label LBLVotosC;
        private System.Windows.Forms.Label LBLPVotosC;
        private System.Windows.Forms.Label LBLVotosD;
        private System.Windows.Forms.Label LBLPVotosD;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.Label LBLVENCEDOR;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnCandA;
        private System.Windows.Forms.Button BtnCandB;
        private System.Windows.Forms.Button BtnCandC;
        private System.Windows.Forms.Button BtnCandD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Terminar;
    }
}

