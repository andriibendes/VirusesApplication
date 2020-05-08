namespace VirusesApplication
{
    partial class Scientists
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
            this.SGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet2 = new VirusesApplication.VirusesDBDataSet2();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sCou = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.sId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scientistTableAdapter = new VirusesApplication.VirusesDBDataSet2TableAdapters.ScientistTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // SGrid
            // 
            this.SGrid.AutoGenerateColumns = false;
            this.SGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.SGrid.DataSource = this.scientistBindingSource;
            this.SGrid.Location = new System.Drawing.Point(231, 174);
            this.SGrid.Name = "SGrid";
            this.SGrid.Size = new System.Drawing.Size(343, 150);
            this.SGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // scientistBindingSource
            // 
            this.scientistBindingSource.DataMember = "Scientist";
            this.scientistBindingSource.DataSource = this.virusesDBDataSet2;
            // 
            // virusesDBDataSet2
            // 
            this.virusesDBDataSet2.DataSetName = "VirusesDBDataSet2";
            this.virusesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(525, 76);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 1;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(426, 75);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 2;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(327, 75);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sCou
            // 
            this.sCou.Location = new System.Drawing.Point(175, 117);
            this.sCou.Name = "sCou";
            this.sCou.Size = new System.Drawing.Size(100, 20);
            this.sCou.TabIndex = 4;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(175, 78);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(100, 20);
            this.sName.TabIndex = 5;
            // 
            // sId
            // 
            this.sId.Location = new System.Drawing.Point(175, 40);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(100, 20);
            this.sId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            // 
            // scientistTableAdapter
            // 
            this.scientistTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "To menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Scientists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.sCou);
            this.Controls.Add(this.add);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.SGrid);
            this.Name = "Scientists";
            this.Text = "Scientists";
            this.Load += new System.EventHandler(this.Scientists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SGrid;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox sCou;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.TextBox sId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VirusesDBDataSet2 virusesDBDataSet2;
        private System.Windows.Forms.BindingSource scientistBindingSource;
        private VirusesDBDataSet2TableAdapters.ScientistTableAdapter scientistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}