namespace MicoChat_V1._0
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
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.lb_send = new System.Windows.Forms.ListBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.ItemHeight = 12;
            this.lb_chat.Location = new System.Drawing.Point(27, 28);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(686, 304);
            this.lb_chat.TabIndex = 0;
            // 
            // lb_send
            // 
            this.lb_send.FormattingEnabled = true;
            this.lb_send.ItemHeight = 12;
            this.lb_send.Location = new System.Drawing.Point(27, 357);
            this.lb_send.Name = "lb_send";
            this.lb_send.Size = new System.Drawing.Size(686, 52);
            this.lb_send.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(606, 441);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lb_send);
            this.Controls.Add(this.lb_chat);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_chat;
        private System.Windows.Forms.ListBox lb_send;
        private System.Windows.Forms.Button btn_send;
    }
}