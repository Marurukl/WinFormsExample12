namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelMenu = new System.Windows.Forms.TextBox();
            this.subItem = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addSubitem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // topLevelMenu
            // 
            this.topLevelMenu.Location = new System.Drawing.Point(12, 146);
            this.topLevelMenu.Name = "topLevelMenu";
            this.topLevelMenu.Size = new System.Drawing.Size(100, 20);
            this.topLevelMenu.TabIndex = 0;
            // 
            // subItem
            // 
            this.subItem.Location = new System.Drawing.Point(12, 210);
            this.subItem.Name = "subItem";
            this.subItem.Size = new System.Drawing.Size(100, 20);
            this.subItem.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(12, 172);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addSubitem
            // 
            this.addSubitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubitem.Location = new System.Drawing.Point(12, 236);
            this.addSubitem.Name = "addSubitem";
            this.addSubitem.Size = new System.Drawing.Size(100, 23);
            this.addSubitem.TabIndex = 3;
            this.addSubitem.Text = "menu";
            this.addSubitem.UseVisualStyleBackColor = true;
            this.addSubitem.Click += new System.EventHandler(this.AddSubitem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addSubitem);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subItem);
            this.Controls.Add(this.topLevelMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topLevelMenu;
        private System.Windows.Forms.TextBox subItem;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addSubitem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

