using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171206Win_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //RichTextBox-un içərisini silmək üçün
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); 
            open.Filter = "Text faylları|*.txt";   //yalnız text fayllarını seçə bilmək üçün
            if (open.ShowDialog()==DialogResult.OK) //Fayl oxu dialoqunda OK klik olunarsa
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText); // seçilmiş text faylını richTextBox-a əlavə edir
                this.Text = "Opened: " + open.FileName; // Formun başlığındakı mətni dəyişmək üçün
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text faylları|*.txt";  //yalnız text faylında yaddaşda saxlamaq üçün
            if (save.ShowDialog() == DialogResult.OK) //SaveFile dialoqunda OK klik olunarsa
            {
                richTextBox1.SaveFile(save.FileName,RichTextBoxStreamType.PlainText); // seçilmiş text faylını yaddaşda saxlamaq üçün
                this.Text = "Saved: " + save.FileName; // Formun başlığındakı mətni dəyişmək üçün
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Proqramdan çıxır
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo(); // Undo(geri qayıtma) metodu
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo(); // Redo(undo-nun əksi) metodu
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); // Mətndə cut metodu
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); // Mətndə copy metodu
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); // Mətndə paste metodu
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();  
            font.Font = richTextBox1.Font;  // Açılacaq font dialoqunda mətnin fontunun seçilmiş olması üçün 
            if (font.ShowDialog() == DialogResult.OK) //Font dialoqunda OK klik olunarsa
            {
                richTextBox1.Font = font.Font; //Mətnin fontunun seçilmiş fonta dəyişmək
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog()==DialogResult.OK) //Rəng dialoqunda OK klik olunarsa
            {
                richTextBox1.ForeColor = color.Color; //Mətnin rənginin seçilmiş rəngə dəyişmək
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1(); //AboutBox formun obyektini yaratmaq
            about.ShowDialog(); //AboutBox formunun obyektinin göstərilməsi
        }
    }
}
