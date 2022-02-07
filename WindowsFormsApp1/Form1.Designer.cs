namespace WindowsFormsApp1
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
            this.texresul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.bigual = new System.Windows.Forms.Button();
            this.bpunto = new System.Windows.Forms.Button();
            this.bequis = new System.Windows.Forms.Button();
            this.bdividir = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.bsuma = new System.Windows.Forms.Button();
            this.borrart = new System.Windows.Forms.Button();
            this.bresta = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texresul
            // 
            this.texresul.BackColor = System.Drawing.Color.Gray;
            this.texresul.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texresul.Location = new System.Drawing.Point(4, 59);
            this.texresul.Multiline = true;
            this.texresul.Name = "texresul";
            this.texresul.ReadOnly = true;
            this.texresul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.texresul.Size = new System.Drawing.Size(272, 44);
            this.texresul.TabIndex = 0;
            this.texresul.Text = "0";
            this.texresul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarnum);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(75, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarnum);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(144, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarnum);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(144, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarnum);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(75, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarnum);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarnum);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(144, 198);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 49);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarnum);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(75, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 49);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarnum);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Thistle;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.agregarnum);
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(6, 143);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(63, 49);
            this.borrar.TabIndex = 13;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // bigual
            // 
            this.bigual.BackColor = System.Drawing.Color.Silver;
            this.bigual.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigual.Location = new System.Drawing.Point(144, 363);
            this.bigual.Name = "bigual";
            this.bigual.Size = new System.Drawing.Size(132, 49);
            this.bigual.TabIndex = 12;
            this.bigual.Text = "=";
            this.bigual.UseVisualStyleBackColor = false;
            this.bigual.Click += new System.EventHandler(this.button11_Click);
            // 
            // bpunto
            // 
            this.bpunto.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpunto.Location = new System.Drawing.Point(6, 363);
            this.bpunto.Name = "bpunto";
            this.bpunto.Size = new System.Drawing.Size(63, 49);
            this.bpunto.TabIndex = 11;
            this.bpunto.Text = ",";
            this.bpunto.UseVisualStyleBackColor = true;
            this.bpunto.Click += new System.EventHandler(this.bpunto_Click);
            // 
            // bequis
            // 
            this.bequis.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequis.Location = new System.Drawing.Point(213, 143);
            this.bequis.Name = "bequis";
            this.bequis.Size = new System.Drawing.Size(63, 49);
            this.bequis.TabIndex = 16;
            this.bequis.Tag = "x";
            this.bequis.Text = "X";
            this.bequis.UseVisualStyleBackColor = true;
            this.bequis.Click += new System.EventHandler(this.clioperador);
            // 
            // bdividir
            // 
            this.bdividir.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdividir.Location = new System.Drawing.Point(144, 143);
            this.bdividir.Name = "bdividir";
            this.bdividir.Size = new System.Drawing.Size(63, 49);
            this.bdividir.TabIndex = 15;
            this.bdividir.Tag = "/";
            this.bdividir.Text = "/";
            this.bdividir.UseVisualStyleBackColor = true;
            this.bdividir.Click += new System.EventHandler(this.clioperador);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(75, 363);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 49);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.agregarnum);
            // 
            // bsuma
            // 
            this.bsuma.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsuma.Location = new System.Drawing.Point(213, 253);
            this.bsuma.Name = "bsuma";
            this.bsuma.Size = new System.Drawing.Size(63, 105);
            this.bsuma.TabIndex = 17;
            this.bsuma.Tag = "+";
            this.bsuma.Text = "+";
            this.bsuma.UseVisualStyleBackColor = true;
            this.bsuma.Click += new System.EventHandler(this.clioperador);
            // 
            // borrart
            // 
            this.borrart.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrart.Location = new System.Drawing.Point(75, 143);
            this.borrart.Name = "borrart";
            this.borrart.Size = new System.Drawing.Size(63, 49);
            this.borrart.TabIndex = 18;
            this.borrart.Text = "CE";
            this.borrart.UseVisualStyleBackColor = true;
            this.borrart.Click += new System.EventHandler(this.borrart_Click);
            // 
            // bresta
            // 
            this.bresta.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bresta.Location = new System.Drawing.Point(213, 198);
            this.bresta.Name = "bresta";
            this.bresta.Size = new System.Drawing.Size(63, 49);
            this.bresta.TabIndex = 19;
            this.bresta.Tag = "-";
            this.bresta.Text = "-";
            this.bresta.UseVisualStyleBackColor = true;
            this.bresta.Click += new System.EventHandler(this.clioperador);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(206, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 53);
            this.panel1.TabIndex = 21;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bresta);
            this.Controls.Add(this.borrart);
            this.Controls.Add(this.bsuma);
            this.Controls.Add(this.bequis);
            this.Controls.Add(this.bdividir);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.bigual);
            this.Controls.Add(this.bpunto);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texresul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texresul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button bigual;
        private System.Windows.Forms.Button bpunto;
        private System.Windows.Forms.Button bequis;
        private System.Windows.Forms.Button bdividir;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bsuma;
        private System.Windows.Forms.Button borrart;
        private System.Windows.Forms.Button bresta;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
    }
}

