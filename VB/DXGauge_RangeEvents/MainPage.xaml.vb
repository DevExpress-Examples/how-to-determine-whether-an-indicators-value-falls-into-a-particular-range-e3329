Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Gauges

Namespace DXGauge_RangeEvents
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub GreenRange_IndicatorEnter(ByVal sender As Object, ByVal e As IndicatorEnterEventArgs)
			stateIndicator.Fill = New SolidColorBrush(Colors.Green)
		End Sub

		Private Sub GreenRange_IndicatorLeave(ByVal sender As Object, ByVal e As IndicatorLeaveEventArgs)
			stateIndicator.Fill = New SolidColorBrush(Colors.Gray)
		End Sub

		Private Sub YellowRange_IndicatorEnter(ByVal sender As Object, ByVal e As IndicatorEnterEventArgs)
			stateIndicator.Fill = New SolidColorBrush(Colors.Yellow)
		End Sub

		Private Sub YellowRange_IndicatorLeave(ByVal sender As Object, ByVal e As IndicatorLeaveEventArgs)
			If ((e.NewValue) < 10) OrElse (((e.NewValue) > 90)) Then
				stateIndicator.Fill = New SolidColorBrush(Colors.Gray)
			End If
		End Sub

		Private Sub RedRange_IndicatorEnter(ByVal sender As Object, ByVal e As IndicatorEnterEventArgs)
			stateIndicator.Fill = New SolidColorBrush(Colors.Red)
		End Sub

		Private Sub RedRange_IndicatorLeave(ByVal sender As Object, ByVal e As IndicatorLeaveEventArgs)
			If ((e.NewValue) < 10) OrElse (((e.NewValue) > 90)) Then
				stateIndicator.Fill = New SolidColorBrush(Colors.Gray)
			End If
		End Sub
	End Class
End Namespace
