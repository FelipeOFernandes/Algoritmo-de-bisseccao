
namespace Bisseccao
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
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelCasasDecimais = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.numericUpDownCasasDecimais = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasasDecimais)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Calcular.Location = new System.Drawing.Point(15, 131);
            this.Btn_Calcular.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(255, 26);
            this.Btn_Calcular.TabIndex = 0;
            this.Btn_Calcular.Text = "Calcular intervalo";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelResultado.Location = new System.Drawing.Point(0, 161);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(290, 144);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(290, 77);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Coloque a funcao f(x) dentro da funcion CalcularFunc e compile para gerar o inter" +
    "valo no qual a raiz da funcao esta";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 77);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 16);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(144, 77);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 16);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B:";
            // 
            // labelCasasDecimais
            // 
            this.labelCasasDecimais.AutoSize = true;
            this.labelCasasDecimais.Location = new System.Drawing.Point(56, 104);
            this.labelCasasDecimais.Name = "labelCasasDecimais";
            this.labelCasasDecimais.Size = new System.Drawing.Size(108, 16);
            this.labelCasasDecimais.TabIndex = 5;
            this.labelCasasDecimais.Text = "Casas decimais:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(38, 74);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 6;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(170, 74);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 7;
            // 
            // numericUpDownCasasDecimais
            // 
            this.numericUpDownCasasDecimais.Location = new System.Drawing.Point(170, 102);
            this.numericUpDownCasasDecimais.Name = "numericUpDownCasasDecimais";
            this.numericUpDownCasasDecimais.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownCasasDecimais.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 305);
            this.Controls.Add(this.numericUpDownCasasDecimais);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelCasasDecimais);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.Btn_Calcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo de biseccao";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCasasDecimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelCasasDecimais;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.NumericUpDown numericUpDownCasasDecimais;
    }
}

