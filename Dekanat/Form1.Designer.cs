namespace Dekanat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GruppiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecialnostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultatiSessiyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UchebniyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PerechenPredmetovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утвердитьУчебныйПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утвердитьСписокСпециальностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаОбОбученииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otlichniciButton = new System.Windows.Forms.Button();
            this.odna4Button = new System.Windows.Forms.Button();
            this.dvoechnikiButton = new System.Windows.Forms.Button();
            this.zachotnayaVedomostButton = new System.Windows.Forms.Button();
            this.uchebniyPlanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.dB_GroupsDataSet1 = new Dekanat.DB_GroupsDataSet();
            this.report2 = new FastReport.Report();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.справкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentiToolStripMenuItem,
            this.GruppiToolStripMenuItem,
            this.KursiToolStripMenuItem,
            this.SpecialnostToolStripMenuItem,
            this.ResultatiSessiyToolStripMenuItem,
            this.UchebniyPlanToolStripMenuItem,
            this.PerechenPredmetovToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // StudentiToolStripMenuItem
            // 
            this.StudentiToolStripMenuItem.Name = "StudentiToolStripMenuItem";
            this.StudentiToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.StudentiToolStripMenuItem.Text = "Студенты";
            this.StudentiToolStripMenuItem.Click += new System.EventHandler(this.StudentiToolStripMenuItem_Click);
            // 
            // GruppiToolStripMenuItem
            // 
            this.GruppiToolStripMenuItem.Name = "GruppiToolStripMenuItem";
            this.GruppiToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.GruppiToolStripMenuItem.Text = "Группы";
            this.GruppiToolStripMenuItem.Click += new System.EventHandler(this.GruppiToolStripMenuItem_Click);
            // 
            // KursiToolStripMenuItem
            // 
            this.KursiToolStripMenuItem.Name = "KursiToolStripMenuItem";
            this.KursiToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.KursiToolStripMenuItem.Text = "Курсы";
            this.KursiToolStripMenuItem.Click += new System.EventHandler(this.KursiToolStripMenuItem_Click);
            // 
            // SpecialnostToolStripMenuItem
            // 
            this.SpecialnostToolStripMenuItem.Name = "SpecialnostToolStripMenuItem";
            this.SpecialnostToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.SpecialnostToolStripMenuItem.Text = "Специальности";
            this.SpecialnostToolStripMenuItem.Click += new System.EventHandler(this.SpecialnostToolStripMenuItem_Click);
            // 
            // ResultatiSessiyToolStripMenuItem
            // 
            this.ResultatiSessiyToolStripMenuItem.Name = "ResultatiSessiyToolStripMenuItem";
            this.ResultatiSessiyToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.ResultatiSessiyToolStripMenuItem.Text = "Результаты сессий";
            this.ResultatiSessiyToolStripMenuItem.Click += new System.EventHandler(this.ResultatiSessiyToolStripMenuItem_Click);
            // 
            // UchebniyPlanToolStripMenuItem
            // 
            this.UchebniyPlanToolStripMenuItem.Name = "UchebniyPlanToolStripMenuItem";
            this.UchebniyPlanToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.UchebniyPlanToolStripMenuItem.Text = "Учебный план";
            this.UchebniyPlanToolStripMenuItem.Click += new System.EventHandler(this.UchebniyPlanToolStripMenuItem_Click);
            // 
            // PerechenPredmetovToolStripMenuItem
            // 
            this.PerechenPredmetovToolStripMenuItem.Name = "PerechenPredmetovToolStripMenuItem";
            this.PerechenPredmetovToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.PerechenPredmetovToolStripMenuItem.Text = "Предметы";
            this.PerechenPredmetovToolStripMenuItem.Click += new System.EventHandler(this.PerechenPredmetovToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.утвердитьУчебныйПланToolStripMenuItem,
            this.утвердитьСписокСпециальностейToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.отчётыToolStripMenuItem.Text = "Составить приказы";
            // 
            // утвердитьУчебныйПланToolStripMenuItem
            // 
            this.утвердитьУчебныйПланToolStripMenuItem.Name = "утвердитьУчебныйПланToolStripMenuItem";
            this.утвердитьУчебныйПланToolStripMenuItem.Size = new System.Drawing.Size(393, 34);
            this.утвердитьУчебныйПланToolStripMenuItem.Text = "Утвердить учебный план";
            this.утвердитьУчебныйПланToolStripMenuItem.Click += new System.EventHandler(this.утвердитьУчебныйПланToolStripMenuItem_Click);
            // 
            // утвердитьСписокСпециальностейToolStripMenuItem
            // 
            this.утвердитьСписокСпециальностейToolStripMenuItem.Name = "утвердитьСписокСпециальностейToolStripMenuItem";
            this.утвердитьСписокСпециальностейToolStripMenuItem.Size = new System.Drawing.Size(393, 34);
            this.утвердитьСписокСпециальностейToolStripMenuItem.Text = "Утвердить список специальностей";
            this.утвердитьСписокСпециальностейToolStripMenuItem.Click += new System.EventHandler(this.утвердитьСписокСпециальностейToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаОбОбученииToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // справкаОбОбученииToolStripMenuItem
            // 
            this.справкаОбОбученииToolStripMenuItem.Name = "справкаОбОбученииToolStripMenuItem";
            this.справкаОбОбученииToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.справкаОбОбученииToolStripMenuItem.Text = "Справка об обучении";
            this.справкаОбОбученииToolStripMenuItem.Click += new System.EventHandler(this.справкаОбОбученииToolStripMenuItem_Click);
            // 
            // otlichniciButton
            // 
            this.otlichniciButton.Location = new System.Drawing.Point(12, 73);
            this.otlichniciButton.Name = "otlichniciButton";
            this.otlichniciButton.Size = new System.Drawing.Size(279, 45);
            this.otlichniciButton.TabIndex = 1;
            this.otlichniciButton.Text = "Отличники";
            this.otlichniciButton.UseVisualStyleBackColor = true;
            this.otlichniciButton.Click += new System.EventHandler(this.otlichniciPoslednyayaButton_Click);
            // 
            // odna4Button
            // 
            this.odna4Button.Location = new System.Drawing.Point(12, 124);
            this.odna4Button.Name = "odna4Button";
            this.odna4Button.Size = new System.Drawing.Size(279, 45);
            this.odna4Button.TabIndex = 2;
            this.odna4Button.Text = "Отличники с одной четвёркой";
            this.odna4Button.UseVisualStyleBackColor = true;
            this.odna4Button.Click += new System.EventHandler(this.odna4Button_Click);
            // 
            // dvoechnikiButton
            // 
            this.dvoechnikiButton.Location = new System.Drawing.Point(12, 175);
            this.dvoechnikiButton.Name = "dvoechnikiButton";
            this.dvoechnikiButton.Size = new System.Drawing.Size(279, 45);
            this.dvoechnikiButton.TabIndex = 3;
            this.dvoechnikiButton.Text = "Не сдавшие сессию";
            this.dvoechnikiButton.UseVisualStyleBackColor = true;
            this.dvoechnikiButton.Click += new System.EventHandler(this.dvoechnikiButton_Click);
            // 
            // zachotnayaVedomostButton
            // 
            this.zachotnayaVedomostButton.Location = new System.Drawing.Point(487, 73);
            this.zachotnayaVedomostButton.Name = "zachotnayaVedomostButton";
            this.zachotnayaVedomostButton.Size = new System.Drawing.Size(279, 45);
            this.zachotnayaVedomostButton.TabIndex = 4;
            this.zachotnayaVedomostButton.Text = "Зачётная ведомость";
            this.zachotnayaVedomostButton.UseVisualStyleBackColor = true;
            this.zachotnayaVedomostButton.Click += new System.EventHandler(this.zachotnayaVedomostButton_Click);
            // 
            // uchebniyPlanButton
            // 
            this.uchebniyPlanButton.Location = new System.Drawing.Point(487, 124);
            this.uchebniyPlanButton.Name = "uchebniyPlanButton";
            this.uchebniyPlanButton.Size = new System.Drawing.Size(279, 45);
            this.uchebniyPlanButton.TabIndex = 5;
            this.uchebniyPlanButton.Text = "Учебный план";
            this.uchebniyPlanButton.UseVisualStyleBackColor = true;
            this.uchebniyPlanButton.Click += new System.EventHandler(this.uchebniyPlanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выборки";
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(487, 175);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(279, 45);
            this.studentButton.TabIndex = 7;
            this.studentButton.Text = "Информация о студенте";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.dB_GroupsDataSet1, "dB_GroupsDataSet1");
            // 
            // dB_GroupsDataSet1
            // 
            this.dB_GroupsDataSet1.DataSetName = "DB_GroupsDataSet";
            this.dB_GroupsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report2
            // 
            this.report2.NeedRefresh = false;
            this.report2.ReportResourceString = resources.GetString("report2.ReportResourceString");
            this.report2.Tag = null;
            this.report2.RegisterData(this.dB_GroupsDataSet1, "dB_GroupsDataSet1");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uchebniyPlanButton);
            this.Controls.Add(this.zachotnayaVedomostButton);
            this.Controls.Add(this.dvoechnikiButton);
            this.Controls.Add(this.odna4Button);
            this.Controls.Add(this.otlichniciButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Деканат Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GroupsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GruppiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecialnostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultatiSessiyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UchebniyPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerechenPredmetovToolStripMenuItem;
        private System.Windows.Forms.Button otlichniciButton;
        private System.Windows.Forms.Button odna4Button;
        private System.Windows.Forms.Button dvoechnikiButton;
        private System.Windows.Forms.Button zachotnayaVedomostButton;
        private System.Windows.Forms.Button uchebniyPlanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem утвердитьУчебныйПланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private FastReport.Report report1;
        private DB_GroupsDataSet dB_GroupsDataSet1;
        private System.Windows.Forms.ToolStripMenuItem утвердитьСписокСпециальностейToolStripMenuItem;
        private FastReport.Report report2;
        private System.Windows.Forms.ToolStripMenuItem справкаОбОбученииToolStripMenuItem;
    }
}

