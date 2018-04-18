namespace Client
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.txtClientOutput = new System.Windows.Forms.RichTextBox();
            this.bttnSend = new System.Windows.Forms.Button();
            this.txtClientMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClientOutput
            // 
            this.txtClientOutput.Location = new System.Drawing.Point(12, 12);
            this.txtClientOutput.Name = "txtClientOutput";
            this.txtClientOutput.ReadOnly = true;
            this.txtClientOutput.Size = new System.Drawing.Size(358, 263);
            this.txtClientOutput.TabIndex = 0;
            this.txtClientOutput.Text = "";
            // 
            // bttnSend
            // 
            this.bttnSend.BackColor = System.Drawing.Color.Transparent;
            this.bttnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnSend.Location = new System.Drawing.Point(302, 281);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(73, 70);
            this.bttnSend.TabIndex = 2;
            this.bttnSend.UseVisualStyleBackColor = false;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // txtClientMessage
            // 
            this.txtClientMessage.Location = new System.Drawing.Point(12, 281);
            this.txtClientMessage.Multiline = true;
            this.txtClientMessage.Name = "txtClientMessage";
            this.txtClientMessage.Size = new System.Drawing.Size(271, 60);
            this.txtClientMessage.TabIndex = 3;
            this.txtClientMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientMessage_KeyDown);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.txtClientMessage);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.txtClientOutput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtClientOutput;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.TextBox txtClientMessage;
    }
}