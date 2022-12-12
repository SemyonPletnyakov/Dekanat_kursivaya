namespace Dekanat
{
    partial class SpecialnostTableForm
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
            this.кодСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аббревиатураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСпециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.летОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.институтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.specialnostViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.SpecialnostViewTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).BeginInit();
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
            this.кодСпециальностиDataGridViewTextBoxColumn,
            this.аббревиатураDataGridViewTextBoxColumn,
            this.названиеСпециальностиDataGridViewTextBoxColumn,
            this.летОбученияDataGridViewTextBoxColumn,
            this.институтDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specialnostViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСпециальностиDataGridViewTextBoxColumn
            // 
            this.кодСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.HeaderText = "Код специальности";
            this.кодСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.кодСпециальностиDataGridViewTextBoxColumn.Name = "кодСпециальностиDataGridViewTextBoxColumn";
            this.кодСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // аббревиатураDataGridViewTextBoxColumn
            // 
            this.аббревиатураDataGridViewTextBoxColumn.DataPropertyName = "Аббревиатура";
            this.аббревиатураDataGridViewTextBoxColumn.HeaderText = "Аббревиатура";
            this.аббревиатураDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.аббревиатураDataGridViewTextBoxColumn.Name = "аббревиатураDataGridViewTextBoxColumn";
            this.аббревиатураDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеСпециальностиDataGridViewTextBoxColumn
            // 
            this.названиеСпециальностиDataGridViewTextBoxColumn.DataPropertyName = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.HeaderText = "Название специальности";
            this.названиеСпециальностиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеСпециальностиDataGridViewTextBoxColumn.Name = "названиеСпециальностиDataGridViewTextBoxColumn";
            this.названиеСпециальностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // летОбученияDataGridViewTextBoxColumn
            // 
            this.летОбученияDataGridViewTextBoxColumn.DataPropertyName = "Лет обучения";
            this.летОбученияDataGridViewTextBoxColumn.HeaderText = "Лет обучения";
            this.летОбученияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.летОбученияDataGridViewTextBoxColumn.Name = "летОбученияDataGridViewTextBoxColumn";
            this.летОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // институтDataGridViewTextBoxColumn
            // 
            this.институтDataGridViewTextBoxColumn.DataPropertyName = "Институт";
            this.институтDataGridViewTextBoxColumn.HeaderText = "Институт";
            this.институтDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.институтDataGridViewTextBoxColumn.Name = "институтDataGridViewTextBoxColumn";
            this.институтDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialnostViewBindingSource
            // 
            this.specialnostViewBindingSource.DataMember = "SpecialnostView";
            this.specialnostViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialnostViewTableAdapter
            // 
            this.specialnostViewTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(0, 148);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 74);
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
            this.updateButton.Location = new System.Drawing.Point(0, 74);
            this.updateButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 74);
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
            this.insertButton.Size = new System.Drawing.Size(200, 74);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(1172, 13);
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
            this.updateActiveButton.Location = new System.Drawing.Point(1172, 13);
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
            this.insertActiveButton.Location = new System.Drawing.Point(1172, 13);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 24;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Код специальности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Аббривеатура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Название специальности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Лет обучения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1078, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Институт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Исходные данные";
            this.label6.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Код специальности", true));
            this.textBox1.Location = new System.Drawing.Point(293, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 26);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Аббревиатура", true));
            this.textBox2.Location = new System.Drawing.Point(458, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 26);
            this.textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Название специальности", true));
            this.textBox3.Location = new System.Drawing.Point(593, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(323, 26);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Лет обучения", true));
            this.textBox4.Location = new System.Drawing.Point(965, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 26);
            this.textBox4.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Институт", true));
            this.textBox5.Location = new System.Drawing.Point(1082, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 26);
            this.textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Институт", true));
            this.textBox6.Location = new System.Drawing.Point(1082, 181);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 26);
            this.textBox6.TabIndex = 48;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Лет обучения", true));
            this.textBox7.Location = new System.Drawing.Point(965, 181);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(71, 26);
            this.textBox7.TabIndex = 47;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Название специальности", true));
            this.textBox8.Location = new System.Drawing.Point(593, 181);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(323, 26);
            this.textBox8.TabIndex = 46;
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Аббревиатура", true));
            this.textBox9.Location = new System.Drawing.Point(458, 181);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(71, 26);
            this.textBox9.TabIndex = 45;
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialnostViewBindingSource, "Код специальности", true));
            this.textBox10.Location = new System.Drawing.Point(293, 181);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(124, 26);
            this.textBox10.TabIndex = 44;
            this.textBox10.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Новые данные";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1078, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Институт";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(961, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Лет обучения";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Название специальности";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Аббривеатура";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Код специальности";
            this.label12.Visible = false;
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
            // SpecialnostTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpecialnostTableForm";
            this.Text = "Таблица Специальности";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SpecialnostTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource specialnostViewBindingSource;
        private DB_GroupsDataSetTableAdapters.SpecialnostViewTableAdapter specialnostViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аббревиатураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСпециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn летОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn институтDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}