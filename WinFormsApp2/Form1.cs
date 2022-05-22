using System.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // CreateLabelWithImage();

            // textBox1.SendToBack();
            // textBox1.BringToFront();



            // Controls.SetChildIndex(textBox1, 3);
            // Controls.SetChildIndex(textBox2, 2);
            // Controls.SetChildIndex(textBox3, 1);
        }

        private void CreateLabelWithImage()
        {
            Label label = new Label();
            Image image = Resources.C__logo;

            label.Image = image;
            label.Size = new Size(image.Width, image.Height);

            // this.Size = new Size(image.Width, image.Height) + new Size(15, 40);

            Controls.Add(label);
        }



        private void btn_remove_label_Click(object sender, EventArgs e)
        {
            Controls.Remove(label1);


            // foreach (var control in Controls)
            // {
            //    if(control is Label lbl)
            //         lbl.Dispose();
            // }
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox1.Text);
            MessageBox.Show(textBox1.SelectedText);

            // textBox1.Focus();
            // Enumerable.Range(0, 10);
        }

        private void btn_textboxCommands_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {


                if (btn.Text.ToLower() == "redo")
                    richTextBox1.Redo();
                else if (btn.Text.ToLower() == "undo")
                    richTextBox1.Undo();
                else if (btn.Text.ToLower() == "copy")
                    richTextBox1.Copy();
                else if (btn.Text.ToLower() == "cut")
                    richTextBox1.Cut();
                else if (btn.Text.ToLower() == "paste")
                    richTextBox1.Paste();



                // btn.Text.ToLower() switch
                // {
                //     "redo" => richTextBox1.Redo(),
                //     "undo" => richTextBox1.Undo(),
                //     "copy" => richTextBox1.Copy(),
                //     "cut" => richTextBox1.Cut(),
                //     "paste" => richTextBox1.Paste(),
                //     _ => MessageBox.Show("Error")
                // }
            }
        }



        private void btn_languages_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(@$"
            // {cBox_CSharp.Text} - {cBox_CSharp.Checked}
            // {cBox_Java.Text} - {cBox_Java.Checked}
            // {cBox_Cplusplus.Text} - {cBox_Cplusplus.Checked}
            // {cBox_Php.Text} - {cBox_Php.Checked}");



            // foreach (var item in gBox_languages.Controls)
            //     if(item is CheckBox cBox)
            //         MessageBox.Show($"{cBox.Text} - {cBox.Checked}");
        }



        private void btn_cardTypes_Click(object sender, EventArgs e)
        {
           foreach (var item in gBox_Cards.Controls)
               if(item is RadioButton rBtn)
                   MessageBox.Show($"{rBtn.Text} - {rBtn.Checked}");
        }



        private void btn_Next_Click(object sender, EventArgs e)
        {
            foreach (var item in gBox_languages.Controls)
                if(item is CheckBox cBox)
                    if(cBox.Checked)
                        gBox_SelectedLang.Controls.Add(cBox);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}