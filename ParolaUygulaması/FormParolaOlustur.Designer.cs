namespace ParolaUygulaması
{
    partial class FormParolaOlustur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSeviye = new System.Windows.Forms.ComboBox();
            this.textBoxSecim = new System.Windows.Forms.TextBox();
            this.textBoxYaz = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonOlustur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxSeviye);
            this.panel1.Controls.Add(this.textBoxSecim);
            this.panel1.Controls.Add(this.textBoxYaz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOlustur.Location = new System.Drawing.Point(560, 115);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(146, 37);
            this.buttonOlustur.TabIndex = 1;
            this.buttonOlustur.Text = "Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(530, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seviye Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(282, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola Metni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alan Girişi";
            // 
            // comboBoxSeviye
            // 
            this.comboBoxSeviye.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSeviye.FormattingEnabled = true;
            this.comboBoxSeviye.Location = new System.Drawing.Point(534, 59);
            this.comboBoxSeviye.Name = "comboBoxSeviye";
            this.comboBoxSeviye.Size = new System.Drawing.Size(172, 29);
            this.comboBoxSeviye.TabIndex = 2;
            // 
            // textBoxSecim
            // 
            this.textBoxSecim.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSecim.Location = new System.Drawing.Point(44, 60);
            this.textBoxSecim.Name = "textBoxSecim";
            this.textBoxSecim.Size = new System.Drawing.Size(166, 28);
            this.textBoxSecim.TabIndex = 0;
            this.textBoxSecim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecim_KeyPress);
            // 
            // textBoxYaz
            // 
            this.textBoxYaz.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYaz.Location = new System.Drawing.Point(286, 60);
            this.textBoxYaz.Name = "textBoxYaz";
            this.textBoxYaz.Size = new System.Drawing.Size(166, 28);
            this.textBoxYaz.TabIndex = 1;
            this.textBoxYaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYaz_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormParolaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormParolaOlustur";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormParolaOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSeviye;
        private System.Windows.Forms.TextBox textBoxSecim;
        private System.Windows.Forms.TextBox textBoxYaz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}