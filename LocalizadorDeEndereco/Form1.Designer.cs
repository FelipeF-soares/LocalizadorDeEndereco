namespace LocalizadorDeEndereco
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
            labelCep = new Label();
            buttonPesquisar = new Button();
            maskedTextBoxCep = new MaskedTextBox();
            richTextBoxResultado = new RichTextBox();
            SuspendLayout();
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(47, 31);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(75, 15);
            labelCep.TabIndex = 0;
            labelCep.Text = "Digite o Cep:";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(47, 171);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 1;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(33, 49);
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(100, 23);
            maskedTextBoxCep.TabIndex = 4;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.Location = new Point(260, 28);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.ReadOnly = true;
            richTextBoxResultado.Size = new Size(400, 166);
            richTextBoxResultado.TabIndex = 5;
            richTextBoxResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 244);
            Controls.Add(richTextBoxResultado);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(buttonPesquisar);
            Controls.Add(labelCep);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCep;
        private Button buttonPesquisar;
        private MaskedTextBox maskedTextBoxCep;
        private RichTextBox richTextBoxResultado;
    }
}