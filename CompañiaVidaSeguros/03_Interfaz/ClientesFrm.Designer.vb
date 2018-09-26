<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        Me.rbtnQuinceMillones = New System.Windows.Forms.RadioButton()
        Me.rbtnDiezMillones = New System.Windows.Forms.RadioButton()
        Me.rbtnCincoMillones = New System.Windows.Forms.RadioButton()
        Me.dtpFechaInicioSeguro = New System.Windows.Forms.DateTimePicker()
        Me.cmbxProvinciaCanton = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtMensualidad = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblMensualidad = New System.Windows.Forms.Label()
        Me.lblFechaInicioSeguro = New System.Windows.Forms.Label()
        Me.lblCoberturaSeguro = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblProvinciaCanton = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardarDatosEnArchivo = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 248)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(936, 270)
        Me.dgvClientes.TabIndex = 0
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(798, 11)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(128, 45)
        Me.btnGenerarXML.TabIndex = 1
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'rbtnQuinceMillones
        '
        Me.rbtnQuinceMillones.AutoSize = True
        Me.rbtnQuinceMillones.Location = New System.Drawing.Point(542, 143)
        Me.rbtnQuinceMillones.Name = "rbtnQuinceMillones"
        Me.rbtnQuinceMillones.Size = New System.Drawing.Size(73, 17)
        Me.rbtnQuinceMillones.TabIndex = 48
        Me.rbtnQuinceMillones.TabStop = True
        Me.rbtnQuinceMillones.Text = "15000000"
        Me.rbtnQuinceMillones.UseVisualStyleBackColor = True
        '
        'rbtnDiezMillones
        '
        Me.rbtnDiezMillones.AutoSize = True
        Me.rbtnDiezMillones.Location = New System.Drawing.Point(457, 143)
        Me.rbtnDiezMillones.Name = "rbtnDiezMillones"
        Me.rbtnDiezMillones.Size = New System.Drawing.Size(73, 17)
        Me.rbtnDiezMillones.TabIndex = 47
        Me.rbtnDiezMillones.TabStop = True
        Me.rbtnDiezMillones.Text = "10000000"
        Me.rbtnDiezMillones.UseVisualStyleBackColor = True
        '
        'rbtnCincoMillones
        '
        Me.rbtnCincoMillones.AutoSize = True
        Me.rbtnCincoMillones.Location = New System.Drawing.Point(378, 143)
        Me.rbtnCincoMillones.Name = "rbtnCincoMillones"
        Me.rbtnCincoMillones.Size = New System.Drawing.Size(67, 17)
        Me.rbtnCincoMillones.TabIndex = 46
        Me.rbtnCincoMillones.TabStop = True
        Me.rbtnCincoMillones.Text = "5000000"
        Me.rbtnCincoMillones.UseVisualStyleBackColor = True
        '
        'dtpFechaInicioSeguro
        '
        Me.dtpFechaInicioSeguro.Location = New System.Drawing.Point(119, 181)
        Me.dtpFechaInicioSeguro.Name = "dtpFechaInicioSeguro"
        Me.dtpFechaInicioSeguro.Size = New System.Drawing.Size(203, 20)
        Me.dtpFechaInicioSeguro.TabIndex = 45
        '
        'cmbxProvinciaCanton
        '
        Me.cmbxProvinciaCanton.FormattingEnabled = True
        Me.cmbxProvinciaCanton.Location = New System.Drawing.Point(397, 102)
        Me.cmbxProvinciaCanton.Name = "cmbxProvinciaCanton"
        Me.cmbxProvinciaCanton.Size = New System.Drawing.Size(200, 21)
        Me.cmbxProvinciaCanton.TabIndex = 44
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(397, 62)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNacimiento.TabIndex = 43
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(66, 145)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(185, 20)
        Me.txtEmail.TabIndex = 42
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(91, 103)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(160, 20)
        Me.txtNacionalidad.TabIndex = 41
        '
        'txtMensualidad
        '
        Me.txtMensualidad.Enabled = False
        Me.txtMensualidad.Location = New System.Drawing.Point(408, 181)
        Me.txtMensualidad.Name = "txtMensualidad"
        Me.txtMensualidad.Size = New System.Drawing.Size(189, 20)
        Me.txtMensualidad.TabIndex = 40
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(334, 17)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(189, 20)
        Me.txtApellido.TabIndex = 39
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(66, 56)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(185, 20)
        Me.txtCedula.TabIndex = 38
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 37
        '
        'lblMensualidad
        '
        Me.lblMensualidad.AutoSize = True
        Me.lblMensualidad.Location = New System.Drawing.Point(331, 185)
        Me.lblMensualidad.Name = "lblMensualidad"
        Me.lblMensualidad.Size = New System.Drawing.Size(70, 13)
        Me.lblMensualidad.TabIndex = 36
        Me.lblMensualidad.Text = "Mensualidad:"
        '
        'lblFechaInicioSeguro
        '
        Me.lblFechaInicioSeguro.AutoSize = True
        Me.lblFechaInicioSeguro.Location = New System.Drawing.Point(11, 185)
        Me.lblFechaInicioSeguro.Name = "lblFechaInicioSeguro"
        Me.lblFechaInicioSeguro.Size = New System.Drawing.Size(102, 13)
        Me.lblFechaInicioSeguro.TabIndex = 35
        Me.lblFechaInicioSeguro.Text = "Fecha inicio seguro:"
        '
        'lblCoberturaSeguro
        '
        Me.lblCoberturaSeguro.AutoSize = True
        Me.lblCoberturaSeguro.Location = New System.Drawing.Point(264, 145)
        Me.lblCoberturaSeguro.Name = "lblCoberturaSeguro"
        Me.lblCoberturaSeguro.Size = New System.Drawing.Size(108, 13)
        Me.lblCoberturaSeguro.TabIndex = 34
        Me.lblCoberturaSeguro.Text = "Cobertura seguro: (₡)"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(13, 145)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email:"
        '
        'lblProvinciaCanton
        '
        Me.lblProvinciaCanton.AutoSize = True
        Me.lblProvinciaCanton.Location = New System.Drawing.Point(293, 105)
        Me.lblProvinciaCanton.Name = "lblProvinciaCanton"
        Me.lblProvinciaCanton.Size = New System.Drawing.Size(93, 13)
        Me.lblProvinciaCanton.TabIndex = 32
        Me.lblProvinciaCanton.Text = "Provincia\Cantón:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(13, 106)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 31
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(281, 63)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 30
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(13, 62)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(43, 13)
        Me.lblCedula.TabIndex = 29
        Me.lblCedula.Text = "Cédula:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(281, 22)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 28
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(652, 11)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(128, 46)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(652, 186)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 43)
        Me.btnSalir.TabIndex = 49
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(652, 69)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(128, 46)
        Me.btnEditar.TabIndex = 50
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(652, 129)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 45)
        Me.btnEliminar.TabIndex = 51
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardarDatosEnArchivo
        '
        Me.btnGuardarDatosEnArchivo.Location = New System.Drawing.Point(798, 69)
        Me.btnGuardarDatosEnArchivo.Name = "btnGuardarDatosEnArchivo"
        Me.btnGuardarDatosEnArchivo.Size = New System.Drawing.Size(128, 46)
        Me.btnGuardarDatosEnArchivo.TabIndex = 52
        Me.btnGuardarDatosEnArchivo.Text = "Guardar datos en archivo"
        Me.btnGuardarDatosEnArchivo.UseVisualStyleBackColor = True
        '
        'ClientesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 530)
        Me.Controls.Add(Me.btnGuardarDatosEnArchivo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.rbtnQuinceMillones)
        Me.Controls.Add(Me.rbtnDiezMillones)
        Me.Controls.Add(Me.rbtnCincoMillones)
        Me.Controls.Add(Me.dtpFechaInicioSeguro)
        Me.Controls.Add(Me.cmbxProvinciaCanton)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.txtMensualidad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblMensualidad)
        Me.Controls.Add(Me.lblFechaInicioSeguro)
        Me.Controls.Add(Me.lblCoberturaSeguro)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblProvinciaCanton)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "ClientesFrm"
        Me.Text = "ClientesFrm"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnGenerarXML As Button
    Friend WithEvents rbtnQuinceMillones As RadioButton
    Friend WithEvents rbtnDiezMillones As RadioButton
    Friend WithEvents rbtnCincoMillones As RadioButton
    Friend WithEvents dtpFechaInicioSeguro As DateTimePicker
    Friend WithEvents cmbxProvinciaCanton As ComboBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents txtMensualidad As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblMensualidad As Label
    Friend WithEvents lblFechaInicioSeguro As Label
    Friend WithEvents lblCoberturaSeguro As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblProvinciaCanton As Label
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardarDatosEnArchivo As Button
End Class
