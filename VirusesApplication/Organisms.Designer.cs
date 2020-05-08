namespace VirusesApplication
{
    partial class Organisms
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
            this.OrganismsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organismBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virusesDBDataSet = new VirusesApplication.VirusesDBDataSet();
            this.organismTableAdapter = new VirusesApplication.VirusesDBDataSetTableAdapters.OrganismTableAdapter();
            this.orgName = new System.Windows.Forms.TextBox();
            this.orgId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_org_button = new System.Windows.Forms.Button();
            this.upd_org_button = new System.Windows.Forms.Button();
            this.del_org_button = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrganismsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganismsGrid
            // 
            this.OrganismsGrid.AutoGenerateColumns = false;
            this.OrganismsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganismsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.OrganismsGrid.DataSource = this.organismBindingSource;
            this.OrganismsGrid.Location = new System.Drawing.Point(229, 190);
            this.OrganismsGrid.Name = "OrganismsGrid";
            this.OrganismsGrid.Size = new System.Drawing.Size(243, 150);
            this.OrganismsGrid.TabIndex = 0;
            this.OrganismsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // organismBindingSource
            // 
            this.organismBindingSource.DataMember = "Organism";
            this.organismBindingSource.DataSource = this.virusesDBDataSet;
            // 
            // virusesDBDataSet
            // 
            this.virusesDBDataSet.DataSetName = "VirusesDBDataSet";
            this.virusesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organismTableAdapter
            // 
            this.organismTableAdapter.ClearBeforeFill = true;
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(146, 98);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(100, 20);
            this.orgName.TabIndex = 1;
            // 
            // orgId
            // 
            this.orgId.Location = new System.Drawing.Point(146, 42);
            this.orgId.Name = "orgId";
            this.orgId.Size = new System.Drawing.Size(100, 20);
            this.orgId.TabIndex = 2;
            this.orgId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // add_org_button
            // 
            this.add_org_button.Location = new System.Drawing.Point(274, 67);
            this.add_org_button.Name = "add_org_button";
            this.add_org_button.Size = new System.Drawing.Size(75, 23);
            this.add_org_button.TabIndex = 5;
            this.add_org_button.Text = "Add";
            this.add_org_button.UseVisualStyleBackColor = true;
            this.add_org_button.Click += new System.EventHandler(this.add_org_button_Click);
            // 
            // upd_org_button
            // 
            this.upd_org_button.Location = new System.Drawing.Point(375, 67);
            this.upd_org_button.Name = "upd_org_button";
            this.upd_org_button.Size = new System.Drawing.Size(75, 23);
            this.upd_org_button.TabIndex = 6;
            this.upd_org_button.Text = "Update";
            this.upd_org_button.UseVisualStyleBackColor = true;
            this.upd_org_button.Click += new System.EventHandler(this.upd_org_button_Click);
            // 
            // del_org_button
            // 
            this.del_org_button.Location = new System.Drawing.Point(481, 67);
            this.del_org_button.Name = "del_org_button";
            this.del_org_button.Size = new System.Drawing.Size(75, 23);
            this.del_org_button.TabIndex = 7;
            this.del_org_button.Text = "Delete";
            this.del_org_button.UseVisualStyleBackColor = true;
            this.del_org_button.Click += new System.EventHandler(this.del_org_button_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(678, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "To menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Organisms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.del_org_button);
            this.Controls.Add(this.upd_org_button);
            this.Controls.Add(this.add_org_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgId);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.OrganismsGrid);
            this.Name = "Organisms";
            this.Text = "Organisms";
            this.Load += new System.EventHandler(this.Organisms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganismsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virusesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrganismsGrid;
        private VirusesDBDataSet virusesDBDataSet;
        private System.Windows.Forms.BindingSource organismBindingSource;
        private VirusesDBDataSetTableAdapters.OrganismTableAdapter organismTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.TextBox orgId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_org_button;
        private System.Windows.Forms.Button upd_org_button;
        private System.Windows.Forms.Button del_org_button;
        private System.Windows.Forms.Button back;
    }
}