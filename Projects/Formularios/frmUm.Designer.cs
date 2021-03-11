
namespace Formularios
{
    partial class frmUm
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
            this.label_final = new System.Windows.Forms.Label();
            this.btn_teste = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(163, 558);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(103, 44);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Location = new System.Drawing.Point(12, 9);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(51, 20);
            this.label_final.TabIndex = 2;
            this.label_final.Text = "label1";
            // 
            // btn_teste
            // 
            this.btn_teste.Location = new System.Drawing.Point(70, 279);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(103, 44);
            this.btn_teste.TabIndex = 3;
            this.btn_teste.Text = "executar";
            this.btn_teste.UseVisualStyleBackColor = true;
            this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(66, 204);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(51, 20);
            this.lbl_text.TabIndex = 4;
            this.lbl_text.Text = "label1";
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 614);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.label_final);
            this.Controls.Add(this.cmd_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.Label lbl_text;
    }
}