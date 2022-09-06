using System.Windows.Forms;

namespace Metronom
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBxIncreaseBPM = new System.Windows.Forms.CheckBox();
            this.BPMtimer = new System.Windows.Forms.Timer(this.components);
            this.txtBxBPM = new System.Windows.Forms.TextBox();
            this.lblEnterBpm = new System.Windows.Forms.Label();
            this.txtBxIncreaseAfter = new System.Windows.Forms.TextBox();
            this.txtBxNewTact = new System.Windows.Forms.TextBox();
            this.lblIncreaseAfter = new System.Windows.Forms.Label();
            this.lblNewBpm = new System.Windows.Forms.Label();
            this.increaseBPMtimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTact = new System.Windows.Forms.Label();
            this.txtBxTact = new System.Windows.Forms.TextBox();
            this.lblTimerInput = new System.Windows.Forms.Label();
            this.txtBxCountDownRemain = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.txtBxInputMin = new System.Windows.Forms.TextBox();
            this.lblTimerInputMin = new System.Windows.Forms.Label();
            this.lblTimerInputSec = new System.Windows.Forms.Label();
            this.txtBxInputSec = new System.Windows.Forms.TextBox();
            this.led1 = new System.Windows.Forms.Button();
            this.led2 = new System.Windows.Forms.Button();
            this.led3 = new System.Windows.Forms.Button();
            this.led4 = new System.Windows.Forms.Button();
            this.led5 = new System.Windows.Forms.Button();
            this.led6 = new System.Windows.Forms.Button();
            this.cBoxLists = new System.Windows.Forms.ComboBox();
            this.lblSelectList = new System.Windows.Forms.Label();
            this.btnStartList = new System.Windows.Forms.Button();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.txtBxArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtBxSong = new System.Windows.Forms.TextBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.led10 = new System.Windows.Forms.Button();
            this.led9 = new System.Windows.Forms.Button();
            this.led8 = new System.Windows.Forms.Button();
            this.led7 = new System.Windows.Forms.Button();
            this.led11 = new System.Windows.Forms.Button();
            this.btnPauseList = new System.Windows.Forms.Button();
            this.btnHelpTwo = new System.Windows.Forms.Button();
            this.txtBxStep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBxIncreaseBPM
            // 
            this.cBxIncreaseBPM.AutoSize = true;
            this.cBxIncreaseBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxIncreaseBPM.Location = new System.Drawing.Point(15, 205);
            this.cBxIncreaseBPM.Name = "cBxIncreaseBPM";
            this.cBxIncreaseBPM.Size = new System.Drawing.Size(150, 26);
            this.cBxIncreaseBPM.TabIndex = 3;
            this.cBxIncreaseBPM.Text = "Increase BPM?";
            this.cBxIncreaseBPM.UseVisualStyleBackColor = true;
            // 
            // BPMtimer
            // 
            this.BPMtimer.Tick += new System.EventHandler(this.BPMtimer_Tick);
            // 
            // txtBxBPM
            // 
            this.txtBxBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxBPM.Location = new System.Drawing.Point(15, 146);
            this.txtBxBPM.Name = "txtBxBPM";
            this.txtBxBPM.Size = new System.Drawing.Size(95, 27);
            this.txtBxBPM.TabIndex = 1;
            // 
            // lblEnterBpm
            // 
            this.lblEnterBpm.AutoSize = true;
            this.lblEnterBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBpm.Location = new System.Drawing.Point(11, 89);
            this.lblEnterBpm.Name = "lblEnterBpm";
            this.lblEnterBpm.Size = new System.Drawing.Size(99, 44);
            this.lblEnterBpm.TabIndex = 0;
            this.lblEnterBpm.Text = "Please\nenter BPM:";
            // 
            // txtBxIncreaseAfter
            // 
            this.txtBxIncreaseAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxIncreaseAfter.Location = new System.Drawing.Point(15, 281);
            this.txtBxIncreaseAfter.Name = "txtBxIncreaseAfter";
            this.txtBxIncreaseAfter.Size = new System.Drawing.Size(135, 27);
            this.txtBxIncreaseAfter.TabIndex = 4;
            // 
            // txtBxNewTact
            // 
            this.txtBxNewTact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNewTact.Location = new System.Drawing.Point(15, 346);
            this.txtBxNewTact.Name = "txtBxNewTact";
            this.txtBxNewTact.Size = new System.Drawing.Size(134, 27);
            this.txtBxNewTact.TabIndex = 5;
            // 
            // lblIncreaseAfter
            // 
            this.lblIncreaseAfter.AutoSize = true;
            this.lblIncreaseAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncreaseAfter.Location = new System.Drawing.Point(11, 234);
            this.lblIncreaseAfter.Name = "lblIncreaseAfter";
            this.lblIncreaseAfter.Size = new System.Drawing.Size(138, 44);
            this.lblIncreaseAfter.TabIndex = 0;
            this.lblIncreaseAfter.Text = "Increase BPM\nafter... seconds:";
            // 
            // lblNewBpm
            // 
            this.lblNewBpm.AutoSize = true;
            this.lblNewBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBpm.Location = new System.Drawing.Point(11, 321);
            this.lblNewBpm.Name = "lblNewBpm";
            this.lblNewBpm.Size = new System.Drawing.Size(150, 22);
            this.lblNewBpm.TabIndex = 0;
            this.lblNewBpm.Text = "Increase BPM by:";
            // 
            // increaseBPMtimer
            // 
            this.increaseBPMtimer.Tick += new System.EventHandler(this.increaseBPMtimer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(650, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 51);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(650, 146);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 51);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTact
            // 
            this.lblTact.AutoSize = true;
            this.lblTact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTact.Location = new System.Drawing.Point(195, 89);
            this.lblTact.Name = "lblTact";
            this.lblTact.Size = new System.Drawing.Size(97, 44);
            this.lblTact.TabIndex = 0;
            this.lblTact.Text = "Please\nenter Tact:";
            // 
            // txtBxTact
            // 
            this.txtBxTact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTact.Location = new System.Drawing.Point(199, 146);
            this.txtBxTact.Name = "txtBxTact";
            this.txtBxTact.Size = new System.Drawing.Size(93, 27);
            this.txtBxTact.TabIndex = 2;
            // 
            // lblTimerInput
            // 
            this.lblTimerInput.AutoSize = true;
            this.lblTimerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerInput.Location = new System.Drawing.Point(165, 255);
            this.lblTimerInput.Name = "lblTimerInput";
            this.lblTimerInput.Size = new System.Drawing.Size(105, 22);
            this.lblTimerInput.TabIndex = 0;
            this.lblTimerInput.Text = "Timer Input:";
            // 
            // txtBxCountDownRemain
            // 
            this.txtBxCountDownRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCountDownRemain.Location = new System.Drawing.Point(169, 346);
            this.txtBxCountDownRemain.Name = "txtBxCountDownRemain";
            this.txtBxCountDownRemain.ReadOnly = true;
            this.txtBxCountDownRemain.Size = new System.Drawing.Size(155, 27);
            this.txtBxCountDownRemain.TabIndex = 0;
            this.txtBxCountDownRemain.TabStop = false;
            this.txtBxCountDownRemain.Text = "0";
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHelp.Location = new System.Drawing.Point(297, 250);
            this.btnHelp.MaximumSize = new System.Drawing.Size(27, 24);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 24);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemain.Location = new System.Drawing.Point(165, 320);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(145, 22);
            this.lblTimeRemain.TabIndex = 0;
            this.lblTimeRemain.Text = "Remaining Time:";
            // 
            // txtBxInputMin
            // 
            this.txtBxInputMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInputMin.Location = new System.Drawing.Point(169, 280);
            this.txtBxInputMin.Name = "txtBxInputMin";
            this.txtBxInputMin.Size = new System.Drawing.Size(39, 27);
            this.txtBxInputMin.TabIndex = 6;
            this.txtBxInputMin.Text = "0";
            // 
            // lblTimerInputMin
            // 
            this.lblTimerInputMin.AutoSize = true;
            this.lblTimerInputMin.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerInputMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerInputMin.Location = new System.Drawing.Point(205, 285);
            this.lblTimerInputMin.Name = "lblTimerInputMin";
            this.lblTimerInputMin.Size = new System.Drawing.Size(38, 22);
            this.lblTimerInputMin.TabIndex = 0;
            this.lblTimerInputMin.Text = "min";
            // 
            // lblTimerInputSec
            // 
            this.lblTimerInputSec.AutoSize = true;
            this.lblTimerInputSec.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerInputSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerInputSec.Location = new System.Drawing.Point(294, 285);
            this.lblTimerInputSec.Name = "lblTimerInputSec";
            this.lblTimerInputSec.Size = new System.Drawing.Size(38, 22);
            this.lblTimerInputSec.TabIndex = 0;
            this.lblTimerInputSec.Text = "sec";
            // 
            // txtBxInputSec
            // 
            this.txtBxInputSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInputSec.Location = new System.Drawing.Point(258, 280);
            this.txtBxInputSec.Name = "txtBxInputSec";
            this.txtBxInputSec.Size = new System.Drawing.Size(39, 27);
            this.txtBxInputSec.TabIndex = 7;
            this.txtBxInputSec.Text = "0";
            // 
            // led1
            // 
            this.led1.AccessibleName = "led1";
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.Enabled = false;
            this.led1.FlatAppearance.BorderSize = 0;
            this.led1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led1.ForeColor = System.Drawing.Color.Transparent;
            this.led1.Location = new System.Drawing.Point(15, 10);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(60, 60);
            this.led1.TabIndex = 10;
            this.led1.TabStop = false;
            this.led1.Tag = "";
            this.led1.UseVisualStyleBackColor = false;
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Transparent;
            this.led2.Enabled = false;
            this.led2.FlatAppearance.BorderSize = 0;
            this.led2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led2.ForeColor = System.Drawing.Color.Transparent;
            this.led2.Location = new System.Drawing.Point(81, 10);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(60, 60);
            this.led2.TabIndex = 11;
            this.led2.TabStop = false;
            this.led2.UseVisualStyleBackColor = false;
            // 
            // led3
            // 
            this.led3.BackColor = System.Drawing.Color.Transparent;
            this.led3.Enabled = false;
            this.led3.FlatAppearance.BorderSize = 0;
            this.led3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led3.ForeColor = System.Drawing.Color.Transparent;
            this.led3.Location = new System.Drawing.Point(147, 10);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(60, 60);
            this.led3.TabIndex = 12;
            this.led3.TabStop = false;
            this.led3.UseVisualStyleBackColor = false;
            // 
            // led4
            // 
            this.led4.BackColor = System.Drawing.Color.Transparent;
            this.led4.Enabled = false;
            this.led4.FlatAppearance.BorderSize = 0;
            this.led4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led4.ForeColor = System.Drawing.Color.Transparent;
            this.led4.Location = new System.Drawing.Point(213, 10);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(60, 60);
            this.led4.TabIndex = 13;
            this.led4.TabStop = false;
            this.led4.UseVisualStyleBackColor = false;
            // 
            // led5
            // 
            this.led5.BackColor = System.Drawing.Color.Transparent;
            this.led5.Enabled = false;
            this.led5.FlatAppearance.BorderSize = 0;
            this.led5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led5.ForeColor = System.Drawing.Color.Transparent;
            this.led5.Location = new System.Drawing.Point(279, 10);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(60, 60);
            this.led5.TabIndex = 14;
            this.led5.TabStop = false;
            this.led5.UseVisualStyleBackColor = false;
            // 
            // led6
            // 
            this.led6.BackColor = System.Drawing.Color.Transparent;
            this.led6.Enabled = false;
            this.led6.FlatAppearance.BorderSize = 0;
            this.led6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led6.ForeColor = System.Drawing.Color.Transparent;
            this.led6.Location = new System.Drawing.Point(345, 10);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(60, 60);
            this.led6.TabIndex = 15;
            this.led6.TabStop = false;
            this.led6.UseVisualStyleBackColor = false;
            // 
            // cBoxLists
            // 
            this.cBoxLists.FormattingEnabled = true;
            this.cBoxLists.Location = new System.Drawing.Point(357, 114);
            this.cBoxLists.Name = "cBoxLists";
            this.cBoxLists.Size = new System.Drawing.Size(277, 21);
            this.cBoxLists.TabIndex = 3;
            // 
            // lblSelectList
            // 
            this.lblSelectList.AutoSize = true;
            this.lblSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Location = new System.Drawing.Point(355, 89);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(182, 22);
            this.lblSelectList.TabIndex = 27;
            this.lblSelectList.Text = "Select a list if wished:";
            // 
            // btnStartList
            // 
            this.btnStartList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartList.Location = new System.Drawing.Point(357, 292);
            this.btnStartList.Name = "btnStartList";
            this.btnStartList.Size = new System.Drawing.Size(85, 51);
            this.btnStartList.TabIndex = 28;
            this.btnStartList.Text = "Start List";
            this.btnStartList.UseVisualStyleBackColor = true;
            this.btnStartList.Click += new System.EventHandler(this.btnStartList_Click);
            // 
            // btnCreateList
            // 
            this.btnCreateList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateList.Location = new System.Drawing.Point(549, 292);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(85, 51);
            this.btnCreateList.TabIndex = 30;
            this.btnCreateList.Text = "Open List Manager";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // txtBxArtist
            // 
            this.txtBxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxArtist.Location = new System.Drawing.Point(357, 174);
            this.txtBxArtist.Name = "txtBxArtist";
            this.txtBxArtist.ReadOnly = true;
            this.txtBxArtist.Size = new System.Drawing.Size(277, 27);
            this.txtBxArtist.TabIndex = 32;
            this.txtBxArtist.TabStop = false;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(355, 149);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(56, 22);
            this.lblArtist.TabIndex = 31;
            this.lblArtist.Text = "Artist:";
            // 
            // txtBxSong
            // 
            this.txtBxSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSong.Location = new System.Drawing.Point(357, 234);
            this.txtBxSong.Name = "txtBxSong";
            this.txtBxSong.ReadOnly = true;
            this.txtBxSong.Size = new System.Drawing.Size(277, 27);
            this.txtBxSong.TabIndex = 34;
            this.txtBxSong.TabStop = false;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(355, 209);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(57, 22);
            this.lblSong.TabIndex = 33;
            this.lblSong.Text = "Song:";
            // 
            // led10
            // 
            this.led10.BackColor = System.Drawing.Color.Transparent;
            this.led10.Enabled = false;
            this.led10.FlatAppearance.BorderSize = 0;
            this.led10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led10.ForeColor = System.Drawing.Color.Transparent;
            this.led10.Location = new System.Drawing.Point(609, 10);
            this.led10.Name = "led10";
            this.led10.Size = new System.Drawing.Size(60, 60);
            this.led10.TabIndex = 38;
            this.led10.TabStop = false;
            this.led10.UseVisualStyleBackColor = false;
            // 
            // led9
            // 
            this.led9.BackColor = System.Drawing.Color.Transparent;
            this.led9.Enabled = false;
            this.led9.FlatAppearance.BorderSize = 0;
            this.led9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led9.ForeColor = System.Drawing.Color.Transparent;
            this.led9.Location = new System.Drawing.Point(543, 10);
            this.led9.Name = "led9";
            this.led9.Size = new System.Drawing.Size(60, 60);
            this.led9.TabIndex = 37;
            this.led9.TabStop = false;
            this.led9.UseVisualStyleBackColor = false;
            // 
            // led8
            // 
            this.led8.BackColor = System.Drawing.Color.Transparent;
            this.led8.Enabled = false;
            this.led8.FlatAppearance.BorderSize = 0;
            this.led8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led8.ForeColor = System.Drawing.Color.Transparent;
            this.led8.Location = new System.Drawing.Point(477, 10);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(60, 60);
            this.led8.TabIndex = 36;
            this.led8.TabStop = false;
            this.led8.UseVisualStyleBackColor = false;
            // 
            // led7
            // 
            this.led7.BackColor = System.Drawing.Color.Transparent;
            this.led7.Enabled = false;
            this.led7.FlatAppearance.BorderSize = 0;
            this.led7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led7.ForeColor = System.Drawing.Color.Transparent;
            this.led7.Location = new System.Drawing.Point(411, 10);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(60, 60);
            this.led7.TabIndex = 35;
            this.led7.TabStop = false;
            this.led7.UseVisualStyleBackColor = false;
            // 
            // led11
            // 
            this.led11.BackColor = System.Drawing.Color.Transparent;
            this.led11.FlatAppearance.BorderSize = 0;
            this.led11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.led11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.led11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led11.ForeColor = System.Drawing.Color.Transparent;
            this.led11.Location = new System.Drawing.Point(675, 10);
            this.led11.Name = "led11";
            this.led11.Size = new System.Drawing.Size(60, 60);
            this.led11.TabIndex = 39;
            this.led11.TabStop = false;
            this.led11.UseVisualStyleBackColor = false;
            this.led11.Click += new System.EventHandler(this.led11_Click);
            // 
            // btnPauseList
            // 
            this.btnPauseList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPauseList.Location = new System.Drawing.Point(453, 292);
            this.btnPauseList.Name = "btnPauseList";
            this.btnPauseList.Size = new System.Drawing.Size(85, 51);
            this.btnPauseList.TabIndex = 29;
            this.btnPauseList.Text = "Pause";
            this.btnPauseList.UseVisualStyleBackColor = true;
            this.btnPauseList.Click += new System.EventHandler(this.btnPauseList_Click);
            // 
            // btnHelpTwo
            // 
            this.btnHelpTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHelpTwo.Location = new System.Drawing.Point(708, 209);
            this.btnHelpTwo.MaximumSize = new System.Drawing.Size(27, 24);
            this.btnHelpTwo.Name = "btnHelpTwo";
            this.btnHelpTwo.Size = new System.Drawing.Size(27, 24);
            this.btnHelpTwo.TabIndex = 40;
            this.btnHelpTwo.TabStop = false;
            this.btnHelpTwo.Text = "?";
            this.btnHelpTwo.UseVisualStyleBackColor = true;
            this.btnHelpTwo.Click += new System.EventHandler(this.btnHelpTwo_Click);
            // 
            // txtBxStep
            // 
            this.txtBxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxStep.Location = new System.Drawing.Point(650, 234);
            this.txtBxStep.Name = "txtBxStep";
            this.txtBxStep.Size = new System.Drawing.Size(85, 27);
            this.txtBxStep.TabIndex = 41;
            this.txtBxStep.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(749, 387);
            this.Controls.Add(this.txtBxStep);
            this.Controls.Add(this.btnHelpTwo);
            this.Controls.Add(this.btnPauseList);
            this.Controls.Add(this.led11);
            this.Controls.Add(this.led10);
            this.Controls.Add(this.led9);
            this.Controls.Add(this.led8);
            this.Controls.Add(this.led7);
            this.Controls.Add(this.txtBxSong);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtBxArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnCreateList);
            this.Controls.Add(this.btnStartList);
            this.Controls.Add(this.lblSelectList);
            this.Controls.Add(this.cBoxLists);
            this.Controls.Add(this.txtBxInputMin);
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.txtBxInputSec);
            this.Controls.Add(this.lblTimerInputSec);
            this.Controls.Add(this.lblTimerInputMin);
            this.Controls.Add(this.lblTimeRemain);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimerInput);
            this.Controls.Add(this.txtBxCountDownRemain);
            this.Controls.Add(this.txtBxTact);
            this.Controls.Add(this.lblTact);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNewBpm);
            this.Controls.Add(this.lblIncreaseAfter);
            this.Controls.Add(this.txtBxNewTact);
            this.Controls.Add(this.txtBxIncreaseAfter);
            this.Controls.Add(this.lblEnterBpm);
            this.Controls.Add(this.txtBxBPM);
            this.Controls.Add(this.cBxIncreaseBPM);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Metronom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CBoxLists_DropDown(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox cBxIncreaseBPM;
        private System.Windows.Forms.Timer BPMtimer;
        private System.Windows.Forms.TextBox txtBxBPM;
        private System.Windows.Forms.Label lblEnterBpm;
        private System.Windows.Forms.TextBox txtBxIncreaseAfter;
        private System.Windows.Forms.TextBox txtBxNewTact;
        private System.Windows.Forms.Label lblIncreaseAfter;
        private System.Windows.Forms.Label lblNewBpm;
        private System.Windows.Forms.Timer increaseBPMtimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTact;
        private System.Windows.Forms.TextBox txtBxTact;
        private System.Windows.Forms.Label lblTimerInput;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.TextBox txtBxInputMin;
        private System.Windows.Forms.Label lblTimerInputMin;
        private System.Windows.Forms.Label lblTimerInputSec;
        private System.Windows.Forms.TextBox txtBxInputSec;
        private System.Windows.Forms.TextBox txtBxCountDownRemain;
        public Button led1;
        public Button led2;
        public Button led3;
        public Button led4;
        public Button led5;
        public Button led6;
        private ComboBox cBoxLists;
        private Label lblSelectList;
        private Button btnStartList;
        private Button btnCreateList;
        private TextBox txtBxArtist;
        private Label lblArtist;
        private TextBox txtBxSong;
        private Label lblSong;
        public Button led10;
        public Button led9;
        public Button led8;
        public Button led7;
        public Button led11;
        private Button btnPauseList;
        private Button btnHelpTwo;
        private TextBox txtBxStep;
    }
}

