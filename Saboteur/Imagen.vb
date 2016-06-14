Imports System.Windows.Forms

Public Class Imagen

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub pbTunel3H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunel3H.Click
        Saboteur.CargaImagen = My.Resources.Tunel3H
        deseleccionar()
        pbTunel3H.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunel3V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunel3V.Click
        Saboteur.cargaImagen = My.Resources.Tunel3V
        deseleccionar()
        pbTunel3V.BorderStyle = BorderStyle.Fixed3D
    End Sub


    Private Sub pbTunel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunel4.Click
        Saboteur.cargaImagen = My.Resources.Tunel4
        deseleccionar()
        pbTunel4.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelHorizontal.Click
        Saboteur.cargaImagen = My.Resources.TunelHorizontal
        deseleccionar()
        pbTunelHorizontal.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelLDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelLDerecha.Click
        Saboteur.cargaImagen = My.Resources.TunelLDerecha
        deseleccionar()
        pbTunelLDerecha.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelLIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelLIzquierda.Click
        Saboteur.cargaImagen = My.Resources.TunelLIzquierda
        deseleccionar()
        pbTunelLIzquierda.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelVertical.Click
        Saboteur.cargaImagen = My.Resources.TunelVertical
        deseleccionar()
        pbTunelVertical.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortado3H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortado3H.Click
        Saboteur.cargaImagen = My.Resources.TunelCortado3H
        deseleccionar()
        pbTunelCortado3H.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortado3V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortado3V.Click
        Saboteur.cargaImagen = My.Resources.TunelCortado3V
        deseleccionar()
        pbTunelCortado3V.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortado4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortado4.Click
        Saboteur.cargaImagen = My.Resources.TunelCortado4
        deseleccionar()
        pbTunelCortado4.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoDerecha.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoDerecha
        deseleccionar()
        pbTunelCortadoDerecha.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoH.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoH
        deseleccionar()
        pbTunelCortadoH.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoInterrogante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoInterrogante.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoInterrogante
        deseleccionar()
        pbTunelCortadoInterrogante.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoLDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoLDerecha.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoLDerecha
        deseleccionar()
        pbTunelCortadoLDerecha.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoLIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoLIzquierda.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoLIzquierda
        deseleccionar()
        pbTunelCortadoLIzquierda.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub pbTunelCortadoV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTunelCortadoV.Click
        Saboteur.cargaImagen = My.Resources.TunelCortadoV
        deseleccionar()
        pbTunelCortadoV.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub deseleccionar()
        pbTunel3V.BorderStyle = BorderStyle.None
        pbTunel4.BorderStyle = BorderStyle.None
        pbTunelCortado3H.BorderStyle = BorderStyle.None
        pbTunelCortado3V.BorderStyle = BorderStyle.None
        pbTunelCortado4.BorderStyle = BorderStyle.None
        pbTunelCortadoDerecha.BorderStyle = BorderStyle.None
        pbTunelCortadoH.BorderStyle = BorderStyle.None
        pbTunelCortadoInterrogante.BorderStyle = BorderStyle.None
        pbTunelCortadoLIzquierda.BorderStyle = BorderStyle.None
        pbTunelCortadoV.BorderStyle = BorderStyle.None
        pbTunelHorizontal.BorderStyle = BorderStyle.None
        pbTunelLDerecha.BorderStyle = BorderStyle.None
        pbTunelLIzquierda.BorderStyle = BorderStyle.None
        pbTunelVertical.BorderStyle = BorderStyle.None
        pbTunel3H.BorderStyle = BorderStyle.None
        pbTunelCortadoLDerecha.BorderStyle = BorderStyle.None
    End Sub
End Class
