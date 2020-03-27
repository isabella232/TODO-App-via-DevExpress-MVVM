namespace TodoApp.Views {
    partial class ItemView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
            this.headerPane = new DevExpress.Utils.Layout.TablePanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.footerPane = new DevExpress.Utils.Layout.TablePanel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dataPane = new DevExpress.Utils.Layout.TablePanel();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.teDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tglCompleted = new DevExpress.XtraEditors.ToggleSwitch();
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).BeginInit();
            this.footerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPane)).BeginInit();
            this.dataPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglCompleted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPane
            // 
            this.headerPane.AutoSize = true;
            this.headerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.headerPane.Controls.Add(this.btnBack);
            this.headerPane.Controls.Add(this.titleLabel);
            this.headerPane.Controls.Add(this.btnDelete);
            this.headerPane.Controls.Add(this.btnSave);
            this.headerPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPane.Location = new System.Drawing.Point(24, 12);
            this.headerPane.Margin = new System.Windows.Forms.Padding(0);
            this.headerPane.Name = "headerPane";
            this.headerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.headerPane.Size = new System.Drawing.Size(350, 38);
            this.headerPane.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.AllowFocus = false;
            this.btnBack.AutoSize = true;
            this.headerPane.SetColumn(this.btnBack, 0);
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.ImageOptions.SvgImage = Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.headerPane.SetRow(this.btnBack, 0);
            this.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBack.Size = new System.Drawing.Size(38, 38);
            this.btnBack.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.FontSizeDelta = 4;
            this.titleLabel.Appearance.Options.UseFont = true;
            this.titleLabel.Appearance.Options.UseTextOptions = true;
            this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.headerPane.SetColumn(this.titleLabel, 1);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(38, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.headerPane.SetRow(this.titleLabel, 0);
            this.titleLabel.Size = new System.Drawing.Size(236, 38);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // footerPane
            // 
            this.footerPane.AutoSize = true;
            this.footerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPane.Controls.Add(this.tglCompleted);
            this.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPane.Location = new System.Drawing.Point(24, 418);
            this.footerPane.Margin = new System.Windows.Forms.Padding(0);
            this.footerPane.Name = "footerPane";
            this.footerPane.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.footerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPane.Size = new System.Drawing.Size(350, 38);
            this.footerPane.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowFocus = false;
            this.btnDelete.AutoSize = true;
            this.headerPane.SetColumn(this.btnDelete, 2);
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.ImageOptions.SvgImage = Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(274, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.headerPane.SetRow(this.btnDelete, 0);
            this.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDelete.Size = new System.Drawing.Size(38, 38);
            this.btnDelete.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.AllowFocus = false;
            this.btnSave.AutoSize = true;
            this.headerPane.SetColumn(this.btnSave, 3);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.ImageOptions.SvgImage = Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(312, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.headerPane.SetRow(this.btnSave, 0);
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(38, 38);
            this.btnSave.TabIndex = 3;
            // 
            // dataPane
            // 
            this.dataPane.AutoSize = true;
            this.dataPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.dataPane.Controls.Add(this.lblDescription);
            this.dataPane.Controls.Add(this.lblTitle);
            this.dataPane.Controls.Add(this.teTitle);
            this.dataPane.Controls.Add(this.teDescription);
            this.dataPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPane.Location = new System.Drawing.Point(24, 50);
            this.dataPane.Margin = new System.Windows.Forms.Padding(0);
            this.dataPane.Name = "dataPane";
            this.dataPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.dataPane.Size = new System.Drawing.Size(350, 368);
            this.dataPane.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.FontSizeDelta = 2;
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Appearance.Options.UseTextOptions = true;
            this.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.dataPane.SetColumn(this.lblDescription, 0);
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Location = new System.Drawing.Point(0, 67);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dataPane.SetRow(this.lblDescription, 2);
            this.lblDescription.Size = new System.Drawing.Size(350, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.FontSizeDelta = 2;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.dataPane.SetColumn(this.lblTitle, 0);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
            this.dataPane.SetRow(this.lblTitle, 0);
            this.lblTitle.Size = new System.Drawing.Size(350, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // teTitle
            // 
            this.dataPane.SetColumn(this.teTitle, 0);
            this.teTitle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teTitle.Location = new System.Drawing.Point(3, 40);
            this.teTitle.Name = "teTitle";
            this.teTitle.Properties.NullValuePrompt = "Enter task title here...";
            this.teTitle.Properties.ValidateOnEnterKey = true;
            this.dataPane.SetRow(this.teTitle, 1);
            this.teTitle.Size = new System.Drawing.Size(344, 24);
            this.teTitle.TabIndex = 2;
            // 
            // teDescription
            // 
            this.dataPane.SetColumn(this.teDescription, 0);
            this.teDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.teDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teDescription.Location = new System.Drawing.Point(0, 92);
            this.teDescription.Margin = new System.Windows.Forms.Padding(0);
            this.teDescription.Name = "teDescription";
            this.teDescription.Properties.NullValuePrompt = "Enter task description here...";
            this.teDescription.Properties.ValidateOnEnterKey = true;
            this.dataPane.SetRow(this.teDescription, 3);
            this.teDescription.Size = new System.Drawing.Size(350, 276);
            this.teDescription.TabIndex = 3;
            // 
            // tglCompleted
            // 
            this.footerPane.SetColumn(this.tglCompleted, 1);
            this.tglCompleted.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.todoItemBindingSource, "IsCompleted", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tglCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tglCompleted.EditValue = true;
            this.tglCompleted.Location = new System.Drawing.Point(202, 8);
            this.tglCompleted.Margin = new System.Windows.Forms.Padding(0);
            this.tglCompleted.Name = "tglCompleted";
            this.tglCompleted.Properties.AllowFocused = false;
            this.tglCompleted.Properties.AutoWidth = true;
            this.tglCompleted.Properties.OffText = " Is Completed";
            this.tglCompleted.Properties.OnText = " Is Completed";
            this.footerPane.SetRow(this.tglCompleted, 0);
            this.tglCompleted.Size = new System.Drawing.Size(148, 30);
            this.tglCompleted.TabIndex = 5;
            // 
            // todoItemBindingSource
            // 
            this.todoItemBindingSource.DataSource = typeof(TodoApp.Model.TodoItem);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(TodoApp.ViewModels.ItemViewModel);
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataPane);
            this.Controls.Add(this.footerPane);
            this.Controls.Add(this.headerPane);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemView";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.Size = new System.Drawing.Size(398, 468);
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).EndInit();
            this.footerPane.ResumeLayout(false);
            this.footerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPane)).EndInit();
            this.dataPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglCompleted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.Utils.Layout.TablePanel headerPane;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.Utils.Layout.TablePanel footerPane;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.Utils.Layout.TablePanel dataPane;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.MemoEdit teDescription;
        private System.Windows.Forms.BindingSource todoItemBindingSource;
        private DevExpress.XtraEditors.ToggleSwitch tglCompleted;
    }
}
