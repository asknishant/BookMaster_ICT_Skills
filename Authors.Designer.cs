namespace practice_project
{
    partial class Authors
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
            this.lblKey = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblDeathDate = new System.Windows.Forms.Label();
            this.lblWikipedia = new System.Windows.Forms.Label();
            this.textboxKey = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.textBoxWikipedia = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.deathDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(138, 84);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 17);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(138, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(138, 212);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(28, 17);
            this.lblBio.TabIndex = 2;
            this.lblBio.Text = "Bio";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(138, 272);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(65, 17);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // lblDeathDate
            // 
            this.lblDeathDate.AutoSize = true;
            this.lblDeathDate.Location = new System.Drawing.Point(138, 344);
            this.lblDeathDate.Name = "lblDeathDate";
            this.lblDeathDate.Size = new System.Drawing.Size(76, 17);
            this.lblDeathDate.TabIndex = 4;
            this.lblDeathDate.Text = "DeathDate";
            // 
            // lblWikipedia
            // 
            this.lblWikipedia.AutoSize = true;
            this.lblWikipedia.Location = new System.Drawing.Point(138, 412);
            this.lblWikipedia.Name = "lblWikipedia";
            this.lblWikipedia.Size = new System.Drawing.Size(69, 17);
            this.lblWikipedia.TabIndex = 5;
            this.lblWikipedia.Text = "Wikipedia";
            // 
            // textboxKey
            // 
            this.textboxKey.Location = new System.Drawing.Point(267, 84);
            this.textboxKey.Name = "textboxKey";
            this.textboxKey.Size = new System.Drawing.Size(257, 22);
            this.textboxKey.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(267, 146);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(257, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(267, 207);
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(257, 22);
            this.textBoxBio.TabIndex = 8;
            // 
            // textBoxWikipedia
            // 
            this.textBoxWikipedia.Location = new System.Drawing.Point(267, 409);
            this.textBoxWikipedia.Name = "textBoxWikipedia";
            this.textBoxWikipedia.Size = new System.Drawing.Size(257, 22);
            this.textBoxWikipedia.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(637, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(267, 267);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(257, 22);
            this.birthdate.TabIndex = 13;
            // 
            // deathDate
            // 
            this.deathDate.Location = new System.Drawing.Point(267, 339);
            this.deathDate.Name = "deathDate";
            this.deathDate.Size = new System.Drawing.Size(257, 22);
            this.deathDate.TabIndex = 14;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deathDate);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxWikipedia);
            this.Controls.Add(this.textBoxBio);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textboxKey);
            this.Controls.Add(this.lblWikipedia);
            this.Controls.Add(this.lblDeathDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblKey);
            this.Name = "Authors";
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblDeathDate;
        private System.Windows.Forms.Label lblWikipedia;
        private System.Windows.Forms.TextBox textboxKey;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBio;
        private System.Windows.Forms.TextBox textBoxWikipedia;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.DateTimePicker deathDate;
    }
}