namespace Capa_Cliente
{
    partial class frm_productos_busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productos_busqueda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtdescripcion = new System.Windows.Forms.RadioButton();
            this.rbtcodigo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rbtdescripcion);
            this.panel1.Controls.Add(this.rbtcodigo);
            this.panel1.Location = new System.Drawing.Point(23, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 86);
            this.panel1.TabIndex = 0;
            // 
            // rbtdescripcion
            // 
            this.rbtdescripcion.AutoSize = true;
            this.rbtdescripcion.Location = new System.Drawing.Point(346, 37);
            this.rbtdescripcion.Name = "rbtdescripcion";
            this.rbtdescripcion.Size = new System.Drawing.Size(100, 17);
            this.rbtdescripcion.TabIndex = 0;
            this.rbtdescripcion.TabStop = true;
            this.rbtdescripcion.Text = "Por Descripcion";
            this.rbtdescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtcodigo
            // 
            this.rbtcodigo.AutoSize = true;
            this.rbtcodigo.Location = new System.Drawing.Point(50, 37);
            this.rbtcodigo.Name = "rbtcodigo";
            this.rbtcodigo.Size = new System.Drawing.Size(142, 17);
            this.rbtcodigo.TabIndex = 0;
            this.rbtcodigo.TabStop = true;
            this.rbtcodigo.Text = "Por Codigo Del Producto";
            this.rbtcodigo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto A Consultar";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(123, 158);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(171, 20);
            this.txtconsulta.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 217);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(544, 185);
            this.dgv1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ver Todo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frm_productos_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 420);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_productos_busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_productos_busqueda";
            this.Load += new System.EventHandler(this.frm_productos_busqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.RadioButton rbtdescripcion;
        private System.Windows.Forms.RadioButton rbtcodigo;
        private System.Windows.Forms.Button button5;
    }
}