namespace CosteoProduccionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularOrdenes_Click(object sender, EventArgs e)
        {
            try
            {
                double materialDirecto = Convert.ToDouble(txtMaterialDirecto.Text);
                double manoDeObraDirecta = Convert.ToDouble(txtManoDeObra.Text);
                double costosIndirectos = Convert.ToDouble(txtCostosIndirectos.Text);

                double costoTotal = materialDirecto + manoDeObraDirecta + costosIndirectos;

                lblResultado1.Text = "Costo total por �rdenes de producci�n: $" + costoTotal.ToString("F2");
                dtgvOrdenes.Rows.Add(materialDirecto, manoDeObraDirecta, costosIndirectos, costoTotal);
                txtMaterialDirecto.Clear();
                txtManoDeObra.Clear();
                txtCostosIndirectos.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos.");
            }

        }

        private void btnCalcularProcesos_Click(object sender, EventArgs e)
        {
            try
            {
                double costoMateriaPrima = Convert.ToDouble(txtMateriaPrima.Text);
                double costoConversion = Convert.ToDouble(txtConversion.Text);
                int unidadesProducidas = Convert.ToInt32(txtUnidades.Text);

                if (unidadesProducidas <= 0)
                {
                    MessageBox.Show("El n�mero de unidades debe ser mayor a 0.");
                    return;
                }

                double costoUnitario = (costoMateriaPrima + costoConversion) / unidadesProducidas;
                lblResultado.Text = "Costo unitario por procesos de producci�n: $" + costoUnitario.ToString("F2");

                dtgvProduccion.Rows.Add(costoMateriaPrima, costoConversion, unidadesProducidas, costoUnitario);
                txtMateriaPrima.Clear();
                txtConversion.Clear();
                txtUnidades.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos.");
            }
        }

     

    }

}
  
