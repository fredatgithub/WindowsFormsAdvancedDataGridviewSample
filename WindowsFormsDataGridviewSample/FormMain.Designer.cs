using System.Windows.Forms;

namespace WindowsFormsDataGridviewSample
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.advancedDataGridViewMain = new ADGV.AdvancedDataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewMain)).BeginInit();
      this.SuspendLayout();
      // 
      // advancedDataGridViewMain
      // 
      this.advancedDataGridViewMain.AllowUserToAddRows = false;
      this.advancedDataGridViewMain.AllowUserToDeleteRows = false;
      this.advancedDataGridViewMain.AllowUserToOrderColumns = true;
      this.advancedDataGridViewMain.AutoGenerateContextFilters = true;
      this.advancedDataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.advancedDataGridViewMain.DateWithTime = false;
      this.advancedDataGridViewMain.Location = new System.Drawing.Point(101, 86);
      this.advancedDataGridViewMain.Name = "advancedDataGridViewMain";
      this.advancedDataGridViewMain.ReadOnly = true;
      this.advancedDataGridViewMain.Size = new System.Drawing.Size(613, 303);
      this.advancedDataGridViewMain.TabIndex = 0;
      this.advancedDataGridViewMain.TimeFilter = false;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.advancedDataGridViewMain);
      this.Name = "FormMain";
      this.Text = "sample Advanced Data Grid View";
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewMain)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    //private BindingSource bindingSource_main;
    private ADGV.AdvancedDataGridView advancedDataGridViewMain;
  }
}

