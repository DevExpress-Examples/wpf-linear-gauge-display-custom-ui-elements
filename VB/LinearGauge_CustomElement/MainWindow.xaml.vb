Imports Microsoft.VisualBasic
Imports System.Windows

Namespace LinearGauge_CustomElement

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If bar.Value < 100 Then
				bar.Value += 10
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If bar.Value > 0 Then
				bar.Value -= 10
			End If
		End Sub
	End Class
End Namespace
