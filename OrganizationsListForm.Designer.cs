namespace medical_examination
{
    partial class OrganizationsListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfOrganizations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPorLegalEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationName,
            this.INN,
            this.KPP,
            this.Address,
            this.TypeOfOrganizations,
            this.IPorLegalEntity,
            this.Town});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(957, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrganizationName
            // 
            this.OrganizationName.HeaderText = "Название";
            this.OrganizationName.MinimumWidth = 6;
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Width = 125;
            // 
            // INN
            // 
            this.INN.HeaderText = "ИНН";
            this.INN.MinimumWidth = 6;
            this.INN.Name = "INN";
            this.INN.Width = 125;
            // 
            // KPP
            // 
            this.KPP.HeaderText = "КПП";
            this.KPP.MinimumWidth = 6;
            this.KPP.Name = "KPP";
            this.KPP.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес регистрации";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // TypeOfOrganizations
            // 
            this.TypeOfOrganizations.HeaderText = "Тип организации";
            this.TypeOfOrganizations.MinimumWidth = 6;
            this.TypeOfOrganizations.Name = "TypeOfOrganizations";
            this.TypeOfOrganizations.Width = 125;
            // 
            // IPorLegalEntity
            // 
            this.IPorLegalEntity.HeaderText = "ИП/Юр. Лицо";
            this.IPorLegalEntity.MinimumWidth = 6;
            this.IPorLegalEntity.Name = "IPorLegalEntity";
            this.IPorLegalEntity.Width = 150;
            // 
            // Town
            // 
            this.Town.HeaderText = "Населенный пункт";
            this.Town.MinimumWidth = 6;
            this.Town.Name = "Town";
            this.Town.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить организацию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(765, 603);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Экспортировать в Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список организаций";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(994, 603);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 33);
            this.button6.TabIndex = 16;
            this.button6.Text = "В главное меню";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(994, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "Применить фильтры";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(846, 53);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(123, 28);
            this.comboBox6.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(688, 53);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(149, 28);
            this.comboBox5.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(564, 53);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(118, 28);
            this.comboBox4.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фильтры";
            // 
            // OrganizationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 656);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrganizationsListForm";
            this.Text = "Список организаций";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private DataGridViewTextBoxColumn OrganizationName;
        private DataGridViewTextBoxColumn INN;
        private DataGridViewTextBoxColumn KPP;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn TypeOfOrganizations;
        private DataGridViewTextBoxColumn IPorLegalEntity;
        private DataGridViewTextBoxColumn Town;
        private Button button6;
        private Button button5;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private Label label2;
    }
}