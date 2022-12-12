namespace Dekanat
{
    partial class StudentiTableForm
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
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.studentiViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.StudentiViewTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gruppiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gruppiTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.GruppiTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.clearFiltrButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).BeginInit();
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
            this.адресDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1874, 433);
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
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentiViewBindingSource
            // 
            this.studentiViewBindingSource.DataMember = "StudentiView";
            this.studentiViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiViewTableAdapter
            // 
            this.studentiViewTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 126);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 63);
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
            this.updateButton.Location = new System.Drawing.Point(0, 63);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 63);
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
            this.insertButton.Size = new System.Drawing.Size(200, 63);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(1254, 50);
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
            this.updateActiveButton.Location = new System.Drawing.Point(1254, 50);
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
            this.insertActiveButton.Location = new System.Drawing.Point(1254, 50);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 24;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Номер зачётки", true));
            this.textBox1.Location = new System.Drawing.Point(263, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "ФИО", true));
            this.textBox2.Location = new System.Drawing.Point(413, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 26);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Адрес", true));
            this.textBox3.Location = new System.Drawing.Point(821, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 26);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Дата рождения", true));
            this.textBox4.Location = new System.Drawing.Point(1101, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 26);
            this.textBox4.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentiViewBindingSource, "Группа", true));
            this.comboBox1.DataSource = this.gruppiBindingSource;
            this.comboBox1.DisplayMember = "nazvanie_gruppi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(694, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "nazvanie_gruppi";
            // 
            // gruppiBindingSource
            // 
            this.gruppiBindingSource.DataMember = "Gruppi";
            this.gruppiBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Номер зачётки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1097, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Дата рождения";
            // 
            // gruppiTableAdapter
            // 
            this.gruppiTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Исходные данные";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Новые данные";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1097, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Дата рождения";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(817, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Адрес";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Группа";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(409, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "ФИО";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Номер зачётки";
            this.label12.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentiViewBindingSource, "Группа", true));
            this.comboBox2.DataSource = this.gruppiBindingSource;
            this.comboBox2.DisplayMember = "nazvanie_gruppi";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(694, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.ValueMember = "nazvanie_gruppi";
            this.comboBox2.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Дата рождения", true));
            this.textBox5.Location = new System.Drawing.Point(1101, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 26);
            this.textBox5.TabIndex = 41;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Адрес", true));
            this.textBox6.Location = new System.Drawing.Point(821, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 26);
            this.textBox6.TabIndex = 40;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "ФИО", true));
            this.textBox7.Location = new System.Drawing.Point(413, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(275, 26);
            this.textBox7.TabIndex = 39;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiViewBindingSource, "Номер зачётки", true));
            this.textBox8.Location = new System.Drawing.Point(263, 148);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 26);
            this.textBox8.TabIndex = 38;
            this.textBox8.Visible = false;
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
            this.clearFiltrButton.Location = new System.Drawing.Point(1615, 64);
            this.clearFiltrButton.Name = "clearFiltrButton";
            this.clearFiltrButton.Size = new System.Drawing.Size(247, 46);
            this.clearFiltrButton.TabIndex = 49;
            this.clearFiltrButton.Text = "Снять фильтр";
            this.clearFiltrButton.UseVisualStyleBackColor = true;
            this.clearFiltrButton.Click += new System.EventHandler(this.clearFiltrButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1615, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 46);
            this.button1.TabIndex = 50;
            this.button1.Text = "Фильтр по группе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentiTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1874, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearFiltrButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentiTableForm";
            this.Text = "Таблица Студенты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentiTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource studentiViewBindingSource;
        private DB_GroupsDataSetTableAdapters.StudentiViewTableAdapter studentiViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗачёткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource gruppiBindingSource;
        private DB_GroupsDataSetTableAdapters.GruppiTableAdapter gruppiTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button clearFiltrButton;
        private System.Windows.Forms.Button button1;
    }
}