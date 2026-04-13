namespace AE.PresentationUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtcontactosLista = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnsalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnbuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnactualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btninsertar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.paneldata = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtcontactosLista)).BeginInit();
            this.paneldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.HintText = "";
            this.txtbuscar.isPassword = false;
            this.txtbuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineThickness = 4;
            this.txtbuscar.Location = new System.Drawing.Point(468, 64);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(175, 35);
            this.txtbuscar.TabIndex = 6;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtcontactosLista
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtcontactosLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtcontactosLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtcontactosLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtcontactosLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcontactosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtcontactosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcontactosLista.DoubleBuffered = true;
            this.dtcontactosLista.EnableHeadersVisualStyles = false;
            this.dtcontactosLista.HeaderBgColor = System.Drawing.Color.White;
            this.dtcontactosLista.HeaderForeColor = System.Drawing.Color.White;
            this.dtcontactosLista.Location = new System.Drawing.Point(0, 46);
            this.dtcontactosLista.Name = "dtcontactosLista";
            this.dtcontactosLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtcontactosLista.RowHeadersWidth = 51;
            this.dtcontactosLista.RowTemplate.Height = 24;
            this.dtcontactosLista.Size = new System.Drawing.Size(461, 405);
            this.dtcontactosLista.TabIndex = 8;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnsalir
            // 
            this.btnsalir.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnsalir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.BorderRadius = 0;
            this.btnsalir.ButtonText = "Salir";
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnsalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsalir.Iconimage = global::AE.PresentationUI.Properties.Resources.exit;
            this.btnsalir.Iconimage_right = null;
            this.btnsalir.Iconimage_right_Selected = null;
            this.btnsalir.Iconimage_Selected = null;
            this.btnsalir.IconMarginLeft = 0;
            this.btnsalir.IconMarginRight = 0;
            this.btnsalir.IconRightVisible = true;
            this.btnsalir.IconRightZoom = 0D;
            this.btnsalir.IconVisible = true;
            this.btnsalir.IconZoom = 70D;
            this.btnsalir.IsTab = false;
            this.btnsalir.Location = new System.Drawing.Point(488, 364);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnsalir.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnsalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsalir.selected = false;
            this.btnsalir.Size = new System.Drawing.Size(145, 47);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.Textcolor = System.Drawing.Color.White;
            this.btnsalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btneliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 0;
            this.btneliminar.ButtonText = "Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = global::AE.PresentationUI.Properties.Resources.delete;
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = global::AE.PresentationUI.Properties.Resources.delete;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 50D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(487, 296);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btneliminar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(145, 47);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnbuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.BorderRadius = 0;
            this.btnbuscar.ButtonText = "Search";
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnbuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnbuscar.Iconimage = null;
            this.btnbuscar.Iconimage_right = global::AE.PresentationUI.Properties.Resources.search;
            this.btnbuscar.Iconimage_right_Selected = null;
            this.btnbuscar.Iconimage_Selected = null;
            this.btnbuscar.IconMarginLeft = 0;
            this.btnbuscar.IconMarginRight = 0;
            this.btnbuscar.IconRightVisible = true;
            this.btnbuscar.IconRightZoom = 0D;
            this.btnbuscar.IconVisible = true;
            this.btnbuscar.IconZoom = 40D;
            this.btnbuscar.IsTab = false;
            this.btnbuscar.Location = new System.Drawing.Point(651, 64);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnbuscar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnbuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnbuscar.selected = false;
            this.btnbuscar.Size = new System.Drawing.Size(114, 35);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Search";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Textcolor = System.Drawing.Color.White;
            this.btnbuscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnactualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactualizar.BorderRadius = 0;
            this.btnactualizar.ButtonText = "Actualizar";
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnactualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnactualizar.Iconimage = global::AE.PresentationUI.Properties.Resources.edit;
            this.btnactualizar.Iconimage_right = null;
            this.btnactualizar.Iconimage_right_Selected = null;
            this.btnactualizar.Iconimage_Selected = null;
            this.btnactualizar.IconMarginLeft = 0;
            this.btnactualizar.IconMarginRight = 0;
            this.btnactualizar.IconRightVisible = true;
            this.btnactualizar.IconRightZoom = 0D;
            this.btnactualizar.IconVisible = true;
            this.btnactualizar.IconZoom = 50D;
            this.btnactualizar.IsTab = false;
            this.btnactualizar.Location = new System.Drawing.Point(487, 153);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnactualizar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnactualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactualizar.selected = false;
            this.btnactualizar.Size = new System.Drawing.Size(145, 46);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Textcolor = System.Drawing.Color.White;
            this.btnactualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btninsertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btninsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btninsertar.BorderRadius = 0;
            this.btninsertar.ButtonText = "Insertar";
            this.btninsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsertar.DisabledColor = System.Drawing.Color.Gray;
            this.btninsertar.Iconcolor = System.Drawing.Color.Transparent;
            this.btninsertar.Iconimage = global::AE.PresentationUI.Properties.Resources.add;
            this.btninsertar.Iconimage_right = null;
            this.btninsertar.Iconimage_right_Selected = null;
            this.btninsertar.Iconimage_Selected = null;
            this.btninsertar.IconMarginLeft = 0;
            this.btninsertar.IconMarginRight = 0;
            this.btninsertar.IconRightVisible = true;
            this.btninsertar.IconRightZoom = 0D;
            this.btninsertar.IconVisible = true;
            this.btninsertar.IconZoom = 50D;
            this.btninsertar.IsTab = false;
            this.btninsertar.Location = new System.Drawing.Point(487, 229);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btninsertar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btninsertar.OnHoverTextColor = System.Drawing.Color.White;
            this.btninsertar.selected = false;
            this.btninsertar.Size = new System.Drawing.Size(145, 47);
            this.btninsertar.TabIndex = 1;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsertar.Textcolor = System.Drawing.Color.White;
            this.btninsertar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // paneldata
            // 
            this.paneldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.paneldata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneldata.BackgroundImage")));
            this.paneldata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneldata.Controls.Add(this.bunifuCustomLabel1);
            this.paneldata.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldata.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.paneldata.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.paneldata.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.paneldata.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.paneldata.Location = new System.Drawing.Point(0, 0);
            this.paneldata.Name = "paneldata";
            this.paneldata.Quality = 10;
            this.paneldata.Size = new System.Drawing.Size(775, 46);
            this.paneldata.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(225, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(353, 34);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "AGENDA ELECTRONICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dtcontactosLista);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.paneldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "AGENDA ELECTRONICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcontactosLista)).EndInit();
            this.paneldata.ResumeLayout(false);
            this.paneldata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel paneldata;
        private Bunifu.Framework.UI.BunifuFlatButton btninsertar;
        private Bunifu.Framework.UI.BunifuFlatButton btnactualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnbuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtcontactosLista;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnsalir;
    }
}

