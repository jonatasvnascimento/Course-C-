
namespace EnvioRetorno
{
    partial class frm1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_avancar = new System.Windows.Forms.Button();
            this.label_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_avancar
            // 
            this.cmd_avancar.Location = new System.Drawing.Point(440, 364);
            this.cmd_avancar.Name = "cmd_avancar";
            this.cmd_avancar.Size = new System.Drawing.Size(103, 51);
            this.cmd_avancar.TabIndex = 0;
            this.cmd_avancar.Text = "Executar";
            this.cmd_avancar.UseVisualStyleBackColor = true;
            this.cmd_avancar.Click += new System.EventHandler(this.cmd_avancar_Click);
            // 
            // label_texto
            // 
            this.label_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_texto.Location = new System.Drawing.Point(12, 9);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(531, 56);
            this.label_texto.TabIndex = 1;
            this.label_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.label_texto);
            this.Controls.Add(this.cmd_avancar);
            this.Name = "frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_avancar;
        private System.Windows.Forms.Label label_texto;
    }
}

