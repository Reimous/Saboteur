<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.pbRotoFarol = New System.Windows.Forms.PictureBox
        Me.pbBloquear = New System.Windows.Forms.PictureBox
        Me.pbVagon = New System.Windows.Forms.PictureBox
        Me.pbPico = New System.Windows.Forms.PictureBox
        Me.pbRotoVagon = New System.Windows.Forms.PictureBox
        Me.pbPicoVagon = New System.Windows.Forms.PictureBox
        Me.pbFarolVagon = New System.Windows.Forms.PictureBox
        Me.pbRotoPico = New System.Windows.Forms.PictureBox
        Me.pbPicoFarol = New System.Windows.Forms.PictureBox
        Me.pbFarol = New System.Windows.Forms.PictureBox
        Me.pbMapa = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbRotoFarol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBloquear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVagon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRotoVagon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPicoVagon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFarolVagon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRotoPico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPicoFarol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFarol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(631, 432)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'pbRotoFarol
        '
        Me.pbRotoFarol.Image = Global.Saboteur.My.Resources.Resources.RotoFarol
        Me.pbRotoFarol.Location = New System.Drawing.Point(461, 8)
        Me.pbRotoFarol.Name = "pbRotoFarol"
        Me.pbRotoFarol.Size = New System.Drawing.Size(125, 199)
        Me.pbRotoFarol.TabIndex = 1
        Me.pbRotoFarol.TabStop = False
        '
        'pbBloquear
        '
        Me.pbBloquear.Image = Global.Saboteur.My.Resources.Resources.TunelBloqueado
        Me.pbBloquear.Location = New System.Drawing.Point(136, 8)
        Me.pbBloquear.Name = "pbBloquear"
        Me.pbBloquear.Size = New System.Drawing.Size(125, 199)
        Me.pbBloquear.TabIndex = 1
        Me.pbBloquear.TabStop = False
        '
        'pbVagon
        '
        Me.pbVagon.Image = Global.Saboteur.My.Resources.Resources.ReparadoVagon
        Me.pbVagon.Location = New System.Drawing.Point(660, 227)
        Me.pbVagon.Name = "pbVagon"
        Me.pbVagon.Size = New System.Drawing.Size(125, 199)
        Me.pbVagon.TabIndex = 1
        Me.pbVagon.TabStop = False
        '
        'pbPico
        '
        Me.pbPico.Image = Global.Saboteur.My.Resources.Resources.ReparadoPico
        Me.pbPico.Location = New System.Drawing.Point(398, 227)
        Me.pbPico.Name = "pbPico"
        Me.pbPico.Size = New System.Drawing.Size(125, 199)
        Me.pbPico.TabIndex = 1
        Me.pbPico.TabStop = False
        '
        'pbRotoVagon
        '
        Me.pbRotoVagon.Image = Global.Saboteur.My.Resources.Resources.RotoVagon
        Me.pbRotoVagon.Location = New System.Drawing.Point(592, 8)
        Me.pbRotoVagon.Name = "pbRotoVagon"
        Me.pbRotoVagon.Size = New System.Drawing.Size(125, 199)
        Me.pbRotoVagon.TabIndex = 1
        Me.pbRotoVagon.TabStop = False
        '
        'pbPicoVagon
        '
        Me.pbPicoVagon.Image = Global.Saboteur.My.Resources.Resources.ReparadoPicoVagon
        Me.pbPicoVagon.Location = New System.Drawing.Point(136, 227)
        Me.pbPicoVagon.Name = "pbPicoVagon"
        Me.pbPicoVagon.Size = New System.Drawing.Size(125, 199)
        Me.pbPicoVagon.TabIndex = 1
        Me.pbPicoVagon.TabStop = False
        '
        'pbFarolVagon
        '
        Me.pbFarolVagon.Image = Global.Saboteur.My.Resources.Resources.ReparadoFarolVagon
        Me.pbFarolVagon.Location = New System.Drawing.Point(267, 227)
        Me.pbFarolVagon.Name = "pbFarolVagon"
        Me.pbFarolVagon.Size = New System.Drawing.Size(125, 199)
        Me.pbFarolVagon.TabIndex = 1
        Me.pbFarolVagon.TabStop = False
        '
        'pbRotoPico
        '
        Me.pbRotoPico.Image = Global.Saboteur.My.Resources.Resources.RotoPico
        Me.pbRotoPico.Location = New System.Drawing.Point(330, 8)
        Me.pbRotoPico.Name = "pbRotoPico"
        Me.pbRotoPico.Size = New System.Drawing.Size(125, 199)
        Me.pbRotoPico.TabIndex = 1
        Me.pbRotoPico.TabStop = False
        '
        'pbPicoFarol
        '
        Me.pbPicoFarol.Image = Global.Saboteur.My.Resources.Resources.ReparadoPicoFarol
        Me.pbPicoFarol.Location = New System.Drawing.Point(5, 227)
        Me.pbPicoFarol.Name = "pbPicoFarol"
        Me.pbPicoFarol.Size = New System.Drawing.Size(125, 199)
        Me.pbPicoFarol.TabIndex = 1
        Me.pbPicoFarol.TabStop = False
        '
        'pbFarol
        '
        Me.pbFarol.Image = Global.Saboteur.My.Resources.Resources.ReparadoFarol
        Me.pbFarol.Location = New System.Drawing.Point(529, 227)
        Me.pbFarol.Name = "pbFarol"
        Me.pbFarol.Size = New System.Drawing.Size(125, 199)
        Me.pbFarol.TabIndex = 1
        Me.pbFarol.TabStop = False
        '
        'pbMapa
        '
        Me.pbMapa.Image = Global.Saboteur.My.Resources.Resources.Mapa
        Me.pbMapa.Location = New System.Drawing.Point(5, 8)
        Me.pbMapa.Name = "pbMapa"
        Me.pbMapa.Size = New System.Drawing.Size(125, 199)
        Me.pbMapa.TabIndex = 1
        Me.pbMapa.TabStop = False
        '
        'Acciones
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(789, 473)
        Me.Controls.Add(Me.pbRotoFarol)
        Me.Controls.Add(Me.pbBloquear)
        Me.Controls.Add(Me.pbVagon)
        Me.Controls.Add(Me.pbPico)
        Me.Controls.Add(Me.pbRotoVagon)
        Me.Controls.Add(Me.pbPicoVagon)
        Me.Controls.Add(Me.pbFarolVagon)
        Me.Controls.Add(Me.pbRotoPico)
        Me.Controls.Add(Me.pbPicoFarol)
        Me.Controls.Add(Me.pbFarol)
        Me.Controls.Add(Me.pbMapa)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acciones"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pbRotoFarol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBloquear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVagon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRotoVagon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPicoVagon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFarolVagon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRotoPico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPicoFarol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFarol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pbMapa As System.Windows.Forms.PictureBox
    Friend WithEvents pbFarol As System.Windows.Forms.PictureBox
    Friend WithEvents pbFarolVagon As System.Windows.Forms.PictureBox
    Friend WithEvents pbPico As System.Windows.Forms.PictureBox
    Friend WithEvents pbPicoFarol As System.Windows.Forms.PictureBox
    Friend WithEvents pbPicoVagon As System.Windows.Forms.PictureBox
    Friend WithEvents pbVagon As System.Windows.Forms.PictureBox
    Friend WithEvents pbRotoFarol As System.Windows.Forms.PictureBox
    Friend WithEvents pbRotoPico As System.Windows.Forms.PictureBox
    Friend WithEvents pbRotoVagon As System.Windows.Forms.PictureBox
    Friend WithEvents pbBloquear As System.Windows.Forms.PictureBox

End Class
