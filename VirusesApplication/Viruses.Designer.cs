namespace VirusesApplication
{
    partial class Viruses
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organismIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet4 = new VirusesApplication.VirusesDBDataSet4();
            this.virusTableAdapter = new VirusesApplication.VirusesDBDataSet4TableAdapters.VirusTableAdapter();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vOrg = new System.Windows.Forms.TextBox();
            this.vGen = new System.Windows.Forms.TextBox();
            this.vName = new System.Windows.Forms.TextBox();
            this.vId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genomeIdDataGridViewTextBoxColumn,
            this.organismIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.virusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
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
            // genomeIdDataGridViewTextBoxColumn
            // 
            this.genomeIdDataGridViewTextBoxColumn.DataPropertyName = "GenomeId";
            this.genomeIdDataGridViewTextBoxColumn.HeaderText = "GenomeId";
            this.genomeIdDataGridViewTextBoxColumn.Name = "genomeIdDataGridViewTextBoxColumn";
            // 
            // organismIdDataGridViewTextBoxColumn
            // 
            this.organismIdDataGridViewTextBoxColumn.DataPropertyName = "OrganismId";
            this.organismIdDataGridViewTextBoxColumn.HeaderText = "OrganismId";
            this.organismIdDataGridViewTextBoxColumn.Name = "organismIdDataGridViewTextBoxColumn";
            // 
            // virusBindingSource
            // 
            this.virusBindingSource.DataMember = "Virus";
            this.virusBindingSource.DataSource = this.virusesDBDataSet4;
            // 
            // virusesDBDataSet4
            // 
            this.virusesDBDataSet4.DataSetName = "VirusesDBDataSet4";
            this.virusesDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virusTableAdapter
            // 
            this.virusTableAdapter.ClearBeforeFill = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(531, 83);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 1;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(429, 83);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 2;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(326, 83);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OrganismId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GenomeId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // vOrg
            // 
            this.vOrg.Location = new System.Drawing.Point(180, 134);
            this.vOrg.Name = "vOrg";
            this.vOrg.Size = new System.Drawing.Size(100, 20);
            this.vOrg.TabIndex = 8;
            // 
            // vGen
            // 
            this.vGen.Location = new System.Drawing.Point(180, 99);
            this.vGen.Name = "vGen";
            this.vGen.Size = new System.Drawing.Size(100, 20);
            this.vGen.TabIndex = 9;
            // 
            // vName
            // 
            this.vName.Location = new System.Drawing.Point(180, 65);
            this.vName.Name = "vName";
            this.vName.Size = new System.Drawing.Size(100, 20);
            this.vName.TabIndex = 10;
            // 
            // vId
            // 
            this.vId.Location = new System.Drawing.Point(180, 29);
            this.vId.Name = "vId";
            this.vId.Size = new System.Drawing.Size(100, 20);
            this.vId.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "To menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viruses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vId);
            this.Controls.Add(this.vName);
            this.Controls.Add(this.vGen);
            this.Controls.Add(this.vOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Viruses";
            this.Text = "Viruses";
            this.Load += new System.EventHandler(this.Viruses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VirusesDBDataSet4 virusesDBDataSet4;
        private System.Windows.Forms.BindingSource virusBindingSource;
        private VirusesDBDataSet4TableAdapters.VirusTableAdapter virusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organismIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vOrg;
        private System.Windows.Forms.TextBox vGen;
        private System.Windows.Forms.TextBox vName;
        private System.Windows.Forms.TextBox vId;
        private System.Windows.Forms.Button button1;
    }
}