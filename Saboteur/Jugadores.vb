Public Class Jugadores
    'Private jugador As String

    'Public Sub getJugador(ByVal jugador As String)
    '    Me.jugador = jugador
    'End Sub

    Private Sub btnAccionJ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccionJ1.Click
        'jugador = "1"
        Dim finestra As New Acciones
        finestra.ShowDialog()
        If finestra.DialogResult = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub btnAccionJ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccionJ2.Click
        'jugador = "2"
        Dim finestra As New Acciones
        finestra.ShowDialog()
        If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
End Class