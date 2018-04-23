Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsFormsApplication186
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private ht As New Hashtable()
		Private rowsInProcess As List(Of DataRow) = New List(Of DataRow)()
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 4
				dataTable1.Rows.Add(New Object() { i, "Name" & i})
			Next i

		End Sub

		Private Sub repositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles riEnabledButtonEdit.ButtonClick
			Dim t As New Timer()
			t.Interval = 2000
			AddHandler t.Tick, AddressOf t_Tick
			Dim view As GridView = CType(gridControl1.FocusedView, GridView)
			Dim dr As DataRow = view.GetDataRow(view.FocusedRowHandle)
			view.CloseEditor()
			view.UpdateCurrentRow()
			t.Tag = dr
			t.Start()
			rowsInProcess.Add(dr)
		End Sub

		Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim t As Timer = CType(sender, Timer)
			Dim dr As DataRow = TryCast(t.Tag, DataRow)
			rowsInProcess.Remove(dr)
			gridView1.CloseEditor()
			gridView1.RefreshRow(FindRowHandleByDataRow(gridView1, dr))
			t.Stop()
		End Sub

		Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
			If e.Column.FieldName = "Name" Then
				Dim view As GridView = CType(sender, GridView)
				Dim dr As DataRow = view.GetDataRow(e.RowHandle)
				If rowsInProcess.Contains(dr) Then
					e.RepositoryItem = riDisabledButtonEdit
				Else
					e.RepositoryItem = riEnabledButtonEdit
				End If
			End If
		End Sub


		Private Function FindRowHandleByDataRow(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As DataRow) As Integer
    Dim I As Integer
    For I = 0 To view.DataRowCount - 1
        If row.Equals(view.GetRow(I)) Then
            Return I
        End If
    Next
    Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
		End Function
	End Class
End Namespace
