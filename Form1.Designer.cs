
namespace Learn_Vocabulary
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEng = new System.Windows.Forms.TextBox();
            this.TxtTurk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblVoc = new System.Windows.Forms.Label();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "English:";
            // 
            // TxtEng
            // 
            this.TxtEng.Location = new System.Drawing.Point(187, 73);
            this.TxtEng.Name = "TxtEng";
            this.TxtEng.Size = new System.Drawing.Size(221, 30);
            this.TxtEng.TabIndex = 10;
            // 
            // TxtTurk
            // 
            this.TxtTurk.Location = new System.Drawing.Point(187, 123);
            this.TxtTurk.Name = "TxtTurk";
            this.TxtTurk.Size = new System.Drawing.Size(221, 30);
            this.TxtTurk.TabIndex = 1;
            this.TxtTurk.TextChanged += new System.EventHandler(this.TxtTurk_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turkısh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(654, 76);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(37, 24);
            this.LblTime.TabIndex = 6;
            this.LblTime.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vocabulary:";
            // 
            // LblVoc
            // 
            this.LblVoc.AutoSize = true;
            this.LblVoc.Location = new System.Drawing.Point(654, 123);
            this.LblVoc.Name = "LblVoc";
            this.LblVoc.Size = new System.Drawing.Size(38, 24);
            this.LblVoc.TabIndex = 8;
            this.LblVoc.Text = "00";
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Location = new System.Drawing.Point(377, 225);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(31, 24);
            this.LblAnswer.TabIndex = 9;
            this.LblAnswer.Text = "...";
            this.LblAnswer.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 281);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.LblVoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTurk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEng);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEng;
        private System.Windows.Forms.TextBox TxtTurk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblVoc;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Timer timer1;
    }
}

