﻿namespace AMTS
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.sendNewMessageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.subjectListView = new System.Windows.Forms.ListView();
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sendersListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // sendNewMessageButton
            // 
            this.sendNewMessageButton.Location = new System.Drawing.Point(576, 385);
            this.sendNewMessageButton.Name = "sendNewMessageButton";
            this.sendNewMessageButton.Size = new System.Drawing.Size(504, 65);
            this.sendNewMessageButton.TabIndex = 6;
            this.sendNewMessageButton.Text = "Wyślij nową wiadomość";
            this.sendNewMessageButton.UseVisualStyleBackColor = true;
            this.sendNewMessageButton.Click += new System.EventHandler(this.sendNewMessageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(573, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wiadomość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nadawca";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(576, 31);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(504, 348);
            this.messageTextBox.TabIndex = 2;
            // 
            // subjectListView
            // 
            this.subjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumnHeader,
            this.subjectColumnHeader});
            this.subjectListView.FullRowSelect = true;
            this.subjectListView.Location = new System.Drawing.Point(232, 31);
            this.subjectListView.MultiSelect = false;
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(338, 419);
            this.subjectListView.TabIndex = 1;
            this.subjectListView.UseCompatibleStateImageBehavior = false;
            this.subjectListView.View = System.Windows.Forms.View.Details;
            this.subjectListView.SelectedIndexChanged += new System.EventHandler(this.subjectListView_SelectedIndexChanged);
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Data";
            this.dateColumnHeader.Width = 120;
            // 
            // subjectColumnHeader
            // 
            this.subjectColumnHeader.Text = "Temat";
            // 
            // sendersListView
            // 
            this.sendersListView.Location = new System.Drawing.Point(22, 31);
            this.sendersListView.MultiSelect = false;
            this.sendersListView.Name = "sendersListView";
            this.sendersListView.Size = new System.Drawing.Size(204, 419);
            this.sendersListView.TabIndex = 0;
            this.sendersListView.UseCompatibleStateImageBehavior = false;
            this.sendersListView.View = System.Windows.Forms.View.SmallIcon;
            this.sendersListView.SelectedIndexChanged += new System.EventHandler(this.sendersListView_SelectedIndexChanged);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 462);
            this.Controls.Add(this.sendNewMessageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectListView);
            this.Controls.Add(this.sendersListView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Messages";
            this.Text = "Wiadomości";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Messages_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sendersListView;
        private System.Windows.Forms.ListView subjectListView;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendNewMessageButton;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader subjectColumnHeader;
    }
}