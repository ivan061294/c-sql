namespace Capa_Cliente
{
    partial class Frmventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmventa));
            this.cbocomprobante = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdsc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtpreventa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantexist = new System.Windows.Forms.TextBox();
            this.btnbuscarpro = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtnroventa = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.lblcodigoenpleado = new System.Windows.Forms.Label();
            this.txtcodem = new System.Windows.Forms.TextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbocomprobante
            // 
            this.cbocomprobante.FormattingEnabled = true;
            this.cbocomprobante.Location = new System.Drawing.Point(144, 20);
            this.cbocomprobante.Name = "cbocomprobante";
            this.cbocomprobante.Size = new System.Drawing.Size(136, 21);
            this.cbocomprobante.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Comprobante :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtdsc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtpreventa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtcantexist);
            this.groupBox1.Controls.Add(this.btnbuscarpro);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtcodigoproducto);
            this.groupBox1.Controls.Add(this.txtarticulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(25, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 108);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // txtdsc
            // 
            this.txtdsc.Location = new System.Drawing.Point(484, 64);
            this.txtdsc.Name = "txtdsc";
            this.txtdsc.Size = new System.Drawing.Size(100, 20);
            this.txtdsc.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Descuento :";
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Location = new System.Drawing.Point(661, 59);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(34, 33);
            this.btneliminar.TabIndex = 34;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Location = new System.Drawing.Point(661, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(35, 35);
            this.btnagregar.TabIndex = 37;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // txtpreventa
            // 
            this.txtpreventa.Location = new System.Drawing.Point(484, 28);
            this.txtpreventa.Name = "txtpreventa";
            this.txtpreventa.Size = new System.Drawing.Size(100, 20);
            this.txtpreventa.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Precio Venta :";
            // 
            // txtcantexist
            // 
            this.txtcantexist.Location = new System.Drawing.Point(202, 74);
            this.txtcantexist.Name = "txtcantexist";
            this.txtcantexist.Size = new System.Drawing.Size(82, 20);
            this.txtcantexist.TabIndex = 33;
            this.txtcantexist.TextChanged += new System.EventHandler(this.Txtcantexist_TextChanged);
            // 
            // btnbuscarpro
            // 
            this.btnbuscarpro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarpro.BackgroundImage")));
            this.btnbuscarpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarpro.Location = new System.Drawing.Point(718, 21);
            this.btnbuscarpro.Name = "btnbuscarpro";
            this.btnbuscarpro.Size = new System.Drawing.Size(38, 32);
            this.btnbuscarpro.TabIndex = 31;
            this.btnbuscarpro.UseVisualStyleBackColor = true;
            this.btnbuscarpro.Click += new System.EventHandler(this.Btnbuscarpro_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(106, 74);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(78, 20);
            this.txtcantidad.TabIndex = 31;
            this.txtcantidad.TextChanged += new System.EventHandler(this.Txtcantidad_TextChanged);
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Location = new System.Drawing.Point(106, 46);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(123, 20);
            this.txtcodigoproducto.TabIndex = 30;
            this.txtcodigoproducto.Text = " ";
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(105, 18);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(124, 20);
            this.txtarticulo.TabIndex = 30;
            this.txtarticulo.Text = " ";
            this.txtarticulo.TextChanged += new System.EventHandler(this.Txtarticulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cantidad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Articulo :";
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.AllowUserToAddRows = false;
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(7, 279);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.Size = new System.Drawing.Size(817, 164);
            this.dgvmostrar.TabIndex = 27;
            // 
            // txtigv
            // 
            this.txtigv.Location = new System.Drawing.Point(609, 20);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(215, 20);
            this.txtigv.TabIndex = 66;
            this.txtigv.TextChanged += new System.EventHandler(this.Txtigv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "IGV :";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(609, 60);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(215, 20);
            this.dtpfecha.TabIndex = 64;
            this.dtpfecha.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
            // 
            // txtnroventa
            // 
            this.txtnroventa.Location = new System.Drawing.Point(388, 22);
            this.txtnroventa.Name = "txtnroventa";
            this.txtnroventa.Size = new System.Drawing.Size(145, 20);
            this.txtnroventa.TabIndex = 63;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(388, 62);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(145, 20);
            this.txtcliente.TabIndex = 62;
            this.txtcliente.TextChanged += new System.EventHandler(this.Txtcliente_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(144, 58);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 20);
            this.txtcodigo.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Codigo Venta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cliente :";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(28, 61);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(46, 13);
            this.codigo.TabIndex = 57;
            this.codigo.Text = "Código :";
            // 
            // lblcodigoenpleado
            // 
            this.lblcodigoenpleado.AutoSize = true;
            this.lblcodigoenpleado.Location = new System.Drawing.Point(28, 97);
            this.lblcodigoenpleado.Name = "lblcodigoenpleado";
            this.lblcodigoenpleado.Size = new System.Drawing.Size(88, 13);
            this.lblcodigoenpleado.TabIndex = 72;
            this.lblcodigoenpleado.Text = "codigo empleado";
            // 
            // txtcodem
            // 
            this.txtcodem.Location = new System.Drawing.Point(144, 95);
            this.txtcodem.Name = "txtcodem";
            this.txtcodem.Size = new System.Drawing.Size(136, 20);
            this.txtcodem.TabIndex = 73;
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(7, 279);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(817, 164);
            this.dgvcliente.TabIndex = 74;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcliente_CellContentClick);
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(7, 279);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(817, 164);
            this.dgvproducto.TabIndex = 75;
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvproducto_CellContentClick);
            // 
            // Frmventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 469);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.txtcodem);
            this.Controls.Add(this.lblcodigoenpleado);
            this.Controls.Add(this.cbocomprobante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtnroventa);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Name = "Frmventa";
            this.Text = "Frmventa";
            this.Load += new System.EventHandler(this.Frmventa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbocomprobante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtdsc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.TextBox txtpreventa;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtcantexist;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvmostrar;
        public System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.TextBox txtnroventa;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codigo;
        public System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodigoenpleado;
        private System.Windows.Forms.TextBox txtcodem;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnbuscarpro;
    }
}