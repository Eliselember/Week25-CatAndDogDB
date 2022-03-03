namespace CatAndDogDB
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
            this.listPets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listPetNames = new System.Windows.Forms.Label();
            this.listPetName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listPets
            // 
            this.listPets.FormattingEnabled = true;
            this.listPets.Location = new System.Drawing.Point(39, 115);
            this.listPets.Name = "listPets";
            this.listPets.Size = new System.Drawing.Size(120, 95);
            this.listPets.TabIndex = 0;
            this.listPets.SelectedIndexChanged += new System.EventHandler(this.listPets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pets";
            // 
            // listPetNames
            // 
            this.listPetNames.AutoSize = true;
            this.listPetNames.Location = new System.Drawing.Point(442, 44);
            this.listPetNames.Name = "listPetNames";
            this.listPetNames.Size = new System.Drawing.Size(59, 13);
            this.listPetNames.TabIndex = 2;
            this.listPetNames.Text = "Pet Names";
            this.listPetNames.Click += new System.EventHandler(this.listPets_SelectedIndexChanged);
            // 
            // listPetName
            // 
            this.listPetName.FormattingEnabled = true;
            this.listPetName.Location = new System.Drawing.Point(445, 115);
            this.listPetName.Name = "listPetName";
            this.listPetName.Size = new System.Drawing.Size(120, 95);
            this.listPetName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPetName);
            this.Controls.Add(this.listPetNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label listPetNames;
        private System.Windows.Forms.ListBox listPetName;
    }
}

