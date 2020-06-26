namespace Rosbisnessoft
{
    partial class FormService
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSpectrum = new System.Windows.Forms.TextBox();
            this.textBoxSoftware = new System.Windows.Forms.TextBox();
            this.textBoxLevel3 = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelVariety = new System.Windows.Forms.Label();
            this.labelSpectrum = new System.Windows.Forms.Label();
            this.labelSoftware = new System.Windows.Forms.Label();
            this.labelLevel3 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxVariety = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Location = new System.Drawing.Point(148, 348);
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
            this.buttonEdit.Location = new System.Drawing.Point(356, 348);
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
            this.buttonDel.Location = new System.Drawing.Point(582, 348);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(128, 34);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewService
            // 
            this.listViewService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewService.FullRowSelect = true;
            this.listViewService.GridLines = true;
            this.listViewService.HideSelection = false;
            this.listViewService.Location = new System.Drawing.Point(148, 133);
            this.listViewService.MultiSelect = false;
            this.listViewService.Name = "listViewService";
            this.listViewService.Size = new System.Drawing.Size(562, 184);
            this.listViewService.TabIndex = 4;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            this.listViewService.View = System.Windows.Forms.View.Details;
            this.listViewService.SelectedIndexChanged += new System.EventHandler(this.listViewService_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1C";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вид ПО";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Уровень";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            this.columnHeader5.Width = 82;
            // 
            // textBoxSpectrum
            // 
            this.textBoxSpectrum.Location = new System.Drawing.Point(194, 73);
            this.textBoxSpectrum.Name = "textBoxSpectrum";
            this.textBoxSpectrum.Size = new System.Drawing.Size(139, 21);
            this.textBoxSpectrum.TabIndex = 8;
            // 
            // textBoxSoftware
            // 
            this.textBoxSoftware.Location = new System.Drawing.Point(345, 73);
            this.textBoxSoftware.Name = "textBoxSoftware";
            this.textBoxSoftware.Size = new System.Drawing.Size(139, 21);
            this.textBoxSoftware.TabIndex = 9;
            // 
            // textBoxLevel3
            // 
            this.textBoxLevel3.Location = new System.Drawing.Point(492, 73);
            this.textBoxLevel3.Name = "textBoxLevel3";
            this.textBoxLevel3.Size = new System.Drawing.Size(139, 21);
            this.textBoxLevel3.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(650, 73);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(139, 21);
            this.textBoxPrice.TabIndex = 11;
            // 
            // labelVariety
            // 
            this.labelVariety.AutoSize = true;
            this.labelVariety.Location = new System.Drawing.Point(26, 46);
            this.labelVariety.Name = "labelVariety";
            this.labelVariety.Size = new System.Drawing.Size(66, 15);
            this.labelVariety.TabIndex = 13;
            this.labelVariety.Text = "Вид услуги";
            // 
            // labelSpectrum
            // 
            this.labelSpectrum.AutoSize = true;
            this.labelSpectrum.Location = new System.Drawing.Point(191, 46);
            this.labelSpectrum.Name = "labelSpectrum";
            this.labelSpectrum.Size = new System.Drawing.Size(23, 15);
            this.labelSpectrum.TabIndex = 14;
            this.labelSpectrum.Text = "1С";
            // 
            // labelSoftware
            // 
            this.labelSoftware.AutoSize = true;
            this.labelSoftware.Location = new System.Drawing.Point(342, 46);
            this.labelSoftware.Name = "labelSoftware";
            this.labelSoftware.Size = new System.Drawing.Size(50, 15);
            this.labelSoftware.TabIndex = 15;
            this.labelSoftware.Text = "Вид ПО";
            // 
            // labelLevel3
            // 
            this.labelLevel3.AutoSize = true;
            this.labelLevel3.Location = new System.Drawing.Point(489, 46);
            this.labelLevel3.Name = "labelLevel3";
            this.labelLevel3.Size = new System.Drawing.Size(55, 15);
            this.labelLevel3.TabIndex = 16;
            this.labelLevel3.Text = "Уровень";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(647, 46);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 15);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxVariety
            // 
            this.textBoxVariety.Location = new System.Drawing.Point(29, 73);
            this.textBoxVariety.Name = "textBoxVariety";
            this.textBoxVariety.Size = new System.Drawing.Size(139, 21);
            this.textBoxVariety.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosbisnessoft.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(689, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(874, 400);
            this.Controls.Add(this.textBoxVariety);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelLevel3);
            this.Controls.Add(this.labelSoftware);
            this.Controls.Add(this.labelSpectrum);
            this.Controls.Add(this.labelVariety);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxLevel3);
            this.Controls.Add(this.textBoxSoftware);
            this.Controls.Add(this.textBoxSpectrum);
            this.Controls.Add(this.listViewService);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormService";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxSpectrum;
        private System.Windows.Forms.TextBox textBoxSoftware;
        private System.Windows.Forms.TextBox textBoxLevel3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelVariety;
        private System.Windows.Forms.Label labelSpectrum;
        private System.Windows.Forms.Label labelSoftware;
        private System.Windows.Forms.Label labelLevel3;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxVariety;
    }
}