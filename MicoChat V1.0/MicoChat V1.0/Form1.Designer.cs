namespace MicoChat_V1._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_UserList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_UserList
            // 
            this.lb_UserList.Font = new System.Drawing.Font("KaiTi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_UserList.FormattingEnabled = true;
            this.lb_UserList.ItemHeight = 24;
            this.lb_UserList.Location = new System.Drawing.Point(2, 39);
            this.lb_UserList.Name = "lb_UserList";
            this.lb_UserList.Size = new System.Drawing.Size(270, 484);
            this.lb_UserList.TabIndex = 0;
            this.lb_UserList.DoubleClick += new System.EventHandler(this.lb_UserList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 575);
            this.Controls.Add(this.lb_UserList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_UserList;
    }
}

