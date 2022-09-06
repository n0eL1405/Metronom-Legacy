
using System.Windows.Forms;

namespace Metronom
{
    partial class CreateListForm
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
            this.txtBxTact = new System.Windows.Forms.TextBox();
            this.lblTact = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblEnterBpm = new System.Windows.Forms.Label();
            this.txtBxBPM = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtBxArtist = new System.Windows.Forms.TextBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtBxSong = new System.Windows.Forms.TextBox();
            this.lblSelectList = new System.Windows.Forms.Label();
            this.cBoxLists = new System.Windows.Forms.ComboBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.currentListEntriesBox = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedEntries = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBxTact
            // 
            this.txtBxTact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTact.Location = new System.Drawing.Point(475, 76);
            this.txtBxTact.Name = "txtBxTact";
            this.txtBxTact.Size = new System.Drawing.Size(93, 27);
            this.txtBxTact.TabIndex = 5;
            // 
            // lblTact
            // 
            this.lblTact.AutoSize = true;
            this.lblTact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTact.Location = new System.Drawing.Point(471, 19);
            this.lblTact.Name = "lblTact";
            this.lblTact.Size = new System.Drawing.Size(97, 44);
            this.lblTact.TabIndex = 29;
            this.lblTact.Text = "Please\nenter Tact:";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(301, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Location = new System.Drawing.Point(483, 121);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 51);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblEnterBpm
            // 
            this.lblEnterBpm.AutoSize = true;
            this.lblEnterBpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBpm.Location = new System.Drawing.Point(297, 19);
            this.lblEnterBpm.Name = "lblEnterBpm";
            this.lblEnterBpm.Size = new System.Drawing.Size(99, 44);
            this.lblEnterBpm.TabIndex = 30;
            this.lblEnterBpm.Text = "Please\nenter BPM:";
            // 
            // txtBxBPM
            // 
            this.txtBxBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxBPM.Location = new System.Drawing.Point(301, 76);
            this.txtBxBPM.Name = "txtBxBPM";
            this.txtBxBPM.Size = new System.Drawing.Size(95, 27);
            this.txtBxBPM.TabIndex = 4;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(8, 19);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(175, 44);
            this.lblEnterName.TabIndex = 36;
            this.lblEnterName.Text = "Please enter a name\nfor the list:";
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(12, 66);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(267, 27);
            this.txtBxName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(392, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(8, 96);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(56, 22);
            this.lblArtist.TabIndex = 38;
            this.lblArtist.Text = "Artist:";
            // 
            // txtBxArtist
            // 
            this.txtBxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxArtist.Location = new System.Drawing.Point(12, 121);
            this.txtBxArtist.Name = "txtBxArtist";
            this.txtBxArtist.Size = new System.Drawing.Size(267, 27);
            this.txtBxArtist.TabIndex = 2;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(8, 151);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(57, 22);
            this.lblSong.TabIndex = 40;
            this.lblSong.Text = "Song:";
            // 
            // txtBxSong
            // 
            this.txtBxSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSong.Location = new System.Drawing.Point(12, 176);
            this.txtBxSong.Name = "txtBxSong";
            this.txtBxSong.Size = new System.Drawing.Size(267, 27);
            this.txtBxSong.TabIndex = 3;
            // 
            // lblSelectList
            // 
            this.lblSelectList.AutoSize = true;
            this.lblSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Location = new System.Drawing.Point(8, 222);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(258, 22);
            this.lblSelectList.TabIndex = 42;
            this.lblSelectList.Text = "Select a list you want to delete:";
            // 
            // cBoxLists
            // 
            this.cBoxLists.FormattingEnabled = true;
            this.cBoxLists.Location = new System.Drawing.Point(10, 247);
            this.cBoxLists.Name = "cBoxLists";
            this.cBoxLists.Size = new System.Drawing.Size(269, 21);
            this.cBoxLists.TabIndex = 41;
            this.cBoxLists.SelectedIndexChanged += new System.EventHandler(this.cBoxListsSelectedIndexChanged);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteList.Location = new System.Drawing.Point(301, 222);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(85, 51);
            this.btnDeleteList.TabIndex = 43;
            this.btnDeleteList.Text = "Delete selected List";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // currentListEntriesBox
            // 
            this.currentListEntriesBox.BackColor = System.Drawing.Color.Silver;
            this.currentListEntriesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentListEntriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentListEntriesBox.FormattingEnabled = true;
            this.currentListEntriesBox.ItemHeight = 25;
            this.currentListEntriesBox.Location = new System.Drawing.Point(574, 18);
            this.currentListEntriesBox.Name = "currentListEntriesBox";
            this.currentListEntriesBox.ScrollAlwaysVisible = true;
            this.currentListEntriesBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.currentListEntriesBox.Size = new System.Drawing.Size(458, 252);
            this.currentListEntriesBox.TabIndex = 44;
            this.currentListEntriesBox.TabStop = false;
            // 
            // btnDeleteSelectedEntries
            // 
            this.btnDeleteSelectedEntries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteSelectedEntries.Location = new System.Drawing.Point(483, 222);
            this.btnDeleteSelectedEntries.Name = "btnDeleteSelectedEntries";
            this.btnDeleteSelectedEntries.Size = new System.Drawing.Size(85, 51);
            this.btnDeleteSelectedEntries.TabIndex = 45;
            this.btnDeleteSelectedEntries.Text = "Delete selected Entries";
            this.toolTip1.SetToolTip(this.btnDeleteSelectedEntries, "COOMING SOON");
            this.btnDeleteSelectedEntries.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // CreateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1044, 287);
            this.Controls.Add(this.btnDeleteSelectedEntries);
            this.Controls.Add(this.currentListEntriesBox);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.lblSelectList);
            this.Controls.Add(this.cBoxLists);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtBxSong);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtBxArtist);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.txtBxTact);
            this.Controls.Add(this.lblTact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblEnterBpm);
            this.Controls.Add(this.txtBxBPM);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CreateListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxTact;
        private System.Windows.Forms.Label lblTact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblEnterBpm;
        private System.Windows.Forms.TextBox txtBxBPM;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtBxArtist;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txtBxSong;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.ComboBox cBoxLists;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.ListBox currentListEntriesBox;
        private Button btnDeleteSelectedEntries;
        private ToolTip toolTip1;
    }
}