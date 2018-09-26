Imports System.Configuration
Imports _02_LogicaNegocios
Imports _03_Entidades

Public Class ClientesFrm

    Dim objArchivosFuenteBL As New ArchivosFuenteBL
    Dim informacionClientes As New ArchivoTexto
    Dim listaDatosCliente As New List(Of ArchivoTexto)

#Region "Eventos"
    Private Sub ClientesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConsultarClientesDesdeArchivoDeTexto()
        ConfigurarFechasMaximas()
        CargarProvinciaCanton()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerarXML_Click(sender As Object, e As EventArgs) Handles btnGenerarXML.Click

        Dim rutaArchivo As String = String.Format(ConfigurationManager.AppSettings("RutaArchivoXML"), My.Computer.FileSystem.CurrentDirectory)

        objArchivosFuenteBL.GenerarXML(rutaArchivo, listaDatosCliente)

        MessageBox.Show("El archivo XML fue generado.", "Información")

    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        Dim filaActual As Integer

        filaActual = dgvClientes.CurrentRow.Index

        txtNombre.Text = dgvClientes.Item(0, filaActual).Value
        txtApellido.Text = dgvClientes.Item(1, filaActual).Value
        txtCedula.Text = dgvClientes.Item(2, filaActual).Value
        dtpFechaNacimiento.Text = dgvClientes.Item(3, filaActual).Value
        txtNacionalidad.Text = dgvClientes.Item(4, filaActual).Value
        cmbxProvinciaCanton.Text = dgvClientes.Item(5, filaActual).Value
        txtEmail.Text = dgvClientes.Item(6, filaActual).Value
        dtpFechaInicioSeguro.Text = dgvClientes.Item(8, filaActual).Value
        txtMensualidad.Text = dgvClientes.Item(9, filaActual).Value

        If dgvClientes.Item(7, filaActual).Value = "5000000" Then
            rbtnCincoMillones.Select()
        ElseIf dgvClientes.Item(7, filaActual).Value = "10000000" Then
            rbtnDiezMillones.Select()
        Else
            rbtnQuinceMillones.Select()
        End If

        txtCedula.Enabled = False
        btnAgregar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Dim mensajeValidacion As String = ""

            Dim objDatosCliente As New ArchivoTexto

            objDatosCliente.Nombre = txtNombre.Text.Trim
            objDatosCliente.Apellido = txtApellido.Text.Trim
            objDatosCliente.Cedula = txtCedula.Text.Trim
            objDatosCliente.FechaNacimiento = dtpFechaNacimiento.Text.Trim
            objDatosCliente.Nacionalidad = txtNacionalidad.Text.Trim
            objDatosCliente.ProvinciaCanton = cmbxProvinciaCanton.Text.Trim
            objDatosCliente.Correo = txtEmail.Text.Trim
            If rbtnCincoMillones.Checked Then
                objDatosCliente.CoberturaSeguro = rbtnCincoMillones.Text.Trim
            ElseIf rbtnDiezMillones.Checked Then
                objDatosCliente.CoberturaSeguro = rbtnDiezMillones.Text.Trim
            ElseIf rbtnQuinceMillones.Checked Then
                objDatosCliente.CoberturaSeguro = rbtnQuinceMillones.Text.Trim
            Else
                objDatosCliente.CoberturaSeguro = ""
            End If
            objDatosCliente.FechaInicioSeguro = dtpFechaInicioSeguro.Text.Trim
            objDatosCliente.Mensualidad = txtMensualidad.Text.Trim

            mensajeValidacion = objArchivosFuenteBL.Validaciones(objDatosCliente)

            If mensajeValidacion.Equals("") Then
                listaDatosCliente.Add(objDatosCliente)

                CargarDataGried(listaDatosCliente)
            Else
                MessageBox.Show(mensajeValidacion, "Validación")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim mensajeValidacion As String = ""

        Dim objDatosClienteActualizado As New ArchivoTexto

        objDatosClienteActualizado.Nombre = txtNombre.Text.Trim
        objDatosClienteActualizado.Apellido = txtApellido.Text.Trim
        objDatosClienteActualizado.Cedula = txtCedula.Text.Trim
        objDatosClienteActualizado.FechaNacimiento = dtpFechaNacimiento.Text.Trim
        objDatosClienteActualizado.Nacionalidad = txtNacionalidad.Text.Trim
        objDatosClienteActualizado.ProvinciaCanton = cmbxProvinciaCanton.Text.Trim
        objDatosClienteActualizado.Correo = txtEmail.Text.Trim
        If rbtnCincoMillones.Checked Then
            objDatosClienteActualizado.CoberturaSeguro = rbtnCincoMillones.Text.Trim
        ElseIf rbtnDiezMillones.Checked Then
            objDatosClienteActualizado.CoberturaSeguro = rbtnDiezMillones.Text.Trim
        ElseIf rbtnDiezMillones.Checked Then
            objDatosClienteActualizado.CoberturaSeguro = rbtnQuinceMillones.Text.Trim
        Else
            objDatosClienteActualizado.CoberturaSeguro = ""
        End If
        objDatosClienteActualizado.FechaInicioSeguro = dtpFechaInicioSeguro.Text.Trim
        objDatosClienteActualizado.Mensualidad = txtMensualidad.Text.Trim

        mensajeValidacion = objArchivosFuenteBL.Validaciones(objDatosClienteActualizado)

        If mensajeValidacion.Equals("") Then
            For Each objClienteFilaActual As ArchivoTexto In listaDatosCliente
                If objClienteFilaActual.Cedula.Equals(objDatosClienteActualizado.Cedula) = True Then
                    objClienteFilaActual.Nombre = objDatosClienteActualizado.Nombre
                    objClienteFilaActual.Apellido = objDatosClienteActualizado.Apellido
                    objClienteFilaActual.Nacionalidad = objDatosClienteActualizado.Nacionalidad
                    objClienteFilaActual.FechaNacimiento = objDatosClienteActualizado.FechaNacimiento
                    objClienteFilaActual.FechaInicioSeguro = objDatosClienteActualizado.FechaInicioSeguro
                    objClienteFilaActual.Correo = objDatosClienteActualizado.Correo
                    objClienteFilaActual.CoberturaSeguro = objDatosClienteActualizado.CoberturaSeguro
                    objClienteFilaActual.ProvinciaCanton = objDatosClienteActualizado.ProvinciaCanton
                    objClienteFilaActual.Mensualidad = objDatosClienteActualizado.Mensualidad
                End If
            Next

            CargarDataGried(listaDatosCliente)
        Else
            MessageBox.Show(mensajeValidacion, "Validación")
        End If

        txtCedula.Enabled = True
        btnAgregar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

        LimpiarCampos()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCedula.Text.Length <> 0 Then
            Dim listaDatosClienteAuxiliar As New List(Of ArchivoTexto)(listaDatosCliente)

            For i = 0 To listaDatosCliente.Count - 1
                If listaDatosCliente(i).Cedula.Equals(txtCedula.Text) Then
                    listaDatosClienteAuxiliar.RemoveAt(i)
                End If
            Next
            listaDatosCliente = listaDatosClienteAuxiliar
            CargarDataGried(listaDatosClienteAuxiliar)

            txtCedula.Enabled = True
            btnAgregar.Enabled = True
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
            LimpiarCampos()
        Else
            MessageBox.Show("No hay más datos que eliminar.", "Validación")
        End If
    End Sub

    Private Sub btnGuardarDatosEnArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarDatosEnArchivo.Click
        Dim rutaArchivo As String = String.Format(ConfigurationManager.AppSettings("RutaArchivoTXT"), My.Computer.FileSystem.CurrentDirectory)

        objArchivosFuenteBL.GuardarDatos(rutaArchivo, listaDatosCliente)

        MessageBox.Show("El archivo TXT fue guardado.", "Información")

    End Sub

    Private Sub rbtnCincoMillones_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCincoMillones.CheckedChanged
        If rbtnCincoMillones.Checked Then
            txtMensualidad.Text = objArchivosFuenteBL.GenerarMensualidad(rbtnCincoMillones.Text, dtpFechaNacimiento.Text)
        End If
    End Sub

    Private Sub rbtnDiezMillones_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDiezMillones.CheckedChanged
        If rbtnDiezMillones.Checked Then
            txtMensualidad.Text = objArchivosFuenteBL.GenerarMensualidad(rbtnDiezMillones.Text, dtpFechaNacimiento.Text)
        End If
    End Sub

    Private Sub rbtnQuinceMillones_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnQuinceMillones.CheckedChanged
        If rbtnQuinceMillones.Checked Then
            txtMensualidad.Text = objArchivosFuenteBL.GenerarMensualidad(rbtnQuinceMillones.Text, dtpFechaNacimiento.Text)
        End If
    End Sub
