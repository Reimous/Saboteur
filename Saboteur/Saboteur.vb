Public Class Saboteur


    Public cargaImagen As Image

    Private Sub Saboteur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 13
            Dim pbA = Controls("pbA" & i)
            Dim pbB = Controls("pbB" & i)
            Dim pbC = Controls("pbC" & i)
            Dim pbD = Controls("pbD" & i)
            Dim pbE = Controls("pbE" & i)
            Dim pbF = Controls("pbF" & i)
            Dim pbG = Controls("pbG" & i)
            Dim pbH = Controls("pbH" & i)
            Dim pbI = Controls("pbI" & i)
            'pbA.BackgroundImage = Nothing

            pbA.BackColor = Color.Azure
            pbB.BackColor = Color.Azure
            If Not pbC.Name = "pbC3" Then
                pbC.BackColor = Color.Azure
            End If
            pbD.BackColor = Color.Azure
            If Not pbE.Name = "pbE3" Then
                pbE.BackColor = Color.Azure
            End If
            pbF.BackColor = Color.Azure
            If Not pbF.Name = "pbF3" Then
                pbG.BackColor = Color.Azure
            End If
            pbH.BackColor = Color.Azure
            pbI.BackColor = Color.Azure

            '    'pb.BackgroundImageLayout = ImageLayout.Center
            Me.Refresh()
        Next
    End Sub
#Region "Evento_click"
#Region "pbA"
    Private Sub pbA1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA1.MouseClick
        If e.button = Windows.Forms.MouseButtons.Right Then
            pbA1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA1.Image = cargaImagen
            End If
            End If
    End Sub
    Private Sub pbA2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA2.MouseClick
        If e.button = Windows.Forms.MouseButtons.Right Then
            pbA2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbA3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbA4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbA5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbA6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbA8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbA13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbA13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbA13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbA13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbB"
    Private Sub pbB1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbB3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbB4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbB5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbB6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbB8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbB13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbB13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbB13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbB13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbC"
    Private Sub pbC1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbC3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbC4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbC5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbC6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbC8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbC13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbC13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbC13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbC13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbD"
    Private Sub pbD1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbD3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbD4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbD5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbD6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbD8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbD13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbD13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbD13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbD13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbE"
    Private Sub pbE1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbE2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbE3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbE4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbE5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbE6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbE7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbE8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbE9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbE10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE10.Image = cargaImagen
            End If
        End If
    End Sub
    'Private Sub pbE11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE11.MouseClick
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        pbE11.Image = Nothing
    '    Else
    '        Dim finestra As New Imagen
    '        finestra.ShowDialog()
    '        If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
    '            pbE11.Image = cargaImagen
    '        End If
    '    End If
    'End Sub
    Private Sub pbE12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbE13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbE13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbE13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbE13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbF"
    Private Sub pbF1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbF3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbF4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbF5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbF6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbF8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbF13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbF13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbF13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbF13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbG"
    Private Sub pbG1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbG3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbG4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbG5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbG6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbG8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbG13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbG13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbG13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbG13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbH"
    Private Sub pbH1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbH3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbH4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbH5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbH6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbH8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbH13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbH13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbH13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbH13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#Region "pbI"
    Private Sub pbI1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI1.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI1.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI2.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI2.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbI3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI3.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI3.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI3.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbI4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI4.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI4.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbI5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI5.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI5.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI5.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbI6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI6.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI6.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI6.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI7.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI7.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI7.Image = cargaImagen
            End If
        End If
    End Sub

    Private Sub pbI8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI8.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI8.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI8.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI9.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI9.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI9.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI10_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI10.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI10.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI10.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI11_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI11.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI11.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI11.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI12_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI12.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI12.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI12.Image = cargaImagen
            End If
        End If
    End Sub
    Private Sub pbI13_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbI13.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            pbI13.Image = Nothing
        Else
            Dim finestra As New Imagen
            finestra.ShowDialog()
            If finestra.DialogResult = Windows.Forms.DialogResult.OK Then
                pbI13.Image = cargaImagen
            End If
        End If
    End Sub
#End Region
#End Region

    Private Sub btnJugadoresAcciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJugadoresAcciones.Click
        Dim finestra As New Jugadores
        finestra.ShowDialog()
    End Sub
End Class
