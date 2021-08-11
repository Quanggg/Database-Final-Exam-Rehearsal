
namespace Database_Final_Exam_Rehearsal
{
    partial class MainForm
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
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.menuStripItemIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStripItemMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStripMainForm.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemIntroduction,
            this.menuStripItemMusic});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(984, 24);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // menuStripItemIntroduction
            // 
            this.menuStripItemIntroduction.Name = "menuStripItemIntroduction";
            this.menuStripItemIntroduction.Size = new System.Drawing.Size(85, 20);
            this.menuStripItemIntroduction.Text = "Introduction";
            this.menuStripItemIntroduction.Click += new System.EventHandler(this.menuStripItemIntroduction_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Margin = new System.Windows.Forms.Padding(20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 536);
            this.panelMain.TabIndex = 1;
            // 
            // menuStripItemMusic
            // 
            this.menuStripItemMusic.CheckOnClick = true;
            this.menuStripItemMusic.Name = "menuStripItemMusic";
            this.menuStripItemMusic.Size = new System.Drawing.Size(51, 20);
            this.menuStripItemMusic.Text = "Music";
            this.menuStripItemMusic.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripItemMusic_DropDownItemClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Rehearsal_CS486_Team14";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemIntroduction;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemMusic;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBox1;
    }
}

