Public Class frmTeorema

    Dim a, b, c As Double
    Dim puntoA, puntoB, puntoC As Boolean
    Dim tresLados As Boolean = True

    Private Sub txtA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress

        If Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If

        If e.KeyChar = ControlChars.Back Then

            If txtA.Text < " " Then
                txtA.Text = Mid(txtA.Text, 1, Len(txtA.Text) - 1 + 1)
            Else
                txtA.Text = Mid(txtA.Text, 1, Len(txtA.Text) - 1)
            End If
        End If

        If e.KeyChar = Chr(46) Then

            If puntoA = False Then

                txtA.Text = txtA.Text + "."
                puntoA = True

            End If


        End If
    End Sub

    Private Sub txtB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress

        If Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If

        If e.KeyChar = ControlChars.Back Then

            If txtB.Text < " " Then
                txtB.Text = Mid(txtB.Text, 1, Len(txtB.Text) - 1 + 1)
            Else
                txtB.Text = Mid(txtB.Text, 1, Len(txtB.Text) - 1)
            End If
        End If

        If e.KeyChar = Chr(46) Then

            If puntoB = False Then

                txtB.Text = txtB.Text + "."
                puntoB = True

            End If


        End If
    End Sub

    Private Sub txtC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtC.KeyPress



        If Not IsNumeric(e.KeyChar) Then

            e.Handled = True
        End If

        If e.KeyChar = ControlChars.Back Then

            If txtC.Text < " " Then
                txtC.Text = Mid(txtC.Text, 1, Len(txtC.Text) - 1 + 1)
            Else
                txtC.Text = Mid(txtC.Text, 1, Len(txtC.Text) - 1)
            End If
        End If

        If e.KeyChar = Chr(46) Then

            If puntoC = False Then

                txtC.Text = txtC.Text + "."
                puntoC = True

            End If


        End If
    End Sub



    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Cuando no introduce ningun lado
        If (txtA.Text = "" Or txtA.Text = ".") And (txtB.Text = "" Or txtB.Text = ".") And (txtC.Text = "" Or txtC.Text = ".") Then

            MsgBox("Se requieren dos lados para calcular el tercero")
            tresLados = False


            'Cuando solo introduce un lado
        ElseIf (txtA.Text IsNot "" Or txtA.Text IsNot ".") And (txtB.Text = "" Or txtB.Text = ".") And (txtC.Text = "" Or txtC.Text = ".") Then

            MsgBox("Se requieren dos lados para calcular el tercero")
            tresLados = False


        ElseIf (txtA.Text = "" Or txtA.Text = ".") And (txtB.Text IsNot "" Or txtB.Text IsNot ".") And (txtC.Text = "" Or txtC.Text = ".") Then

            MsgBox("Se requieren dos lados para calcular el tercero")
            tresLados = False


        ElseIf (txtA.Text = "" Or txtA.Text = ".") And (txtB.Text = "" Or txtB.Text = ".") And (txtC.Text IsNot "" Or txtC.Text IsNot ".") Then

            MsgBox("Se requieren dos lados para calcular el tercero")
            tresLados = False





            'Cuando introduces dos lados
        Else





            'Cuando metes a y b
            If (txtA.Text IsNot "" Or txtA.Text IsNot ".") And (txtB.Text IsNot "" Or txtB.Text IsNot ".") And (txtC.Text = "" Or txtC.Text = ".") Then

                a = Convert.ToDouble(txtA.Text)
                b = Convert.ToDouble(txtB.Text)


                'Cuando algun lado vale 0
                If (a <= 0) Or (b <= 0) Then

                    MsgBox("Ningun lado puede valer cero")
                    tresLados = False

                Else

                    c = Math.Sqrt((a ^ 2) + (b ^ 2))

                    lblHip.Text = "c = " & c
                    lblCatA.Text = "a = " & a
                    lblCatB.Text = "b = " & b

                    lblFormula.Text = "c = √ ( ( " & a & " ^ 2 ) + ( " & b & " ^ 2 ) ) = " & c

                    puntoA = False
                    puntoB = False
                    puntoC = False

                    tresLados = False
                End If


            End If



            'Cuando metes a y c
            If (txtA.Text IsNot "" Or txtA.Text IsNot ".") And (txtB.Text = "" Or txtB.Text = ".") And (txtC.Text IsNot "" Or txtC.Text IsNot ".") Then

                a = Convert.ToDouble(txtA.Text)
                c = Convert.ToDouble(txtC.Text)

                'Cuando algun lado vale 0
                If (a <= 0) Or (c <= 0) Then

                    MsgBox("Ningun lado puede valer cero")
                    tresLados = False

                ElseIf a >= c Then

                    MsgBox("Ningun cateto puede valer mas o igual a la hipotenusa")
                    tresLados = False

                Else

                    b = Math.Sqrt((c ^ 2) - (a ^ 2))

                    lblHip.Text = "c = " & c
                    lblCatA.Text = "a = " & a
                    lblCatB.Text = "b = " & b

                    lblFormula.Text = "b = √ ( ( " & c & " ^ 2 ) - ( " & a & " ^ 2 ) ) = " & b

                    puntoA = False
                    puntoB = False
                    puntoC = False
                    tresLados = False

                End If

            End If


            'Cuando metes b y c
            If (txtA.Text = "" Or txtA.Text = ".") And (txtB.Text IsNot "" Or txtB.Text IsNot ".") And (txtC.Text IsNot "" Or txtC.Text IsNot ".") Then

                b = Convert.ToDouble(txtB.Text)
                c = Convert.ToDouble(txtC.Text)

                'Cuando algun lado vale 0
                If (b <= 0) Or (c <= 0) Then

                    MsgBox("Ningun lado puede valer cero")
                    tresLados = False

                ElseIf b >= c Then

                    MsgBox("Ningun cateto puede valer mas o igual a la hipotenusa")
                    tresLados = False

                Else

                    a = Math.Sqrt((c ^ 2) - (b ^ 2))

                    lblHip.Text = "c = " & c
                    lblCatA.Text = "a = " & a
                    lblCatB.Text = "b = " & b

                    lblFormula.Text = "a = √ ( ( " & c & " ^ 2 ) - ( " & b & " ^ 2 ) ) = " & a

                    puntoA = False
                    puntoB = False
                    puntoC = False
                    tresLados = False

                End If

            End If


        End If

        If tresLados = True Then

            MsgBox("Solo debes introducir dos lados para calcular el tercero")

        End If




        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""

        puntoA = False
        puntoB = False
        puntoC = False

        tresLados = False
    End Sub

End Class
