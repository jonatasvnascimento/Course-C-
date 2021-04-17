
namespace Agenda
{
    partial class FormInserirEditar
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
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contactos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(132, 12);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(429, 31);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(132, 49);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(230, 31);
            this.text_numero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Gray;
            this.cmd_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fechar.ForeColor = System.Drawing.Color.White;
            this.cmd_fechar.Location = new System.Drawing.Point(449, 598);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(112, 34);
            this.cmd_fechar.TabIndex = 5;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.BackColor = System.Drawing.Color.Gray;
            this.cmd_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_gravar.ForeColor = System.Drawing.Color.White;
            this.cmd_gravar.Location = new System.Drawing.Point(132, 160);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(112, 34);
            this.cmd_gravar.TabIndex = 4;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = false;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_contactos
            // 
            this.lista_contactos.FormattingEnabled = true;
            this.lista_contactos.ItemHeight = 25;
            this.lista_contactos.Location = new System.Drawing.Point(12, 262);
            this.lista_contactos.Name = "lista_contactos";
            this.lista_contactos.Size = new System.Drawing.Size(549, 329);
            this.lista_contactos.TabIndex = 6;
            this.lista_contactos.SelectedIndexChanged += new System.EventHandler(this.lista_contactos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de Contatos";
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Location = new System.Drawing.Point(12, 598);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(104, 25);
            this.label_numero_registros.TabIndex = 8;
            this.label_numero_registros.Text = "Registros: 0";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.BackColor = System.Drawing.Color.Gray;
            this.cmd_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_apagar.ForeColor = System.Drawing.Color.White;
            this.cmd_apagar.Location = new System.Drawing.Point(331, 598);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(112, 34);
            this.cmd_apagar.TabIndex = 6;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = false;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackColor = System.Drawing.Color.Gray;
            this.cmd_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_editar.ForeColor = System.Drawing.Color.White;
            this.cmd_editar.Location = new System.Drawing.Point(213, 598);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(112, 34);
            this.cmd_editar.TabIndex = 7;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "CEP:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_cep
            // 
            this.text_cep.Location = new System.Drawing.Point(132, 86);
            this.text_cep.MaxLength = 20;
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(230, 31);
            this.text_cep.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(132, 123);
            this.text_email.MaxLength = 50;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(230, 31);
            this.text_email.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(439, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nomes                 | Numero            | Cep            | Email\r\n";
            // 
            // FormInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 647);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_cep);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contactos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.text_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInserirEditar";
            this.Text = "INSERIR | EDITAR";
            this.Load += new System.EventHandler(this.FormInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contactos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label6;
    }
}