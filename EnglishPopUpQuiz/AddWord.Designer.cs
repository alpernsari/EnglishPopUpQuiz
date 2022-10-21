
namespace EnglishPopUpQuiz
{
    partial class AddWord
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
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(76, 35);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(195, 22);
            this.txtIngilizce.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(475, 63);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 32);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(361, 35);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(195, 22);
            this.txtTurkce.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Türkçe";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIngilizce);
            this.Name = "AddWord";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWord_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}