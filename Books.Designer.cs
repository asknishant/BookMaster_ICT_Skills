namespace practice_project
{
    partial class Books
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
            this.Key = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblFirstpublication = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtboxkey = new System.Windows.Forms.TextBox();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.textboxSubtitle = new System.Windows.Forms.TextBox();
            this.textboxFirstpublicatoin = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(109, 88);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(46, 17);
            this.Key.TabIndex = 0;
            this.Key.Text = "lblKey";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(109, 159);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(109, 217);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(55, 17);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Subtitle";
            // 
            // lblFirstpublication
            // 
            this.lblFirstpublication.AutoSize = true;
            this.lblFirstpublication.Location = new System.Drawing.Point(109, 267);
            this.lblFirstpublication.Name = "lblFirstpublication";
            this.lblFirstpublication.Size = new System.Drawing.Size(108, 17);
            this.lblFirstpublication.TabIndex = 3;
            this.lblFirstpublication.Text = "First Publication";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(109, 331);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtboxkey
            // 
            this.txtboxkey.Location = new System.Drawing.Point(270, 82);
            this.txtboxkey.Name = "txtboxkey";
            this.txtboxkey.Size = new System.Drawing.Size(239, 22);
            this.txtboxkey.TabIndex = 5;
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(270, 154);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(239, 22);
            this.textboxTitle.TabIndex = 6;
            // 
            // textboxSubtitle
            // 
            this.textboxSubtitle.Location = new System.Drawing.Point(270, 217);
            this.textboxSubtitle.Name = "textboxSubtitle";
            this.textboxSubtitle.Size = new System.Drawing.Size(239, 22);
            this.textboxSubtitle.TabIndex = 7;
            // 
            // textboxFirstpublicatoin
            // 
            this.textboxFirstpublicatoin.Location = new System.Drawing.Point(270, 267);
            this.textboxFirstpublicatoin.Name = "textboxFirstpublicatoin";
            this.textboxFirstpublicatoin.Size = new System.Drawing.Size(239, 22);
            this.textboxFirstpublicatoin.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(270, 326);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(239, 22);
            this.textBoxDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textboxFirstpublicatoin);
            this.Controls.Add(this.textboxSubtitle);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.txtboxkey);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFirstpublication);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Key);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFirstpublication;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtboxkey;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.TextBox textboxSubtitle;
        private System.Windows.Forms.TextBox textboxFirstpublicatoin;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnSave;
    }
}