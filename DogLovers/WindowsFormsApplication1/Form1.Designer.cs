namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gvDogLovers = new System.Windows.Forms.DataGridView();
            this.btnGetDogs = new System.Windows.Forms.Button();
            this.cmbMale = new System.Windows.Forms.ComboBox();
            this.cmbFemale = new System.Windows.Forms.ComboBox();
            this.lblMaleBreed = new System.Windows.Forms.Label();
            this.lblFemaleBreed = new System.Windows.Forms.Label();
            this.pbFemaleDog = new System.Windows.Forms.PictureBox();
            this.pbMaleDog = new System.Windows.Forms.PictureBox();
            this.lblMaleBirth = new System.Windows.Forms.Label();
            this.lblFemaleBirth = new System.Windows.Forms.Label();
            this.dtpMale = new System.Windows.Forms.DateTimePicker();
            this.dtpFemale = new System.Windows.Forms.DateTimePicker();
            this.btnCheckCompatibility = new System.Windows.Forms.Button();
            this.lblKompatibilnost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDogLovers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemaleDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaleDog)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDogLovers
            // 
            this.gvDogLovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDogLovers.Location = new System.Drawing.Point(29, 69);
            this.gvDogLovers.Name = "gvDogLovers";
            this.gvDogLovers.Size = new System.Drawing.Size(563, 140);
            this.gvDogLovers.TabIndex = 0;
            this.gvDogLovers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGetDogs
            // 
            this.btnGetDogs.Location = new System.Drawing.Point(29, 40);
            this.btnGetDogs.Name = "btnGetDogs";
            this.btnGetDogs.Size = new System.Drawing.Size(223, 23);
            this.btnGetDogs.TabIndex = 1;
            this.btnGetDogs.Text = "Види ги сите";
            this.btnGetDogs.UseVisualStyleBackColor = true;
            this.btnGetDogs.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMale
            // 
            this.cmbMale.FormattingEnabled = true;
            this.cmbMale.Items.AddRange(new object[] {
            "пекинезер",
            "териер",
            "лабрадор",
            "ретривер",
            "питбул",
            "чау-чау"});
            this.cmbMale.Location = new System.Drawing.Point(183, 247);
            this.cmbMale.Name = "cmbMale";
            this.cmbMale.Size = new System.Drawing.Size(121, 21);
            this.cmbMale.TabIndex = 2;
            // 
            // cmbFemale
            // 
            this.cmbFemale.FormattingEnabled = true;
            this.cmbFemale.Items.AddRange(new object[] {
            "пекинезер",
            "териер",
            "лабрадор",
            "ретривер",
            "питбул",
            "чау-чау"});
            this.cmbFemale.Location = new System.Drawing.Point(471, 242);
            this.cmbFemale.Name = "cmbFemale";
            this.cmbFemale.Size = new System.Drawing.Size(121, 21);
            this.cmbFemale.TabIndex = 3;
            // 
            // lblMaleBreed
            // 
            this.lblMaleBreed.AutoSize = true;
            this.lblMaleBreed.Location = new System.Drawing.Point(91, 255);
            this.lblMaleBreed.Name = "lblMaleBreed";
            this.lblMaleBreed.Size = new System.Drawing.Size(35, 13);
            this.lblMaleBreed.TabIndex = 4;
            this.lblMaleBreed.Text = "Раса:";
            // 
            // lblFemaleBreed
            // 
            this.lblFemaleBreed.AutoSize = true;
            this.lblFemaleBreed.Location = new System.Drawing.Point(401, 250);
            this.lblFemaleBreed.Name = "lblFemaleBreed";
            this.lblFemaleBreed.Size = new System.Drawing.Size(35, 13);
            this.lblFemaleBreed.TabIndex = 5;
            this.lblFemaleBreed.Text = "Раса:";
            // 
            // pbFemaleDog
            // 
            this.pbFemaleDog.Image = ((System.Drawing.Image)(resources.GetObject("pbFemaleDog.Image")));
            this.pbFemaleDog.Location = new System.Drawing.Point(337, 237);
            this.pbFemaleDog.Name = "pbFemaleDog";
            this.pbFemaleDog.Size = new System.Drawing.Size(60, 71);
            this.pbFemaleDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFemaleDog.TabIndex = 6;
            this.pbFemaleDog.TabStop = false;
            // 
            // pbMaleDog
            // 
            this.pbMaleDog.Image = ((System.Drawing.Image)(resources.GetObject("pbMaleDog.Image")));
            this.pbMaleDog.Location = new System.Drawing.Point(29, 237);
            this.pbMaleDog.Name = "pbMaleDog";
            this.pbMaleDog.Size = new System.Drawing.Size(60, 71);
            this.pbMaleDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaleDog.TabIndex = 7;
            this.pbMaleDog.TabStop = false;
            // 
            // lblMaleBirth
            // 
            this.lblMaleBirth.AutoSize = true;
            this.lblMaleBirth.Location = new System.Drawing.Point(91, 284);
            this.lblMaleBirth.Name = "lblMaleBirth";
            this.lblMaleBirth.Size = new System.Drawing.Size(59, 13);
            this.lblMaleBirth.TabIndex = 8;
            this.lblMaleBirth.Text = "Роденден:";
            // 
            // lblFemaleBirth
            // 
            this.lblFemaleBirth.AutoSize = true;
            this.lblFemaleBirth.Location = new System.Drawing.Point(401, 284);
            this.lblFemaleBirth.Name = "lblFemaleBirth";
            this.lblFemaleBirth.Size = new System.Drawing.Size(59, 13);
            this.lblFemaleBirth.TabIndex = 9;
            this.lblFemaleBirth.Text = "Роденден:";
            // 
            // dtpMale
            // 
            this.dtpMale.Location = new System.Drawing.Point(183, 284);
            this.dtpMale.Name = "dtpMale";
            this.dtpMale.Size = new System.Drawing.Size(121, 20);
            this.dtpMale.TabIndex = 10;
            // 
            // dtpFemale
            // 
            this.dtpFemale.Location = new System.Drawing.Point(471, 284);
            this.dtpFemale.Name = "dtpFemale";
            this.dtpFemale.Size = new System.Drawing.Size(121, 20);
            this.dtpFemale.TabIndex = 11;
            // 
            // btnCheckCompatibility
            // 
            this.btnCheckCompatibility.Location = new System.Drawing.Point(219, 334);
            this.btnCheckCompatibility.Name = "btnCheckCompatibility";
            this.btnCheckCompatibility.Size = new System.Drawing.Size(121, 23);
            this.btnCheckCompatibility.TabIndex = 12;
            this.btnCheckCompatibility.Text = "Make a MATCH";
            this.btnCheckCompatibility.UseVisualStyleBackColor = true;
            this.btnCheckCompatibility.Click += new System.EventHandler(this.btnCheckCompatibility_Click);
            // 
            // lblKompatibilnost
            // 
            this.lblKompatibilnost.AutoSize = true;
            this.lblKompatibilnost.Location = new System.Drawing.Point(404, 343);
            this.lblKompatibilnost.Name = "lblKompatibilnost";
            this.lblKompatibilnost.Size = new System.Drawing.Size(0, 13);
            this.lblKompatibilnost.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 385);
            this.Controls.Add(this.lblKompatibilnost);
            this.Controls.Add(this.btnCheckCompatibility);
            this.Controls.Add(this.dtpFemale);
            this.Controls.Add(this.dtpMale);
            this.Controls.Add(this.lblFemaleBirth);
            this.Controls.Add(this.lblMaleBirth);
            this.Controls.Add(this.pbMaleDog);
            this.Controls.Add(this.pbFemaleDog);
            this.Controls.Add(this.lblFemaleBreed);
            this.Controls.Add(this.lblMaleBreed);
            this.Controls.Add(this.cmbFemale);
            this.Controls.Add(this.cmbMale);
            this.Controls.Add(this.btnGetDogs);
            this.Controls.Add(this.gvDogLovers);
            this.Name = "Form1";
            this.Text = "Dog\'s Matchmaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDogLovers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemaleDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaleDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDogLovers;
        private System.Windows.Forms.Button btnGetDogs;
        private System.Windows.Forms.ComboBox cmbMale;
        private System.Windows.Forms.ComboBox cmbFemale;
        private System.Windows.Forms.Label lblMaleBreed;
        private System.Windows.Forms.Label lblFemaleBreed;
        private System.Windows.Forms.PictureBox pbFemaleDog;
        private System.Windows.Forms.PictureBox pbMaleDog;
        private System.Windows.Forms.Label lblMaleBirth;
        private System.Windows.Forms.Label lblFemaleBirth;
        private System.Windows.Forms.DateTimePicker dtpMale;
        private System.Windows.Forms.DateTimePicker dtpFemale;
        private System.Windows.Forms.Button btnCheckCompatibility;
        private System.Windows.Forms.Label lblKompatibilnost;
    }
}

