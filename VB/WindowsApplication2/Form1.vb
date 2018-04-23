Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication2
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim r As New Random()
			For i As Integer = 0 To 9
				dataTable1.Rows.Add("name " & i.ToString(), r.NextDouble() * 100)
			Next i
		End Sub

		Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawFooterCell
			If e.Column.FieldName = "Amount" Then
				Dim v As Object = e.Info.Value
				If Not(TypeOf v Is Decimal) Then
					Return
				End If

				Dim d As Decimal = Convert.ToDecimal(v)
				If d <= 0 Then
					e.Appearance.ForeColor = Color.Red
				ElseIf d <= 500 Then
					e.Appearance.ForeColor = Color.GreenYellow
				Else
					e.Appearance.ForeColor = Color.Green
				End If
			End If

		End Sub
	End Class
End Namespace