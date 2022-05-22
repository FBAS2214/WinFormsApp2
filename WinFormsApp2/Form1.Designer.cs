namespace WinFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove_label = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cBox_CSharp = new System.Windows.Forms.CheckBox();
            this.cBox_Java = new System.Windows.Forms.CheckBox();
            this.cBox_Cplusplus = new System.Windows.Forms.CheckBox();
            this.cBox_Php = new System.Windows.Forms.CheckBox();
            this.gBox_languages = new System.Windows.Forms.GroupBox();
            this.btn_languages = new System.Windows.Forms.Button();
            this.gBox_Cards = new System.Windows.Forms.GroupBox();
            this.rBtn_PayPal = new System.Windows.Forms.RadioButton();
            this.rBtn_MasterCard = new System.Windows.Forms.RadioButton();
            this.rBtn_Visa = new System.Windows.Forms.RadioButton();
            this.btn_cardTypes = new System.Windows.Forms.Button();
            this.gBox_SelectedLang = new System.Windows.Forms.GroupBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gBox_languages.SuspendLayout();
            this.gBox_Cards.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Label";
            // 
            // btn_remove_label
            // 
            this.btn_remove_label.Location = new System.Drawing.Point(22, 17);
            this.btn_remove_label.Margin = new System.Windows.Forms.Padding(6);
            this.btn_remove_label.Name = "btn_remove_label";
            this.btn_remove_label.Size = new System.Drawing.Size(139, 44);
            this.btn_remove_label.TabIndex = 16;
            this.btn_remove_label.Text = "Remove Label";
            this.btn_remove_label.UseVisualStyleBackColor = true;
            this.btn_remove_label.Click += new System.EventHandler(this.btn_remove_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(878, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Password";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(334, 36);
            this.textBox1.TabIndex = 17;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "😂";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(1073, 57);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(139, 44);
            this.btn_Submit.TabIndex = 18;
            this.btn_Submit.TabStop = false;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(796, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 169);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(983, 300);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(73, 44);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_textboxCommands_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(1060, 300);
            this.btn_cut.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(69, 44);
            this.btn_cut.TabIndex = 3;
            this.btn_cut.Text = "Cut";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_textboxCommands_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Location = new System.Drawing.Point(1133, 300);
            this.btn_paste.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(82, 44);
            this.btn_paste.TabIndex = 4;
            this.btn_paste.Text = "Paste";
            this.btn_paste.UseVisualStyleBackColor = true;
            this.btn_paste.Click += new System.EventHandler(this.btn_textboxCommands_Click);
            // 
            // btn_redo
            // 
            this.btn_redo.Location = new System.Drawing.Point(877, 300);
            this.btn_redo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(81, 44);
            this.btn_redo.TabIndex = 1;
            this.btn_redo.Text = "Redo";
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_textboxCommands_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(796, 300);
            this.btn_undo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(78, 44);
            this.btn_undo.TabIndex = 0;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_textboxCommands_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(745, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 36);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(718, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 36);
            this.textBox3.TabIndex = 20;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(300, 22);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 36);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // cBox_CSharp
            // 
            this.cBox_CSharp.AutoSize = true;
            this.cBox_CSharp.Location = new System.Drawing.Point(20, 67);
            this.cBox_CSharp.Name = "cBox_CSharp";
            this.cBox_CSharp.Size = new System.Drawing.Size(63, 33);
            this.cBox_CSharp.TabIndex = 22;
            this.cBox_CSharp.Text = "C#";
            this.cBox_CSharp.UseVisualStyleBackColor = true;
            // 
            // cBox_Java
            // 
            this.cBox_Java.AutoSize = true;
            this.cBox_Java.Location = new System.Drawing.Point(20, 106);
            this.cBox_Java.Name = "cBox_Java";
            this.cBox_Java.Size = new System.Drawing.Size(80, 33);
            this.cBox_Java.TabIndex = 23;
            this.cBox_Java.Text = "Java";
            this.cBox_Java.UseVisualStyleBackColor = true;
            // 
            // cBox_Cplusplus
            // 
            this.cBox_Cplusplus.AutoSize = true;
            this.cBox_Cplusplus.Location = new System.Drawing.Point(20, 145);
            this.cBox_Cplusplus.Name = "cBox_Cplusplus";
            this.cBox_Cplusplus.Size = new System.Drawing.Size(80, 33);
            this.cBox_Cplusplus.TabIndex = 24;
            this.cBox_Cplusplus.Text = "C++";
            this.cBox_Cplusplus.UseVisualStyleBackColor = true;
            // 
            // cBox_Php
            // 
            this.cBox_Php.AutoSize = true;
            this.cBox_Php.Location = new System.Drawing.Point(20, 186);
            this.cBox_Php.Name = "cBox_Php";
            this.cBox_Php.Size = new System.Drawing.Size(74, 33);
            this.cBox_Php.TabIndex = 25;
            this.cBox_Php.Text = "PHP";
            this.cBox_Php.UseVisualStyleBackColor = true;
            // 
            // gBox_languages
            // 
            this.gBox_languages.Controls.Add(this.cBox_Cplusplus);
            this.gBox_languages.Controls.Add(this.cBox_Php);
            this.gBox_languages.Controls.Add(this.cBox_CSharp);
            this.gBox_languages.Controls.Add(this.cBox_Java);
            this.gBox_languages.Location = new System.Drawing.Point(39, 191);
            this.gBox_languages.Name = "gBox_languages";
            this.gBox_languages.Size = new System.Drawing.Size(185, 253);
            this.gBox_languages.TabIndex = 26;
            this.gBox_languages.TabStop = false;
            this.gBox_languages.Text = "Languages";
            // 
            // btn_languages
            // 
            this.btn_languages.Location = new System.Drawing.Point(39, 469);
            this.btn_languages.Margin = new System.Windows.Forms.Padding(6);
            this.btn_languages.Name = "btn_languages";
            this.btn_languages.Size = new System.Drawing.Size(94, 44);
            this.btn_languages.TabIndex = 27;
            this.btn_languages.TabStop = false;
            this.btn_languages.Text = "Submit";
            this.btn_languages.UseVisualStyleBackColor = true;
            this.btn_languages.Click += new System.EventHandler(this.btn_languages_Click);
            // 
            // gBox_Cards
            // 
            this.gBox_Cards.Controls.Add(this.rBtn_PayPal);
            this.gBox_Cards.Controls.Add(this.rBtn_MasterCard);
            this.gBox_Cards.Controls.Add(this.rBtn_Visa);
            this.gBox_Cards.Location = new System.Drawing.Point(1027, 444);
            this.gBox_Cards.Name = "gBox_Cards";
            this.gBox_Cards.Size = new System.Drawing.Size(185, 197);
            this.gBox_Cards.TabIndex = 28;
            this.gBox_Cards.TabStop = false;
            this.gBox_Cards.Text = "Card types";
            // 
            // rBtn_PayPal
            // 
            this.rBtn_PayPal.AutoSize = true;
            this.rBtn_PayPal.Location = new System.Drawing.Point(26, 134);
            this.rBtn_PayPal.Name = "rBtn_PayPal";
            this.rBtn_PayPal.Size = new System.Drawing.Size(100, 33);
            this.rBtn_PayPal.TabIndex = 32;
            this.rBtn_PayPal.TabStop = true;
            this.rBtn_PayPal.Text = "PayPal";
            this.rBtn_PayPal.UseVisualStyleBackColor = true;
            // 
            // rBtn_MasterCard
            // 
            this.rBtn_MasterCard.AutoSize = true;
            this.rBtn_MasterCard.Location = new System.Drawing.Point(26, 95);
            this.rBtn_MasterCard.Name = "rBtn_MasterCard";
            this.rBtn_MasterCard.Size = new System.Drawing.Size(153, 33);
            this.rBtn_MasterCard.TabIndex = 31;
            this.rBtn_MasterCard.TabStop = true;
            this.rBtn_MasterCard.Text = "MasterCard";
            this.rBtn_MasterCard.UseVisualStyleBackColor = true;
            // 
            // rBtn_Visa
            // 
            this.rBtn_Visa.AutoSize = true;
            this.rBtn_Visa.Location = new System.Drawing.Point(26, 56);
            this.rBtn_Visa.Name = "rBtn_Visa";
            this.rBtn_Visa.Size = new System.Drawing.Size(74, 33);
            this.rBtn_Visa.TabIndex = 30;
            this.rBtn_Visa.TabStop = true;
            this.rBtn_Visa.Text = "Visa";
            this.rBtn_Visa.UseVisualStyleBackColor = true;
            // 
            // btn_cardTypes
            // 
            this.btn_cardTypes.Location = new System.Drawing.Point(1060, 650);
            this.btn_cardTypes.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cardTypes.Name = "btn_cardTypes";
            this.btn_cardTypes.Size = new System.Drawing.Size(139, 44);
            this.btn_cardTypes.TabIndex = 29;
            this.btn_cardTypes.TabStop = false;
            this.btn_cardTypes.Text = "Submit";
            this.btn_cardTypes.UseVisualStyleBackColor = true;
            this.btn_cardTypes.Click += new System.EventHandler(this.btn_cardTypes_Click);
            // 
            // gBox_SelectedLang
            // 
            this.gBox_SelectedLang.Location = new System.Drawing.Point(336, 191);
            this.gBox_SelectedLang.Name = "gBox_SelectedLang";
            this.gBox_SelectedLang.Size = new System.Drawing.Size(185, 253);
            this.gBox_SelectedLang.TabIndex = 27;
            this.gBox_SelectedLang.TabStop = false;
            this.gBox_SelectedLang.Text = "Languages";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(233, 300);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(94, 44);
            this.btn_Next.TabIndex = 30;
            this.btn_Next.TabStop = false;
            this.btn_Next.Text = "=>";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 564);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(468, 36);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.gBox_SelectedLang);
            this.Controls.Add(this.btn_cardTypes);
            this.Controls.Add(this.gBox_Cards);
            this.Controls.Add(this.btn_languages);
            this.Controls.Add(this.gBox_languages);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_redo);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remove_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox_languages.ResumeLayout(false);
            this.gBox_languages.PerformLayout();
            this.gBox_Cards.ResumeLayout(false);
            this.gBox_Cards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_remove_label;
        private TextBox textBox1;
        private Button btn_Submit;
        private RichTextBox richTextBox1;
        private Button btn_copy;
        private Button btn_cut;
        private Button btn_paste;
        private Button btn_redo;
        private Button btn_undo;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private CheckBox cBox_CSharp;
        private CheckBox cBox_Java;
        private CheckBox cBox_Cplusplus;
        private CheckBox cBox_Php;
        private GroupBox gBox_languages;
        private Button btn_languages;
        private GroupBox gBox_Cards;
        private Button btn_cardTypes;
        private RadioButton rBtn_PayPal;
        private RadioButton rBtn_MasterCard;
        private RadioButton rBtn_Visa;
        private GroupBox gBox_SelectedLang;
        private Button btn_Next;
        private DateTimePicker dateTimePicker1;
    }
}