namespace FrmAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //validar campos obligatorios(opcional pero recomendable)
            if (txtID.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor complete los campos obligatorios: ID, Nombre y Telefono.");
                return;

            }
            // determinar el genero seleccionado
            string genero = "";
            if (rdbMASCULINO.Checked)
                genero = "Masculino";
            else if (rdbFEMENINO.Checked)
                genero = "Femenino";
            //agregar la fila al datagridView
            dtgAgenda.Rows.Add(
                txtID.Text,
                txtNombre.Text,
                txtApellido.Text,
               txtTelefono.Text,
                txtCorreoelectronico.Text,
                txtDireccion.Text,
                genero
                );
            //limpiar los campos despues de agregar
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreoelectronico.Clear();
            txtDireccion.Clear();
            txtobservaciones.Clear();
            rdbMASCULINO.Checked = false;
            rdbFEMENINO.Checked = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgAgenda.SelectedRows.Count > 0)
            {
                //confirmar eliminacion
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar este registro?",
                    "confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    //elimina la fila seleccionada
                    dtgAgenda.Rows.RemoveAt(dtgAgenda.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("por favor seleccione un registro para eliminar.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
