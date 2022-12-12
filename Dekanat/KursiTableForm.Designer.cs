namespace Dekanat
{
    partial class KursiTableForm
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
            this.годНачалаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКурсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kursiViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.kursiViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.KursiViewTableAdapter();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.ulabel4 = new System.Windows.Forms.Label();
            this.ulabel5 = new System.Windows.Forms.Label();
            this.ucheckBox2 = new System.Windows.Forms.CheckBox();
            this.ulabel6 = new System.Windows.Forms.Label();
            this.ulabel7 = new System.Windows.Forms.Label();
            this.ucomboBox2 = new System.Windows.Forms.ComboBox();
            this.utextBox2 = new System.Windows.Forms.TextBox();
            this.ulabel8 = new System.Windows.Forms.Label();
            this.dB_GroupsDataSet1 = new Dekanat.DB_GroupsDataSet();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursiViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet1)).BeginInit();
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
            this.годНачалаОбученияDataGridViewTextBoxColumn,
            this.номерКурсаDataGridViewTextBoxColumn,
            this.состояниеDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kursiViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // годНачалаОбученияDataGridViewTextBoxColumn
            // 
            this.годНачалаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Год начала обучения";
            this.годНачалаОбученияDataGridViewTextBoxColumn.HeaderText = "Год начала обучения";
            this.годНачалаОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.годНачалаОбученияDataGridViewTextBoxColumn.Name = "годНачалаОбученияDataGridViewTextBoxColumn";
            this.годНачалаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерКурсаDataGridViewTextBoxColumn
            // 
            this.номерКурсаDataGridViewTextBoxColumn.DataPropertyName = "Номер курса";
            this.номерКурсаDataGridViewTextBoxColumn.HeaderText = "Номер курса";
            this.номерКурсаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерКурсаDataGridViewTextBoxColumn.Name = "номерКурсаDataGridViewTextBoxColumn";
            this.номерКурсаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // состояниеDataGridViewCheckBoxColumn
            // 
            this.состояниеDataGridViewCheckBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewCheckBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.состояниеDataGridViewCheckBoxColumn.Name = "состояниеDataGridViewCheckBoxColumn";
            this.состояниеDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kursiViewBindingSource
            // 
            this.kursiViewBindingSource.DataMember = "KursiView";
            this.kursiViewBindingSource.DataSource = this.dB_GroupsDataSet;
            this.kursiViewBindingSource.CurrentChanged += new System.EventHandler(this.kursiViewBindingSource_CurrentChanged);
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursiViewTableAdapter
            // 
            this.kursiViewTableAdapter.ClearBeforeFill = true;
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
            this.insertButton.Size = new System.Drawing.Size(200, 60);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(0, 60);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 60);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 120);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 60);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Год начала обучения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kursiViewBindingSource, "Год начала обучения", true));
            this.textBox1.Location = new System.Drawing.Point(272, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kursiViewBindingSource, "Номер курса", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(452, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер курса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Состояние";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kursiViewBindingSource, "Состояние", true));
            this.checkBox1.Location = new System.Drawing.Point(592, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(397, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Если ещё проходит обучение, то стоит галочка";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // insertActiveButton
            // 
            this.insertActiveButton.Location = new System.Drawing.Point(879, 13);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 10;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
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
            // updateActiveButton
            // 
            this.updateActiveButton.Location = new System.Drawing.Point(879, 13);
            this.updateActiveButton.Name = "updateActiveButton";
            this.updateActiveButton.Size = new System.Drawing.Size(140, 47);
            this.updateActiveButton.TabIndex = 11;
            this.updateActiveButton.Text = "Изменить";
            this.updateActiveButton.UseVisualStyleBackColor = true;
            this.updateActiveButton.Visible = false;
            this.updateActiveButton.Click += new System.EventHandler(this.updateActiveButton_Click);
            // 
            // ulabel4
            // 
            this.ulabel4.AutoSize = true;
            this.ulabel4.Location = new System.Drawing.Point(235, 9);
            this.ulabel4.Name = "ulabel4";
            this.ulabel4.Size = new System.Drawing.Size(146, 20);
            this.ulabel4.TabIndex = 12;
            this.ulabel4.Text = "Исходные данные";
            this.ulabel4.Visible = false;
            this.ulabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ulabel5
            // 
            this.ulabel5.AutoSize = true;
            this.ulabel5.Location = new System.Drawing.Point(235, 96);
            this.ulabel5.Name = "ulabel5";
            this.ulabel5.Size = new System.Drawing.Size(121, 20);
            this.ulabel5.TabIndex = 13;
            this.ulabel5.Text = "Новые данные";
            this.ulabel5.Visible = false;
            // 
            // ucheckBox2
            // 
            this.ucheckBox2.AutoSize = true;
            this.ucheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.kursiViewBindingSource, "Состояние", true));
            this.ucheckBox2.Location = new System.Drawing.Point(592, 146);
            this.ucheckBox2.Name = "ucheckBox2";
            this.ucheckBox2.Size = new System.Drawing.Size(397, 24);
            this.ucheckBox2.TabIndex = 19;
            this.ucheckBox2.Text = "Если ещё проходит обучение, то стоит галочка";
            this.ucheckBox2.UseVisualStyleBackColor = true;
            this.ucheckBox2.Visible = false;
            // 
            // ulabel6
            // 
            this.ulabel6.AutoSize = true;
            this.ulabel6.Location = new System.Drawing.Point(592, 116);
            this.ulabel6.Name = "ulabel6";
            this.ulabel6.Size = new System.Drawing.Size(91, 20);
            this.ulabel6.TabIndex = 18;
            this.ulabel6.Text = "Состояние";
            this.ulabel6.Visible = false;
            // 
            // ulabel7
            // 
            this.ulabel7.AutoSize = true;
            this.ulabel7.Location = new System.Drawing.Point(452, 116);
            this.ulabel7.Name = "ulabel7";
            this.ulabel7.Size = new System.Drawing.Size(104, 20);
            this.ulabel7.TabIndex = 17;
            this.ulabel7.Text = "Номер курса";
            this.ulabel7.Visible = false;
            // 
            // ucomboBox2
            // 
            this.ucomboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kursiViewBindingSource, "Номер курса", true));
            this.ucomboBox2.FormattingEnabled = true;
            this.ucomboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ucomboBox2.Location = new System.Drawing.Point(452, 146);
            this.ucomboBox2.Name = "ucomboBox2";
            this.ucomboBox2.Size = new System.Drawing.Size(121, 28);
            this.ucomboBox2.TabIndex = 16;
            this.ucomboBox2.Visible = false;
            // 
            // utextBox2
            // 
            this.utextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kursiViewBindingSource, "Год начала обучения", true));
            this.utextBox2.Location = new System.Drawing.Point(272, 146);
            this.utextBox2.Name = "utextBox2";
            this.utextBox2.Size = new System.Drawing.Size(160, 26);
            this.utextBox2.TabIndex = 15;
            this.utextBox2.Visible = false;
            // 
            // ulabel8
            // 
            this.ulabel8.AutoSize = true;
            this.ulabel8.Location = new System.Drawing.Point(267, 116);
            this.ulabel8.Name = "ulabel8";
            this.ulabel8.Size = new System.Drawing.Size(171, 20);
            this.ulabel8.TabIndex = 14;
            this.ulabel8.Text = "Год начала обучения";
            this.ulabel8.Visible = false;
            // 
            // dB_GroupsDataSet1
            // 
            this.dB_GroupsDataSet1.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(879, 13);
            this.deleteActiveButton.Name = "deleteActiveButton";
            this.deleteActiveButton.Size = new System.Drawing.Size(140, 47);
            this.deleteActiveButton.TabIndex = 20;
            this.deleteActiveButton.Text = "Удалить";
            this.deleteActiveButton.UseVisualStyleBackColor = true;
            this.deleteActiveButton.Visible = false;
            this.deleteActiveButton.Click += new System.EventHandler(this.deleteActiveButton_Click);
            // 
            // KursiTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.ucheckBox2);
            this.Controls.Add(this.ulabel6);
            this.Controls.Add(this.ulabel7);
            this.Controls.Add(this.ucomboBox2);
            this.Controls.Add(this.utextBox2);
            this.Controls.Add(this.ulabel8);
            this.Controls.Add(this.ulabel5);
            this.Controls.Add(this.ulabel4);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KursiTableForm";
            this.Text = "Таблица Курсы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KursiTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursiViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource kursiViewBindingSource;
        private DB_GroupsDataSetTableAdapters.KursiViewTableAdapter kursiViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn годНачалаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКурсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn состояниеDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Label ulabel4;
        private System.Windows.Forms.Label ulabel5;
        private System.Windows.Forms.CheckBox ucheckBox2;
        private System.Windows.Forms.Label ulabel6;
        private System.Windows.Forms.Label ulabel7;
        private System.Windows.Forms.ComboBox ucomboBox2;
        private System.Windows.Forms.TextBox utextBox2;
        private System.Windows.Forms.Label ulabel8;
        private DB_GroupsDataSet dB_GroupsDataSet1;
        private System.Windows.Forms.Button deleteActiveButton;
    }
}