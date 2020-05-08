namespace VirusesApplication
{
    partial class Genomes
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
            this.virusesDBDataSet = new VirusesApplication.VirusesDBDataSet();
            this.virusesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GenomeGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet1 = new VirusesApplication.VirusesDBDataSet1();
            this.virusesDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genomeTableAdapter = new VirusesApplication.VirusesDBDataSet1TableAdapters.GenomeTableAdapter();
            this.gen_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genSense = new System.Windows.Forms.TextBox();
            this.genStrand = new System.Windows.Forms.TextBox();
            this.genName = new System.Windows.Forms.TextBox();
            this.genId = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenomeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // virusesDBDataSet
            // 
            this.virusesDBDataSet.DataSetName = "VirusesDBDataSet";
            this.virusesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virusesDBDataSetBindingSource
            // 
            this.virusesDBDataSetBindingSource.DataSource = this.virusesDBDataSet;
            this.virusesDBDataSetBindingSource.Position = 0;
            // 
            // virusesDBDataSetBindingSource1
            // 
            this.virusesDBDataSetBindingSource1.DataSource = this.virusesDBDataSet;
            this.virusesDBDataSetBindingSource1.Position = 0;
            this.virusesDBDataSetBindingSource1.CurrentChanged += new System.EventHandler(this.virusesDBDataSetBindingSource1_CurrentChanged);
            // 
            // GenomeGrid
            // 
            this.GenomeGrid.AutoGenerateColumns = false;
            this.GenomeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenomeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.strandDataGridViewTextBoxColumn,
            this.senseDataGridViewTextBoxColumn});
            this.GenomeGrid.DataSource = this.genomeBindingSource;
            this.GenomeGrid.Location = new System.Drawing.Point(191, 244);
            this.GenomeGrid.Name = "GenomeGrid";
            this.GenomeGrid.Size = new System.Drawing.Size(447, 150);
            this.GenomeGrid.TabIndex = 0;
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
            // strandDataGridViewTextBoxColumn
            // 
            this.strandDataGridViewTextBoxColumn.DataPropertyName = "Strand";
            this.strandDataGridViewTextBoxColumn.HeaderText = "Strand";
            this.strandDataGridViewTextBoxColumn.Name = "strandDataGridViewTextBoxColumn";
            // 
            // senseDataGridViewTextBoxColumn
            // 
            this.senseDataGridViewTextBoxColumn.DataPropertyName = "Sense";
            this.senseDataGridViewTextBoxColumn.HeaderText = "Sense";
            this.senseDataGridViewTextBoxColumn.Name = "senseDataGridViewTextBoxColumn";
            // 
            // genomeBindingSource
            // 
            this.genomeBindingSource.DataMember = "Genome";
            this.genomeBindingSource.DataSource = this.virusesDBDataSet1;
            // 
            // virusesDBDataSet1
            // 
            this.virusesDBDataSet1.DataSetName = "VirusesDBDataSet1";
            this.virusesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virusesDBDataSetBindingSource2
            // 
            this.virusesDBDataSetBindingSource2.DataSource = this.virusesDBDataSet;
            this.virusesDBDataSetBindingSource2.Position = 0;
            // 
            // genomeTableAdapter
            // 
            this.genomeTableAdapter.ClearBeforeFill = true;
            // 
            // gen_id
            // 
            this.gen_id.AutoSize = true;
            this.gen_id.Location = new System.Drawing.Point(135, 57);
            this.gen_id.Name = "gen_id";
            this.gen_id.Size = new System.Drawing.Size(16, 13);
            this.gen_id.TabIndex = 1;
            this.gen_id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Strand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sense";
            // 
            // genSense
            // 
            this.genSense.Location = new System.Drawing.Point(203, 158);
            this.genSense.Name = "genSense";
            this.genSense.Size = new System.Drawing.Size(100, 20);
            this.genSense.TabIndex = 5;
            // 
            // genStrand
            // 
            this.genStrand.Location = new System.Drawing.Point(203, 123);
            this.genStrand.Name = "genStrand";
            this.genStrand.Size = new System.Drawing.Size(100, 20);
            this.genStrand.TabIndex = 6;
            // 
            // genName
            // 
            this.genName.Location = new System.Drawing.Point(203, 90);
            this.genName.Name = "genName";
            this.genName.Size = new System.Drawing.Size(100, 20);
            this.genName.TabIndex = 7;
            // 
            // genId
            // 
            this.genId.Location = new System.Drawing.Point(203, 57);
            this.genId.Name = "genId";
            this.genId.Size = new System.Drawing.Size(100, 20);
            this.genId.TabIndex = 8;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(554, 102);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 9;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(446, 102);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 10;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(340, 102);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "To menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Genomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.genId);
            this.Controls.Add(this.genName);
            this.Controls.Add(this.genStrand);
            this.Controls.Add(this.genSense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gen_id);
            this.Controls.Add(this.GenomeGrid);
            this.Name = "Genomes";
            this.Text = "Genomes";
            this.Load += new System.EventHandler(this.Genomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenomeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource virusesDBDataSetBindingSource;
        private VirusesDBDataSet virusesDBDataSet;
        private System.Windows.Forms.BindingSource virusesDBDataSetBindingSource1;
        private System.Windows.Forms.DataGridView GenomeGrid;
        private System.Windows.Forms.BindingSource virusesDBDataSetBindingSource2;
        private VirusesDBDataSet1 virusesDBDataSet1;
        private System.Windows.Forms.BindingSource genomeBindingSource;
        private VirusesDBDataSet1TableAdapters.GenomeTableAdapter genomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label gen_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genSense;
        private System.Windows.Forms.TextBox genStrand;
        private System.Windows.Forms.TextBox genName;
        private System.Windows.Forms.TextBox genId;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
    }
}