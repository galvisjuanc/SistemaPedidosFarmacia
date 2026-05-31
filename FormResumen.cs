using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPedidosFarmacia
{
    public partial class FormResumen : Form
    {
        public FormResumen(int cantidad, string tipo, string nombre, string distribuidor, bool principal, bool secundaria)
        {
            InitializeComponent();

            // 1. Título de la ventana
            this.Text = $"Pedido al distribuidor {distribuidor}";

            // 2. Texto con el medicamento
            lblMedicamento.Text = $"{cantidad} unidades del {tipo} {nombre}";

            // 3. Texto con la dirección
            string direccion = "Para la farmacia situada en ";

            if (principal && secundaria)
            {
                direccion += "Calle de la Rosa n. 28 y para la situada en Calle Alcazabilla n. 3";
            }
            else if (principal)
            {
                direccion += "Calle de la Rosa n. 28";
            }
            else if (secundaria)
            {
                direccion += "Calle Alcazabilla n. 3";
            }

            lblDireccion.Text = direccion;
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra la ventana de resumen sin hacer nada más
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Muestra el mensaje final y luego cierra la ventana
            MessageBox.Show("Pedido enviado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
