
namespace Agenda
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_inserir_editar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_inserir_editar
            // 
            this.cmd_inserir_editar.BackColor = System.Drawing.Color.Gray;
            this.cmd_inserir_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_inserir_editar.ForeColor = System.Drawing.Color.White;
            this.cmd_inserir_editar.Location = new System.Drawing.Point(92, 98);
            this.cmd_inserir_editar.Name = "cmd_inserir_editar";
            this.cmd_inserir_editar.Size = new System.Drawing.Size(213, 70);
            this.cmd_inserir_editar.TabIndex = 0;
            this.cmd_inserir_editar.Text = "Inserir | Editar";
            this.cmd_inserir_editar.UseVisualStyleBackColor = false;
            this.cmd_inserir_editar.Click += new System.EventHandler(this.cmd_inserir_editar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(103, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(191, 65);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Agenda";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(8, 365);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(70, 25);
            this.lbl_version.TabIndex = 2;
            this.lbl_version.Text = "Version";
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.Gray;
            this.cmd_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_pesquisar.ForeColor = System.Drawing.Color.White;
            this.cmd_pesquisar.Location = new System.Drawing.Point(92, 174);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(213, 70);
            this.cmd_pesquisar.TabIndex = 3;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = false;
            // 
            // cmd_sair
            // 
            this.cmd_sair.BackColor = System.Drawing.Color.Gray;
            this.cmd_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_sair.ForeColor = System.Drawing.Color.White;
            this.cmd_sair.Location = new System.Drawing.Point(92, 250);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(213, 70);
            this.cmd_sair.TabIndex = 4;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = false;
            this.cmd_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 403);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmd_inserir_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_inserir_editar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
    }
}

