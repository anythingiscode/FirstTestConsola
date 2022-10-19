namespace EjWinFrmDataGrid
{
    public partial class frmDGV : Form
    {
        public frmDGV()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add(txtNombre.Text,txtApellidos.Text ,nudEdad.Value );  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow.Index != -1)
            {
                //dgvPersonas.Rows.RemoveAt(dgvPersonas.CurrentCell.RowIndex);
                dgvPersonas.Rows.RemoveAt(dgvPersonas.CurrentRow.Index);
            }
        }
    }
}