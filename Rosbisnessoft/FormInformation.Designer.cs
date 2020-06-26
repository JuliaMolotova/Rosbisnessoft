namespace Rosbisnessoft
{
    partial class FormInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1C = new System.Windows.Forms.Button();
            this.buttonPO = new System.Windows.Forms.Button();
            this.buttonAvt = new System.Windows.Forms.Button();
            this.buttonConsultation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(19, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для уточнения информации вы\r\nможете связаться снами";
            // 
            // button1C
            // 
            this.button1C.BackColor = System.Drawing.Color.LimeGreen;
            this.button1C.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1C.Location = new System.Drawing.Point(22, 69);
            this.button1C.Name = "button1C";
            this.button1C.Size = new System.Drawing.Size(335, 65);
            this.button1C.TabIndex = 1;
            this.button1C.Text = "1С: Предприятие 8";
            this.button1C.UseVisualStyleBackColor = false;
            this.button1C.Click += new System.EventHandler(this.button1C_Click);
            // 
            // buttonPO
            // 
            this.buttonPO.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPO.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPO.Location = new System.Drawing.Point(22, 161);
            this.buttonPO.Name = "buttonPO";
            this.buttonPO.Size = new System.Drawing.Size(335, 65);
            this.buttonPO.TabIndex = 2;
            this.buttonPO.Text = "Деловое ПО";
            this.buttonPO.UseVisualStyleBackColor = false;
            this.buttonPO.Click += new System.EventHandler(this.buttonPO_Click);
            // 
            // buttonAvt
            // 
            this.buttonAvt.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAvt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAvt.Location = new System.Drawing.Point(22, 248);
            this.buttonAvt.Name = "buttonAvt";
            this.buttonAvt.Size = new System.Drawing.Size(335, 65);
            this.buttonAvt.TabIndex = 3;
            this.buttonAvt.Text = "Комплексная автоматизация";
            this.buttonAvt.UseVisualStyleBackColor = false;
            this.buttonAvt.Click += new System.EventHandler(this.buttonAvt_Click);
            // 
            // buttonConsultation
            // 
            this.buttonConsultation.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConsultation.Location = new System.Drawing.Point(229, 332);
            this.buttonConsultation.Name = "buttonConsultation";
            this.buttonConsultation.Size = new System.Drawing.Size(128, 34);
            this.buttonConsultation.TabIndex = 5;
            this.buttonConsultation.Text = "Связаться";
            this.buttonConsultation.UseVisualStyleBackColor = false;
            this.buttonConsultation.Click += new System.EventHandler(this.buttonConsultation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosbisnessoft.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(385, 385);
            this.Controls.Add(this.buttonConsultation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAvt);
            this.Controls.Add(this.buttonPO);
            this.Controls.Add(this.button1C);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormInformation";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1C;
        private System.Windows.Forms.Button buttonPO;
        private System.Windows.Forms.Button buttonAvt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConsultation;
    }
}