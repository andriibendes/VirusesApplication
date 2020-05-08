namespace VirusesApplication
{
    partial class Medicine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virusDrugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet5 = new VirusesApplication.VirusesDBDataSet5();
            this.virusDrugTableAdapter = new VirusesApplication.VirusesDBDataSet5TableAdapters.VirusDrugTableAdapter();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mDrug = new System.Windows.Forms.TextBox();
            this.mVir = new System.Windows.Forms.TextBox();
            this.mId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusDrugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.virusIdDataGridViewTextBoxColumn,
            this.drugIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.virusDrugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(222, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // virusIdDataGridViewTextBoxColumn
            // 
            this.virusIdDataGridViewTextBoxColumn.DataPropertyName = "VirusId";
            this.virusIdDataGridViewTextBoxColumn.HeaderText = "VirusId";
            this.virusIdDataGridViewTextBoxColumn.Name = "virusIdDataGridViewTextBoxColumn";
            // 
            // drugIdDataGridViewTextBoxColumn
            // 
            this.drugIdDataGridViewTextBoxColumn.DataPropertyName = "DrugId";
            this.drugIdDataGridViewTextBoxColumn.HeaderText = "DrugId";
            this.drugIdDataGridViewTextBoxColumn.Name = "drugIdDataGridViewTextBoxColumn";
            // 
            // virusDrugBindingSource
            // 
            this.virusDrugBindingSource.DataMember = "VirusDrug";
            this.virusDrugBindingSource.DataSource = this.virusesDBDataSet5;
            // 
            // virusesDBDataSet5
            // 
            this.virusesDBDataSet5.DataSetName = "VirusesDBDataSet5";
            this.virusesDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virusDrugTableAdapter
            // 
            this.virusDrugTableAdapter.ClearBeforeFill = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(319, 79);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(525, 79);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.button2_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(419, 79);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 3;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VirusId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DrugId";
            // 
            // mDrug
            // 
            this.mDrug.Location = new System.Drawing.Point(189, 114);
            this.mDrug.Name = "mDrug";
            this.mDrug.Size = new System.Drawing.Size(100, 20);
            this.mDrug.TabIndex = 7;
            // 
            // mVir
            // 
            this.mVir.Location = new System.Drawing.Point(189, 79);
            this.mVir.Name = "mVir";
            this.mVir.Size = new System.Drawing.Size(100, 20);
            this.mVir.TabIndex = 8;
            // 
            // mId
            // 
            this.mId.Location = new System.Drawing.Point(189, 42);
            this.mId.Name = "mId";
            this.mId.Size = new System.Drawing.Size(100, 20);
            this.mId.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "To menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mId);
            this.Controls.Add(this.mVir);
            this.Controls.Add(this.mDrug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusDrugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VirusesDBDataSet5 virusesDBDataSet5;
        private System.Windows.Forms.BindingSource virusDrugBindingSource;
        private VirusesDBDataSet5TableAdapters.VirusDrugTableAdapter virusDrugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn virusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mDrug;
        private System.Windows.Forms.TextBox mVir;
        private System.Windows.Forms.TextBox mId;
        private System.Windows.Forms.Button button1;
    }
}