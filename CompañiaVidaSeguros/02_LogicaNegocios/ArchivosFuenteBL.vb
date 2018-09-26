Imports _01AccesoADatos
Imports _03_Entidades

Public Class ArchivosFuenteBL

    Dim objArchivosFuenteDAL As New ArchivosFuenteDAL

#Region "Métodos"
    Public Function LeerDatosCliente(ByVal rutaArchivo As String) As List(Of ArchivoTexto)

        Dim listaDatosArchivos As New List(Of ArchivoTexto)

        listaDatosArchivos = objArchivosFuenteDAL.LeerDatosCliente(rutaArchivo)

        Return listaDatosArchivos

    End Function

    Public Function Validaciones(ByVal datoCliente As ArchivoTexto) As String
        If datoCliente.Nombre.Length = 0 Or IsNumeric(datoCliente.Nombre) Then
            Return "Nombre del cliente inválido."
        End If
        If datoCliente.Apellido.Length = 0 Or IsNumeric(datoCliente.Apellido) Then
            Return "Apellido del cliente inválido."
        End If
        If datoCliente.Cedula.Length = 0 Or Not IsNumeric(datoCliente.Cedula) Then
            Return "Cédula del cliente inválida."
        End If
        If datoCliente.Correo.Length = 0 Or IsNumeric(datoCliente.Correo) Or Not datoCliente.Correo.Contains("@") Then
            Return "Correo inválido."
        End If
        If datoCliente.FechaNacimiento.Length = 0 Then
            Return "Fecha de nacimiento inválida."
        End If
        If datoCliente.Nacionalidad.Length = 0 Or IsNumeric(datoCliente.Nacionalidad) Then
            Return "Nacionalidad inválida."
        End If
        If datoCliente.CoberturaSeguro.Length = 0 Then
            Return "Cobertura de seguro inválida."
        End If
        If datoCliente.FechaInicioSeguro.Length = 0 Then
            Return "Fecha de inicio de suguro inválida."
        End If
        If datoCliente.ProvinciaCanton.Equals("Seleccione") Then
            Return "Provincia, Cantón inválidas."
        End If

        Return ""

    End Function

    Public Sub GuardarDatos(ByVal rutaArchivo As String, ByVal listaDatosArchivo As List(Of ArchivoTexto))
        objArchivosFuenteDAL.GuardarDatos(rutaArchivo, listaDatosArchivo)
    End Sub

    Public Sub GenerarXML(ByVal rutaArchivo As String, ByVal listaDatosArchivo As List(Of ArchivoTexto))
        objArchivosFuenteDAL.GenerarXML(rutaArchivo, listaDatosArchivo)
    End Sub

    Public Function GenerarMensualidad(ByVal coberturaSeguro As String, ByVal fechaNacimiento As Date) As String

        If coberturaSeguro = "5000000" Then
            If (CalcularEdad(fechaNacimiento) >= 18) And (CalcularEdad(fechaNacimiento) <= 45) Then
                Return "75000"
            ElseIf (CalcularEdad(fechaNacimiento) >= 46) And (CalcularEdad(fechaNacimiento) <= 65) Then
                Return "85000"
            Else
                Return "100000"
            End If
        End If
        If coberturaSeguro = "10000000" Then
            If (CalcularEdad(fechaNacimiento) >= 18) And (CalcularEdad(fechaNacimiento) <= 45) Then
                Return "90000"
            ElseIf (CalcularEdad(fechaNacimiento) >= 46) And (CalcularEdad(fechaNacimiento) <= 65) Then
                Return "110000"
            Else
                Return "125000"
            End If
        End If
        If coberturaSeguro = "15000000" Then
            If (CalcularEdad(fechaNacimiento) >= 18) And (CalcularEdad(fechaNacimiento) <= 45) Then
                Return "115000"
            ElseIf (CalcularEdad(fechaNacimiento) >= 46) And (CalcularEdad(fechaNacimiento) <= 65) Then
                Return "135000"
            Else
                Return "165000"
            End If
        End If

        Return ""

    End Function

    Public Function CalcularEdad(ByVal nacimiento As Date) As Integer
        Dim edad As Integer
        edad = Today.Year - nacimiento.Year
        If (nacimiento > Today.AddYears(-edad)) Then
            edad -= 1
        End If
        Return edad
    End Function

#End Region

End Class
