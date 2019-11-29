namespace SharedMemory
{
    partial class MainWindow
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
            this.chatHistoryTextbox = new System.Windows.Forms.RichTextBox();
            this.createClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatHistoryTextbox
            // 
            this.chatHistoryTextbox.Location = new System.Drawing.Point(12, 38);
            this.chatHistoryTextbox.Name = "chatHistoryTextbox";
            this.chatHistoryTextbox.ReadOnly = true;
            this.chatHistoryTextbox.Size = new System.Drawing.Size(558, 400);
            this.chatHistoryTextbox.TabIndex = 0;
            this.chatHistoryTextbox.Text = "";
            // 
            // createClientButton
            // 
            this.createClientButton.Location = new System.Drawing.Point(600, 38);
            this.createClientButton.Name = "createClientButton";
            this.createClientButton.Size = new System.Drawing.Size(188, 42);
            this.createClientButton.TabIndex = 1;
            this.createClientButton.Text = "Create Client";
            this.createClientButton.UseVisualStyleBackColor = true;
            this.createClientButton.Click += new System.EventHandler(this.createClientButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createClientButton);
            this.Controls.Add(this.chatHistoryTextbox);
            this.Name = "MainWindow";
            this.Text = "Chat Room";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatHistoryTextbox;
        private System.Windows.Forms.Button createClientButton;
    }
}

