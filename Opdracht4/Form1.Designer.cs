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
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnNextTask = new System.Windows.Forms.Button();
            this.btnTaskFinished = new System.Windows.Forms.Button();
            this.btnPutTaskBehind = new System.Windows.Forms.Button();
            this.tbMededelingen = new System.Windows.Forms.TextBox();
            this.lvTaken = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMeedelenText = new System.Windows.Forms.Button();
            this.btnMeedelenBox = new System.Windows.Forms.Button();
            this.btnGeluid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPickerTijd = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(73, 22);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(199, 23);
            this.tbTitel.TabIndex = 0;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(73, 51);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(199, 118);
            this.tbInfo.TabIndex = 1;
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Location = new System.Drawing.Point(2, 175);
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
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informatie";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(143, 206);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(129, 23);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Taak toevoegen";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnNextTask
            // 
            this.btnNextTask.Location = new System.Drawing.Point(292, 219);
            this.btnNextTask.Name = "btnNextTask";
            this.btnNextTask.Size = new System.Drawing.Size(136, 23);
            this.btnNextTask.TabIndex = 6;
            this.btnNextTask.Text = "Volgende taak";
            this.btnNextTask.UseVisualStyleBackColor = true;
            this.btnNextTask.Click += new System.EventHandler(this.btnNextTask_Click);
            // 
            // btnTaskFinished
            // 
            this.btnTaskFinished.Location = new System.Drawing.Point(434, 219);
            this.btnTaskFinished.Name = "btnTaskFinished";
            this.btnTaskFinished.Size = new System.Drawing.Size(136, 23);
            this.btnTaskFinished.TabIndex = 7;
            this.btnTaskFinished.Text = "Taak is afgewerkt";
            this.btnTaskFinished.UseVisualStyleBackColor = true;
            this.btnTaskFinished.Click += new System.EventHandler(this.btnTaskFinished_Click);
            // 
            // btnPutTaskBehind
            // 
            this.btnPutTaskBehind.Location = new System.Drawing.Point(576, 219);
            this.btnPutTaskBehind.Name = "btnPutTaskBehind";
            this.btnPutTaskBehind.Size = new System.Drawing.Size(141, 23);
            this.btnPutTaskBehind.TabIndex = 8;
            this.btnPutTaskBehind.Text = "Zet achteraan";
            this.btnPutTaskBehind.UseVisualStyleBackColor = true;
            this.btnPutTaskBehind.Click += new System.EventHandler(this.btnPutTaskBehind_Click);
            // 
            // tbMededelingen
            // 
            this.tbMededelingen.Location = new System.Drawing.Point(301, 272);
            this.tbMededelingen.Multiline = true;
            this.tbMededelingen.Name = "tbMededelingen";
            this.tbMededelingen.Size = new System.Drawing.Size(412, 184);
            this.tbMededelingen.TabIndex = 9;
            this.tbMededelingen.TextChanged += new System.EventHandler(this.tbMededelingen_TextChanged);
            // 
            // lvTaken
            // 
            this.lvTaken.Location = new System.Drawing.Point(12, 35);
            this.lvTaken.Name = "lvTaken";
            this.lvTaken.Size = new System.Drawing.Size(705, 178);
            this.lvTaken.TabIndex = 10;
            this.lvTaken.UseCompatibleStateImageBehavior = false;
            this.lvTaken.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Taken";
            // 
            // btnMeedelenText
            // 
            this.btnMeedelenText.Location = new System.Drawing.Point(300, 460);
            this.btnMeedelenText.Name = "btnMeedelenText";
            this.btnMeedelenText.Size = new System.Drawing.Size(133, 23);
            this.btnMeedelenText.TabIndex = 13;
            this.btnMeedelenText.Text = "Meedelen in text";
            this.btnMeedelenText.UseVisualStyleBackColor = true;
            this.btnMeedelenText.Click += new System.EventHandler(this.btnMeedelenText_Click);
            // 
            // btnMeedelenBox
            // 
            this.btnMeedelenBox.Location = new System.Drawing.Point(442, 460);
            this.btnMeedelenBox.Name = "btnMeedelenBox";
            this.btnMeedelenBox.Size = new System.Drawing.Size(133, 23);
            this.btnMeedelenBox.TabIndex = 14;
            this.btnMeedelenBox.Text = "Meedelen in MsgBox";
            this.btnMeedelenBox.UseVisualStyleBackColor = true;
            this.btnMeedelenBox.Click += new System.EventHandler(this.btnMeedelenBox_Click);
            // 
            // btnGeluid
            // 
            this.btnGeluid.Location = new System.Drawing.Point(580, 460);
            this.btnGeluid.Name = "btnGeluid";
            this.btnGeluid.Size = new System.Drawing.Size(133, 23);
            this.btnGeluid.TabIndex = 15;
            this.btnGeluid.Text = "Geluid";
            this.btnGeluid.UseVisualStyleBackColor = true;
            this.btnGeluid.Click += new System.EventHandler(this.btnGeluid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPickerTijd);
            this.groupBox1.Controls.Add(this.btnAddTask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTijd);
            this.groupBox1.Controls.Add(this.tbInfo);
            this.groupBox1.Controls.Add(this.tbTitel);
            this.groupBox1.Location = new System.Drawing.Point(11, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 231);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taak";
            // 
            // dtPickerTijd
            // 
            this.dtPickerTijd.Location = new System.Drawing.Point(72, 175);
            this.dtPickerTijd.Name = "dtPickerTijd";
            this.dtPickerTijd.Size = new System.Drawing.Size(200, 23);
            this.dtPickerTijd.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(296, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 233);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mededelingen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeluid);
            this.Controls.Add(this.btnMeedelenBox);
            this.Controls.Add(this.btnMeedelenText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvTaken);
            this.Controls.Add(this.tbMededelingen);
            this.Controls.Add(this.btnPutTaskBehind);
            this.Controls.Add(this.btnTaskFinished);
            this.Controls.Add(this.btnNextTask);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbInfo;
        private CheckBox cbTijd;
        private Label label1;
        private Label label2;
        private Button btnAddTask;
        private Button btnNextTask;
        private Button btnTaskFinished;
        private Button btnPutTaskBehind;
        private TextBox tbMededelingen;
        private ListView lvTaken;
        private Label label3;
        private Button btnMeedelenText;
        private Button btnMeedelenBox;
        private Button btnGeluid;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtPickerTijd;
    }
}