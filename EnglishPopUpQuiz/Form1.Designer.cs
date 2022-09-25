
namespace EnglishPopUpQuiz
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(228, 47);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(79, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(12, 193);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(103, 47);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "btnAnswer1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(138, 193);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(103, 47);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "button2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(262, 193);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(103, 47);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "button3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(380, 193);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(103, 47);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "button4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(522, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 370);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 429);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Timer tmrTimer;
        public System.Windows.Forms.Label lblQuestion;
        public System.Windows.Forms.Button btnAnswer1;
        public System.Windows.Forms.Button btnAnswer2;
        public System.Windows.Forms.Button btnAnswer3;
        public System.Windows.Forms.Button btnAnswer4;
    }
}

