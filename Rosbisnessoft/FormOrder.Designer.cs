namespace Rosbisnessoft
{
    partial class FormOrder
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDateStart = new System.Windows.Forms.TextBox();
            this.textBoxDateEnd = new System.Windows.Forms.TextBox();
            this.росбизнессофтDataSet = new Rosbisnessoft.РосбизнессофтDataSet();
            this.clientsSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsSetTableAdapter = new Rosbisnessoft.РосбизнессофтDataSetTableAdapters.ClientsSetTableAdapter();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.росбизнессофтDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Location = new System.Drawing.Point(440, 414);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEdit.Location = new System.Drawing.Point(593, 414);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(128, 34);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDel.Location = new System.Drawing.Point(741, 414);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(128, 34);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(19, 42);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(47, 15);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Клиент";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(19, 121);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(67, 15);
            this.labelAgent.TabIndex = 5;
            this.labelAgent.Text = "Сотрудник";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(19, 200);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 15);
            this.labelService.TabIndex = 6;
            this.labelService.Text = "Услуга";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Location = new System.Drawing.Point(19, 269);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(123, 15);
            this.labelDateStart.TabIndex = 7;
            this.labelDateStart.Text = "Дата начала работы";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(19, 338);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(143, 15);
            this.labelDateEnd.TabIndex = 8;
            this.labelDateEnd.Text = "Дата окончания работы";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(211, 110);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(658, 274);
            this.listViewOrder.TabIndex = 9;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id клиента";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ФИО клиента";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id сотрудника";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО сотрудника";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id услуги";
            this.columnHeader6.Width = 91;
            // 
            // textBoxDateStart
            // 
            this.textBoxDateStart.Location = new System.Drawing.Point(22, 303);
            this.textBoxDateStart.Name = "textBoxDateStart";
            this.textBoxDateStart.Size = new System.Drawing.Size(139, 21);
            this.textBoxDateStart.TabIndex = 13;
            // 
            // textBoxDateEnd
            // 
            this.textBoxDateEnd.Location = new System.Drawing.Point(22, 374);
            this.textBoxDateEnd.Name = "textBoxDateEnd";
            this.textBoxDateEnd.Size = new System.Drawing.Size(139, 21);
            this.textBoxDateEnd.TabIndex = 14;
            // 
            // росбизнессофтDataSet
            // 
            this.росбизнессофтDataSet.DataSetName = "РосбизнессофтDataSet";
            this.росбизнессофтDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsSetBindingSource
            // 
            this.clientsSetBindingSource.DataMember = "ClientsSet";
            this.clientsSetBindingSource.DataSource = this.росбизнессофтDataSet;
            // 
            // clientsSetTableAdapter
            // 
            this.clientsSetTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(22, 77);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(139, 23);
            this.comboBoxClients.TabIndex = 15;
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(22, 154);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(139, 23);
            this.comboBoxAgents.TabIndex = 16;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(22, 227);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(139, 23);
            this.comboBoxService.TabIndex = 17;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Вид услуги";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дата начала работы";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Дата окончания работы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosbisnessoft.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(694, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(892, 464);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.textBoxDateEnd);
            this.Controls.Add(this.textBoxDateStart);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormOrder";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.росбизнессофтDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.TextBox textBoxDateStart;
        private System.Windows.Forms.TextBox textBoxDateEnd;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private РосбизнессофтDataSet росбизнессофтDataSet;
        private System.Windows.Forms.BindingSource clientsSetBindingSource;
        private РосбизнессофтDataSetTableAdapters.ClientsSetTableAdapter clientsSetTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}