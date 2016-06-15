using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog myDialog = new Microsoft.Win32.SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                
            }
            int temp=0;
            for(index=1;index<=itemCount-1;index++)
            if (Convert.ToInt32(myAL[index]) < Convert.ToInt32(myAL[index - 1])&&(Convert.ToInt32(myAL[index]) < Convert.ToInt32(myAL[index + 1])))temp+=1 ;
            lbMain.Items.Add(temp);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);

            }
            int temp = 0;
            for (index = 0; index <= itemCount; index++)
                if (Convert.ToInt32(myAL[index]) < 25) { lbMain.Items.Add(index); break; } 
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);

            }
            int temp = 0;
            for (index = 0; index <= itemCount; index++)
                if (Convert.ToInt32(myAL[index]) > Convert.ToInt32(myAL[1])) temp += Convert.ToInt32(myAL[index]); lbMain.Items.Add(temp);
        }
    }
}
