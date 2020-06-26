namespace Rosbisnessoft
{
    partial class Form1C
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
            this.buttonProd = new System.Windows.Forms.Button();
            this.buttonNastr = new System.Windows.Forms.Button();
            this.buttonObsl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProd
            // 
            this.buttonProd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonProd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProd.Location = new System.Drawing.Point(12, 65);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(335, 65);
            this.buttonProd.TabIndex = 0;
            this.buttonProd.Text = "Продажа 1С";
            this.buttonProd.UseVisualStyleBackColor = false;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // buttonNastr
            // 
            this.buttonNastr.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonNastr.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNastr.Location = new System.Drawing.Point(12, 147);
            this.buttonNastr.Name = "buttonNastr";
            this.buttonNastr.Size = new System.Drawing.Size(335, 65);
            this.buttonNastr.TabIndex = 1;
            this.buttonNastr.Text = "Настройка 1С";
            this.buttonNastr.UseVisualStyleBackColor = false;
            this.buttonNastr.Click += new System.EventHandler(this.buttonNastr_Click);
            // 
            // buttonObsl
            // 
            this.buttonObsl.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonObsl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonObsl.Location = new System.Drawing.Point(12, 227);
            this.buttonObsl.Name = "buttonObsl";
            this.buttonObsl.Size = new System.Drawing.Size(335, 65);
            this.buttonObsl.TabIndex = 2;
            this.buttonObsl.Text = "Обслуживание 1С";
            this.buttonObsl.UseVisualStyleBackColor = false;
            this.buttonObsl.Click += new System.EventHandler(this.buttonObsl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosbisnessoft.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(369, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonObsl);
            this.Controls.Add(this.buttonNastr);
            this.Controls.Add(this.buttonProd);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1C";
            this.Text = "1C: Предприятие 8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Button buttonNastr;
        private System.Windows.Forms.Button buttonObsl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}