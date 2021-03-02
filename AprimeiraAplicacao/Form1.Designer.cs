
namespace AprimeiraAplicacao
{
    partial class Form1
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
            this.cmd_executar = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.text_parcela_1 = new System.Windows.Forms.TextBox();
            this.text_parcela_2 = new System.Windows.Forms.TextBox();
            this.cmd_adicao = new System.Windows.Forms.Button();
            this.cmd_subitracao = new System.Windows.Forms.Button();
            this.cmd_muiltiplicar = new System.Windows.Forms.Button();
            this.cmd_divisao = new System.Windows.Forms.Button();
            this.cmd_modulo = new System.Windows.Forms.Button();
            this.btn_operation_math = new System.Windows.Forms.Button();
            this.bnt_if = new System.Windows.Forms.Button();
            this.bnt_switch = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_do_while = new System.Windows.Forms.Button();
            this.btn_foreach = new System.Windows.Forms.Button();
            this.btn_array = new System.Windows.Forms.Button();
            this.btn_string = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(655, 408);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(92, 31);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_resultado.Location = new System.Drawing.Point(164, 12);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(437, 59);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "Texto de exemplo";
            // 
            // text_parcela_1
            // 
            this.text_parcela_1.Location = new System.Drawing.Point(12, 12);
            this.text_parcela_1.Name = "text_parcela_1";
            this.text_parcela_1.Size = new System.Drawing.Size(146, 26);
            this.text_parcela_1.TabIndex = 2;
            // 
            // text_parcela_2
            // 
            this.text_parcela_2.Location = new System.Drawing.Point(12, 45);
            this.text_parcela_2.Name = "text_parcela_2";
            this.text_parcela_2.Size = new System.Drawing.Size(146, 26);
            this.text_parcela_2.TabIndex = 3;
            // 
            // cmd_adicao
            // 
            this.cmd_adicao.Location = new System.Drawing.Point(11, 85);
            this.cmd_adicao.Name = "cmd_adicao";
            this.cmd_adicao.Size = new System.Drawing.Size(30, 30);
            this.cmd_adicao.TabIndex = 4;
            this.cmd_adicao.Text = "+";
            this.cmd_adicao.UseVisualStyleBackColor = true;
            this.cmd_adicao.Click += new System.EventHandler(this.cmd_adicao_Click);
            // 
            // cmd_subitracao
            // 
            this.cmd_subitracao.Location = new System.Drawing.Point(48, 85);
            this.cmd_subitracao.Name = "cmd_subitracao";
            this.cmd_subitracao.Size = new System.Drawing.Size(30, 30);
            this.cmd_subitracao.TabIndex = 5;
            this.cmd_subitracao.Text = "-";
            this.cmd_subitracao.UseVisualStyleBackColor = true;
            this.cmd_subitracao.Click += new System.EventHandler(this.cmd_subitracao_Click);
            // 
            // cmd_muiltiplicar
            // 
            this.cmd_muiltiplicar.Location = new System.Drawing.Point(88, 85);
            this.cmd_muiltiplicar.Name = "cmd_muiltiplicar";
            this.cmd_muiltiplicar.Size = new System.Drawing.Size(30, 30);
            this.cmd_muiltiplicar.TabIndex = 6;
            this.cmd_muiltiplicar.Text = "*";
            this.cmd_muiltiplicar.UseVisualStyleBackColor = true;
            this.cmd_muiltiplicar.Click += new System.EventHandler(this.cmd_muiltiplicar_Click);
            // 
            // cmd_divisao
            // 
            this.cmd_divisao.Location = new System.Drawing.Point(12, 122);
            this.cmd_divisao.Name = "cmd_divisao";
            this.cmd_divisao.Size = new System.Drawing.Size(30, 30);
            this.cmd_divisao.TabIndex = 7;
            this.cmd_divisao.TabStop = false;
            this.cmd_divisao.Text = "/";
            this.cmd_divisao.UseVisualStyleBackColor = true;
            this.cmd_divisao.Click += new System.EventHandler(this.cmd_divisao_Click);
            // 
            // cmd_modulo
            // 
            this.cmd_modulo.Location = new System.Drawing.Point(123, 85);
            this.cmd_modulo.Name = "cmd_modulo";
            this.cmd_modulo.Size = new System.Drawing.Size(30, 30);
            this.cmd_modulo.TabIndex = 8;
            this.cmd_modulo.Text = "%";
            this.cmd_modulo.UseVisualStyleBackColor = true;
            this.cmd_modulo.Click += new System.EventHandler(this.cmd_modulo_Click);
            // 
            // btn_operation_math
            // 
            this.btn_operation_math.Location = new System.Drawing.Point(84, 234);
            this.btn_operation_math.Name = "btn_operation_math";
            this.btn_operation_math.Size = new System.Drawing.Size(67, 30);
            this.btn_operation_math.TabIndex = 9;
            this.btn_operation_math.Text = "OMath";
            this.btn_operation_math.UseVisualStyleBackColor = true;
            this.btn_operation_math.Click += new System.EventHandler(this.btn_operation_math_Click);
            // 
            // bnt_if
            // 
            this.bnt_if.Location = new System.Drawing.Point(12, 158);
            this.bnt_if.Name = "bnt_if";
            this.bnt_if.Size = new System.Drawing.Size(67, 30);
            this.bnt_if.TabIndex = 10;
            this.bnt_if.Text = "IF Else";
            this.bnt_if.UseVisualStyleBackColor = true;
            this.bnt_if.Click += new System.EventHandler(this.bnt_if_Click);
            // 
            // bnt_switch
            // 
            this.bnt_switch.Location = new System.Drawing.Point(86, 158);
            this.bnt_switch.Name = "bnt_switch";
            this.bnt_switch.Size = new System.Drawing.Size(67, 30);
            this.bnt_switch.TabIndex = 11;
            this.bnt_switch.Text = "Switch";
            this.bnt_switch.UseVisualStyleBackColor = true;
            this.bnt_switch.Click += new System.EventHandler(this.bnt_switch_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(607, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(140, 224);
            this.lista.TabIndex = 12;
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(11, 234);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(67, 30);
            this.btn_for.TabIndex = 13;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(85, 198);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(68, 30);
            this.btn_while.TabIndex = 14;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_do_while
            // 
            this.btn_do_while.Location = new System.Drawing.Point(12, 198);
            this.btn_do_while.Name = "btn_do_while";
            this.btn_do_while.Size = new System.Drawing.Size(67, 30);
            this.btn_do_while.TabIndex = 15;
            this.btn_do_while.Text = "Do";
            this.btn_do_while.UseVisualStyleBackColor = true;
            this.btn_do_while.Click += new System.EventHandler(this.btn_do_while_Click);
            // 
            // btn_foreach
            // 
            this.btn_foreach.Location = new System.Drawing.Point(46, 122);
            this.btn_foreach.Name = "btn_foreach";
            this.btn_foreach.Size = new System.Drawing.Size(105, 30);
            this.btn_foreach.TabIndex = 16;
            this.btn_foreach.Text = "Foreach";
            this.btn_foreach.UseVisualStyleBackColor = true;
            this.btn_foreach.Click += new System.EventHandler(this.btn_foreach_Click);
            // 
            // btn_array
            // 
            this.btn_array.Location = new System.Drawing.Point(12, 270);
            this.btn_array.Name = "btn_array";
            this.btn_array.Size = new System.Drawing.Size(67, 30);
            this.btn_array.TabIndex = 17;
            this.btn_array.Text = "Array";
            this.btn_array.UseVisualStyleBackColor = true;
            this.btn_array.Click += new System.EventHandler(this.btn_array_Click);
            // 
            // btn_string
            // 
            this.btn_string.Location = new System.Drawing.Point(84, 270);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(67, 30);
            this.btn_string.TabIndex = 18;
            this.btn_string.Text = "String";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.btn_string);
            this.Controls.Add(this.btn_array);
            this.Controls.Add(this.btn_foreach);
            this.Controls.Add(this.btn_do_while);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.bnt_switch);
            this.Controls.Add(this.bnt_if);
            this.Controls.Add(this.btn_operation_math);
            this.Controls.Add(this.cmd_modulo);
            this.Controls.Add(this.cmd_divisao);
            this.Controls.Add(this.cmd_muiltiplicar);
            this.Controls.Add(this.cmd_subitracao);
            this.Controls.Add(this.cmd_adicao);
            this.Controls.Add(this.text_parcela_2);
            this.Controls.Add(this.text_parcela_1);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox text_parcela_1;
        private System.Windows.Forms.TextBox text_parcela_2;
        private System.Windows.Forms.Button cmd_adicao;
        private System.Windows.Forms.Button cmd_subitracao;
        private System.Windows.Forms.Button cmd_muiltiplicar;
        private System.Windows.Forms.Button cmd_divisao;
        private System.Windows.Forms.Button cmd_modulo;
        private System.Windows.Forms.Button btn_operation_math;
        private System.Windows.Forms.Button bnt_if;
        private System.Windows.Forms.Button bnt_switch;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_do_while;
        private System.Windows.Forms.Button btn_foreach;
        private System.Windows.Forms.Button btn_array;
        private System.Windows.Forms.Button btn_string;
    }
}