#End Region

#Region "Métodos"
    Public Sub ConsultarClientesDesdeArchivoDeTexto()

        Dim rutaArchivo As String = String.Format(ConfigurationManager.AppSettings("RutaArchivoTXT"), My.Computer.FileSystem.CurrentDirectory)

        listaDatosCliente = objArchivosFuenteBL.LeerDatosCliente(rutaArchivo)

        CargarDataGried(listaDatosCliente)

    End Sub

    Public Sub CargarDataGried(ByVal listaDatosCliente As List(Of ArchivoTexto))

        Dim listaDatosClienteAuxiliar As New List(Of ArchivoTexto)(listaDatosCliente)

        Dim columnasCabecera As ArchivoTexto = listaDatosClienteAuxiliar(0)

        listaDatosClienteAuxiliar.RemoveAt(0)

        dgvClientes.DataSource = listaDatosClienteAuxiliar

        dgvClientes.Columns(0).HeaderText = columnasCabecera.Nombre
        dgvClientes.Columns(1).HeaderText = columnasCabecera.Apellido
        dgvClientes.Columns(2).HeaderText = columnasCabecera.Cedula
        dgvClientes.Columns(3).HeaderText = columnasCabecera.FechaNacimiento
        dgvClientes.Columns(4).HeaderText = columnasCabecera.Nacionalidad
        dgvClientes.Columns(5).HeaderText = columnasCabecera.ProvinciaCanton
        dgvClientes.Columns(6).HeaderText = columnasCabecera.Correo
        dgvClientes.Columns(7).HeaderText = columnasCabecera.CoberturaSeguro
        dgvClientes.Columns(8).HeaderText = columnasCabecera.FechaInicioSeguro
        dgvClientes.Columns(9).HeaderText = columnasCabecera.Mensualidad

        dgvClientes.Columns(3).Width = 145
        dgvClientes.Columns(6).Width = 130
        dgvClientes.Columns(7).Width = 194
        dgvClientes.Columns(8).Width = 188
    End Sub

    Public Sub CargarProvinciaCanton()
        'Seleccionar la provincias y el cantón al combo box
        Me.cmbxProvinciaCanton.Items.Add("Seleccione")
        Me.cmbxProvinciaCanton.Items.Add("San José, San José")
        Me.cmbxProvinciaCanton.Items.Add("San José, Escazú")
        Me.cmbxProvinciaCanton.Items.Add("San José, Desamparados")
        Me.cmbxProvinciaCanton.Items.Add("San José, Puriscal")
        Me.cmbxProvinciaCanton.Items.Add("San José, Tarrazú")
        Me.cmbxProvinciaCanton.Items.Add("San José, Aserrí")
        Me.cmbxProvinciaCanton.Items.Add("San José, Mora")
        Me.cmbxProvinciaCanton.Items.Add("San José, Goicoechea")
        Me.cmbxProvinciaCanton.Items.Add("San José, Santa Ana")
        Me.cmbxProvinciaCanton.Items.Add("San José, Alajuelita")
        Me.cmbxProvinciaCanton.Items.Add("San José, Vásquez de Coronado")
        Me.cmbxProvinciaCanton.Items.Add("San José, Acosta")
        Me.cmbxProvinciaCanton.Items.Add("San José, Tibás")
        Me.cmbxProvinciaCanton.Items.Add("San José, Moravia")
        Me.cmbxProvinciaCanton.Items.Add("San José, Montes de Oca")
        Me.cmbxProvinciaCanton.Items.Add("San José, Turrubares")
        Me.cmbxProvinciaCanton.Items.Add("San José, Dota")
        Me.cmbxProvinciaCanton.Items.Add("San José, Curridabat")
        Me.cmbxProvinciaCanton.Items.Add("San José, Pérez Zeledón")
        Me.cmbxProvinciaCanton.Items.Add("San José, Léon Cortéz Castro")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Alajuela")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, San Ramón")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Grecia")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, San Mateo")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Atenas")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Naranjo")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Palmares")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Poás")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Orotina")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, San Carlos")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Zarcero")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Valverde Vega")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Upala")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Los Chiles")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Guatuso")
        Me.cmbxProvinciaCanton.Items.Add("Alajuela, Río Cuarto")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Libería")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Nicoya")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Bagaces")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Santa Cruz")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Carrillo")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Cañas")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Abangares")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Tilarán")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Nandayure")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, La Cruz")
        Me.cmbxProvinciaCanton.Items.Add("Guanacaste, Hojancha")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Puntarenas")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Esparza")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Buenos Aires")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Montes de Oro")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Osa")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Quepos")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Golfito")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Coto Brus")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Parrita")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Corredores")
        Me.cmbxProvinciaCanton.Items.Add("Puntarenas, Garabito")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Heredia")
        Me.cmbxProvinciaCanton.Items.Add("Heredia,  Barva")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Santo Domingo")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Santa Bárbara")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, San Rafael")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, San Isidro")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Belén")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Flores")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, San Pablo")
        Me.cmbxProvinciaCanton.Items.Add("Heredia, Sarapiquí")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Cartago")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Paraíso")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, La Unión")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Jiménez")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Turrialba")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Alvarado")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, Oreamuno")
        Me.cmbxProvinciaCanton.Items.Add("Cartago, El Guarco")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Limón")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Pococí")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Siquirres")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Talamanca")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Matina")
        Me.cmbxProvinciaCanton.Items.Add("Limón, Guácimo")
        Me.cmbxProvinciaCanton.SelectedIndex = 0
    End Sub

    Public Sub ConfigurarFechasMaximas()
        'Darle el limite de la fecha actual
        Me.dtpFechaNacimiento.MaxDate = DateTime.Today
        Me.dtpFechaInicioSeguro.MaxDate = DateTime.Today
    End Sub

    Public Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        txtEmail.Clear()
        txtNacionalidad.Clear()
        txtMensualidad.Clear()
        cmbxProvinciaCanton.SelectedIndex = 0
    End Sub

#End Region

End Class