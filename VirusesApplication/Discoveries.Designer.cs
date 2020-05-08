namespace VirusesApplication
{
    partial class Discoveries
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
            this.scientistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virusScientistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet6 = new VirusesApplication.VirusesDBDataSet6();
            this.virusScientistTableAdapter = new VirusesApplication.VirusesDBDataSet6TableAdapters.VirusScientistTableAdapter();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dId = new System.Windows.Forms.TextBox();
            this.dYear = new System.Windows.Forms.TextBox();
            this.dSci = new System.Windows.Forms.TextBox();
            this.dVir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusScientistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.virusIdDataGridViewTextBoxColumn,
            this.scientistIdDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.virusScientistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(177, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
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
            // scientistIdDataGridViewTextBoxColumn
            // 
            this.scientistIdDataGridViewTextBoxColumn.DataPropertyName = "ScientistId";
            this.scientistIdDataGridViewTextBoxColumn.HeaderText = "ScientistId";
            this.scientistIdDataGridViewTextBoxColumn.Name = "scientistIdDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // virusScientistBindingSource
            // 
            this.virusScientistBindingSource.DataMember = "VirusScientist";
            this.virusScientistBindingSource.DataSource = this.virusesDBDataSet6;
            // 
            // virusesDBDataSet6
            // 
            this.virusesDBDataSet6.DataSetName = "VirusesDBDataSet6";
            this.virusesDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virusScientistTableAdapter
            // 
            this.virusScientistTableAdapter.ClearBeforeFill = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(537, 67);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 1;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(443, 67);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 2;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(351, 67);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dId
            // 
            this.dId.Location = new System.Drawing.Point(225, 30);
            this.dId.Name = "dId";
            this.dId.Size = new System.Drawing.Size(100, 20);
            this.dId.TabIndex = 4;
            // 
            // dYear
            // 
            this.dYear.Location = new System.Drawing.Point(225, 108);
            this.dYear.Name = "dYear";
            this.dYear.Size = new System.Drawing.Size(100, 20);
            this.dYear.TabIndex = 5;
            // 
            // dSci
            // 
            this.dSci.Location = new System.Drawing.Point(225, 82);
            this.dSci.Name = "dSci";
            this.dSci.Size = new System.Drawing.Size(100, 20);
            this.dSci.TabIndex = 6;
            // 
            // dVir
            // 
            this.dVir.Location = new System.Drawing.Point(225, 56);
            this.dVir.Name = "dVir";
            this.dVir.Size = new System.Drawing.Size(100, 20);
            this.dVir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ScientistId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "VirusId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "To menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Discoveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dVir);
            this.Controls.Add(this.dSci);
            this.Controls.Add(this.dYear);
            this.Controls.Add(this.dId);
            this.Controls.Add(this.add);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Discoveries";
            this.Text = "Discoveries";
            this.Load += new System.EventHandler(this.Discoveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusScientistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VirusesDBDataSet6 virusesDBDataSet6;
        private System.Windows.Forms.BindingSource virusScientistBindingSource;
        private VirusesDBDataSet6TableAdapters.VirusScientistTableAdapter virusScientistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn virusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scientistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox dId;
        private System.Windows.Forms.TextBox dYear;
        private System.Windows.Forms.TextBox dSci;
        private System.Windows.Forms.TextBox dVir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}