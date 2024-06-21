namespace atividade01.View
{
    partial class AtvSoma
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
            primerio = new Label();
            numeroDois = new Label();
            label1 = new Label();
            lbl_Soma = new Button();
            txb_numeroum = new TextBox();
            txb_numerodois = new TextBox();
            label2 = new Label();
            lbl_resultado = new Label();
            SuspendLayout();
            // 
            // primerio
            // 
            primerio.AutoSize = true;
            primerio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            primerio.Location = new Point(110, 144);
            primerio.Name = "primerio";
            primerio.Size = new Size(95, 21);
            primerio.TabIndex = 0;
            primerio.Text = "Numero 01";
            primerio.Click += label1_Click;
            // 
            // numeroDois
            // 
            numeroDois.AutoSize = true;
            numeroDois.FlatStyle = FlatStyle.Flat;
            numeroDois.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numeroDois.Location = new Point(110, 190);
            numeroDois.Name = "numeroDois";
            numeroDois.Size = new Size(95, 21);
            numeroDois.TabIndex = 1;
            numeroDois.Text = "Numero 02";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 73);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 2;
            label1.Text = "Soma";
            // 
            // lbl_Soma
            // 
            lbl_Soma.Location = new Point(141, 365);
            lbl_Soma.Name = "lbl_Soma";
            lbl_Soma.Size = new Size(293, 50);
            lbl_Soma.TabIndex = 3;
            lbl_Soma.Text = "Somar";
            lbl_Soma.UseVisualStyleBackColor = true;
            lbl_Soma.Click += lbl_Soma_Click;
            // 
            // txb_numeroum
            // 
            txb_numeroum.Location = new Point(222, 142);
            txb_numeroum.Name = "txb_numeroum";
            txb_numeroum.Size = new Size(212, 23);
            txb_numeroum.TabIndex = 4;
            // 
            // txb_numerodois
            // 
            txb_numerodois.Location = new Point(222, 188);
            txb_numerodois.Name = "txb_numerodois";
            txb_numerodois.Size = new Size(212, 23);
            txb_numerodois.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 237);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 7;
            label2.Text = "Resultado";
            // 
            // lbl_resultado
            // 
            lbl_resultado.BackColor = Color.FromArgb(255, 192, 192);
            lbl_resultado.Location = new Point(222, 237);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(212, 115);
            lbl_resultado.TabIndex = 8;
            // 
            // AtvSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 505);
            Controls.Add(lbl_resultado);
            Controls.Add(label2);
            Controls.Add(txb_numerodois);
            Controls.Add(txb_numeroum);
            Controls.Add(lbl_Soma);
            Controls.Add(label1);
            Controls.Add(numeroDois);
            Controls.Add(primerio);
            Name = "AtvSoma";
            Text = "AtvSoma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label primerio;
        private Label numeroDois;
        private Label label1;
        private Button lbl_Soma;
        private TextBox txb_numeroum;
        private TextBox txb_numerodois;
        private Label label2;
        private Label lbl_resultado;
    }
}