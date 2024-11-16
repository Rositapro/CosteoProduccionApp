namespace CosteoProduccionApp
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
            dtgvProduccion = new DataGridView();
            CostosMateriaPrima = new DataGridViewTextBoxColumn();
            CostosdeConversion = new DataGridViewTextBoxColumn();
            UnidadesProducidas = new DataGridViewTextBoxColumn();
            Resultado2 = new DataGridViewTextBoxColumn();
            tbCalculadoraDeCostos = new TabControl();
            Orden = new TabPage();
            dtgvOrdenes = new DataGridView();
            MaterialDirecto = new DataGridViewTextBoxColumn();
            ManodeObraDirecta = new DataGridViewTextBoxColumn();
            CostosIndirectos = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            lblResultado1 = new Label();
            label11 = new Label();
            txtCostosIndirectos = new TextBox();
            txtManoDeObra = new TextBox();
            txtMaterialDirecto = new TextBox();
            btnCalcularOrdenes = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Procesos = new TabPage();
            lblResultado = new Label();
            label10 = new Label();
            txtUnidades = new TextBox();
            txtConversion = new TextBox();
            txtMateriaPrima = new TextBox();
            btnCalcularProcesos = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvProduccion).BeginInit();
            tbCalculadoraDeCostos.SuspendLayout();
            Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOrdenes).BeginInit();
            Procesos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 18);
            label1.Name = "label1";
            label1.Size = new Size(437, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de costos de produccion";
            // 
            // dtgvProduccion
            // 
            dtgvProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProduccion.Columns.AddRange(new DataGridViewColumn[] { CostosMateriaPrima, CostosdeConversion, UnidadesProducidas, Resultado2 });
            dtgvProduccion.Location = new Point(291, 68);
            dtgvProduccion.Name = "dtgvProduccion";
            dtgvProduccion.Size = new Size(418, 203);
            dtgvProduccion.TabIndex = 21;
            // 
            // CostosMateriaPrima
            // 
            CostosMateriaPrima.HeaderText = "Costos Materia Prima";
            CostosMateriaPrima.Name = "CostosMateriaPrima";
            // 
            // CostosdeConversion
            // 
            CostosdeConversion.HeaderText = "Costos de Conversion";
            CostosdeConversion.Name = "CostosdeConversion";
            // 
            // UnidadesProducidas
            // 
            UnidadesProducidas.HeaderText = "Unidades Producidas";
            UnidadesProducidas.Name = "UnidadesProducidas";
            // 
            // Resultado2
            // 
            Resultado2.HeaderText = "Resultado";
            Resultado2.Name = "Resultado2";
            // 
            // tbCalculadoraDeCostos
            // 
            tbCalculadoraDeCostos.Controls.Add(Orden);
            tbCalculadoraDeCostos.Controls.Add(Procesos);
            tbCalculadoraDeCostos.Location = new Point(12, 53);
            tbCalculadoraDeCostos.Name = "tbCalculadoraDeCostos";
            tbCalculadoraDeCostos.SelectedIndex = 0;
            tbCalculadoraDeCostos.Size = new Size(744, 412);
            tbCalculadoraDeCostos.TabIndex = 22;
            // 
            // Orden
            // 
            Orden.Controls.Add(dtgvOrdenes);
            Orden.Controls.Add(lblResultado1);
            Orden.Controls.Add(label11);
            Orden.Controls.Add(txtCostosIndirectos);
            Orden.Controls.Add(txtManoDeObra);
            Orden.Controls.Add(txtMaterialDirecto);
            Orden.Controls.Add(btnCalcularOrdenes);
            Orden.Controls.Add(label6);
            Orden.Controls.Add(label5);
            Orden.Controls.Add(label4);
            Orden.Controls.Add(label2);
            Orden.Location = new Point(4, 24);
            Orden.Name = "Orden";
            Orden.Padding = new Padding(3);
            Orden.Size = new Size(736, 384);
            Orden.TabIndex = 0;
            Orden.Text = "Ordenes";
            Orden.UseVisualStyleBackColor = true;
            // 
            // dtgvOrdenes
            // 
            dtgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrdenes.Columns.AddRange(new DataGridViewColumn[] { MaterialDirecto, ManodeObraDirecta, CostosIndirectos, Resultado });
            dtgvOrdenes.Location = new Point(297, 75);
            dtgvOrdenes.Name = "dtgvOrdenes";
            dtgvOrdenes.Size = new Size(418, 203);
            dtgvOrdenes.TabIndex = 31;
            // 
            // MaterialDirecto
            // 
            MaterialDirecto.HeaderText = "Material Directo";
            MaterialDirecto.Name = "MaterialDirecto";
            // 
            // ManodeObraDirecta
            // 
            ManodeObraDirecta.HeaderText = "Mano de Obra Directa";
            ManodeObraDirecta.Name = "ManodeObraDirecta";
            // 
            // CostosIndirectos
            // 
            CostosIndirectos.HeaderText = "Costos indirectos";
            CostosIndirectos.Name = "CostosIndirectos";
            // 
            // Resultado
            // 
            Resultado.HeaderText = "Resultado";
            Resultado.Name = "Resultado";
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado1.Location = new Point(101, 298);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(0, 20);
            lblResultado1.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 297);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 29;
            label11.Text = "Resultado:";
            // 
            // txtCostosIndirectos
            // 
            txtCostosIndirectos.Location = new Point(176, 142);
            txtCostosIndirectos.Name = "txtCostosIndirectos";
            txtCostosIndirectos.Size = new Size(100, 23);
            txtCostosIndirectos.TabIndex = 28;
            // 
            // txtManoDeObra
            // 
            txtManoDeObra.Location = new Point(176, 109);
            txtManoDeObra.Name = "txtManoDeObra";
            txtManoDeObra.Size = new Size(100, 23);
            txtManoDeObra.TabIndex = 27;
            // 
            // txtMaterialDirecto
            // 
            txtMaterialDirecto.Location = new Point(176, 75);
            txtMaterialDirecto.Name = "txtMaterialDirecto";
            txtMaterialDirecto.Size = new Size(100, 23);
            txtMaterialDirecto.TabIndex = 26;
            // 
            // btnCalcularOrdenes
            // 
            btnCalcularOrdenes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularOrdenes.Location = new Point(176, 189);
            btnCalcularOrdenes.Name = "btnCalcularOrdenes";
            btnCalcularOrdenes.Size = new Size(75, 23);
            btnCalcularOrdenes.TabIndex = 25;
            btnCalcularOrdenes.Text = "Calcular";
            btnCalcularOrdenes.UseVisualStyleBackColor = true;
            btnCalcularOrdenes.Click += btnCalcularOrdenes_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 143);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 24;
            label6.Text = "Costos Indirectos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 108);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 23;
            label5.Text = "Mano de Obra Directa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 74);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 22;
            label4.Text = "Material Directo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(279, 19);
            label2.TabIndex = 21;
            label2.Text = "Costos por Ordenes de Produccion";
            // 
            // Procesos
            // 
            Procesos.Controls.Add(lblResultado);
            Procesos.Controls.Add(dtgvProduccion);
            Procesos.Controls.Add(label10);
            Procesos.Controls.Add(txtUnidades);
            Procesos.Controls.Add(txtConversion);
            Procesos.Controls.Add(txtMateriaPrima);
            Procesos.Controls.Add(btnCalcularProcesos);
            Procesos.Controls.Add(label9);
            Procesos.Controls.Add(label8);
            Procesos.Controls.Add(label7);
            Procesos.Controls.Add(label3);
            Procesos.Location = new Point(4, 24);
            Procesos.Name = "Procesos";
            Procesos.Padding = new Padding(3);
            Procesos.Size = new Size(736, 384);
            Procesos.TabIndex = 1;
            Procesos.Text = "Procesos";
            Procesos.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            lblResultado.Location = new Point(94, 308);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 308);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 27;
            label10.Text = "Resultado:";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(175, 144);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 26;
            // 
            // txtConversion
            // 
            txtConversion.Location = new Point(175, 114);
            txtConversion.Name = "txtConversion";
            txtConversion.Size = new Size(100, 23);
            txtConversion.TabIndex = 25;
            // 
            // txtMateriaPrima
            // 
            txtMateriaPrima.Location = new Point(175, 84);
            txtMateriaPrima.Name = "txtMateriaPrima";
            txtMateriaPrima.Size = new Size(100, 23);
            txtMateriaPrima.TabIndex = 24;
            // 
            // btnCalcularProcesos
            // 
            btnCalcularProcesos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularProcesos.Location = new Point(175, 194);
            btnCalcularProcesos.Name = "btnCalcularProcesos";
            btnCalcularProcesos.Size = new Size(75, 23);
            btnCalcularProcesos.TabIndex = 23;
            btnCalcularProcesos.Text = "Calcular";
            btnCalcularProcesos.UseVisualStyleBackColor = true;
            btnCalcularProcesos.Click += btnCalcularProcesos_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(19, 146);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 22;
            label9.Text = "Unidades Producidas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(19, 114);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 21;
            label8.Text = "Costos de conversion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(19, 82);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 20;
            label7.Text = "Costos Materia Prima:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 26);
            label3.Name = "label3";
            label3.Size = new Size(287, 19);
            label3.TabIndex = 19;
            label3.Text = "Costos por Procesos de Produccion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(768, 495);
            Controls.Add(tbCalculadoraDeCostos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvProduccion).EndInit();
            tbCalculadoraDeCostos.ResumeLayout(false);
            Orden.ResumeLayout(false);
            Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOrdenes).EndInit();
            Procesos.ResumeLayout(false);
            Procesos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvProduccion;
        private TabControl tbCalculadoraDeCostos;
        private TabPage Orden;
        private TabPage Procesos;
        private DataGridView dtgvOrdenes;
        private Label lblResultado1;
        private Label label11;
        private TextBox txtCostosIndirectos;
        private TextBox txtManoDeObra;
        private TextBox txtMaterialDirecto;
        private Button btnCalcularOrdenes;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label lblResultado;
        private Label label10;
        private TextBox txtUnidades;
        private TextBox txtConversion;
        private TextBox txtMateriaPrima;
        private Button btnCalcularProcesos;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private TabPage tabPage1;
        private TabPage Ordenes;
        private DataGridViewTextBoxColumn MaterialDirecto;
        private DataGridViewTextBoxColumn ManodeObraDirecta;
        private DataGridViewTextBoxColumn CostosIndirectos;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn CostosMateriaPrima;
        private DataGridViewTextBoxColumn CostosdeConversion;
        private DataGridViewTextBoxColumn UnidadesProducidas;
        private DataGridViewTextBoxColumn Resultado2;
    }
}
