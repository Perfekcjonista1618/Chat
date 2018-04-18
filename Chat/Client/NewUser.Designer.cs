namespace Client
{
    partial class NewUser
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.bttnJoin = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // bttnJoin
            // 
            this.bttnJoin.BackColor = System.Drawing.Color.AliceBlue;
            this.bttnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnJoin.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.bttnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnJoin.Location = new System.Drawing.Point(114, 127);
            this.bttnJoin.Name = "bttnJoin";
            this.bttnJoin.Size = new System.Drawing.Size(100, 30);
            this.bttnJoin.TabIndex = 2;
            this.bttnJoin.Text = "Join server!";
            this.bttnJoin.UseVisualStyleBackColor = false;
            this.bttnJoin.Click += new System.EventHandler(this.bttnJoin_Click);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(48, 98);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(166, 25);
            this.txtNick.TabIndex = 3;
            this.txtNick.Text = "";
            this.txtNick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNick_KeyDown);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(287, 257);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.bttnJoin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnJoin;
        private System.Windows.Forms.RichTextBox txtNick;
    }
}

