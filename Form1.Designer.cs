namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCalculadora = new System.Windows.Forms.Label();
            this.btnuno = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncero = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCalculadora
            // 
            this.labelCalculadora.AutoSize = true;
            this.labelCalculadora.Location = new System.Drawing.Point(256, 9);
            this.labelCalculadora.Name = "labelCalculadora";
            this.labelCalculadora.Size = new System.Drawing.Size(110, 17);
            this.labelCalculadora.TabIndex = 0;
            this.labelCalculadora.Text = "CALCULADORA";
            // 
            // btnuno
            // 
            this.btnuno.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnuno.Location = new System.Drawing.Point(70, 90);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(42, 58);
            this.btnuno.TabIndex = 1;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = false;
            this.btnuno.Click += new System.EventHandler(this.btnuno_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Location = new System.Drawing.Point(135, 90);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 58);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btntres
            // 
            this.btntres.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntres.Location = new System.Drawing.Point(201, 90);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(42, 58);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = false;
            this.btntres.Click += new System.EventHandler(this.btntres_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeis.Location = new System.Drawing.Point(201, 180);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(42, 58);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCinco.Location = new System.Drawing.Point(135, 180);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(42, 58);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btncuatro
            // 
            this.btncuatro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncuatro.Location = new System.Drawing.Point(70, 180);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(42, 58);
            this.btncuatro.TabIndex = 4;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = false;
            this.btncuatro.Click += new System.EventHandler(this.btncuatro_Click);
            // 
            // btnnueve
            // 
            this.btnnueve.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnueve.Location = new System.Drawing.Point(201, 262);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(42, 58);
            this.btnnueve.TabIndex = 9;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = false;
            this.btnnueve.Click += new System.EventHandler(this.btnnueve_Click);
            // 
            // btnocho
            // 
            this.btnocho.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnocho.Location = new System.Drawing.Point(135, 262);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(42, 58);
            this.btnocho.TabIndex = 8;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = false;
            this.btnocho.Click += new System.EventHandler(this.btnocho_Click);
            // 
            // btnsiete
            // 
            this.btnsiete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsiete.Location = new System.Drawing.Point(70, 262);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(42, 58);
            this.btnsiete.TabIndex = 7;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = false;
            this.btnsiete.Click += new System.EventHandler(this.btnsiete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado";
            // 
            // btncero
            // 
            this.btncero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncero.Location = new System.Drawing.Point(135, 340);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(42, 57);
            this.btncero.TabIndex = 13;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = false;
            this.btncero.Click += new System.EventHandler(this.btncero_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(201, 340);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(42, 57);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(440, 113);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 22);
            this.txtNumero1.TabIndex = 15;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(440, 157);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 22);
            this.txtNumero2.TabIndex = 16;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(440, 198);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 17;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSumar.Location = new System.Drawing.Point(45, 433);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(132, 57);
            this.btnSumar.TabIndex = 18;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnrestar.Location = new System.Drawing.Point(215, 433);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(132, 57);
            this.btnrestar.TabIndex = 19;
            this.btnrestar.Text = "restar";
            this.btnrestar.UseVisualStyleBackColor = false;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(374, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 20;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFactorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFactorial.Location = new System.Drawing.Point(374, 356);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(132, 57);
            this.btnFactorial.TabIndex = 21;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(610, 530);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.labelCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalculadora;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFactorial;
    }
}

