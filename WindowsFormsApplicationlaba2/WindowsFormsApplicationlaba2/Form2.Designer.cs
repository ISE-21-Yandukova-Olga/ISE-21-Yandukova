using System;
using System.Windows.Forms;

namespace WindowsFormsApplicationlaba2
{
    partial class Form2
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
            this.groupBoxStone = new System.Windows.Forms.GroupBox();
            this.buttonTarantul = new System.Windows.Forms.Button();
            this.buttonSpiderswolf = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAnnulment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDopColor = new System.Windows.Forms.Button();
            this.buttonBaseColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGrey = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.groupBoxStone.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStone
            // 
            this.groupBoxStone.Controls.Add(this.buttonTarantul);
            this.groupBoxStone.Controls.Add(this.buttonSpiderswolf);
            this.groupBoxStone.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStone.Name = "groupBoxStone";
            this.groupBoxStone.Size = new System.Drawing.Size(160, 159);
            this.groupBoxStone.TabIndex = 1;
            this.groupBoxStone.TabStop = false;
            this.groupBoxStone.Text = "Тип ";
            // 
            // buttonTarantul
            // 
            this.buttonTarantul.AllowDrop = true;
            this.buttonTarantul.Location = new System.Drawing.Point(21, 87);
            this.buttonTarantul.Name = "buttonTarantul";
            this.buttonTarantul.Size = new System.Drawing.Size(102, 41);
            this.buttonTarantul.TabIndex = 1;
            this.buttonTarantul.Text = "Tarantul";
            this.buttonTarantul.UseVisualStyleBackColor = true;
            this.buttonTarantul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTarantul_MouseDown);
            // 
            // buttonSpiderswolf
            // 
            this.buttonSpiderswolf.AllowDrop = true;
            this.buttonSpiderswolf.Location = new System.Drawing.Point(21, 29);
            this.buttonSpiderswolf.Name = "buttonSpiderswolf";
            this.buttonSpiderswolf.Size = new System.Drawing.Size(102, 41);
            this.buttonSpiderswolf.TabIndex = 0;
            this.buttonSpiderswolf.Text = "Spiderswolf";
            this.buttonSpiderswolf.UseVisualStyleBackColor = true;
            this.buttonSpiderswolf.Click += new System.EventHandler(this.pictureBox1_Click);
            this.buttonSpiderswolf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSpiderswolf_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(72, 22);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAnnulment
            // 
            this.buttonAnnulment.Location = new System.Drawing.Point(12, 275);
            this.buttonAnnulment.Name = "buttonAnnulment";
            this.buttonAnnulment.Size = new System.Drawing.Size(72, 21);
            this.buttonAnnulment.TabIndex = 3;
            this.buttonAnnulment.Text = "Отмена";
            this.buttonAnnulment.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonDopColor);
            this.panel1.Controls.Add(this.buttonBaseColor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(298, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 292);
            this.panel1.TabIndex = 4;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // buttonDopColor
            // 
            this.buttonDopColor.AllowDrop = true;
            this.buttonDopColor.Location = new System.Drawing.Point(44, 229);
            this.buttonDopColor.Name = "buttonDopColor";
            this.buttonDopColor.Size = new System.Drawing.Size(162, 41);
            this.buttonDopColor.TabIndex = 2;
            this.buttonDopColor.Text = "Доп цвет";
            this.buttonDopColor.UseVisualStyleBackColor = true;
            this.buttonDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.buttonDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonBaseColor
            // 
            this.buttonBaseColor.AllowDrop = true;
            this.buttonBaseColor.Location = new System.Drawing.Point(42, 172);
            this.buttonBaseColor.Name = "buttonBaseColor";
            this.buttonBaseColor.Size = new System.Drawing.Size(165, 39);
            this.buttonBaseColor.TabIndex = 1;
            this.buttonBaseColor.Text = "Основной цвет";
            this.buttonBaseColor.UseVisualStyleBackColor = true;
            this.buttonBaseColor.Click += new System.EventHandler(this.buttonBaseColor_Click_1);
            this.buttonBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.buttonBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelColorBlue);
            this.panelColor.Controls.Add(this.panelColorGrey);
            this.panelColor.Controls.Add(this.panelColorRed);
            this.panelColor.Controls.Add(this.panelColorYellow);
            this.panelColor.Controls.Add(this.panelColorWhite);
            this.panelColor.Controls.Add(this.panelColorBlack);
            this.panelColor.Location = new System.Drawing.Point(619, 16);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(182, 290);
            this.panelColor.TabIndex = 5;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.AllowDrop = true;
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlue.Location = new System.Drawing.Point(108, 181);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(45, 55);
            this.panelColorBlue.TabIndex = 5;
            // 
            // panelColorGrey
            // 
            this.panelColorGrey.AllowDrop = true;
            this.panelColorGrey.BackColor = System.Drawing.Color.Gray;
            this.panelColorGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGrey.Location = new System.Drawing.Point(16, 181);
            this.panelColorGrey.Name = "panelColorGrey";
            this.panelColorGrey.Size = new System.Drawing.Size(45, 55);
            this.panelColorGrey.TabIndex = 4;
            // 
            // panelColorRed
            // 
            this.panelColorRed.AllowDrop = true;
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorRed.Location = new System.Drawing.Point(108, 99);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(45, 55);
            this.panelColorRed.TabIndex = 3;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.AllowDrop = true;
            this.panelColorYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorYellow.Location = new System.Drawing.Point(16, 99);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(45, 55);
            this.panelColorYellow.TabIndex = 2;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.AllowDrop = true;
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorWhite.Location = new System.Drawing.Point(108, 18);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(45, 55);
            this.panelColorWhite.TabIndex = 1;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.AllowDrop = true;
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlack.Location = new System.Drawing.Point(16, 18);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(45, 55);
            this.panelColorBlack.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 413);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAnnulment);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxStone);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxStone.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void buttonSpiderswolf_MouseDown(object sender, MouseEventArgs e)
        {

        }

        #endregion

        private GroupBox groupBoxStone;
        private Button buttonTarantul;
        private Button buttonSpiderswolf;
        private Button buttonAdd;
        private Button buttonAnnulment;
        private Panel panel1;
        private Button buttonDopColor;
        private Button buttonBaseColor;
        private PictureBox pictureBox1;
        private Panel panelColor;
        private Panel panelColorBlue;
        private Panel panelColorGrey;
        private Panel panelColorRed;
        private Panel panelColorYellow;
        private Panel panelColorWhite;
        private Panel panelColorBlack;
    }
}