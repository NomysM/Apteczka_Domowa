namespace Apteczka_Domowa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNazwa = new TextBox();
            label2 = new Label();
            txtOpis = new TextBox();
            label3 = new Label();
            dtpDataWaznosci = new DateTimePicker();
            label4 = new Label();
            numIlosc = new NumericUpDown();
            btnDodaj = new Button();
            btnZapisz = new Button();
            listBoxLekow = new ListBox();
            btnWczytaj = new Button();
            btnPrzeterminowane = new Button();
            btnZmniejszIlosc = new Button();
            ((System.ComponentModel.ISupportInitialize)numIlosc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa:";
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(63, 12);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(100, 23);
            txtNazwa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 47);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Opis:";
            label2.Click += label2_Click;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(63, 47);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(100, 23);
            txtOpis.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Data ważności:";
            // 
            // dtpDataWaznosci
            // 
            dtpDataWaznosci.Location = new Point(103, 84);
            dtpDataWaznosci.Name = "dtpDataWaznosci";
            dtpDataWaznosci.Size = new Size(200, 23);
            dtpDataWaznosci.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 123);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Ilość:";
            // 
            // numIlosc
            // 
            numIlosc.Location = new Point(58, 121);
            numIlosc.Name = "numIlosc";
            numIlosc.Size = new Size(120, 23);
            numIlosc.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(12, 165);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(103, 165);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 9;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // listBoxLekow
            // 
            listBoxLekow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxLekow.FormattingEnabled = true;
            listBoxLekow.ItemHeight = 15;
            listBoxLekow.Location = new Point(444, 15);
            listBoxLekow.Name = "listBoxLekow";
            listBoxLekow.Size = new Size(428, 94);
            listBoxLekow.TabIndex = 10;
            // 
            // btnWczytaj
            // 
            btnWczytaj.Location = new Point(193, 165);
            btnWczytaj.Name = "btnWczytaj";
            btnWczytaj.Size = new Size(75, 23);
            btnWczytaj.TabIndex = 11;
            btnWczytaj.Text = "Wczytaj";
            btnWczytaj.UseVisualStyleBackColor = true;
            btnWczytaj.Click += btnWczytaj_Click;
            // 
            // btnPrzeterminowane
            // 
            btnPrzeterminowane.Location = new Point(288, 12);
            btnPrzeterminowane.Name = "btnPrzeterminowane";
            btnPrzeterminowane.Size = new Size(150, 23);
            btnPrzeterminowane.TabIndex = 12;
            btnPrzeterminowane.Text = "Pokaż przeterminowane";
            btnPrzeterminowane.UseVisualStyleBackColor = true;
            btnPrzeterminowane.Click += btnPrzeterminowane_Click;
            // 
            // btnZmniejszIlosc
            // 
            btnZmniejszIlosc.Location = new Point(363, 47);
            btnZmniejszIlosc.Name = "btnZmniejszIlosc";
            btnZmniejszIlosc.Size = new Size(75, 23);
            btnZmniejszIlosc.TabIndex = 13;
            btnZmniejszIlosc.Text = "Zużyj";
            btnZmniejszIlosc.UseVisualStyleBackColor = true;
            btnZmniejszIlosc.Click += btnZmniejszIlosc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(btnZmniejszIlosc);
            Controls.Add(btnPrzeterminowane);
            Controls.Add(btnWczytaj);
            Controls.Add(listBoxLekow);
            Controls.Add(btnZapisz);
            Controls.Add(btnDodaj);
            Controls.Add(numIlosc);
            Controls.Add(label4);
            Controls.Add(dtpDataWaznosci);
            Controls.Add(label3);
            Controls.Add(txtOpis);
            Controls.Add(label2);
            Controls.Add(txtNazwa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numIlosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNazwa;
        private Label label2;
        private TextBox txtOpis;
        private Label label3;
        private DateTimePicker dtpDataWaznosci;
        private Label label4;
        private NumericUpDown numIlosc;
        private Button btnDodaj;
        private Button btnZapisz;
        private ListBox listBoxLekow;
        private Button btnWczytaj;
        private Button btnPrzeterminowane;
        private Button btnZmniejszIlosc;
    }
}
