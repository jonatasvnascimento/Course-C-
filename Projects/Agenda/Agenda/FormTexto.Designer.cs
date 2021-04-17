
namespace Agenda
{
    partial class FormTexto
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_texto = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa:";
            // 
            // text_texto
            // 
            this.text_texto.Location = new System.Drawing.Point(13, 41);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(318, 31);
            this.text_texto.TabIndex = 1;
            this.text_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_texto_KeyDown);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.Color.Gray;
            this.cmd_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_cancelar.ForeColor = System.Drawing.Color.White;
            this.cmd_cancelar.Location = new System.Drawing.Point(101, 78);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(112, 34);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.Gray;
            this.cmd_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_pesquisar.ForeColor = System.Drawing.Color.White;
            this.cmd_pesquisar.Location = new System.Drawing.Point(219, 78);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(112, 34);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // FormTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 133);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTexto";
            this.Text = "PESQUISA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_texto;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_pesquisar;
    }
}