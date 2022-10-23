namespace Opdracht4
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
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTijd = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnNextTask = new System.Windows.Forms.Button();
            this.btnTaskFinished = new System.Windows.Forms.Button();
            this.btnPutTaskBehind = new System.Windows.Forms.Button();
            this.tbMededelingen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(102, 40);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(199, 23);
            this.tbTitel.TabIndex = 0;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(102, 87);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(199, 79);
            this.tbInfo.TabIndex = 1;
            // 
            // tbTijd
            // 
            this.tbTijd.Location = new System.Drawing.Point(102, 220);
            this.tbTijd.Name = "tbTijd";
            this.tbTijd.Size = new System.Drawing.Size(199, 23);
            this.tbTijd.TabIndex = 2;
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(34, 177);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(45, 19);
            this.cbTijd.TabIndex = 3;
            this.cbTijd.Text = "Tijd";
            this.cbTijd.UseVisualStyleBackColor = true;
            this.cbTijd.CheckedChanged += new System.EventHandler(this.cbTijd_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informatie";
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Location = new System.Drawing.Point(34, 220);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(26, 15);
            this.lblTijd.TabIndex = 4;
            this.lblTijd.Text = "Tijd";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(64, 327);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(129, 23);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Taak toevoegen";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnNextTask
            // 
            this.btnNextTask.Location = new System.Drawing.Point(319, 327);
            this.btnNextTask.Name = "btnNextTask";
            this.btnNextTask.Size = new System.Drawing.Size(136, 23);
            this.btnNextTask.TabIndex = 6;
            this.btnNextTask.Text = "Volgende taak";
            this.btnNextTask.UseVisualStyleBackColor = true;
            // 
            // btnTaskFinished
            // 
            this.btnTaskFinished.Location = new System.Drawing.Point(479, 327);
            this.btnTaskFinished.Name = "btnTaskFinished";
            this.btnTaskFinished.Size = new System.Drawing.Size(136, 23);
            this.btnTaskFinished.TabIndex = 7;
            this.btnTaskFinished.Text = "Taak is afgewerkt";
            this.btnTaskFinished.UseVisualStyleBackColor = true;
            // 
            // btnPutTaskBehind
            // 
            this.btnPutTaskBehind.Location = new System.Drawing.Point(635, 327);
            this.btnPutTaskBehind.Name = "btnPutTaskBehind";
            this.btnPutTaskBehind.Size = new System.Drawing.Size(141, 23);
            this.btnPutTaskBehind.TabIndex = 8;
            this.btnPutTaskBehind.Text = "Zet achteraan";
            this.btnPutTaskBehind.UseVisualStyleBackColor = true;
            // 
            // tbMededelingen
            // 
            this.tbMededelingen.Location = new System.Drawing.Point(388, 40);
            this.tbMededelingen.Multiline = true;
            this.tbMededelingen.Name = "tbMededelingen";
            this.tbMededelingen.Size = new System.Drawing.Size(343, 203);
            this.tbMededelingen.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMededelingen);
            this.Controls.Add(this.btnPutTaskBehind);
            this.Controls.Add(this.btnTaskFinished);
            this.Controls.Add(this.btnNextTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.tbTijd);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbInfo;
        private TextBox tbTijd;
        private CheckBox cbTijd;
        private Label label1;
        private Label label2;
        private Label lblTijd;
        private Button btnAddTask;
        private Button btnNextTask;
        private Button btnTaskFinished;
        private Button btnPutTaskBehind;
        private TextBox tbMededelingen;
    }
}