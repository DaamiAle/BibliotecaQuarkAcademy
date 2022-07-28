namespace Views.src.UI
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSocioRegister = new System.Windows.Forms.TabPage();
            this.label05 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.nuevoSocioCuota = new System.Windows.Forms.TextBox();
            this.nuevoSocioIdentificacion = new System.Windows.Forms.TextBox();
            this.nuevoSocioApellido = new System.Windows.Forms.TextBox();
            this.nuevoSocioNombre = new System.Windows.Forms.TextBox();
            this.nuevoSocioVIP = new System.Windows.Forms.CheckBox();
            this.buttonRegisterSocio = new System.Windows.Forms.Button();
            this.tabLibroRegister = new System.Windows.Forms.TabPage();
            this.buttonRegisterLibro = new System.Windows.Forms.Button();
            this.label06 = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.libroNuevoNombre = new System.Windows.Forms.TextBox();
            this.libroNuevoAutor = new System.Windows.Forms.TextBox();
            this.libroNuevoCodigoISBN = new System.Windows.Forms.TextBox();
            this.tabEjemplarSave = new System.Windows.Forms.TabPage();
            this.buttonSaveEjemplarButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ejemplarNuevoUbicacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ejemplarNuevoNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ejemplarNuevoCodigoISBN = new System.Windows.Forms.TextBox();
            this.label09 = new System.Windows.Forms.Label();
            this.ejemplarNuevoNombreLibro = new System.Windows.Forms.TextBox();
            this.tabPrestamoRegister = new System.Windows.Forms.TabPage();
            this.buttonVerificadorEjemplares = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.prestamoNuevoNumEjemplar = new System.Windows.Forms.TextBox();
            this.buttonRegisterPrestamo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.prestamoNuevoSocioDNI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.prestamoNuevoCodigoISBN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.prestamoNuevoNombreLibro = new System.Windows.Forms.TextBox();
            this.tabDevolverEjemplar = new System.Windows.Forms.TabPage();
            this.buttonRegisterDevolucion = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.devolucionSocioDNI = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.devolucionNumEjemplar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.devolucionCodigoISBN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.devolucionNombreLibro = new System.Windows.Forms.TextBox();
            this.tabPrestamoHistory = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNombreLibro = new System.Windows.Forms.ColumnHeader();
            this.columnCodigoISBN = new System.Windows.Forms.ColumnHeader();
            this.columnEjemplarNum = new System.Windows.Forms.ColumnHeader();
            this.columnNombreSocio = new System.Windows.Forms.ColumnHeader();
            this.columnFechaPrestamo = new System.Windows.Forms.ColumnHeader();
            this.columnEstadoPrestamo = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabSocioRegister.SuspendLayout();
            this.tabLibroRegister.SuspendLayout();
            this.tabEjemplarSave.SuspendLayout();
            this.tabPrestamoRegister.SuspendLayout();
            this.tabDevolverEjemplar.SuspendLayout();
            this.tabPrestamoHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSocioRegister);
            this.tabControl1.Controls.Add(this.tabLibroRegister);
            this.tabControl1.Controls.Add(this.tabEjemplarSave);
            this.tabControl1.Controls.Add(this.tabPrestamoRegister);
            this.tabControl1.Controls.Add(this.tabDevolverEjemplar);
            this.tabControl1.Controls.Add(this.tabPrestamoHistory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSocioRegister
            // 
            this.tabSocioRegister.Controls.Add(this.label05);
            this.tabSocioRegister.Controls.Add(this.label03);
            this.tabSocioRegister.Controls.Add(this.label04);
            this.tabSocioRegister.Controls.Add(this.label02);
            this.tabSocioRegister.Controls.Add(this.label01);
            this.tabSocioRegister.Controls.Add(this.nuevoSocioCuota);
            this.tabSocioRegister.Controls.Add(this.nuevoSocioIdentificacion);
            this.tabSocioRegister.Controls.Add(this.nuevoSocioApellido);
            this.tabSocioRegister.Controls.Add(this.nuevoSocioNombre);
            this.tabSocioRegister.Controls.Add(this.nuevoSocioVIP);
            this.tabSocioRegister.Controls.Add(this.buttonRegisterSocio);
            this.tabSocioRegister.Location = new System.Drawing.Point(4, 24);
            this.tabSocioRegister.Name = "tabSocioRegister";
            this.tabSocioRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabSocioRegister.Size = new System.Drawing.Size(976, 433);
            this.tabSocioRegister.TabIndex = 0;
            this.tabSocioRegister.Text = "Registrar Socio";
            this.tabSocioRegister.UseVisualStyleBackColor = true;
            this.tabSocioRegister.Enter += new System.EventHandler(this.socioRegister_Enter);
            // 
            // label05
            // 
            this.label05.Location = new System.Drawing.Point(16, 175);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(64, 23);
            this.label05.TabIndex = 10;
            this.label05.Text = "Cuota:";
            this.label05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label03
            // 
            this.label03.Location = new System.Drawing.Point(16, 96);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(64, 23);
            this.label03.TabIndex = 9;
            this.label03.Text = "DNI:";
            this.label03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label04
            // 
            this.label04.Location = new System.Drawing.Point(16, 136);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(64, 23);
            this.label04.TabIndex = 8;
            this.label04.Text = "Socio VIP:";
            this.label04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label02
            // 
            this.label02.Location = new System.Drawing.Point(16, 56);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(64, 23);
            this.label02.TabIndex = 7;
            this.label02.Text = "Apellido:";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label01
            // 
            this.label01.Location = new System.Drawing.Point(16, 16);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(64, 23);
            this.label01.TabIndex = 6;
            this.label01.Text = "Nombre:";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuevoSocioCuota
            // 
            this.nuevoSocioCuota.Location = new System.Drawing.Point(96, 176);
            this.nuevoSocioCuota.Name = "nuevoSocioCuota";
            this.nuevoSocioCuota.Size = new System.Drawing.Size(100, 23);
            this.nuevoSocioCuota.TabIndex = 5;
            this.nuevoSocioCuota.TextChanged += new System.EventHandler(this.nuevoSocioCuota_TextChanged);
            // 
            // nuevoSocioIdentificacion
            // 
            this.nuevoSocioIdentificacion.Location = new System.Drawing.Point(96, 96);
            this.nuevoSocioIdentificacion.Name = "nuevoSocioIdentificacion";
            this.nuevoSocioIdentificacion.Size = new System.Drawing.Size(100, 23);
            this.nuevoSocioIdentificacion.TabIndex = 4;
            this.nuevoSocioIdentificacion.TextChanged += new System.EventHandler(this.nuevoSocioIdentificacion_TextChanged);
            // 
            // nuevoSocioApellido
            // 
            this.nuevoSocioApellido.Location = new System.Drawing.Point(96, 56);
            this.nuevoSocioApellido.Name = "nuevoSocioApellido";
            this.nuevoSocioApellido.Size = new System.Drawing.Size(100, 23);
            this.nuevoSocioApellido.TabIndex = 3;
            this.nuevoSocioApellido.TextChanged += new System.EventHandler(this.nuevoSocioApellido_TextChanged);
            // 
            // nuevoSocioNombre
            // 
            this.nuevoSocioNombre.Location = new System.Drawing.Point(96, 16);
            this.nuevoSocioNombre.Name = "nuevoSocioNombre";
            this.nuevoSocioNombre.Size = new System.Drawing.Size(100, 23);
            this.nuevoSocioNombre.TabIndex = 2;
            this.nuevoSocioNombre.TextChanged += new System.EventHandler(this.nuevoSocioNombre_TextChanged);
            // 
            // nuevoSocioVIP
            // 
            this.nuevoSocioVIP.Location = new System.Drawing.Point(96, 136);
            this.nuevoSocioVIP.Name = "nuevoSocioVIP";
            this.nuevoSocioVIP.Size = new System.Drawing.Size(23, 23);
            this.nuevoSocioVIP.TabIndex = 1;
            this.nuevoSocioVIP.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterSocio
            // 
            this.buttonRegisterSocio.Enabled = false;
            this.buttonRegisterSocio.Location = new System.Drawing.Point(16, 256);
            this.buttonRegisterSocio.Name = "buttonRegisterSocio";
            this.buttonRegisterSocio.Size = new System.Drawing.Size(80, 30);
            this.buttonRegisterSocio.TabIndex = 0;
            this.buttonRegisterSocio.Text = "Registrar";
            this.buttonRegisterSocio.UseVisualStyleBackColor = true;
            this.buttonRegisterSocio.Click += new System.EventHandler(this.buttonRegisterSocio_Click);
            // 
            // tabLibroRegister
            // 
            this.tabLibroRegister.Controls.Add(this.buttonRegisterLibro);
            this.tabLibroRegister.Controls.Add(this.label06);
            this.tabLibroRegister.Controls.Add(this.label07);
            this.tabLibroRegister.Controls.Add(this.label08);
            this.tabLibroRegister.Controls.Add(this.libroNuevoNombre);
            this.tabLibroRegister.Controls.Add(this.libroNuevoAutor);
            this.tabLibroRegister.Controls.Add(this.libroNuevoCodigoISBN);
            this.tabLibroRegister.Location = new System.Drawing.Point(4, 24);
            this.tabLibroRegister.Name = "tabLibroRegister";
            this.tabLibroRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibroRegister.Size = new System.Drawing.Size(976, 433);
            this.tabLibroRegister.TabIndex = 1;
            this.tabLibroRegister.Text = "Registrar Libro";
            this.tabLibroRegister.UseVisualStyleBackColor = true;
            this.tabLibroRegister.Enter += new System.EventHandler(this.libroRegister_Enter);
            // 
            // buttonRegisterLibro
            // 
            this.buttonRegisterLibro.Enabled = false;
            this.buttonRegisterLibro.Location = new System.Drawing.Point(16, 256);
            this.buttonRegisterLibro.Name = "buttonRegisterLibro";
            this.buttonRegisterLibro.Size = new System.Drawing.Size(80, 30);
            this.buttonRegisterLibro.TabIndex = 16;
            this.buttonRegisterLibro.Text = "Registrar";
            this.buttonRegisterLibro.UseVisualStyleBackColor = true;
            this.buttonRegisterLibro.Click += new System.EventHandler(this.buttonRegisterLibro_Click);
            // 
            // label06
            // 
            this.label06.Location = new System.Drawing.Point(16, 16);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(64, 23);
            this.label06.TabIndex = 15;
            this.label06.Text = "Nombre:";
            this.label06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label07
            // 
            this.label07.Location = new System.Drawing.Point(16, 56);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(64, 23);
            this.label07.TabIndex = 14;
            this.label07.Text = "Autor:";
            this.label07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label08
            // 
            this.label08.Location = new System.Drawing.Point(16, 96);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(80, 23);
            this.label08.TabIndex = 13;
            this.label08.Text = "Codigo ISBN:";
            this.label08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // libroNuevoNombre
            // 
            this.libroNuevoNombre.Location = new System.Drawing.Point(96, 16);
            this.libroNuevoNombre.Name = "libroNuevoNombre";
            this.libroNuevoNombre.Size = new System.Drawing.Size(100, 23);
            this.libroNuevoNombre.TabIndex = 12;
            this.libroNuevoNombre.TextChanged += new System.EventHandler(this.libroNuevoNombre_TextChanged);
            // 
            // libroNuevoAutor
            // 
            this.libroNuevoAutor.Location = new System.Drawing.Point(96, 56);
            this.libroNuevoAutor.Name = "libroNuevoAutor";
            this.libroNuevoAutor.Size = new System.Drawing.Size(100, 23);
            this.libroNuevoAutor.TabIndex = 11;
            this.libroNuevoAutor.TextChanged += new System.EventHandler(this.libroNuevoAutor_TextChanged);
            // 
            // libroNuevoCodigoISBN
            // 
            this.libroNuevoCodigoISBN.Location = new System.Drawing.Point(96, 96);
            this.libroNuevoCodigoISBN.Name = "libroNuevoCodigoISBN";
            this.libroNuevoCodigoISBN.Size = new System.Drawing.Size(100, 23);
            this.libroNuevoCodigoISBN.TabIndex = 10;
            this.libroNuevoCodigoISBN.TextChanged += new System.EventHandler(this.libroNuevoCodigoISBN_TextChanged);
            // 
            // tabEjemplarSave
            // 
            this.tabEjemplarSave.Controls.Add(this.buttonSaveEjemplarButton);
            this.tabEjemplarSave.Controls.Add(this.label12);
            this.tabEjemplarSave.Controls.Add(this.ejemplarNuevoUbicacion);
            this.tabEjemplarSave.Controls.Add(this.label11);
            this.tabEjemplarSave.Controls.Add(this.ejemplarNuevoNumero);
            this.tabEjemplarSave.Controls.Add(this.label10);
            this.tabEjemplarSave.Controls.Add(this.ejemplarNuevoCodigoISBN);
            this.tabEjemplarSave.Controls.Add(this.label09);
            this.tabEjemplarSave.Controls.Add(this.ejemplarNuevoNombreLibro);
            this.tabEjemplarSave.Location = new System.Drawing.Point(4, 24);
            this.tabEjemplarSave.Name = "tabEjemplarSave";
            this.tabEjemplarSave.Padding = new System.Windows.Forms.Padding(3);
            this.tabEjemplarSave.Size = new System.Drawing.Size(976, 433);
            this.tabEjemplarSave.TabIndex = 2;
            this.tabEjemplarSave.Text = "Guardar Ejemplar";
            this.tabEjemplarSave.UseVisualStyleBackColor = true;
            this.tabEjemplarSave.Enter += new System.EventHandler(this.ejemplarSave_Enter);
            // 
            // buttonSaveEjemplarButton
            // 
            this.buttonSaveEjemplarButton.Enabled = false;
            this.buttonSaveEjemplarButton.Location = new System.Drawing.Point(16, 256);
            this.buttonSaveEjemplarButton.Name = "buttonSaveEjemplarButton";
            this.buttonSaveEjemplarButton.Size = new System.Drawing.Size(80, 30);
            this.buttonSaveEjemplarButton.TabIndex = 24;
            this.buttonSaveEjemplarButton.Text = "Guardar";
            this.buttonSaveEjemplarButton.UseVisualStyleBackColor = true;
            this.buttonSaveEjemplarButton.Click += new System.EventHandler(this.buttonSaveEjemplarButton_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ubicacion:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ejemplarNuevoUbicacion
            // 
            this.ejemplarNuevoUbicacion.Location = new System.Drawing.Point(96, 136);
            this.ejemplarNuevoUbicacion.Name = "ejemplarNuevoUbicacion";
            this.ejemplarNuevoUbicacion.Size = new System.Drawing.Size(100, 23);
            this.ejemplarNuevoUbicacion.TabIndex = 22;
            this.ejemplarNuevoUbicacion.TextChanged += new System.EventHandler(this.ejemplarNuevoUbicacion_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ejemplar N°:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ejemplarNuevoNumero
            // 
            this.ejemplarNuevoNumero.Location = new System.Drawing.Point(96, 96);
            this.ejemplarNuevoNumero.Name = "ejemplarNuevoNumero";
            this.ejemplarNuevoNumero.Size = new System.Drawing.Size(100, 23);
            this.ejemplarNuevoNumero.TabIndex = 20;
            this.ejemplarNuevoNumero.TextChanged += new System.EventHandler(this.ejemplarNuevoNumero_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Codigo ISBN:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ejemplarNuevoCodigoISBN
            // 
            this.ejemplarNuevoCodigoISBN.Location = new System.Drawing.Point(96, 56);
            this.ejemplarNuevoCodigoISBN.Name = "ejemplarNuevoCodigoISBN";
            this.ejemplarNuevoCodigoISBN.Size = new System.Drawing.Size(100, 23);
            this.ejemplarNuevoCodigoISBN.TabIndex = 18;
            this.ejemplarNuevoCodigoISBN.TextChanged += new System.EventHandler(this.ejemplarNuevoCodigoISBN_TextChanged);
            // 
            // label09
            // 
            this.label09.Location = new System.Drawing.Point(16, 16);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(64, 23);
            this.label09.TabIndex = 17;
            this.label09.Text = "Nombre:";
            this.label09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ejemplarNuevoNombreLibro
            // 
            this.ejemplarNuevoNombreLibro.Location = new System.Drawing.Point(96, 16);
            this.ejemplarNuevoNombreLibro.Name = "ejemplarNuevoNombreLibro";
            this.ejemplarNuevoNombreLibro.Size = new System.Drawing.Size(100, 23);
            this.ejemplarNuevoNombreLibro.TabIndex = 16;
            this.ejemplarNuevoNombreLibro.TextChanged += new System.EventHandler(this.ejemplarNuevoNombreLibro_TextChanged);
            // 
            // tabPrestamoRegister
            // 
            this.tabPrestamoRegister.Controls.Add(this.buttonVerificadorEjemplares);
            this.tabPrestamoRegister.Controls.Add(this.label15);
            this.tabPrestamoRegister.Controls.Add(this.prestamoNuevoNumEjemplar);
            this.tabPrestamoRegister.Controls.Add(this.buttonRegisterPrestamo);
            this.tabPrestamoRegister.Controls.Add(this.label16);
            this.tabPrestamoRegister.Controls.Add(this.prestamoNuevoSocioDNI);
            this.tabPrestamoRegister.Controls.Add(this.label14);
            this.tabPrestamoRegister.Controls.Add(this.prestamoNuevoCodigoISBN);
            this.tabPrestamoRegister.Controls.Add(this.label13);
            this.tabPrestamoRegister.Controls.Add(this.prestamoNuevoNombreLibro);
            this.tabPrestamoRegister.Location = new System.Drawing.Point(4, 24);
            this.tabPrestamoRegister.Name = "tabPrestamoRegister";
            this.tabPrestamoRegister.Size = new System.Drawing.Size(976, 433);
            this.tabPrestamoRegister.TabIndex = 4;
            this.tabPrestamoRegister.Text = "Registrar Prestamo";
            this.tabPrestamoRegister.UseVisualStyleBackColor = true;
            this.tabPrestamoRegister.Enter += new System.EventHandler(this.prestamoRegister_Enter);
            // 
            // buttonVerificadorEjemplares
            // 
            this.buttonVerificadorEjemplares.Enabled = false;
            this.buttonVerificadorEjemplares.Location = new System.Drawing.Point(256, 16);
            this.buttonVerificadorEjemplares.Name = "buttonVerificadorEjemplares";
            this.buttonVerificadorEjemplares.Size = new System.Drawing.Size(96, 63);
            this.buttonVerificadorEjemplares.TabIndex = 28;
            this.buttonVerificadorEjemplares.Text = "Verificar\r\nDisponibilidad\r\nde Ejemplares";
            this.buttonVerificadorEjemplares.UseVisualStyleBackColor = true;
            this.buttonVerificadorEjemplares.Click += new System.EventHandler(this.buttonVerificadorEjemplares_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(16, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Ejemplar N°:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prestamoNuevoNumEjemplar
            // 
            this.prestamoNuevoNumEjemplar.Location = new System.Drawing.Point(96, 96);
            this.prestamoNuevoNumEjemplar.Name = "prestamoNuevoNumEjemplar";
            this.prestamoNuevoNumEjemplar.Size = new System.Drawing.Size(100, 23);
            this.prestamoNuevoNumEjemplar.TabIndex = 26;
            this.prestamoNuevoNumEjemplar.TextChanged += new System.EventHandler(this.prestamoNuevoNumEjemplar_TextChanged);
            // 
            // buttonRegisterPrestamo
            // 
            this.buttonRegisterPrestamo.Enabled = false;
            this.buttonRegisterPrestamo.Location = new System.Drawing.Point(16, 256);
            this.buttonRegisterPrestamo.Name = "buttonRegisterPrestamo";
            this.buttonRegisterPrestamo.Size = new System.Drawing.Size(80, 30);
            this.buttonRegisterPrestamo.TabIndex = 24;
            this.buttonRegisterPrestamo.Text = "Registrar";
            this.buttonRegisterPrestamo.UseVisualStyleBackColor = true;
            this.buttonRegisterPrestamo.Click += new System.EventHandler(this.buttonRegisterPrestamo_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(16, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 23);
            this.label16.TabIndex = 23;
            this.label16.Text = "DNI Socio:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prestamoNuevoSocioDNI
            // 
            this.prestamoNuevoSocioDNI.Location = new System.Drawing.Point(96, 136);
            this.prestamoNuevoSocioDNI.Name = "prestamoNuevoSocioDNI";
            this.prestamoNuevoSocioDNI.Size = new System.Drawing.Size(100, 23);
            this.prestamoNuevoSocioDNI.TabIndex = 22;
            this.prestamoNuevoSocioDNI.TextChanged += new System.EventHandler(this.prestamoNuevoSocioDNI_TextChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(16, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Codigo ISBN:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prestamoNuevoCodigoISBN
            // 
            this.prestamoNuevoCodigoISBN.Location = new System.Drawing.Point(96, 56);
            this.prestamoNuevoCodigoISBN.Name = "prestamoNuevoCodigoISBN";
            this.prestamoNuevoCodigoISBN.Size = new System.Drawing.Size(100, 23);
            this.prestamoNuevoCodigoISBN.TabIndex = 20;
            this.prestamoNuevoCodigoISBN.TextChanged += new System.EventHandler(this.prestamoNuevoCodigoISBN_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Libro:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prestamoNuevoNombreLibro
            // 
            this.prestamoNuevoNombreLibro.Location = new System.Drawing.Point(96, 16);
            this.prestamoNuevoNombreLibro.Name = "prestamoNuevoNombreLibro";
            this.prestamoNuevoNombreLibro.Size = new System.Drawing.Size(100, 23);
            this.prestamoNuevoNombreLibro.TabIndex = 18;
            this.prestamoNuevoNombreLibro.TextChanged += new System.EventHandler(this.prestamoNuevoNombreLibro_TextChanged);
            // 
            // tabDevolverEjemplar
            // 
            this.tabDevolverEjemplar.Controls.Add(this.buttonRegisterDevolucion);
            this.tabDevolverEjemplar.Controls.Add(this.label20);
            this.tabDevolverEjemplar.Controls.Add(this.devolucionSocioDNI);
            this.tabDevolverEjemplar.Controls.Add(this.label19);
            this.tabDevolverEjemplar.Controls.Add(this.devolucionNumEjemplar);
            this.tabDevolverEjemplar.Controls.Add(this.label18);
            this.tabDevolverEjemplar.Controls.Add(this.devolucionCodigoISBN);
            this.tabDevolverEjemplar.Controls.Add(this.label17);
            this.tabDevolverEjemplar.Controls.Add(this.devolucionNombreLibro);
            this.tabDevolverEjemplar.Location = new System.Drawing.Point(4, 24);
            this.tabDevolverEjemplar.Name = "tabDevolverEjemplar";
            this.tabDevolverEjemplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevolverEjemplar.Size = new System.Drawing.Size(976, 433);
            this.tabDevolverEjemplar.TabIndex = 5;
            this.tabDevolverEjemplar.Text = "Devolver Libro";
            this.tabDevolverEjemplar.UseVisualStyleBackColor = true;
            this.tabDevolverEjemplar.Enter += new System.EventHandler(this.devolverEjemplar_Enter);
            // 
            // buttonRegisterDevolucion
            // 
            this.buttonRegisterDevolucion.Enabled = false;
            this.buttonRegisterDevolucion.Location = new System.Drawing.Point(16, 256);
            this.buttonRegisterDevolucion.Name = "buttonRegisterDevolucion";
            this.buttonRegisterDevolucion.Size = new System.Drawing.Size(80, 30);
            this.buttonRegisterDevolucion.TabIndex = 28;
            this.buttonRegisterDevolucion.Text = "Devolver";
            this.buttonRegisterDevolucion.UseVisualStyleBackColor = true;
            this.buttonRegisterDevolucion.Click += new System.EventHandler(this.buttonRegisterDevolucion_Click);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(16, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 23);
            this.label20.TabIndex = 27;
            this.label20.Text = "DNI Socio:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devolucionSocioDNI
            // 
            this.devolucionSocioDNI.Location = new System.Drawing.Point(96, 136);
            this.devolucionSocioDNI.Name = "devolucionSocioDNI";
            this.devolucionSocioDNI.Size = new System.Drawing.Size(100, 23);
            this.devolucionSocioDNI.TabIndex = 26;
            this.devolucionSocioDNI.TextChanged += new System.EventHandler(this.devolucionSocioDNI_TextChanged);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(16, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 23);
            this.label19.TabIndex = 25;
            this.label19.Text = "Ejemplar N°:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devolucionNumEjemplar
            // 
            this.devolucionNumEjemplar.Location = new System.Drawing.Point(96, 96);
            this.devolucionNumEjemplar.Name = "devolucionNumEjemplar";
            this.devolucionNumEjemplar.Size = new System.Drawing.Size(100, 23);
            this.devolucionNumEjemplar.TabIndex = 24;
            this.devolucionNumEjemplar.TextChanged += new System.EventHandler(this.devolucionNumEjemplar_TextChanged);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(16, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Codigo ISBN:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devolucionCodigoISBN
            // 
            this.devolucionCodigoISBN.Location = new System.Drawing.Point(96, 56);
            this.devolucionCodigoISBN.Name = "devolucionCodigoISBN";
            this.devolucionCodigoISBN.Size = new System.Drawing.Size(100, 23);
            this.devolucionCodigoISBN.TabIndex = 22;
            this.devolucionCodigoISBN.TextChanged += new System.EventHandler(this.devolucionCodigoISBN_TextChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(16, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "Libro:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devolucionNombreLibro
            // 
            this.devolucionNombreLibro.Location = new System.Drawing.Point(96, 16);
            this.devolucionNombreLibro.Name = "devolucionNombreLibro";
            this.devolucionNombreLibro.Size = new System.Drawing.Size(100, 23);
            this.devolucionNombreLibro.TabIndex = 20;
            this.devolucionNombreLibro.TextChanged += new System.EventHandler(this.devolucionNombreLibro_TextChanged);
            // 
            // tabPrestamoHistory
            // 
            this.tabPrestamoHistory.Controls.Add(this.listView1);
            this.tabPrestamoHistory.Location = new System.Drawing.Point(4, 24);
            this.tabPrestamoHistory.Name = "tabPrestamoHistory";
            this.tabPrestamoHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamoHistory.Size = new System.Drawing.Size(976, 433);
            this.tabPrestamoHistory.TabIndex = 3;
            this.tabPrestamoHistory.Text = "Historial Prestamos";
            this.tabPrestamoHistory.UseVisualStyleBackColor = true;
            this.tabPrestamoHistory.Enter += new System.EventHandler(this.prestamoHistory_Enter);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombreLibro,
            this.columnCodigoISBN,
            this.columnEjemplarNum,
            this.columnNombreSocio,
            this.columnFechaPrestamo,
            this.columnEstadoPrestamo});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(970, 427);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnNombreLibro
            // 
            this.columnNombreLibro.Text = "Libro";
            this.columnNombreLibro.Width = 256;
            // 
            // columnCodigoISBN
            // 
            this.columnCodigoISBN.Text = "Codigo ISBN";
            this.columnCodigoISBN.Width = 96;
            // 
            // columnEjemplarNum
            // 
            this.columnEjemplarNum.Text = "Ejemplar";
            this.columnEjemplarNum.Width = 72;
            // 
            // columnNombreSocio
            // 
            this.columnNombreSocio.Text = "Socio";
            this.columnNombreSocio.Width = 256;
            // 
            // columnFechaPrestamo
            // 
            this.columnFechaPrestamo.Text = "Fecha";
            this.columnFechaPrestamo.Width = 128;
            // 
            // columnEstadoPrestamo
            // 
            this.columnEstadoPrestamo.Text = "Estado";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPage";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSocioRegister.ResumeLayout(false);
            this.tabSocioRegister.PerformLayout();
            this.tabLibroRegister.ResumeLayout(false);
            this.tabLibroRegister.PerformLayout();
            this.tabEjemplarSave.ResumeLayout(false);
            this.tabEjemplarSave.PerformLayout();
            this.tabPrestamoRegister.ResumeLayout(false);
            this.tabPrestamoRegister.PerformLayout();
            this.tabDevolverEjemplar.ResumeLayout(false);
            this.tabDevolverEjemplar.PerformLayout();
            this.tabPrestamoHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabSocioRegister;
        private TabPage tabLibroRegister;
        private TabPage tabEjemplarSave;
        private TabPage tabPrestamoRegister;
        private TabPage tabPrestamoHistory;
        private ListView listView1;
        private ColumnHeader columnNombreLibro;
        private ColumnHeader columnCodigoISBN;
        private ColumnHeader columnEjemplarNum;
        private ColumnHeader columnNombreSocio;
        private ColumnHeader columnFechaPrestamo;
        private ColumnHeader columnEstadoPrestamo;
        private Button buttonRegisterSocio;
        private TabPage tabDevolverEjemplar;
        private TextBox nuevoSocioIdentificacion;
        private TextBox nuevoSocioApellido;
        private TextBox nuevoSocioNombre;
        private CheckBox nuevoSocioVIP;
        private Label label02;
        private Label label01;
        private TextBox nuevoSocioCuota;
        private Label label05;
        private Label label03;
        private Label label04;
        private Label label06;
        private Label label07;
        private Label label08;
        private TextBox libroNuevoNombre;
        private TextBox libroNuevoAutor;
        private TextBox libroNuevoCodigoISBN;
        private Button buttonRegisterLibro;
        private Label label12;
        private TextBox ejemplarNuevoUbicacion;
        private Label label11;
        private TextBox ejemplarNuevoNumero;
        private Label label10;
        private TextBox ejemplarNuevoCodigoISBN;
        private Label label09;
        private TextBox ejemplarNuevoNombreLibro;
        private Button buttonSaveEjemplarButton;
        private Label label16;
        private TextBox prestamoNuevoSocioDNI;
        private Label label14;
        private TextBox prestamoNuevoCodigoISBN;
        private Label label13;
        private TextBox prestamoNuevoNombreLibro;
        private Button buttonRegisterPrestamo;
        private Label label20;
        private TextBox devolucionSocioDNI;
        private Label label19;
        private TextBox devolucionNumEjemplar;
        private Label label18;
        private TextBox devolucionCodigoISBN;
        private Label label17;
        private TextBox devolucionNombreLibro;
        private Button buttonRegisterDevolucion;
        private Label label15;
        private TextBox prestamoNuevoNumEjemplar;
        private Button buttonVerificadorEjemplares;
    }
}