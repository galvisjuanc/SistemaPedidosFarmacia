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
                direccion += "Calle 7 # 14-14 y para la situada en Carrera 123 # 80-13";
            }
            else if (principal)
            {
                direccion += "Calle 7 # 14-14";
            }
            else if (secundaria)
            {
                direccion += "Carrera 123 # 80-13";
            }

            lblDireccion.Text = direccion;
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
