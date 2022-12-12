namespace Dekanat
{
    partial class UchebniyPlanTableForm
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
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семестрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОтчётностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uchebniyplanViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.uchebniy_planViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Uchebniy_planViewTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.perechenpredmetovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.specialnostTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.SpecialnostTableAdapter();
            this.perechen_predmetovTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.clearFiltrButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebniyplanViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
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
            this.специальностьDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.семестрDataGridViewTextBoxColumn,
            this.формаОтчётностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uchebniyplanViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1894, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
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
            // uchebniyplanViewBindingSource
            // 
            this.uchebniyplanViewBindingSource.DataMember = "Uchebniy_planView";
            this.uchebniyplanViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uchebniy_planViewTableAdapter
            // 
            this.uchebniy_planViewTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 136);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 68);
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
            this.updateButton.Location = new System.Drawing.Point(0, 68);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 68);
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
            this.insertButton.Size = new System.Drawing.Size(200, 68);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(1382, 13);
            this.deleteActiveButton.Name = "deleteActiveButton";
            this.deleteActiveButton.Size = new System.Drawing.Size(140, 47);
            this.deleteActiveButton.TabIndex = 26;
            this.deleteActiveButton.Text = "Удалить";
            this.deleteActiveButton.UseVisualStyleBackColor = true;
            this.deleteActiveButton.Visible = false;
            this.deleteActiveButton.Click += new System.EventHandler(this.deleteActiveButton_Click);
            // 
            // updateActiveButton
            // 
            this.updateActiveButton.Location = new System.Drawing.Point(1382, 13);
            this.updateActiveButton.Name = "updateActiveButton";
            this.updateActiveButton.Size = new System.Drawing.Size(140, 47);
            this.updateActiveButton.TabIndex = 25;
            this.updateActiveButton.Text = "Изменить";
            this.updateActiveButton.UseVisualStyleBackColor = true;
            this.updateActiveButton.Visible = false;
            this.updateActiveButton.Click += new System.EventHandler(this.updateActiveButton_Click);
            // 
            // insertActiveButton
            // 
            this.insertActiveButton.Location = new System.Drawing.Point(1382, 13);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 24;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchebniyplanViewBindingSource, "Специальность", true));
            this.comboBox1.DataSource = this.specialnostBindingSource;
            this.comboBox1.DisplayMember = "nazvanie_specialnosti";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 28);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "nazvanie_specialnosti";
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchebniyplanViewBindingSource, "Дисциплина", true));
            this.comboBox2.DataSource = this.perechenpredmetovBindingSource;
            this.comboBox2.DisplayMember = "nazvanie_predmeta";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(578, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(350, 28);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.ValueMember = "nazvanie_predmeta";
            // 
            // perechenpredmetovBindingSource
            // 
            this.perechenpredmetovBindingSource.DataMember = "Perechen_predmetov";
            this.perechenpredmetovBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uchebniyplanViewBindingSource, "Семестр", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(934, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 28);
            this.comboBox3.TabIndex = 29;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uchebniyplanViewBindingSource, "Форма отчётности", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "зачёт",
            "зачёт дифференцируемый",
            "экзамен",
            "защита выпускной квалификационной работы"});
            this.comboBox4.Location = new System.Drawing.Point(1019, 60);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(357, 28);
            this.comboBox4.TabIndex = 30;
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // perechen_predmetovTableAdapter
            // 
            this.perechen_predmetovTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Специальность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дисциплина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Семестр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1015, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Форма отчётности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Исходные данные";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Новые данные";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1015, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Форма отчётности";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(934, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Семестр";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Дисциплина";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Специальность";
            this.label10.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uchebniyplanViewBindingSource, "Форма отчётности", true));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "зачёт",
            "зачёт дифференцируемый",
            "экзамен",
            "защита выпускной квалификационной работы"});
            this.comboBox5.Location = new System.Drawing.Point(1019, 157);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(357, 28);
            this.comboBox5.TabIndex = 39;
            this.comboBox5.Visible = false;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uchebniyplanViewBindingSource, "Семестр", true));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox6.Location = new System.Drawing.Point(934, 157);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(75, 28);
            this.comboBox6.TabIndex = 38;
            this.comboBox6.Visible = false;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchebniyplanViewBindingSource, "Дисциплина", true));
            this.comboBox7.DataSource = this.perechenpredmetovBindingSource;
            this.comboBox7.DisplayMember = "nazvanie_predmeta";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(578, 157);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(350, 28);
            this.comboBox7.TabIndex = 37;
            this.comboBox7.ValueMember = "nazvanie_predmeta";
            this.comboBox7.Visible = false;
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uchebniyplanViewBindingSource, "Специальность", true));
            this.comboBox8.DataSource = this.specialnostBindingSource;
            this.comboBox8.DisplayMember = "nazvanie_specialnosti";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(275, 157);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(297, 28);
            this.comboBox8.TabIndex = 36;
            this.comboBox8.ValueMember = "nazvanie_specialnosti";
            this.comboBox8.Visible = false;
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
            this.clearFiltrButton.Location = new System.Drawing.Point(1647, 147);
            this.clearFiltrButton.Name = "clearFiltrButton";
            this.clearFiltrButton.Size = new System.Drawing.Size(247, 46);
            this.clearFiltrButton.TabIndex = 50;
            this.clearFiltrButton.Text = "Снять фильтр";
            this.clearFiltrButton.UseVisualStyleBackColor = true;
            this.clearFiltrButton.Click += new System.EventHandler(this.clearFiltrButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1647, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 46);
            this.button1.TabIndex = 51;
            this.button1.Text = "Фильтр по специальности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1647, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 46);
            this.button2.TabIndex = 52;
            this.button2.Text = "Фильтр по семестру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1647, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 46);
            this.button3.TabIndex = 53;
            this.button3.Text = "Фильтр по спец. и семестру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UchebniyPlanTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1894, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearFiltrButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UchebniyPlanTableForm";
            this.Text = "Таблица Учебные планы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UchebniyPlanTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebniyplanViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource uchebniyplanViewBindingSource;
        private DB_GroupsDataSetTableAdapters.Uchebniy_planViewTableAdapter uchebniy_planViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семестрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОтчётностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private DB_GroupsDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.BindingSource perechenpredmetovBindingSource;
        private DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter perechen_predmetovTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button clearFiltrButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}