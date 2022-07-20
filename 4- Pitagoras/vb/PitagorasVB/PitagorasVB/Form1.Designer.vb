<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeorema
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
        Me.picTriangulo = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblb = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHip = New System.Windows.Forms.Label()
        Me.lblCatA = New System.Windows.Forms.Label()
        Me.lblCatB = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblLadoC = New System.Windows.Forms.Label()
        Me.lblLadoB = New System.Windows.Forms.Label()
        Me.lblLadoA = New System.Windows.Forms.Label()
        CType(Me.picTriangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTriangulo
        '
        Me.picTriangulo.Image = Global.PitagorasVB.My.Resources.Resources.WhatsApp_Image_2020_01_22_at_11_29_56_PM
        Me.picTriangulo.Location = New System.Drawing.Point(21, 248)
        Me.picTriangulo.Name = "picTriangulo"
        Me.picTriangulo.Size = New System.Drawing.Size(249, 209)
        Me.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTriangulo.TabIndex = 0
        Me.picTriangulo.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(209, 38)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(388, 32)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Ingresa dos lados para calcular el tercero"
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.Location = New System.Drawing.Point(290, 81)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(34, 32)
        Me.lbla.TabIndex = 2
        Me.lbla.Text = "a:"
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb.Location = New System.Drawing.Point(290, 120)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(31, 32)
        Me.lblb.TabIndex = 3
        Me.lblb.Text = "b:"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.Location = New System.Drawing.Point(290, 156)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(30, 32)
        Me.lblc.TabIndex = 4
        Me.lblc.Text = "c:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(316, 87)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(194, 20)
        Me.txtA.TabIndex = 5
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(316, 125)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(194, 20)
        Me.txtB.TabIndex = 6
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(316, 162)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(194, 20)
        Me.txtC.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(367, 188)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(88, 44)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        '
        'lblHip
        '
        Me.lblHip.AutoSize = True
        Me.lblHip.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHip.Location = New System.Drawing.Point(359, 394)
        Me.lblHip.Name = "lblHip"
        Me.lblHip.Size = New System.Drawing.Size(47, 34)
        Me.lblHip.TabIndex = 10
        Me.lblHip.Text = "c ="
        '
        'lblCatA
        '
        Me.lblCatA.AutoSize = True
        Me.lblCatA.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatA.Location = New System.Drawing.Point(359, 274)
        Me.lblCatA.Name = "lblCatA"
        Me.lblCatA.Size = New System.Drawing.Size(48, 34)
        Me.lblCatA.TabIndex = 11
        Me.lblCatA.Text = "a ="
        '
        'lblCatB
        '
        Me.lblCatB.AutoSize = True
        Me.lblCatB.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatB.Location = New System.Drawing.Point(359, 338)
        Me.lblCatB.Name = "lblCatB"
        Me.lblCatB.Size = New System.Drawing.Size(48, 34)
        Me.lblCatB.TabIndex = 12
        Me.lblCatB.Text = "b ="
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(516, 120)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(211, 25)
        Me.lblFormula.TabIndex = 13
        Me.lblFormula.Text = "c = √ ( ( a ^ 2 ) + ( b ^ 2 ) )"
        '
        'lblLadoC
        '
        Me.lblLadoC.AutoSize = True
        Me.lblLadoC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLadoC.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLadoC.Location = New System.Drawing.Point(209, 327)
        Me.lblLadoC.Name = "lblLadoC"
        Me.lblLadoC.Size = New System.Drawing.Size(24, 32)
        Me.lblLadoC.TabIndex = 14
        Me.lblLadoC.Text = "c"
        '
        'lblLadoB
        '
        Me.lblLadoB.AutoSize = True
        Me.lblLadoB.BackColor = System.Drawing.SystemColors.Info
        Me.lblLadoB.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLadoB.Location = New System.Drawing.Point(74, 406)
        Me.lblLadoB.Name = "lblLadoB"
        Me.lblLadoB.Size = New System.Drawing.Size(25, 32)
        Me.lblLadoB.TabIndex = 15
        Me.lblLadoB.Text = "b"
        '
        'lblLadoA
        '
        Me.lblLadoA.AutoSize = True
        Me.lblLadoA.Font = New System.Drawing.Font("Viner Hand ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLadoA.Location = New System.Drawing.Point(159, 460)
        Me.lblLadoA.Name = "lblLadoA"
        Me.lblLadoA.Size = New System.Drawing.Size(28, 32)
        Me.lblLadoA.TabIndex = 16
        Me.lblLadoA.Text = "a"
        '
        'frmTeorema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.lblLadoA)
        Me.Controls.Add(Me.lblLadoB)
        Me.Controls.Add(Me.lblLadoC)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblCatB)
        Me.Controls.Add(Me.lblCatA)
        Me.Controls.Add(Me.lblHip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.lblb)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.picTriangulo)
        Me.Name = "frmTeorema"
        Me.Text = "Teorema de Pitagoras"
        CType(Me.picTriangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTriangulo As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbla As Label
    Friend WithEvents lblb As Label
    Friend WithEvents lblc As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHip As Label
    Friend WithEvents lblCatA As Label
    Friend WithEvents lblCatB As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblLadoC As Label
    Friend WithEvents lblLadoB As Label
    Friend WithEvents lblLadoA As Label
End Class
