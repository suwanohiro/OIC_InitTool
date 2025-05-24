namespace OIC_InitTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            ApplicationExit = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 212);
            button1.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 0;
            button1.Text = "追加";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 120, 212);
            button2.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button2.ForeColor = Color.White;
            button2.Location = new Point(90, 22);
            button2.Name = "button2";
            button2.Size = new Size(150, 33);
            button2.TabIndex = 1;
            button2.Text = "スタートアップに登録";
            button2.UseVisualStyleBackColor = false;
            // 
            // ApplicationExit
            // 
            ApplicationExit.BackColor = Color.FromArgb(0, 120, 212);
            ApplicationExit.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            ApplicationExit.ForeColor = Color.White;
            ApplicationExit.Location = new Point(550, 22);
            ApplicationExit.Name = "ApplicationExit";
            ApplicationExit.Size = new Size(78, 33);
            ApplicationExit.TabIndex = 2;
            ApplicationExit.Text = "終了";
            ApplicationExit.UseVisualStyleBackColor = false;
            ApplicationExit.Click += ApplicationExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(ApplicationExit);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(640, 360);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(640, 360);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button ApplicationExit;
        private GroupBox groupBox1;
    }
}
