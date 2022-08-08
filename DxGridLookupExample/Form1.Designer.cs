namespace DxGridLookupExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            this.bsColors = new System.Windows.Forms.BindingSource(this.components);
            this.gcCars = new DevExpress.XtraGrid.GridControl();
            this.gvCars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repColors = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repColors)).BeginInit();
            this.SuspendLayout();
            // 
            // bsCars
            // 
            this.bsCars.DataSource = typeof(DxGridLookupExample.Car);
            // 
            // bsColors
            // 
            this.bsColors.DataSource = typeof(DxGridLookupExample.Color);
            // 
            // gcCars
            // 
            this.gcCars.DataSource = this.bsCars;
            this.gcCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCars.Location = new System.Drawing.Point(0, 0);
            this.gcCars.MainView = this.gvCars;
            this.gcCars.Name = "gcCars";
            this.gcCars.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repColors});
            this.gcCars.Size = new System.Drawing.Size(759, 434);
            this.gcCars.TabIndex = 1;
            this.gcCars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCars});
            // 
            // gvCars
            // 
            this.gvCars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMarka,
            this.colOpis,
            this.colColorId});
            this.gvCars.GridControl = this.gcCars;
            this.gvCars.Name = "gvCars";
            this.gvCars.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 1;
            // 
            // colOpis
            // 
            this.colOpis.FieldName = "Opis";
            this.colOpis.Name = "colOpis";
            this.colOpis.Visible = true;
            this.colOpis.VisibleIndex = 2;
            // 
            // colColorId
            // 
            this.colColorId.ColumnEdit = this.repColors;
            this.colColorId.FieldName = "ColorId";
            this.colColorId.Name = "colColorId";
            this.colColorId.Visible = true;
            this.colColorId.VisibleIndex = 3;
            // 
            // repColors
            // 
            this.repColors.AutoHeight = false;
            this.repColors.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repColors.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repColors.DataSource = this.bsColors;
            this.repColors.DisplayMember = "Name";
            this.repColors.KeyMember = "Id";
            this.repColors.Name = "repColors";
            this.repColors.ValueMember = "Id";
            this.repColors.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.repColors_QueryPopUp);
            this.repColors.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repColors_CloseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 434);
            this.Controls.Add(this.gcCars);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCars;
        private System.Windows.Forms.BindingSource bsColors;
        private DevExpress.XtraGrid.GridControl gcCars;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCars;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colOpis;
        private DevExpress.XtraGrid.Columns.GridColumn colColorId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repColors;
    }
}

