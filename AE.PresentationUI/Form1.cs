using AE.Application;
using WinFormsApp = System.Windows.Forms.Application;
using AE.DataAccessLayer;
using AE.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AE.PresentationUI
{
    public partial class Form1 : Form
    {
        private readonly LogicService _service;
        public Form1()
        {
            InitializeComponent();

            IContactRepository repo = new ContactRepository();
            _service = new LogicService(repo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarContactos();

        }

        private void CargarContactos()
        {
            dtcontactosLista.DataSource = null;
            dtcontactosLista.DataSource = _service.GetAll();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Deseas salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                WinFormsApp.Exit();
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            using (DatosContacto insertarcontacto = new DatosContacto())
            {
                insertarcontacto.ShowDialog();
                CargarContactos();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtcontactosLista.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un contacto para actualizar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dtcontactosLista.CurrentRow.Cells["Id"].Value);

            using (DatosContacto actualizarcontacto = new DatosContacto(id))
            {
                if (actualizarcontacto.ShowDialog() == DialogResult.OK)
                    CargarContactos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtbuscar.Text.Trim();

                
                if (string.IsNullOrWhiteSpace(texto))
                {
                    CargarContactos();
                    return;
                }

                var lista = _service.Search(texto);

                dtcontactosLista.DataSource = null;
                dtcontactosLista.DataSource = lista;

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron contactos.",
                        "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dtcontactosLista.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un contacto para eliminar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                int id = Convert.ToInt32(dtcontactosLista.CurrentRow.Cells["Id"].Value);

                
                var confirm = MessageBox.Show(
                    "¿Está seguro que desea eliminar este contacto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                
                bool eliminado = _service.Delete(id);

                if (eliminado)
                {
                    MessageBox.Show("Contacto eliminado correctamente.",
                        "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContactos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el contacto.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
