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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelCep = new Label();
            buttonPesquisar = new Button();
            maskedTextBoxCep = new MaskedTextBox();
            richTextBoxResultado = new RichTextBox();
            SuspendLayout();
            // 
            // labelCep
            // 
            resources.ApplyResources(labelCep, "labelCep");
            labelCep.Name = "labelCep";
            // 
            // buttonPesquisar
            // 
            resources.ApplyResources(buttonPesquisar, "buttonPesquisar");
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // maskedTextBoxCep
            // 
            resources.ApplyResources(maskedTextBoxCep, "maskedTextBoxCep");
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            // 
            // richTextBoxResultado
            // 
            resources.ApplyResources(richTextBoxResultado, "richTextBoxResultado");
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBoxResultado);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(buttonPesquisar);
            Controls.Add(labelCep);
            MaximizeBox = false;
            Name = "Form1";
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