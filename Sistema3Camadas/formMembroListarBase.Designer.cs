namespace Iesj
{
    partial class formMembroListarBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditarCadastro = new System.Windows.Forms.Button();
            this.textBoxNomeListar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonNovoCadastro = new System.Windows.Forms.Button();
            this.dataGridViewMostrarMembros = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarMembros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditarCadastro);
            this.panel1.Controls.Add(this.textBoxNomeListar);
            this.panel1.Controls.Add(this.buttonFiltrar);
            this.panel1.Controls.Add(this.buttonNovoCadastro);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonEditarCadastro
            // 
            this.buttonEditarCadastro.Location = new System.Drawing.Point(3, 52);
            this.buttonEditarCadastro.Name = "buttonEditarCadastro";
            this.buttonEditarCadastro.Size = new System.Drawing.Size(100, 36);
            this.buttonEditarCadastro.TabIndex = 2;
            this.buttonEditarCadastro.Text = "Editar";
            this.buttonEditarCadastro.UseVisualStyleBackColor = true;
            this.buttonEditarCadastro.Click += new System.EventHandler(this.ButtonEditarCadastro_Click);
            // 
            // textBoxNomeListar
            // 
            this.textBoxNomeListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeListar.Location = new System.Drawing.Point(109, 19);
            this.textBoxNomeListar.Name = "textBoxNomeListar";
            this.textBoxNomeListar.Size = new System.Drawing.Size(387, 26);
            this.textBoxNomeListar.TabIndex = 1;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(525, 10);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(100, 36);
            this.buttonFiltrar.TabIndex = 1;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.ButtonFiltrar_Click);
            // 
            // buttonNovoCadastro
            // 
            this.buttonNovoCadastro.Location = new System.Drawing.Point(3, 10);
            this.buttonNovoCadastro.Name = "buttonNovoCadastro";
            this.buttonNovoCadastro.Size = new System.Drawing.Size(100, 36);
            this.buttonNovoCadastro.TabIndex = 0;
            this.buttonNovoCadastro.Text = "Novo";
            this.buttonNovoCadastro.UseVisualStyleBackColor = true;
            this.buttonNovoCadastro.Click += new System.EventHandler(this.ButtonNovoCadastro_Click);
            // 
            // dataGridViewMostrarMembros
            // 
            this.dataGridViewMostrarMembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarMembros.Location = new System.Drawing.Point(3, 116);
            this.dataGridViewMostrarMembros.Name = "dataGridViewMostrarMembros";
            this.dataGridViewMostrarMembros.Size = new System.Drawing.Size(633, 244);
            this.dataGridViewMostrarMembros.TabIndex = 0;
            this.dataGridViewMostrarMembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMostrarMembros_CellContentClick);
            // 
            // formMembroListarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 374);
            this.Controls.Add(this.dataGridViewMostrarMembros);
            this.Controls.Add(this.panel1);
            this.Name = "formMembroListarBase";
            this.Text = "Gerenciar Membros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarMembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNomeListar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonNovoCadastro;
        private System.Windows.Forms.DataGridView dataGridViewMostrarMembros;
        private System.Windows.Forms.Button buttonEditarCadastro;
    }
}