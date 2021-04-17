
namespace Agenda
{
    partial class FormResultado
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Gray;
            this.cmd_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fechar.ForeColor = System.Drawing.Color.White;
            this.cmd_fechar.Location = new System.Drawing.Point(505, 347);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(112, 34);
            this.cmd_fechar.TabIndex = 4;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.BackColor = System.Drawing.Color.Gray;
            this.cmd_nova_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_nova_pesquisa.ForeColor = System.Drawing.Color.White;
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(333, 347);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(166, 34);
            this.cmd_nova_pesquisa.TabIndex = 4;
            this.cmd_nova_pesquisa.Text = "Nova pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = false;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_nova_pesquisa_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.ItemHeight = 25;
            this.lista_final.Location = new System.Drawing.Point(12, 12);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(605, 329);
            this.lista_final.TabIndex = 5;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Location = new System.Drawing.Point(12, 347);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(104, 25);
            this.label_numero_registros.TabIndex = 9;
            this.label_numero_registros.Text = "Registros: 0";
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 394);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADO";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_nova_pesquisa;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label label_numero_registros;
    }
}