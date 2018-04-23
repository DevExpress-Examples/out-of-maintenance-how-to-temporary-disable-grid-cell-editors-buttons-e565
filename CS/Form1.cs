using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsFormsApplication186
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable ht = new Hashtable();
        List<DataRow> rowsInProcess = new List<DataRow>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =0; i<5; i++)
                dataTable1.Rows.Add(new object[] { i, "Name" + i});

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 2000;
            t.Tick += new EventHandler(t_Tick);
            GridView view = (GridView)gridControl1.FocusedView;
            DataRow dr = view.GetDataRow(view.FocusedRowHandle);
            view.CloseEditor();
            view.UpdateCurrentRow();
            t.Tag = dr;
            t.Start();
            rowsInProcess.Add(dr);
        }

        void t_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            DataRow dr = t.Tag as DataRow;
            rowsInProcess.Remove(dr);
            gridView1.CloseEditor();
            gridView1.RefreshRow(FindRowHandleByDataRow(gridView1, dr));
            t.Stop();
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Name") {
                GridView view = (GridView)sender;
                DataRow dr = view.GetDataRow(e.RowHandle);
                if (rowsInProcess.Contains(dr))
                    e.RepositoryItem = riDisabledButtonEdit;
                else
                    e.RepositoryItem = riEnabledButtonEdit;
            }
        }


        private int FindRowHandleByDataRow(DevExpress.XtraGrid.Views.Grid.GridView view, DataRow row)
        {
            for (int i = 0; i < view.DataRowCount; i++)
                if (view.GetDataRow(i) == row)
                    return i;
            return DevExpress.XtraGrid.GridControl.InvalidRowHandle;
        }
    }
}
