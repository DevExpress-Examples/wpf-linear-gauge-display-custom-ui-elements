Imports System.Windows

Namespace LinearGauge_CustomElement

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.bar.Value < 100 Then Me.bar.Value += 10
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.bar.Value > 0 Then Me.bar.Value -= 10
        End Sub
    End Class
End Namespace
