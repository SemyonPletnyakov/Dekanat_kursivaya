namespace Dekanat
{
    partial class GruppiTableForm
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
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.gruppiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppiTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.GruppiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годНачалаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruppiViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppiViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.GruppiViewTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.specialnostBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kursiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialnostTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.SpecialnostTableAdapter();
            this.kursiTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.KursiTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.specialnostFilterButton = new System.Windows.Forms.Button();
            this.kursFilterButton = new System.Windows.Forms.Button();
            this.clearFiltrButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruppiBindingSource
            // 
            this.gruppiBindingSource.DataMember = "Gruppi";
            this.gruppiBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // gruppiTableAdapter
            // 
            this.gruppiTableAdapter.ClearBeforeFill = true;
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
            this.группаDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.годНачалаОбученияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gruppiViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1437, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            this.курсDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годНачалаОбученияDataGridViewTextBoxColumn
            // 
            this.годНачалаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Год начала обучения";
            this.годНачалаОбученияDataGridViewTextBoxColumn.HeaderText = "Год начала обучения";
            this.годНачалаОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.годНачалаОбученияDataGridViewTextBoxColumn.Name = "годНачалаОбученияDataGridViewTextBoxColumn";
            this.годНачалаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gruppiViewBindingSource
            // 
            this.gruppiViewBindingSource.DataMember = "GruppiView";
            this.gruppiViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // gruppiViewTableAdapter
            // 
            this.gruppiViewTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 142);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 71);
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
            this.updateButton.Location = new System.Drawing.Point(0, 71);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 71);
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
            this.insertButton.Size = new System.Drawing.Size(200, 71);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(862, 82);
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
            this.updateActiveButton.Location = new System.Drawing.Point(862, 82);
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
            this.insertActiveButton.Location = new System.Drawing.Point(862, 83);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 24;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppiViewBindingSource, "Группа", true));
            this.textBox1.Location = new System.Drawing.Point(275, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppiViewBindingSource, "Специальность", true));
            this.comboBox1.DataSource = this.specialnostBindingSource1;
            this.comboBox1.DisplayMember = "nazvanie_specialnosti";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(381, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 28);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "nazvanie_specialnosti";
            // 
            // specialnostBindingSource1
            // 
            this.specialnostBindingSource1.DataMember = "Specialnost";
            this.specialnostBindingSource1.DataSource = this.dB_GroupsDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppiViewBindingSource, "Год начала обучения", true));
            this.comboBox2.DataSource = this.kursiBindingSource;
            this.comboBox2.DisplayMember = "god_nachala";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(672, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 28);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.ValueMember = "god_nachala";
            // 
            // kursiBindingSource
            // 
            this.kursiBindingSource.DataMember = "Kursi";
            this.kursiBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Год начала обучения";
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // kursiTableAdapter
            // 
            this.kursiTableAdapter.ClearBeforeFill = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Исходные значения";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruppiViewBindingSource, "Группа", true));
            this.textBox2.Location = new System.Drawing.Point(275, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppiViewBindingSource, "Специальность", true));
            this.comboBox3.DataSource = this.specialnostBindingSource1;
            this.comboBox3.DisplayMember = "nazvanie_specialnosti";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(381, 180);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(285, 28);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.ValueMember = "nazvanie_specialnosti";
            this.comboBox3.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruppiViewBindingSource, "Год начала обучения", true));
            this.comboBox4.DataSource = this.kursiBindingSource;
            this.comboBox4.DisplayMember = "god_nachala";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(672, 180);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(168, 28);
            this.comboBox4.TabIndex = 29;
            this.comboBox4.ValueMember = "god_nachala";
            this.comboBox4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Группа";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Специальность";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Год начала обучения";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Новые значения";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // specialnostFilterButton
            // 
            this.specialnostFilterButton.Location = new System.Drawing.Point(1178, 12);
            this.specialnostFilterButton.Name = "specialnostFilterButton";
            this.specialnostFilterButton.Size = new System.Drawing.Size(247, 46);
            this.specialnostFilterButton.TabIndex = 34;
            this.specialnostFilterButton.Text = "Фильтр по специальности";
            this.specialnostFilterButton.UseVisualStyleBackColor = true;
            this.specialnostFilterButton.Click += new System.EventHandler(this.specialnostFilterButton_Click);
            // 
            // kursFilterButton
            // 
            this.kursFilterButton.Location = new System.Drawing.Point(1178, 64);
            this.kursFilterButton.Name = "kursFilterButton";
            this.kursFilterButton.Size = new System.Drawing.Size(247, 46);
            this.kursFilterButton.TabIndex = 35;
            this.kursFilterButton.Text = "Фильтр по курсу";
            this.kursFilterButton.UseVisualStyleBackColor = true;
            this.kursFilterButton.Click += new System.EventHandler(this.kursFilterButton_Click);
            // 
            // clearFiltrButton
            // 
            this.clearFiltrButton.Location = new System.Drawing.Point(1178, 116);
            this.clearFiltrButton.Name = "clearFiltrButton";
            this.clearFiltrButton.Size = new System.Drawing.Size(247, 46);
            this.clearFiltrButton.TabIndex = 36;
            this.clearFiltrButton.Text = "Снять фильтр";
            this.clearFiltrButton.UseVisualStyleBackColor = true;
            this.clearFiltrButton.Click += new System.EventHandler(this.clearFiltrButton_Click);
            // 
            // GruppiTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1437, 450);
            this.Controls.Add(this.clearFiltrButton);
            this.Controls.Add(this.kursFilterButton);
            this.Controls.Add(this.specialnostFilterButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GruppiTableForm";
            this.Text = "Таблица Группы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GruppiTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppiViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource gruppiBindingSource;
        private DB_GroupsDataSetTableAdapters.GruppiTableAdapter gruppiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gruppiViewBindingSource;
        private DB_GroupsDataSetTableAdapters.GruppiViewTableAdapter gruppiViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годНачалаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private DB_GroupsDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.BindingSource specialnostBindingSource1;
        private System.Windows.Forms.BindingSource kursiBindingSource;
        private DB_GroupsDataSetTableAdapters.KursiTableAdapter kursiTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button specialnostFilterButton;
        private System.Windows.Forms.Button kursFilterButton;
        private System.Windows.Forms.Button clearFiltrButton;
    }
}