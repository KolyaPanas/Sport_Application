﻿namespace Sport_Application
{
    partial class IDADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDADD));
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.scannerButton1 = new System.Windows.Forms.RadioButton();
            this.scannerButton2 = new System.Windows.Forms.RadioButton();
            this.idStudentLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.numbStudentLabel = new System.Windows.Forms.Label();
            this.addIDButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.closeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(98, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(327, 24);
            this.label.TabIndex = 1;
            this.label.Text = "Добавить ID студенчего билета";
            // 
            // scannerButton1
            // 
            this.scannerButton1.AutoSize = true;
            this.scannerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton1.Location = new System.Drawing.Point(14, 54);
            this.scannerButton1.Name = "scannerButton1";
            this.scannerButton1.Size = new System.Drawing.Size(128, 28);
            this.scannerButton1.TabIndex = 31;
            this.scannerButton1.TabStop = true;
            this.scannerButton1.Text = "Сканер №1";
            this.scannerButton1.UseVisualStyleBackColor = true;
            this.scannerButton1.Click += new System.EventHandler(this.scannerButton1_Click);
            // 
            // scannerButton2
            // 
            this.scannerButton2.AutoSize = true;
            this.scannerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton2.Location = new System.Drawing.Point(386, 54);
            this.scannerButton2.Name = "scannerButton2";
            this.scannerButton2.Size = new System.Drawing.Size(128, 28);
            this.scannerButton2.TabIndex = 26;
            this.scannerButton2.TabStop = true;
            this.scannerButton2.Text = "Сканер №2";
            this.scannerButton2.UseVisualStyleBackColor = true;
            this.scannerButton2.Click += new System.EventHandler(this.scannerButton2_Click);
            // 
            // idStudentLabel
            // 
            this.idStudentLabel.AutoSize = true;
            this.idStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idStudentLabel.Location = new System.Drawing.Point(136, 85);
            this.idStudentLabel.Name = "idStudentLabel";
            this.idStudentLabel.Size = new System.Drawing.Size(234, 24);
            this.idStudentLabel.TabIndex = 30;
            this.idStudentLabel.Text = "ID студенческого билета";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(117, 112);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(276, 26);
            this.idBox.TabIndex = 27;
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numberBox.Location = new System.Drawing.Point(117, 168);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(276, 26);
            this.numberBox.TabIndex = 23;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // numbStudentLabel
            // 
            this.numbStudentLabel.AutoSize = true;
            this.numbStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbStudentLabel.Location = new System.Drawing.Point(136, 141);
            this.numbStudentLabel.Name = "numbStudentLabel";
            this.numbStudentLabel.Size = new System.Drawing.Size(237, 24);
            this.numbStudentLabel.TabIndex = 20;
            this.numbStudentLabel.Text = "№ студенческого билета";
            // 
            // addIDButton
            // 
            this.addIDButton.Enabled = false;
            this.addIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIDButton.Location = new System.Drawing.Point(170, 200);
            this.addIDButton.Name = "addIDButton";
            this.addIDButton.Size = new System.Drawing.Size(157, 36);
            this.addIDButton.TabIndex = 19;
            this.addIDButton.Text = "Добавить";
            this.addIDButton.UseVisualStyleBackColor = true;
            this.addIDButton.Click += new System.EventHandler(this.addIDButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // closeBox
            // 
            this.closeBox.BackgroundImage = global::Sport_Application.Properties.Resources.cross;
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBox.Location = new System.Drawing.Point(492, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 32;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // IDADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 302);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.scannerButton1);
            this.Controls.Add(this.scannerButton2);
            this.Controls.Add(this.idStudentLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.numbStudentLabel);
            this.Controls.Add(this.addIDButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IDADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDADD";
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton scannerButton1;
        private System.Windows.Forms.RadioButton scannerButton2;
        private System.Windows.Forms.Label idStudentLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label numbStudentLabel;
        private System.Windows.Forms.Button addIDButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox closeBox;
    }
}