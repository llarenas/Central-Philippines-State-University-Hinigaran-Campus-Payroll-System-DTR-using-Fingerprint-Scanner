'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Public Class welcome

    Private Sub welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = 2000 'for 5 seconds and 10 000 for 10 seconds

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        timeattendance.Show()
        Timer1.Enabled = False
        Me.Hide()

    End Sub

End Class

