namespace Students
{
    partial class Form1
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
            this.lbListaStudenti = new System.Windows.Forms.ListBox();
            this.nudBrPredmeti = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDosie = new System.Windows.Forms.ListBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProsek = new System.Windows.Forms.TextBox();
            this.tbNajvisokProsek = new System.Windows.Forms.TextBox();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на студенти";
            // 
            // lbListaStudenti
            // 
            this.lbListaStudenti.FormattingEnabled = true;
            this.lbListaStudenti.Location = new System.Drawing.Point(13, 30);
            this.lbListaStudenti.Name = "lbListaStudenti";
            this.lbListaStudenti.Size = new System.Drawing.Size(193, 368);
            this.lbListaStudenti.TabIndex = 1;
            this.lbListaStudenti.SelectedIndexChanged += new System.EventHandler(this.lbListaStudenti_SelectedIndexChanged);
            // 
            // nudBrPredmeti
            // 
            this.nudBrPredmeti.Location = new System.Drawing.Point(212, 30);
            this.nudBrPredmeti.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBrPredmeti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrPredmeti.Name = "nudBrPredmeti";
            this.nudBrPredmeti.Size = new System.Drawing.Size(150, 20);
            this.nudBrPredmeti.TabIndex = 2;
            this.nudBrPredmeti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Досие";
            // 
            // lbDosie
            // 
            this.lbDosie.FormattingEnabled = true;
            this.lbDosie.Location = new System.Drawing.Point(372, 30);
            this.lbDosie.Name = "lbDosie";
            this.lbDosie.Size = new System.Drawing.Size(193, 368);
            this.lbDosie.TabIndex = 4;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(13, 405);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(193, 23);
            this.btnDodadi.TabIndex = 5;
            this.btnDodadi.Text = "Нов студент";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(13, 435);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(193, 23);
            this.btnIzbrisi.TabIndex = 6;
            this.btnIzbrisi.Text = "Избриши студент";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Просек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Највисок просек";
            // 
            // tbProsek
            // 
            this.tbProsek.Location = new System.Drawing.Point(470, 402);
            this.tbProsek.Name = "tbProsek";
            this.tbProsek.ReadOnly = true;
            this.tbProsek.Size = new System.Drawing.Size(95, 20);
            this.tbProsek.TabIndex = 9;
            // 
            // tbNajvisokProsek
            // 
            this.tbNajvisokProsek.Location = new System.Drawing.Point(470, 432);
            this.tbNajvisokProsek.Name = "tbNajvisokProsek";
            this.tbNajvisokProsek.ReadOnly = true;
            this.tbNajvisokProsek.Size = new System.Drawing.Size(95, 20);
            this.tbNajvisokProsek.TabIndex = 10;
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Enabled = false;
            this.btnGeneriraj.Location = new System.Drawing.Point(213, 57);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(149, 23);
            this.btnGeneriraj.TabIndex = 11;
            this.btnGeneriraj.Text = "Генерирај досие";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 475);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.tbNajvisokProsek);
            this.Controls.Add(this.tbProsek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.lbDosie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBrPredmeti);
            this.Controls.Add(this.lbListaStudenti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Досие студент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbListaStudenti;
        private System.Windows.Forms.NumericUpDown nudBrPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDosie;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProsek;
        private System.Windows.Forms.TextBox tbNajvisokProsek;
        private System.Windows.Forms.Button btnGeneriraj;
    }
}

