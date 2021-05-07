
namespace LojadeCarros_Gui_
{
    partial class Form1
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
            this.add_novo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.btn_add_lista = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_novo
            // 
            this.add_novo.Location = new System.Drawing.Point(4, 539);
            this.add_novo.Name = "add_novo";
            this.add_novo.Size = new System.Drawing.Size(115, 27);
            this.add_novo.TabIndex = 7;
            this.add_novo.Text = "Adicionar Carro";
            this.add_novo.UseVisualStyleBackColor = true;
            this.add_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(574, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 527);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Compras";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 14);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(449, 507);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(777, 542);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(135, 25);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Aplicar desconto(%)";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Total:";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(699, 548);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(34, 15);
            this.lbl_preco.TabIndex = 9;
            this.lbl_preco.Text = "$0,00";
            // 
            // btn_add_lista
            // 
            this.btn_add_lista.Location = new System.Drawing.Point(471, 245);
            this.btn_add_lista.Name = "btn_add_lista";
            this.btn_add_lista.Size = new System.Drawing.Size(97, 24);
            this.btn_add_lista.TabIndex = 10;
            this.btn_add_lista.Text = "Add à Lista";
            this.btn_add_lista.UseVisualStyleBackColor = true;
            this.btn_add_lista.Click += new System.EventHandler(this.btn_add_lista_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(918, 572);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(107, 30);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(471, 275);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(97, 24);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar Lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(918, 543);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_desc.Size = new System.Drawing.Size(107, 23);
            this.txt_desc.TabIndex = 13;
            this.txt_desc.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 527);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_novo);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_add_lista);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Button btn_add_lista;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button add_novo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView2;
        public System.Windows.Forms.ListView listView1;
    }
}

