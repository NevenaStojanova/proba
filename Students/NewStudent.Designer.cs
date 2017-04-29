namespace Students
{
    partial class NewStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIndeks = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadiNov = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(13, 26);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(232, 20);
            this.tbIme.TabIndex = 1;
            this.tbIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIme_KeyDown);
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Презиме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Индекс";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(13, 77);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(232, 20);
            this.tbPrezime.TabIndex = 4;
            this.tbPrezime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrezime_KeyDown);
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // tbIndeks
            // 
            this.tbIndeks.Location = new System.Drawing.Point(12, 128);
            this.tbIndeks.Name = "tbIndeks";
            this.tbIndeks.Size = new System.Drawing.Size(232, 20);
            this.tbIndeks.TabIndex = 5;
            this.tbIndeks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIndeks_KeyDown);
            this.tbIndeks.Validating += new System.ComponentModel.CancelEventHandler(this.tbIndeks_Validating);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(13, 168);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 6;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadiNov
            // 
            this.btnDodadiNov.Location = new System.Drawing.Point(168, 167);
            this.btnDodadiNov.Name = "btnDodadiNov";
            this.btnDodadiNov.Size = new System.Drawing.Size(75, 23);
            this.btnDodadiNov.TabIndex = 7;
            this.btnDodadiNov.Text = "Додади";
            this.btnDodadiNov.UseVisualStyleBackColor = true;
            this.btnDodadiNov.Click += new System.EventHandler(this.btnDodadiNov_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 212);
            this.Controls.Add(this.btnDodadiNov);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.tbIndeks);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label1);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIndeks;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadiNov;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}