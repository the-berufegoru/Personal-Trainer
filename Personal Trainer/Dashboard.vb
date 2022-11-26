Public Class Dashboard
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' declare variable to store distances
        Dim saturdayDistance, sundayDistance As Decimal
        ' declare variables to store time
        Dim saturdayTime, sundayTime As Integer

        ' check if saturday is checked
        If chkSaturday.Checked = True Then
            ' convert saturday distance to decimal and assign to saturdayDistance
            If Decimal.TryParse(txtSaturdayDisance.Text, saturdayDistance) Then
                ' convert saturday distance to decimal and assign to saturdayTime
                If Decimal.TryParse(txtSaturdayTime.Text, saturdayTime) Then
                    ' check if distance < 1.0 and time < 1
                    If (saturdayDistance < 1.0) Or (saturdayTime < 1) Then
                        MessageBox.Show("Sorry, Distance And Time Must Be Greater Than 0", "VALUE ERROR")
                    Else

                    End If
                Else
                    MessageBox.Show("Saturday Time Not Valid.", "INPUT ERROR")
                End If
            Else
                MessageBox.Show("Saturday Distance Not Valid.", "INPUT ERROR")
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkSaturday.Checked = False
        chkSunday.Checked = False
        txtSaturdayDisance.Text = ""
        txtSundayDisance.Text = ""
        txtSaturdayTime.Text = ""
        txtSundayTime.Text = ""
        ' clear output labels
        lblTotalDistance.Text = ""
        lblAverageDistance.Text = ""
        lblTotalTime.Text = ""
        lblAverageTime.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim exitStatus As DialogResult = MessageBox.Show("Are You Sure You Want To Exit ?", "EXIT WARNING", MessageBoxButtons.YesNo)

        ' check if user clicked yes and close program
        If exitStatus = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
