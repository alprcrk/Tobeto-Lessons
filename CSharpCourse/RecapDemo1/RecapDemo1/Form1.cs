using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; // Hazır bir classı kullandık
            int top = 0;
            int left = 0;
            //Döngüler
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // Bu kısımda GetUpperBound(0) yaptığı [8, 8] burada 0. boyutun en büyük alabileceği değer 7 dir
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) // Bu şu anlama geliyor i '0' iken j '0' yani 0. buton 0. satırın 0. butonu yani ilk butonumuz sonra j kaç olacak 1 olacak 0. satırın 2. butonu en nihayetinde 7 olacak 0. satırın 8. butonu gibi.
                {
                    //Class özelliklerine erişim  ve Değer atamaları
                    buttons[i, j] = new Button();  // bu her seferinde 0 a 0, 0 a 1, 0 a 2, 0 a 3, 0 a 4, 0 a 5, 6 7 sonra 1 e 0, 1 e 1, 1 e 2, bu şekilde ilerleyecek
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50; // 2. butonu sağa doğru 50 karakterden sonra başlatmamız gerekiyor.
                    buttons[i, j].Left = left; //soldan uzaklığı i ve j nin lefti formun başlangıç değerine göre uzaklığı şu an 0. 
                    buttons[i, j].Top = top;
                    left += 50;
                    //if blokları
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]); //this dediği forma karşılık gelir Form1 buna 

                }
                top += 50; // 2. satıra geçtiğinde bi 50 arttır demek. 
                left = 0; // sıfırlamamız lazım ki 2. satıra geçtiğimizde sola geçsin.

            }
        }
    }
}
