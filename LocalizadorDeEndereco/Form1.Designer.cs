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
            dataGridViewresultado = new DataGridView();
            textBoxLogradouro = new TextBox();
            textBoxCidade = new TextBox();
            groupBoxPesquisaLogradouro = new GroupBox();
            buttonPesquisar = new Button();
            labelUf = new Label();
            labelCidade = new Label();
            labelLogradouro = new Label();
            comboBoxUF = new ComboBox();
            groupBoxPesquisaPorCep = new GroupBox();
            maskedTextBoxCEP = new MaskedTextBox();
            buttonPesquisaCEP = new Button();
            labelCEP = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewresultado).BeginInit();
            groupBoxPesquisaLogradouro.SuspendLayout();
            groupBoxPesquisaPorCep.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewresultado
            // 
            resources.ApplyResources(dataGridViewresultado, "dataGridViewresultado");
            dataGridViewresultado.AllowUserToAddRows = false;
            dataGridViewresultado.AllowUserToDeleteRows = false;
            dataGridViewresultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewresultado.Name = "dataGridViewresultado";
            dataGridViewresultado.ReadOnly = true;
            dataGridViewresultado.RowTemplate.Height = 25;
            // 
            // textBoxLogradouro
            // 
            resources.ApplyResources(textBoxLogradouro, "textBoxLogradouro");
            textBoxLogradouro.Name = "textBoxLogradouro";
            // 
            // textBoxCidade
            // 
            resources.ApplyResources(textBoxCidade, "textBoxCidade");
            textBoxCidade.Name = "textBoxCidade";
            // 
            // groupBoxPesquisaLogradouro
            // 
            resources.ApplyResources(groupBoxPesquisaLogradouro, "groupBoxPesquisaLogradouro");
            groupBoxPesquisaLogradouro.Controls.Add(buttonPesquisar);
            groupBoxPesquisaLogradouro.Controls.Add(labelUf);
            groupBoxPesquisaLogradouro.Controls.Add(labelCidade);
            groupBoxPesquisaLogradouro.Controls.Add(labelLogradouro);
            groupBoxPesquisaLogradouro.Controls.Add(comboBoxUF);
            groupBoxPesquisaLogradouro.Controls.Add(textBoxCidade);
            groupBoxPesquisaLogradouro.Controls.Add(textBoxLogradouro);
            groupBoxPesquisaLogradouro.Name = "groupBoxPesquisaLogradouro";
            groupBoxPesquisaLogradouro.TabStop = false;
            // 
            // buttonPesquisar
            // 
            resources.ApplyResources(buttonPesquisar, "buttonPesquisar");
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // labelUf
            // 
            resources.ApplyResources(labelUf, "labelUf");
            labelUf.Name = "labelUf";
            // 
            // labelCidade
            // 
            resources.ApplyResources(labelCidade, "labelCidade");
            labelCidade.Name = "labelCidade";
            // 
            // labelLogradouro
            // 
            resources.ApplyResources(labelLogradouro, "labelLogradouro");
            labelLogradouro.Name = "labelLogradouro";
            // 
            // comboBoxUF
            // 
            resources.ApplyResources(comboBoxUF, "comboBoxUF");
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Items.AddRange(new object[] { resources.GetString("comboBoxUF.Items"), resources.GetString("comboBoxUF.Items1"), resources.GetString("comboBoxUF.Items2"), resources.GetString("comboBoxUF.Items3"), resources.GetString("comboBoxUF.Items4"), resources.GetString("comboBoxUF.Items5"), resources.GetString("comboBoxUF.Items6"), resources.GetString("comboBoxUF.Items7"), resources.GetString("comboBoxUF.Items8"), resources.GetString("comboBoxUF.Items9"), resources.GetString("comboBoxUF.Items10"), resources.GetString("comboBoxUF.Items11"), resources.GetString("comboBoxUF.Items12"), resources.GetString("comboBoxUF.Items13"), resources.GetString("comboBoxUF.Items14"), resources.GetString("comboBoxUF.Items15"), resources.GetString("comboBoxUF.Items16"), resources.GetString("comboBoxUF.Items17"), resources.GetString("comboBoxUF.Items18"), resources.GetString("comboBoxUF.Items19"), resources.GetString("comboBoxUF.Items20"), resources.GetString("comboBoxUF.Items21"), resources.GetString("comboBoxUF.Items22"), resources.GetString("comboBoxUF.Items23"), resources.GetString("comboBoxUF.Items24"), resources.GetString("comboBoxUF.Items25"), resources.GetString("comboBoxUF.Items26") });
            comboBoxUF.Name = "comboBoxUF";
            // 
            // groupBoxPesquisaPorCep
            // 
            resources.ApplyResources(groupBoxPesquisaPorCep, "groupBoxPesquisaPorCep");
            groupBoxPesquisaPorCep.Controls.Add(maskedTextBoxCEP);
            groupBoxPesquisaPorCep.Controls.Add(buttonPesquisaCEP);
            groupBoxPesquisaPorCep.Controls.Add(labelCEP);
            groupBoxPesquisaPorCep.Name = "groupBoxPesquisaPorCep";
            groupBoxPesquisaPorCep.TabStop = false;
            // 
            // maskedTextBoxCEP
            // 
            resources.ApplyResources(maskedTextBoxCEP, "maskedTextBoxCEP");
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.TextChanged += maskedTextBoxCEP_TextChanged;
            // 
            // buttonPesquisaCEP
            // 
            resources.ApplyResources(buttonPesquisaCEP, "buttonPesquisaCEP");
            buttonPesquisaCEP.Name = "buttonPesquisaCEP";
            buttonPesquisaCEP.UseVisualStyleBackColor = true;
            buttonPesquisaCEP.Click += buttonPesquisaCEP_Click;
            // 
            // labelCEP
            // 
            resources.ApplyResources(labelCEP, "labelCEP");
            labelCEP.Name = "labelCEP";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPesquisaPorCep);
            Controls.Add(groupBoxPesquisaLogradouro);
            Controls.Add(dataGridViewresultado);
            MaximizeBox = false;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewresultado).EndInit();
            groupBoxPesquisaLogradouro.ResumeLayout(false);
            groupBoxPesquisaLogradouro.PerformLayout();
            groupBoxPesquisaPorCep.ResumeLayout(false);
            groupBoxPesquisaPorCep.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewresultado;
        private TextBox textBoxLogradouro;
        private TextBox textBoxCidade;
        private GroupBox groupBoxPesquisaLogradouro;
        private Button buttonPesquisar;
        private Label labelUf;
        private Label labelCidade;
        private Label labelLogradouro;
        private ComboBox comboBoxUF;
        private GroupBox groupBoxPesquisaPorCep;
        private Button buttonPesquisaCEP;
        private Label labelCEP;
        private MaskedTextBox maskedTextBoxCEP;
    }
}