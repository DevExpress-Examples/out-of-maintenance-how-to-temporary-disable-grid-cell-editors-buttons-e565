Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication186
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.riEnabledButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.riDisabledButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.riEnabledButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.riDisabledButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataMember = "Table1"
			Me.gridControl1.DataSource = Me.dataSet1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.riEnabledButtonEdit, Me.riDisabledButtonEdit})
			Me.gridControl1.Size = New System.Drawing.Size(499, 356)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomRowCellEdit += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridView1_CustomRowCellEdit);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Name"
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.ColumnEdit = Me.riEnabledButtonEdit
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 1
			' 
			' riEnabledButtonEdit
			' 
			Me.riEnabledButtonEdit.AutoHeight = False
			Me.riEnabledButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Start!", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
			Me.riEnabledButtonEdit.Name = "riEnabledButtonEdit"
'			Me.riEnabledButtonEdit.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.repositoryItemButtonEdit1_ButtonClick);
			' 
			' riDisabledButtonEdit
			' 
			Me.riDisabledButtonEdit.AutoHeight = False
			Me.riDisabledButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Processing", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
			Me.riDisabledButtonEdit.Name = "riDisabledButtonEdit"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(499, 356)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.riEnabledButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.riDisabledButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents riEnabledButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private riDisabledButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace

