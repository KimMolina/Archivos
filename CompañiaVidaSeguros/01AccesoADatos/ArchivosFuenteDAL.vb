Imports _03_Entidades

Public Class ArchivosFuenteDAL

    Public Function LeerDatosCliente(ByVal rutaArchivo As String) As List(Of ArchivoTexto)

        Dim listaDatosArchivos As New List(Of ArchivoTexto)

        For i = 0 To IO.File.ReadLines(rutaArchivo).Count - 1
            Dim fila As String() = IO.File.ReadLines(rutaArchivo)(i).Split(";")
            Dim objArchivoTexto As New ArchivoTexto

            objArchivoTexto.Nombre = fila(0)
            objArchivoTexto.Apellido = fila(1)
            objArchivoTexto.Cedula = fila(2)
            objArchivoTexto.FechaNacimiento = fila(3)
            objArchivoTexto.Nacionalidad = fila(4)
            objArchivoTexto.ProvinciaCanton = fila(5)
            objArchivoTexto.Correo = fila(6)
            objArchivoTexto.CoberturaSeguro = fila(7)
            objArchivoTexto.FechaInicioSeguro = fila(8)
            objArchivoTexto.Mensualidad = fila(9)

            listaDatosArchivos.Add(objArchivoTexto)
        Next

        Return listaDatosArchivos
    End Function

    Public Sub GuardarDatos(ByVal rutaArchivo As String, ByVal listaDatosArchivo As List(Of ArchivoTexto))

        Dim datosArchivos As String = ""

        For Each objClienteFilaActual As ArchivoTexto In listaDatosArchivo
            datosArchivos += String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}" & vbCrLf, objClienteFilaActual.Nombre, objClienteFilaActual.Apellido, objClienteFilaActual.Cedula,
                                          objClienteFilaActual.FechaNacimiento, objClienteFilaActual.Nacionalidad, objClienteFilaActual.ProvinciaCanton, objClienteFilaActual.Correo,
                                          objClienteFilaActual.CoberturaSeguro, objClienteFilaActual.FechaInicioSeguro, objClienteFilaActual.Mensualidad)
        Next
        My.Computer.FileSystem.WriteAllText(rutaArchivo, datosArchivos, False)

    End Sub

    Public Sub GenerarXML(ByVal rutaArchivo As String, ByVal listaDatosArchivo As List(Of ArchivoTexto))

        Dim dsgvClientes As New DataSet("DatosClientes")

        Dim dtCliente As New DataTable("Cliente")

        dsgvClientes.Tables.Add(dtCliente)

        dtCliente.Columns.Add("Nombre", GetType(String))
        dtCliente.Columns.Add("Apellido", GetType(String))
        dtCliente.Columns.Add("Cedula", GetType(String))
        dtCliente.Columns.Add("FechaNacimiento", GetType(Date))
        dtCliente.Columns.Add("Nacionalidad", GetType(String))
        dtCliente.Columns.Add("ProvinciaCanton", GetType(String))
        dtCliente.Columns.Add("Correo", GetType(String))
        dtCliente.Columns.Add("CoberturaSeguro", GetType(String))
        dtCliente.Columns.Add("FechaInicioSeguro", GetType(Date))
        dtCliente.Columns.Add("Mensualidad", GetType(String))

        For i = 0 To listaDatosArchivo.Count - 1
            If i <> 0 Then
                Dim drNuevoCliente As DataRow = dsgvClientes.Tables(0).NewRow()

                drNuevoCliente("Nombre") = listaDatosArchivo(i).Nombre
                drNuevoCliente("Apellido") = listaDatosArchivo(i).Apellido
                drNuevoCliente("Cedula") = listaDatosArchivo(i).Cedula
                drNuevoCliente("FechaNacimiento") = listaDatosArchivo(i).FechaNacimiento
                drNuevoCliente("Nacionalidad") = listaDatosArchivo(i).Nacionalidad
                drNuevoCliente("ProvinciaCanton") = listaDatosArchivo(i).ProvinciaCanton
                drNuevoCliente("Correo") = listaDatosArchivo(i).Correo
                drNuevoCliente("CoberturaSeguro") = listaDatosArchivo(i).CoberturaSeguro
                drNuevoCliente("FechaInicioSeguro") = listaDatosArchivo(i).FechaInicioSeguro
                drNuevoCliente("Mensualidad") = listaDatosArchivo(i).Mensualidad

                dsgvClientes.Tables(0).Rows.Add(drNuevoCliente)
            End If
        Next

        dsgvClientes.WriteXml(rutaArchivo)
    End Sub

End Class
