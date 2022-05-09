
namespace TrabajoGrupal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbArtesanal = new System.Windows.Forms.RadioButton();
            this.rbDelgada = new System.Windows.Forms.RadioButton();
            this.rbPanPizza = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbTamanos = new System.Windows.Forms.ListBox();
            this.Ingredientes = new System.Windows.Forms.GroupBox();
            this.chkAceitunas = new System.Windows.Forms.CheckBox();
            this.chkHongos = new System.Windows.Forms.CheckBox();
            this.chkSalchicha = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbEdad = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdad)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzería Francesco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbArtesanal);
            this.groupBox1.Controls.Add(this.rbDelgada);
            this.groupBox1.Controls.Add(this.rbPanPizza);
            this.groupBox1.Location = new System.Drawing.Point(16, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Masa";
            // 
            // rbArtesanal
            // 
            this.rbArtesanal.AutoSize = true;
            this.rbArtesanal.Location = new System.Drawing.Point(7, 68);
            this.rbArtesanal.Name = "rbArtesanal";
            this.rbArtesanal.Size = new System.Drawing.Size(69, 17);
            this.rbArtesanal.TabIndex = 2;
            this.rbArtesanal.TabStop = true;
            this.rbArtesanal.Text = "Artesanal";
            this.rbArtesanal.UseVisualStyleBackColor = true;
            // 
            // rbDelgada
            // 
            this.rbDelgada.AutoSize = true;
            this.rbDelgada.Location = new System.Drawing.Point(7, 44);
            this.rbDelgada.Name = "rbDelgada";
            this.rbDelgada.Size = new System.Drawing.Size(65, 17);
            this.rbDelgada.TabIndex = 1;
            this.rbDelgada.TabStop = true;
            this.rbDelgada.Text = "Delgada";
            this.rbDelgada.UseVisualStyleBackColor = true;
            // 
            // rbPanPizza
            // 
            this.rbPanPizza.AutoSize = true;
            this.rbPanPizza.Location = new System.Drawing.Point(7, 20);
            this.rbPanPizza.Name = "rbPanPizza";
            this.rbPanPizza.Size = new System.Drawing.Size(72, 17);
            this.rbPanPizza.TabIndex = 0;
            this.rbPanPizza.TabStop = true;
            this.rbPanPizza.Text = "Pan Pizza";
            this.rbPanPizza.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbTamanos);
            this.groupBox2.Location = new System.Drawing.Point(16, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño de la Pizza";
            // 
            // lstbTamanos
            // 
            this.lstbTamanos.FormattingEnabled = true;
            this.lstbTamanos.Items.AddRange(new object[] {
            "Grande",
            "Extra Grande"});
            this.lstbTamanos.Location = new System.Drawing.Point(7, 20);
            this.lstbTamanos.Name = "lstbTamanos";
            this.lstbTamanos.Size = new System.Drawing.Size(114, 43);
            this.lstbTamanos.TabIndex = 0;
            // 
            // Ingredientes
            // 
            this.Ingredientes.Controls.Add(this.chkAceitunas);
            this.Ingredientes.Controls.Add(this.chkHongos);
            this.Ingredientes.Controls.Add(this.chkSalchicha);
            this.Ingredientes.Controls.Add(this.chkPepperoni);
            this.Ingredientes.Controls.Add(this.chkJamon);
            this.Ingredientes.Location = new System.Drawing.Point(179, 192);
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Size = new System.Drawing.Size(126, 137);
            this.Ingredientes.TabIndex = 3;
            this.Ingredientes.TabStop = false;
            this.Ingredientes.Text = "Ingredientes";
            // 
            // chkAceitunas
            // 
            this.chkAceitunas.AutoSize = true;
            this.chkAceitunas.Location = new System.Drawing.Point(7, 114);
            this.chkAceitunas.Name = "chkAceitunas";
            this.chkAceitunas.Size = new System.Drawing.Size(73, 17);
            this.chkAceitunas.TabIndex = 4;
            this.chkAceitunas.Text = "Aceitunas";
            this.chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkHongos
            // 
            this.chkHongos.AutoSize = true;
            this.chkHongos.Location = new System.Drawing.Point(7, 92);
            this.chkHongos.Name = "chkHongos";
            this.chkHongos.Size = new System.Drawing.Size(63, 17);
            this.chkHongos.TabIndex = 3;
            this.chkHongos.Text = "Hongos";
            this.chkHongos.UseVisualStyleBackColor = true;
            // 
            // chkSalchicha
            // 
            this.chkSalchicha.AutoSize = true;
            this.chkSalchicha.Location = new System.Drawing.Point(7, 68);
            this.chkSalchicha.Name = "chkSalchicha";
            this.chkSalchicha.Size = new System.Drawing.Size(73, 17);
            this.chkSalchicha.TabIndex = 2;
            this.chkSalchicha.Text = "Salchicha";
            this.chkSalchicha.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(7, 44);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 1;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(7, 20);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(57, 17);
            this.chkJamon.TabIndex = 0;
            this.chkJamon.Text = "Jamón";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impuesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sub total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(11, 19);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(53, 20);
            this.txtEdad.TabIndex = 11;
            this.txtEdad.Text = "0";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(392, 51);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 12;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(392, 87);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 13;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(392, 129);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 14;
            this.txtImpuesto.Text = "0.00";
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(392, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResumen
            // 
            this.txtResumen.Enabled = false;
            this.txtResumen.Location = new System.Drawing.Point(335, 210);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(268, 132);
            this.txtResumen.TabIndex = 16;
            this.txtResumen.TextChanged += new System.EventHandler(this.txtResumen_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(528, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(528, 164);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(15, 46);
            this.tbEdad.Maximum = 90;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(233, 45);
            this.tbEdad.TabIndex = 19;
            this.tbEdad.TickFrequency = 10;
            this.tbEdad.Scroll += new System.EventHandler(this.tbEdad_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEdad);
            this.groupBox3.Controls.Add(this.tbEdad);
            this.groupBox3.Location = new System.Drawing.Point(12, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 97);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edad cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoGrupal2.Properties.Resources._815ded7afc1c54dfb5a60f81f68f928b_icono_de_rebanada_de_pizza_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(521, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingredientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizzeria Francesco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Ingredientes.ResumeLayout(false);
            this.Ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbArtesanal;
        private System.Windows.Forms.RadioButton rbDelgada;
        private System.Windows.Forms.RadioButton rbPanPizza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Ingredientes;
        private System.Windows.Forms.CheckBox chkAceitunas;
        private System.Windows.Forms.CheckBox chkHongos;
        private System.Windows.Forms.CheckBox chkSalchicha;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TrackBar tbEdad;
        private System.Windows.Forms.ListBox lstbTamanos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

