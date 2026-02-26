namespace PrimerExamen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSueldo = new TextBox();
            btnCalcular = new Button();
            label3 = new Label();
            txtIsr = new TextBox();
            label4 = new Label();
            txtNeto = new TextBox();
            label5 = new Label();
            txtExcedente = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(300, 54);
            label1.TabIndex = 0;
            label1.Text = "Calculo del ISR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 117);
            label2.Name = "label2";
            label2.Size = new Size(260, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su sueldo en Pesos Mexicanos:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(317, 117);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(81, 208);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 228);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 4;
            label3.Text = "El ISR a pagar es de $";
            // 
            // txtIsr
            // 
            txtIsr.Location = new Point(602, 225);
            txtIsr.Name = "txtIsr";
            txtIsr.Size = new Size(125, 27);
            txtIsr.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 281);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 6;
            label4.Text = "Su sueldo neto es de $";
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(602, 274);
            txtNeto.Name = "txtNeto";
            txtNeto.Size = new Size(125, 27);
            txtNeto.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 182);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 8;
            label5.Text = "El excedente es de $";
            // 
            // txtExcedente
            // 
            txtExcedente.Location = new Point(602, 182);
            txtExcedente.Name = "txtExcedente";
            txtExcedente.Size = new Size(125, 27);
            txtExcedente.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 24);
            label6.Name = "label6";
            label6.Size = new Size(197, 20);
            label6.TabIndex = 10;
            label6.Text = "Carlos Andrés Flores Rosales";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 58);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 11;
            label7.Text = "24130796";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 319);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtExcedente);
            Controls.Add(label5);
            Controls.Add(txtNeto);
            Controls.Add(label4);
            Controls.Add(txtIsr);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtSueldo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSueldo;
        private Button btnCalcular;
        private Label label3;
        private TextBox txtIsr;
        private Label label4;
        private TextBox txtNeto;
        private Label label5;
        private TextBox txtExcedente;
        private Label label6;
        private Label label7;
    }
}
