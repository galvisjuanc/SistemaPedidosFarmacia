using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaPedidosFarmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";

            cmbTipo.SelectedIndex = -1;

            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
            rbCemefar.Checked = false;

            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;

            txtNombre.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 1. Validar Nombre del medicamento (Alfanumérico y no vacío)
            string nombreMedicamento = txtNombre.Text.Trim();
            // La expresión regular "^[a-zA-Z0-9 ]+$" permite letras, números y espacios.
            if (string.IsNullOrEmpty(nombreMedicamento) || !Regex.IsMatch(nombreMedicamento, "^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Por favor, ingrese un nombre de medicamento válido (solo letras y números).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar Tipo de medicamento (Que se haya seleccionado algo en el ComboBox)
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de medicamento.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar Cantidad (Número entero positivo)
            // int.TryParse intenta convertir el texto a número. Si puede, lo guarda en 'cantidad'.
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validar Distribuidor (Al menos un RadioButton seleccionado)
            if (!rbCofarma.Checked && !rbEmpsephar.Checked && !rbCemefar.Checked)
            {
                MessageBox.Show("Debe seleccionar un distribuidor farmacéutico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Validar Sucursal (Al menos un CheckBox seleccionado)
            if (!chkPrincipal.Checked && !chkSecundaria.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos una sucursal para el envío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- SI LLEGAMOS HASTA AQUÍ, TODOS LOS DATOS SON CORRECTOS ---

            // Aquí es donde recopilaremos los datos para pasarlos a la siguiente ventana
            string tipoSeleccionado = cmbTipo.SelectedItem.ToString();

            string distribuidor = "";
            if (rbCofarma.Checked) distribuidor = "Cofarma";
            else if (rbEmpsephar.Checked) distribuidor = "Empsephar";
            else if (rbCemefar.Checked) distribuidor = "Cemefar";

            bool envioPrincipal = chkPrincipal.Checked;
            bool envioSecundaria = chkSecundaria.Checked;

            // Próximo paso: Instanciar el FormResumen y enviarle estas variables
            //MessageBox.Show("¡Todos los datos son correctos! Listo para abrir el resumen.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // EL CAMBIO ESTÁ AQUÍ:
            // Instanciamos el segundo formulario enviándole las variables
            FormResumen ventanaResumen = new FormResumen(cantidad, tipoSeleccionado, nombreMedicamento, distribuidor, envioPrincipal, envioSecundaria);

            // Mostramos la ventana como un diálogo (impide usar Form1 hasta que se cierre FormResumen)
            ventanaResumen.ShowDialog();

            btnBorrar_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Llenamos las opciones del menú desplegable
            cmbTipo.Items.Add("Analgésico");
            cmbTipo.Items.Add("Analéptico");
            cmbTipo.Items.Add("Anestésico");
            cmbTipo.Items.Add("Antiácido");
            cmbTipo.Items.Add("Antidepresivo");
            cmbTipo.Items.Add("Antibiótico");

            // 2. Bloqueamos el ComboBox para que no se pueda escribir texto libre en él
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Evaluamos la tecla presionada. 
            // char.IsControl permite usar borrar (Backspace).
            // char.IsDigit permite los números del 0 al 9.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla NO es control y NO es un dígito, cancelamos el evento.
                // Es como decirle al teclado: "Ignora esta tecla, no la escribas".
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // char.IsLetter permite letras (a-z, A-Z)
            // char.IsDigit permite números (0-9)
            // char.IsControl permite usar borrar (Backspace)
            // char.IsSeparator permite la barra espaciadora
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                // Bloqueamos cualquier símbolo especial
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
