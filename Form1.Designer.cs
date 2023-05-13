
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Acc_Name_textBox = new System.Windows.Forms.TextBox();
            this.Acc_No_textBox = new System.Windows.Forms.TextBox();
            this.ADD_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Acc_Name_textBox
            // 
            this.Acc_Name_textBox.Location = new System.Drawing.Point(155, 52);
            this.Acc_Name_textBox.Name = "Acc_Name_textBox";
            this.Acc_Name_textBox.Size = new System.Drawing.Size(100, 22);
            this.Acc_Name_textBox.TabIndex = 0;
            // 
            // Acc_No_textBox
            // 
            this.Acc_No_textBox.Location = new System.Drawing.Point(155, 107);
            this.Acc_No_textBox.Name = "Acc_No_textBox";
            this.Acc_No_textBox.Size = new System.Drawing.Size(100, 22);
            this.Acc_No_textBox.TabIndex = 1;
            // 
            // ADD_button
            // 
            this.ADD_button.Location = new System.Drawing.Point(294, 81);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(75, 23);
            this.ADD_button.TabIndex = 2;
            this.ADD_button.Text = "button1";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ADD_button);
            this.Controls.Add(this.Acc_No_textBox);
            this.Controls.Add(this.Acc_Name_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Acc_Name_textBox;
        private System.Windows.Forms.TextBox Acc_No_textBox;
        private System.Windows.Forms.Button ADD_button;
    }
}

