namespace MysteryN
{
    partial class gameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameScreen));
            this.gbxSetUp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEndAt = new System.Windows.Forms.TextBox();
            this.txbStartAt = new System.Windows.Forms.TextBox();
            this.cmbxAttempts = new System.Windows.Forms.ComboBox();
            this.btnStartf2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            this.gbxPlay = new System.Windows.Forms.GroupBox();
            this.btnNumbersOffShow = new System.Windows.Forms.Button();
            this.lblCorrectIncorrect = new System.Windows.Forms.Label();
            this.lblNumbersOff = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWrongCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMyGuess = new System.Windows.Forms.TextBox();
            this.lblRemainingTries = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pgbGuess = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCheat = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLocate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.gbxDebug = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxSetUp.SuspendLayout();
            this.gbxPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuess)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSetUp
            // 
            this.gbxSetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxSetUp.Controls.Add(this.label3);
            this.gbxSetUp.Controls.Add(this.label2);
            this.gbxSetUp.Controls.Add(this.label1);
            this.gbxSetUp.Controls.Add(this.txbEndAt);
            this.gbxSetUp.Controls.Add(this.txbStartAt);
            this.gbxSetUp.Controls.Add(this.cmbxAttempts);
            this.gbxSetUp.Controls.Add(this.btnStartf2);
            this.gbxSetUp.ForeColor = System.Drawing.Color.White;
            this.gbxSetUp.Location = new System.Drawing.Point(12, 48);
            this.gbxSetUp.Name = "gbxSetUp";
            this.gbxSetUp.Size = new System.Drawing.Size(356, 136);
            this.gbxSetUp.TabIndex = 0;
            this.gbxSetUp.TabStop = false;
            this.gbxSetUp.Text = "Set Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attempts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "End at:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start at:";
            // 
            // txbEndAt
            // 
            this.txbEndAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEndAt.ForeColor = System.Drawing.Color.White;
            this.txbEndAt.Location = new System.Drawing.Point(216, 59);
            this.txbEndAt.Name = "txbEndAt";
            this.txbEndAt.Size = new System.Drawing.Size(127, 22);
            this.txbEndAt.TabIndex = 5;
            this.txbEndAt.Text = "10";
            // 
            // txbStartAt
            // 
            this.txbStartAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbStartAt.ForeColor = System.Drawing.Color.White;
            this.txbStartAt.Location = new System.Drawing.Point(216, 20);
            this.txbStartAt.Name = "txbStartAt";
            this.txbStartAt.Size = new System.Drawing.Size(127, 22);
            this.txbStartAt.TabIndex = 4;
            this.txbStartAt.Text = "0";
            // 
            // cmbxAttempts
            // 
            this.cmbxAttempts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbxAttempts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbxAttempts.ForeColor = System.Drawing.Color.White;
            this.cmbxAttempts.FormattingEnabled = true;
            this.cmbxAttempts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "35",
            "50",
            "100"});
            this.cmbxAttempts.Location = new System.Drawing.Point(215, 99);
            this.cmbxAttempts.Name = "cmbxAttempts";
            this.cmbxAttempts.Size = new System.Drawing.Size(128, 24);
            this.cmbxAttempts.TabIndex = 2;
            // 
            // btnStartf2
            // 
            this.btnStartf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartf2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartf2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartf2.ForeColor = System.Drawing.Color.White;
            this.btnStartf2.Location = new System.Drawing.Point(6, 23);
            this.btnStartf2.Name = "btnStartf2";
            this.btnStartf2.Size = new System.Drawing.Size(100, 100);
            this.btnStartf2.TabIndex = 0;
            this.btnStartf2.Text = "Start";
            this.btnStartf2.UseVisualStyleBackColor = false;
            this.btnStartf2.Click += new System.EventHandler(this.btnStartf2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(100, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DimGray;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(78, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbxInfo.ForeColor = System.Drawing.Color.White;
            this.rtbxInfo.Location = new System.Drawing.Point(11, 21);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.ReadOnly = true;
            this.rtbxInfo.Size = new System.Drawing.Size(264, 88);
            this.rtbxInfo.TabIndex = 1;
            this.rtbxInfo.Text = "";
            // 
            // gbxPlay
            // 
            this.gbxPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxPlay.Controls.Add(this.btnNumbersOffShow);
            this.gbxPlay.Controls.Add(this.lblCorrectIncorrect);
            this.gbxPlay.Controls.Add(this.lblNumbersOff);
            this.gbxPlay.Controls.Add(this.label9);
            this.gbxPlay.Controls.Add(this.lblWrongCounter);
            this.gbxPlay.Controls.Add(this.label7);
            this.gbxPlay.Controls.Add(this.txbMyGuess);
            this.gbxPlay.Controls.Add(this.lblRemainingTries);
            this.gbxPlay.Controls.Add(this.label8);
            this.gbxPlay.Controls.Add(this.pgbGuess);
            this.gbxPlay.Controls.Add(this.label6);
            this.gbxPlay.Controls.Add(this.label5);
            this.gbxPlay.Controls.Add(this.tbGuess);
            this.gbxPlay.Controls.Add(this.label4);
            this.gbxPlay.Controls.Add(this.btnGuess);
            this.gbxPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlay.ForeColor = System.Drawing.Color.White;
            this.gbxPlay.Location = new System.Drawing.Point(10, 190);
            this.gbxPlay.Name = "gbxPlay";
            this.gbxPlay.Size = new System.Drawing.Size(440, 176);
            this.gbxPlay.TabIndex = 2;
            this.gbxPlay.TabStop = false;
            this.gbxPlay.Text = "Play";
            // 
            // btnNumbersOffShow
            // 
            this.btnNumbersOffShow.BackColor = System.Drawing.Color.DimGray;
            this.btnNumbersOffShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumbersOffShow.ForeColor = System.Drawing.Color.Black;
            this.btnNumbersOffShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNumbersOffShow.Location = new System.Drawing.Point(394, 121);
            this.btnNumbersOffShow.Name = "btnNumbersOffShow";
            this.btnNumbersOffShow.Size = new System.Drawing.Size(31, 23);
            this.btnNumbersOffShow.TabIndex = 24;
            this.btnNumbersOffShow.Text = "=";
            this.btnNumbersOffShow.UseVisualStyleBackColor = false;
            this.btnNumbersOffShow.Click += new System.EventHandler(this.btnNumbersOffShow_Click);
            // 
            // lblCorrectIncorrect
            // 
            this.lblCorrectIncorrect.AutoSize = true;
            this.lblCorrectIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectIncorrect.Location = new System.Drawing.Point(162, 129);
            this.lblCorrectIncorrect.Name = "lblCorrectIncorrect";
            this.lblCorrectIncorrect.Size = new System.Drawing.Size(99, 32);
            this.lblCorrectIncorrect.TabIndex = 23;
            this.lblCorrectIncorrect.Text = "?????";
            // 
            // lblNumbersOff
            // 
            this.lblNumbersOff.AutoSize = true;
            this.lblNumbersOff.Location = new System.Drawing.Point(291, 143);
            this.lblNumbersOff.Name = "lblNumbersOff";
            this.lblNumbersOff.Size = new System.Drawing.Size(13, 18);
            this.lblNumbersOff.TabIndex = 21;
            this.lblNumbersOff.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Numbers Off:";
            // 
            // lblWrongCounter
            // 
            this.lblWrongCounter.AutoSize = true;
            this.lblWrongCounter.Location = new System.Drawing.Point(291, 43);
            this.lblWrongCounter.Name = "lblWrongCounter";
            this.lblWrongCounter.Size = new System.Drawing.Size(16, 18);
            this.lblWrongCounter.TabIndex = 19;
            this.lblWrongCounter.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Wrong Couter:";
            // 
            // txbMyGuess
            // 
            this.txbMyGuess.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txbMyGuess.ForeColor = System.Drawing.Color.White;
            this.txbMyGuess.Location = new System.Drawing.Point(198, 23);
            this.txbMyGuess.Name = "txbMyGuess";
            this.txbMyGuess.Size = new System.Drawing.Size(77, 24);
            this.txbMyGuess.TabIndex = 17;
            this.txbMyGuess.Text = "0";
            // 
            // lblRemainingTries
            // 
            this.lblRemainingTries.AutoSize = true;
            this.lblRemainingTries.Location = new System.Drawing.Point(291, 93);
            this.lblRemainingTries.Name = "lblRemainingTries";
            this.lblRemainingTries.Size = new System.Drawing.Size(13, 18);
            this.lblRemainingTries.TabIndex = 16;
            this.lblRemainingTries.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Remaining Tries:";
            // 
            // pgbGuess
            // 
            this.pgbGuess.Location = new System.Drawing.Point(11, 140);
            this.pgbGuess.Name = "pgbGuess";
            this.pgbGuess.Size = new System.Drawing.Size(122, 25);
            this.pgbGuess.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(116, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(255, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "H";
            // 
            // tbGuess
            // 
            this.tbGuess.Cursor = System.Windows.Forms.Cursors.No;
            this.tbGuess.Location = new System.Drawing.Point(112, 65);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(173, 56);
            this.tbGuess.TabIndex = 10;
            this.tbGuess.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGuess.Scroll += new System.EventHandler(this.tbGuess_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "My Guess:";
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(6, 21);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 100);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.groupBox3.Controls.Add(this.btnCheat);
            this.groupBox3.Controls.Add(this.btnAbout);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnLocate);
            this.groupBox3.Controls.Add(this.rtbxInfo);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // btnCheat
            // 
            this.btnCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheat.Location = new System.Drawing.Point(215, 115);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(60, 28);
            this.btnCheat.TabIndex = 5;
            this.btnCheat.Text = "Cheat";
            this.btnCheat.UseVisualStyleBackColor = false;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(130, 115);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 28);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(70, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLocate
            // 
            this.btnLocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocate.Location = new System.Drawing.Point(10, 115);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(58, 28);
            this.btnLocate.TabIndex = 2;
            this.btnLocate.Text = "Locate";
            this.btnLocate.UseVisualStyleBackColor = false;
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(384, 48);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(65, 65);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDebug.ForeColor = System.Drawing.Color.White;
            this.btnDebug.Location = new System.Drawing.Point(384, 119);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(65, 65);
            this.btnDebug.TabIndex = 5;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // gbxDebug
            // 
            this.gbxDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxDebug.ForeColor = System.Drawing.Color.White;
            this.gbxDebug.Location = new System.Drawing.Point(304, 372);
            this.gbxDebug.Name = "gbxDebug";
            this.gbxDebug.Size = new System.Drawing.Size(146, 153);
            this.gbxDebug.TabIndex = 6;
            this.gbxDebug.TabStop = false;
            this.gbxDebug.Text = "Debug";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(124, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "=============================";
            this.label10.DoubleClick += new System.EventHandler(this.label10_Click);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 532);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbxDebug);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxPlay);
            this.Controls.Add(this.gbxSetUp);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameScreen";
            this.Text = "Game Screen";
            this.gbxSetUp.ResumeLayout(false);
            this.gbxSetUp.PerformLayout();
            this.gbxPlay.ResumeLayout(false);
            this.gbxPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuess)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSetUp;
        private System.Windows.Forms.ComboBox cmbxAttempts;
        private System.Windows.Forms.Button btnStartf2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txbEndAt;
        private System.Windows.Forms.RichTextBox rtbxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbxPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TrackBar tbGuess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRemainingTries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pgbGuess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLocate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbStartAt;
        private System.Windows.Forms.TextBox txbMyGuess;
        private System.Windows.Forms.Label lblNumbersOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWrongCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCorrectIncorrect;
        private System.Windows.Forms.Button btnNumbersOffShow;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.GroupBox gbxDebug;
        private System.Windows.Forms.Label label10;
    }
}