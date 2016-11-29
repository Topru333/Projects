using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        ArrayList Figures = new ArrayList();
        private int A
        {
            get
            {
                try { return int.Parse(Atext.Text); }
                catch(Exception) { return 0; }
            }
        }
        private int B
        {
            get
            {
                try { return int.Parse(Btext.Text); }
                catch(Exception) { return 0; }
            }
        }
        private int C
        {
            get
            {
                try { return int.Parse(Ctext.Text); }
                catch(Exception) { return 0; }
            }
        }
        public Form1(){ InitializeComponent(); }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (A > 0 && B > 0)
            {
                if (C > 0)
                { AddToComboBox(Base.CreateFigure(A, B, C)); }
                else
                { AddToComboBox(Base.CreateFigure(A, B)); }
            }
            else { MessageBox.Show("Wrong sides!"); }
        }
        /// <summary>
        /// Обновление лэйбэлов с инфой
        /// </summary>
        /// <param name="F">Фигура из которой инфа</param>
        private void AddToTextABC(Figure F)
        {
            S.Text = "S:" + F.S.ToString();
            P.Text = "P:" + F.P.ToString();
            try { V.Text = "V:" + F.V.ToString(); }
            catch (Exception) { V.Text = "V:0"; }
        }
        /// <summary>
        /// Добавление новой фигуры в списки
        /// </summary>
        /// <param name="F"></param>
        private void AddToComboBox(Figure F)
        {
            ComboInfo.Items.Add(ComboInfo.Items.Count+1); 
            ComboMore1.Items.Add(ComboMore1.Items.Count + 1);
            ComboMore2.Items.Add(ComboMore2.Items.Count + 1);
            Figures.Add(F);
        }
        private void ComboInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Figure F = (Figure)Figures[int.Parse(ComboInfo.SelectedItem.ToString())-1];
            AddToTextABC(F);
            RectanglePanelSize(F);
        }
        private void RectanglePanelSize(Figure F)
        {
            if (F.C > 0)
            {
                panel2.Height = 0;
                panel2.Width = 0;
            }
            else
            {
                panel2.Height = F.A * 5;
                panel2.Width = F.B * 5;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMore1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMore2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void MoreButton_Click(object sender, EventArgs e)
        {
            Figure F1, F2;
            if (ComboMore1.SelectedItem != null&& ComboMore2.SelectedItem != null)
            {
                 F1 = (Figure)Figures[int.Parse(ComboMore1.SelectedItem.ToString()) - 1];
                 F2 = (Figure)Figures[int.Parse(ComboMore2.SelectedItem.ToString()) - 1];
                 MoreAnswer.Text = F1.MoreThan(F2);
            }
            else
            {
                MoreAnswer.Text = "Error";
            }
        }
        private void Rnumbers_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Atext.Text = rnd.Next(1, 20).ToString();
            Btext.Text = rnd.Next(1, 20).ToString();
            Ctext.Text = rnd.Next(1, 20).ToString();
        }
        private void ABC_Click(object sender, EventArgs e)
        {
            if(ComboInfo.SelectedItem != null)
            {
                Figure F1 = (Figure)Figures[int.Parse(ComboInfo.SelectedItem.ToString()) - 1];
                MessageBox.Show(F1.About());
            }
        }
    }
}
