using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ConexionBD bd;
        public Form1()
        {
            InitializeComponent();
            bd = new ConexionBD();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Trabajador t = new Trabajador();
                t.Cuil = Convert.ToInt32(txtCuil.Text);
                t.Nombre = txtNombre.Text;
                t.Apellido = txtApellido.Text;
                t.Puesto = Convert.ToInt32(cboPuesto.SelectedValue);
                t.CantidadHijos = Convert.ToInt32(txtCantHijos.Text);
                t.SueldoXhora = Convert.ToDouble(txtImpxhs.Text);
                t.Sueldo = t.SueldoXhora * (Convert.ToInt32(txtHs.Text)) + (t.CantidadHijos * 150);

                if(chkCasado.Checked == true)
                {
                   t.Sueldo += t.Sueldo * 0.05;
                }
                else
                {
                    t.Sueldo = t.Sueldo;
                }

                txtImpxHijo.Text = Convert.ToString( t.CantidadHijos * 150);

                string consulta = "insert into trabajadores values(@cuil , @nombre ,@apellido , @sueldo_hora , @id_puesto,@cant_hijos , @sueldo) ";

                if(bd.modificarBD(consulta , t) == 1)
                {
                    lstSueldos.Items.Add(t.ToString());
                }
                else
                {
                    MessageBox.Show("no se pudo registrar , intente nuevamente");
                }
                    
                
            }
            else
            {
                MessageBox.Show("VALIDAR CAMPOS", "ATENCION");
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo(cboPuesto, "puestos");

            txtNombre.Text = string.Empty;
            txtHs.Text = "(en el mes)";
            txtApellido.Text = string.Empty;
            txtCantHijos.Text = "0";
            cboPuesto.Text = "(su puesto)";
        }

        private void cargarCombo(ComboBox cboPuesto, string tabla)
        {
            DataTable dt = bd.consutartabla(tabla);
            cboPuesto.DataSource = dt;
            cboPuesto.ValueMember= dt.Columns[0].ColumnName;
            cboPuesto.DisplayMember = dt.Columns[1].ColumnName;

        }

        public bool validar()
        {
            bool validado = true;
            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                validado = false;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("DEBE INGRESAR UN APELLIDO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                validado = false;
            }
            if (string.IsNullOrEmpty(txtCuil.Text)){
                MessageBox.Show("DEBE INGRESAR SU CUIL", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuil.Focus();
                validado = false;
            }
            if (string.IsNullOrEmpty(txtHs.Text))
            {
                MessageBox.Show("DEBE INGRESAR LA CANTIDAD DE HORAS TRABAJADAS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHs.Focus();
                validado = false;
            }
            if(cboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR AU PUESTO DE TRABAJO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPuesto.Focus();
                validado = false;
            }
            return validado;


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtImpxHijo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtImpxhs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int puesto = cboPuesto.SelectedIndex;

            if (puesto == 0) { txtImpxhs.Text = Convert.ToString(150); }
            else if(puesto == 1) { txtImpxhs.Text = Convert.ToString(200); }
            else if(puesto == 2) { txtImpxhs.Text = Convert.ToString(250); }
            else if (puesto == 3) { txtImpxhs.Text = Convert.ToString(400); }
        }

        private void txtCantHijos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCantHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito (0-9) o la tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un dígito o la tecla de borrar, cancelar el evento para evitar que se ingrese el carácter no válido.
                e.Handled = true;
            }
        }

        public void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtHs.Text = "(introduzca las horas trabajadas en el mes)";
            txtApellido.Text = string.Empty;
            txtCantHijos.Text = "(introduzca la cantidad de hijos)";
            cboPuesto.Text = "(seleccione su puesto)";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           limpiar();
        }
    }
}
