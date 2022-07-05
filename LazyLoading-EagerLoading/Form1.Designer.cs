
namespace LazyLoading_EagerLoading
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
            this.btnLazyLoading = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEagerLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLazyLoading
            // 
            this.btnLazyLoading.Location = new System.Drawing.Point(13, 64);
            this.btnLazyLoading.Margin = new System.Windows.Forms.Padding(4);
            this.btnLazyLoading.Name = "btnLazyLoading";
            this.btnLazyLoading.Size = new System.Drawing.Size(113, 28);
            this.btnLazyLoading.TabIndex = 5;
            this.btnLazyLoading.Text = "Lazy Loading";
            this.btnLazyLoading.UseVisualStyleBackColor = true;
            this.btnLazyLoading.Click += new System.EventHandler(this.btnLazyLoading_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 100);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 164);
            this.listBox1.TabIndex = 4;
            // 
            // btnEagerLoading
            // 
            this.btnEagerLoading.Location = new System.Drawing.Point(13, 13);
            this.btnEagerLoading.Margin = new System.Windows.Forms.Padding(4);
            this.btnEagerLoading.Name = "btnEagerLoading";
            this.btnEagerLoading.Size = new System.Drawing.Size(113, 28);
            this.btnEagerLoading.TabIndex = 3;
            this.btnEagerLoading.Text = "Eager Loading";
            this.btnEagerLoading.UseVisualStyleBackColor = true;
            this.btnEagerLoading.Click += new System.EventHandler(this.btnEagerLoading_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 278);
            this.Controls.Add(this.btnLazyLoading);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEagerLoading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLazyLoading;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEagerLoading;
    }
}

