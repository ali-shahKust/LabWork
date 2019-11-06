namespace CheckItemListBox
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
            this.myList = new System.Windows.Forms.CheckedListBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.ProsPecBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myList
            // 
            this.myList.FormattingEnabled = true;
            this.myList.Location = new System.Drawing.Point(254, 83);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(171, 214);
            this.myList.TabIndex = 0;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(266, 304);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(149, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Data";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // ProsPecBtn
            // 
            this.ProsPecBtn.Location = new System.Drawing.Point(432, 83);
            this.ProsPecBtn.Name = "ProsPecBtn";
            this.ProsPecBtn.Size = new System.Drawing.Size(75, 23);
            this.ProsPecBtn.TabIndex = 2;
            this.ProsPecBtn.Text = "Price ";
            this.ProsPecBtn.UseVisualStyleBackColor = true;
            this.ProsPecBtn.Click += new System.EventHandler(this.ProsPecBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProsPecBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.myList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox myList;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button ProsPecBtn;
    }
}

