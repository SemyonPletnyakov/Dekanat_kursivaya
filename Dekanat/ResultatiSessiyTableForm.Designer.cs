namespace Dekanat
{
    partial class ResultatiSessiyTableForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерЗачёткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семестрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОтчётностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПопыткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultatisessiyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.resultati_sessiyViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Resultati_sessiyViewTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.perechenpredmetovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.perechen_predmetovTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.clearFiltrButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatisessiyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗачёткиDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.семестрDataGridViewTextBoxColumn,
            this.формаОтчётностиDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.номерПопыткиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultatisessiyViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1616, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерЗачёткиDataGridViewTextBoxColumn
            // 
            this.номерЗачёткиDataGridViewTextBoxColumn.DataPropertyName = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.HeaderText = "Номер зачётки";
            this.номерЗачёткиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерЗачёткиDataGridViewTextBoxColumn.Name = "номерЗачёткиDataGridViewTextBoxColumn";
            this.номерЗачёткиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            this.дисциплинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // семестрDataGridViewTextBoxColumn
            // 
            this.семестрDataGridViewTextBoxColumn.DataPropertyName = "Семестр";
            this.семестрDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.семестрDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.семестрDataGridViewTextBoxColumn.Name = "семестрDataGridViewTextBoxColumn";
            this.семестрDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // формаОтчётностиDataGridViewTextBoxColumn
            // 
            this.формаОтчётностиDataGridViewTextBoxColumn.DataPropertyName = "Форма отчётности";
            this.формаОтчётностиDataGridViewTextBoxColumn.HeaderText = "Форма отчётности";
            this.формаОтчётностиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.формаОтчётностиDataGridViewTextBoxColumn.Name = "формаОтчётностиDataGridViewTextBoxColumn";
            this.формаОтчётностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерПопыткиDataGridViewTextBoxColumn
            // 
            this.номерПопыткиDataGridViewTextBoxColumn.DataPropertyName = "Номер попытки";
            this.номерПопыткиDataGridViewTextBoxColumn.HeaderText = "Номер попытки";
            this.номерПопыткиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерПопыткиDataGridViewTextBoxColumn.Name = "номерПопыткиDataGridViewTextBoxColumn";
            this.номерПопыткиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultatisessiyViewBindingSource
            // 
            this.resultatisessiyViewBindingSource.DataMember = "Resultati_sessiyView";
            this.resultatisessiyViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultati_sessiyViewTableAdapter
            // 
            this.resultati_sessiyViewTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 138);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 70);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(0, 70);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 70);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.Window;
            this.insertButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.insertButton.FlatAppearance.BorderSize = 0;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Location = new System.Drawing.Point(0, 0);
            this.insertButton.Margin = new System.Windows.Forms.Padding(0);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(200, 70);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Номер зачётки", true));
            this.textBox1.Location = new System.Drawing.Point(277, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resultatisessiyViewBindingSource, "Дисциплина", true));
            this.comboBox1.DataSource = this.perechenpredmetovBindingSource;
            this.comboBox1.DisplayMember = "nazvanie_predmeta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(428, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "nazvanie_predmeta";
            // 
            // perechenpredmetovBindingSource
            // 
            this.perechenpredmetovBindingSource.DataMember = "Perechen_predmetov";
            this.perechenpredmetovBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Номер попытки", true));
            this.textBox3.Location = new System.Drawing.Point(876, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 26);
            this.textBox3.TabIndex = 13;
            this.textBox3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Семестр", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(678, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 28);
            this.comboBox2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Номер зачётки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дисциплина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Семестр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Оценка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Номер попытки";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Оценка", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "зачёт",
            "не зачёт",
            "отл",
            "хор",
            "удв",
            "не удв"});
            this.comboBox3.Location = new System.Drawing.Point(759, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 28);
            this.comboBox3.TabIndex = 36;
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(1047, 63);
            this.deleteActiveButton.Name = "deleteActiveButton";
            this.deleteActiveButton.Size = new System.Drawing.Size(140, 47);
            this.deleteActiveButton.TabIndex = 39;
            this.deleteActiveButton.Text = "Удалить";
            this.deleteActiveButton.UseVisualStyleBackColor = true;
            this.deleteActiveButton.Visible = false;
            this.deleteActiveButton.Click += new System.EventHandler(this.deleteActiveButton_Click);
            // 
            // updateActiveButton
            // 
            this.updateActiveButton.Location = new System.Drawing.Point(1047, 63);
            this.updateActiveButton.Name = "updateActiveButton";
            this.updateActiveButton.Size = new System.Drawing.Size(140, 47);
            this.updateActiveButton.TabIndex = 38;
            this.updateActiveButton.Text = "Изменить";
            this.updateActiveButton.UseVisualStyleBackColor = true;
            this.updateActiveButton.Visible = false;
            this.updateActiveButton.Click += new System.EventHandler(this.updateActiveButton_Click);
            // 
            // insertActiveButton
            // 
            this.insertActiveButton.Location = new System.Drawing.Point(1047, 63);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 37;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Исходные данные";
            this.label6.Visible = false;
            // 
            // perechen_predmetovTableAdapter
            // 
            this.perechen_predmetovTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Новые данные";
            this.label7.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Оценка", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "зачёт",
            "не зачёт",
            "отл",
            "хор",
            "удв",
            "не удв"});
            this.comboBox4.Location = new System.Drawing.Point(759, 151);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(111, 28);
            this.comboBox4.TabIndex = 50;
            this.comboBox4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(872, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Номер попытки";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(755, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Оценка";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Семестр";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Дисциплина";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Номер зачётки";
            this.label12.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Семестр", true));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox5.Location = new System.Drawing.Point(678, 151);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(75, 28);
            this.comboBox5.TabIndex = 44;
            this.comboBox5.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Номер попытки", true));
            this.textBox2.Location = new System.Drawing.Point(876, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 26);
            this.textBox2.TabIndex = 43;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.resultatisessiyViewBindingSource, "Дисциплина", true));
            this.comboBox6.DataSource = this.perechenpredmetovBindingSource;
            this.comboBox6.DisplayMember = "nazvanie_predmeta";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(428, 151);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(244, 28);
            this.comboBox6.TabIndex = 42;
            this.comboBox6.ValueMember = "nazvanie_predmeta";
            this.comboBox6.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultatisessiyViewBindingSource, "Номер зачётки", true));
            this.textBox4.Location = new System.Drawing.Point(277, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 26);
            this.textBox4.TabIndex = 41;
            this.textBox4.Visible = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-7GQT4U6\\SQLEXPRESS;Initial Catalog=DB_Groups;Integrated Secur" +
    "ity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // clearFiltrButton
            // 
            this.clearFiltrButton.Location = new System.Drawing.Point(1258, 63);
            this.clearFiltrButton.Name = "clearFiltrButton";
            this.clearFiltrButton.Size = new System.Drawing.Size(345, 46);
            this.clearFiltrButton.TabIndex = 52;
            this.clearFiltrButton.Text = "Снять фильтр";
            this.clearFiltrButton.UseVisualStyleBackColor = true;
            this.clearFiltrButton.Click += new System.EventHandler(this.clearFiltrButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1258, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "Фильтр по группе и семестру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultatiSessiyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1615, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearFiltrButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ResultatiSessiyTableForm";
            this.Text = "Таблица Результаты сессий";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResultatiSessiyTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatisessiyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource resultatisessiyViewBindingSource;
        private DB_GroupsDataSetTableAdapters.Resultati_sessiyViewTableAdapter resultati_sessiyViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗачёткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семестрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОтчётностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПопыткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource perechenpredmetovBindingSource;
        private DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter perechen_predmetovTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button clearFiltrButton;
        private System.Windows.Forms.Button button1;
    }
}