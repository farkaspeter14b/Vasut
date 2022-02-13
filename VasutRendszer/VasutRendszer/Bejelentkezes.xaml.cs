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
using System.Windows.Shapes;
using System.IO;
using VasutRendszer.Classes;

namespace VasutRendszer
{
    /// <summary>
    /// Interaction logic for Bejelentkezve.xaml
    /// </summary>
    public partial class Bejelentkezve : Window
    {
        public Bejelentkezve()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            string username = textBoxNameNew.Text.Trim();
            string password = textBoxPassWNew.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                UserHelper help = new UserHelper();
                if (!help.AddUser(username,password))
                {
                    MessageBox.Show("Hiba", "A felhasználó már létezik");
                }
                else
                {
                    MessageBox.Show("Sikeres volt a regisztráció");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string username = textBoxName.Text;
            string password = textBoxPassW.Text;
            UserHelper help = new UserHelper();
            if (help.SearchUser(username,password) == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Hibás jészó vagy felhasználónév");
            }

        }
    }
}
