namespace ChatSize_ADMIN_
{
    partial class ChatAppAdminSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatAppAdminSize));
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameText
            // 
            this.UsernameText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.UsernameText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.UsernameText.Location = new System.Drawing.Point(305, 145);
            this.UsernameText.Multiline = true;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(510, 281);
            this.UsernameText.TabIndex = 0;
            // 
            // ChatAppAdminSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.UsernameText);
            this.Name = "ChatAppAdminSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Size [ADMIN]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameText;
    }
}

