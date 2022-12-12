namespace Dekanat
{
    partial class PerechenPredmetovTableForm
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
            this.названиеПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perechenpredmetovViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GroupsDataSet = new Dekanat.DB_GroupsDataSet();
            this.perechenpredmetovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perechen_predmetovTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.updateActiveButton = new System.Windows.Forms.Button();
            this.insertActiveButton = new System.Windows.Forms.Button();
            this.perechen_predmetovViewTableAdapter = new Dekanat.DB_GroupsDataSetTableAdapters.Perechen_predmetovViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovViewBindingSource)).BeginInit();
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
            this.названиеПредметаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.perechenpredmetovViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеПредметаDataGridViewTextBoxColumn
            // 
            this.названиеПредметаDataGridViewTextBoxColumn.DataPropertyName = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.HeaderText = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеПредметаDataGridViewTextBoxColumn.Name = "названиеПредметаDataGridViewTextBoxColumn";
            this.названиеПредметаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perechenpredmetovViewBindingSource
            // 
            this.perechenpredmetovViewBindingSource.DataMember = "Perechen_predmetovView";
            this.perechenpredmetovViewBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // dB_GroupsDataSet
            // 
            this.dB_GroupsDataSet.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perechenpredmetovBindingSource
            // 
            this.perechenpredmetovBindingSource.DataMember = "Perechen_predmetov";
            this.perechenpredmetovBindingSource.DataSource = this.dB_GroupsDataSet;
            // 
            // perechen_predmetovTableAdapter
            // 
            this.perechen_predmetovTableAdapter.ClearBeforeFill = true;
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
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.updateButton.TabIndex = 5;
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
            this.insertButton.Size = new System.Drawing.Size(200, 60);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.Location = new System.Drawing.Point(648, 12);
            this.deleteActiveButton.Name = "deleteActiveButton";
            this.deleteActiveButton.Size = new System.Drawing.Size(140, 47);
            this.deleteActiveButton.TabIndex = 23;
            this.deleteActiveButton.Text = "Удалить";
            this.deleteActiveButton.UseVisualStyleBackColor = true;
            this.deleteActiveButton.Visible = false;
            this.deleteActiveButton.Click += new System.EventHandler(this.deleteActiveButton_Click);
            // 
            // updateActiveButton
            // 
            this.updateActiveButton.Location = new System.Drawing.Point(648, 12);
            this.updateActiveButton.Name = "updateActiveButton";
            this.updateActiveButton.Size = new System.Drawing.Size(140, 47);
            this.updateActiveButton.TabIndex = 22;
            this.updateActiveButton.Text = "Изменить";
            this.updateActiveButton.UseVisualStyleBackColor = true;
            this.updateActiveButton.Visible = false;
            this.updateActiveButton.Click += new System.EventHandler(this.updateActiveButton_Click);
            // 
            // insertActiveButton
            // 
            this.insertActiveButton.Location = new System.Drawing.Point(648, 12);
            this.insertActiveButton.Name = "insertActiveButton";
            this.insertActiveButton.Size = new System.Drawing.Size(140, 47);
            this.insertActiveButton.TabIndex = 21;
            this.insertActiveButton.Text = "Добавить";
            this.insertActiveButton.UseVisualStyleBackColor = true;
            this.insertActiveButton.Click += new System.EventHandler(this.insertActiveButton_Click);
            // 
            // perechen_predmetovViewTableAdapter
            // 
            this.perechen_predmetovViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название предмета";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perechenpredmetovViewBindingSource, "Название предмета", true));
            this.textBox1.Location = new System.Drawing.Point(312, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 25;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Исходные данные";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Новые данные";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perechenpredmetovViewBindingSource, "Название предмета", true));
            this.textBox2.Location = new System.Drawing.Point(312, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 26);
            this.textBox2.TabIndex = 28;
            this.textBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Название предмета";
            this.label4.Visible = false;
            // 
            // PerechenPredmetovTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.updateActiveButton);
            this.Controls.Add(this.insertActiveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PerechenPredmetovTableForm";
            this.Text = "Таблица Перечень предметов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerechenPredmetovTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perechenpredmetovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_GroupsDataSet dB_GroupsDataSet;
        private System.Windows.Forms.BindingSource perechenpredmetovBindingSource;
        private DB_GroupsDataSetTableAdapters.Perechen_predmetovTableAdapter perechen_predmetovTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.Button updateActiveButton;
        private System.Windows.Forms.Button insertActiveButton;
        private System.Windows.Forms.BindingSource perechenpredmetovViewBindingSource;
        private DB_GroupsDataSetTableAdapters.Perechen_predmetovViewTableAdapter perechen_predmetovViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}