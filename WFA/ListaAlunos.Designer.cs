namespace WFA
{
    partial class ListaAlunos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.CódigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurmaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoColumn,
            this.NomeColumn,
            this.TurmaColumn,
            this.TurnoColumn,
            this.IdadeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(286, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 32);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(215, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(151, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(58, 32);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CódigoColumn
            // 
            this.CódigoColumn.HeaderText = "Código";
            this.CódigoColumn.Name = "CódigoColumn";
            this.CódigoColumn.ReadOnly = true;
            // 
            // NomeColumn
            // 
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // TurmaColumn
            // 
            this.TurmaColumn.HeaderText = "Turma";
            this.TurmaColumn.Name = "TurmaColumn";
            this.TurmaColumn.ReadOnly = true;
            // 
            // TurnoColumn
            // 
            this.TurnoColumn.HeaderText = "Turno";
            this.TurnoColumn.Name = "TurnoColumn";
            this.TurnoColumn.ReadOnly = true;
            // 
            // IdadeColumn
            // 
            this.IdadeColumn.HeaderText = "Idade";
            this.IdadeColumn.Name = "IdadeColumn";
            this.IdadeColumn.ReadOnly = true;
            // 
            // ListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 377);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaAlunos";
            this.Text = "ListaAlunos";
            this.Activated += new System.EventHandler(this.ListaAlunos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurmaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeColumn;
    }
}