using System;
using System.Windows.Forms;

namespace WindowsFormsDataGridviewSample
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      //initialize dataset
      //_dataTable = new DataTable();
      //_dataSet = new DataSet();
      //_dataTable.Columns.Add("colonne1");
      //_dataTable.Columns.Add("colonne2");
      ////AdvancedDataGridView.
      //_dataTable.TableName= "Data table name";
      //_dataTable = _dataSet.Tables.Add("TableTest");
      //_dataTable.Columns.Add("colonne1", typeof(string));
      //_dataTable.Columns.Add("colonne2", typeof(string));
      //bindingSource_main.DataMember = _dataTable.TableName;

      //advancedDataGridViewSearchToolBar_main.SetColumns(advancedDataGridView_main.Columns);
      object[] newRow = new object[] {
        "data1",
        "data2"
      };

      //_dataTable.Rows.Add(newRow);

      advancedDataGridViewMain.Columns.Add("colonne1", "header1");
      advancedDataGridViewMain.Columns.Add("colonne2", "header2");
      //var onerow = new DataGridViewRow();
      //onerow.Cells.Add(new DataGridViewCell("dd"));
      //var rowcollection = new DataGridViewRowCollection()
      advancedDataGridViewMain.Rows.Add(newRow);

    }
  }
}

