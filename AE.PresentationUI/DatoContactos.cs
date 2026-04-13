using AE.Application;
using AE.DataAccessLayer;
using AE.Domain;
using AE.Domain.Entities;
using System;
using System.Windows.Forms;
using WinFormsApp = System.Windows.Forms.Application;

namespace AE.PresentationUI
{
    public partial class DatosContacto : Form
    {
        private readonly LogicService _service;
        private readonly bool _isEdit;
        private readonly int _contactId;

        
        public DatosContacto()
        {
            InitializeComponent();

            IContactRepository repo = new ContactRepository();
            _service = new LogicService(repo);

            _isEdit = false;
            _contactId = 0;
        }

        
        public DatosContacto(int contactId)
        {
            InitializeComponent();

            IContactRepository repo = new ContactRepository();
            _service = new LogicService(repo);

            _isEdit = true;
            _contactId = contactId;
        }

        private void CargarCombos()
        {
            cmbxGenero.DataSource = Enum.GetValues(typeof(GenderMF));
            cmbxEstadoCivil.DataSource = Enum.GetValues(typeof(CivilStatus));
        }

        private void CargarDatosParaEditar()
        {
            var c = _service.GetById(_contactId);
            if (c == null)
            {
                MessageBox.Show("No se encontró el contacto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            txtNombre.Text = c.Name;
            txtApellido.Text = c.LastName;
            dateTimePicker1.Value = c.Birthday ?? DateTime.Today;
            txtDireccion.Text = c.Address;
            txtMovil.Text = c.Mobile;
            txtTelefono.Text = c.PhoneNumber;
            txtCorreo.Text = c.Email;

            cmbxGenero.SelectedItem = c.Gender;
            cmbxEstadoCivil.SelectedItem = c.CivilStatusType;
        }

        private void DatosContacto_Load(object sender, EventArgs e)
        {
            CargarCombos();

            if (_isEdit)
                CargarDatosParaEditar();
            else
            {
                cmbxGenero.SelectedIndex = -1;
                cmbxEstadoCivil.SelectedIndex = -1;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Deseas salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                WinFormsApp.Exit();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El apellido es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return;
                }

                if (cmbxGenero.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona un género.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxGenero.Focus();
                    return;
                }

                if (cmbxEstadoCivil.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona un estado civil.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxEstadoCivil.Focus();
                    return;
                }

                Contact c = new Contact
                {
                    Id = _isEdit ? _contactId : 0,
                    Name = txtNombre.Text.Trim(),
                    LastName = txtApellido.Text.Trim(),
                    Birthday = dateTimePicker1.Value.Date,
                    Address = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                    Mobile = string.IsNullOrWhiteSpace(txtMovil.Text) ? null : txtMovil.Text.Trim(),
                    PhoneNumber = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                    Gender = (GenderMF)cmbxGenero.SelectedItem,
                    CivilStatusType = (CivilStatus)cmbxEstadoCivil.SelectedItem
                };

                if (_isEdit)
                    _service.Update(c);
                else
                    _service.Insert(c);

                MessageBox.Show(
                    _isEdit ? "Contacto actualizado correctamente." : "Contacto guardado correctamente.",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}