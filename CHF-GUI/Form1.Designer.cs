namespace CHF_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テンプレートの選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルから開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.左から右に読むToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプを表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuView,
            this.MenuHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(67, 20);
            this.MenuFile.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テンプレートの選択ToolStripMenuItem,
            this.ファイルから開くToolStripMenuItem});
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // テンプレートの選択ToolStripMenuItem
            // 
            this.テンプレートの選択ToolStripMenuItem.Name = "テンプレートの選択ToolStripMenuItem";
            this.テンプレートの選択ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.テンプレートの選択ToolStripMenuItem.Text = "テンプレートの選択";
            // 
            // ファイルから開くToolStripMenuItem
            // 
            this.ファイルから開くToolStripMenuItem.Name = "ファイルから開くToolStripMenuItem";
            this.ファイルから開くToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ファイルから開くToolStripMenuItem.Text = "ファイルから開く";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントFToolStripMenuItem});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(57, 20);
            this.MenuEdit.Text = "編集(&E)";
            // 
            // フォントFToolStripMenuItem
            // 
            this.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem";
            this.フォントFToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.フォントFToolStripMenuItem.Text = "フォント(F)";
            this.フォントFToolStripMenuItem.Click += new System.EventHandler(this.フォントFToolStripMenuItem_Click);
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左から右に読むToolStripMenuItem});
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(58, 20);
            this.MenuView.Text = "表示(&V)";
            // 
            // 左から右に読むToolStripMenuItem
            // 
            this.左から右に読むToolStripMenuItem.Name = "左から右に読むToolStripMenuItem";
            this.左から右に読むToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.左から右に読むToolStripMenuItem.Text = "左から右に読む";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプを表示ToolStripMenuItem});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(65, 20);
            this.MenuHelp.Text = "ヘルプ(&H)";
            // 
            // ヘルプを表示ToolStripMenuItem
            // 
            this.ヘルプを表示ToolStripMenuItem.Name = "ヘルプを表示ToolStripMenuItem";
            this.ヘルプを表示ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ヘルプを表示ToolStripMenuItem.Text = "ヘルプを表示";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(799, 423);
            this.textBox1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "PC";
            this.saveFileDialog1.Tag = "S-F-D1";
            this.saveFileDialog1.Title = "保存";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "C-S Text Editor";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テンプレートの選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルから開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem フォントFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 左から右に読むToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプを表示ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

