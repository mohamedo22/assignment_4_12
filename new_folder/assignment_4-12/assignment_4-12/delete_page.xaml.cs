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

namespace assignment_4_12
{
    /// <summary>
    /// Interaction logic for delete_page.xaml
    /// </summary>
    public partial class delete_page : Page
    {
        userEntities userEntities = new userEntities();
        public delete_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users_table users_ = new users_table();
            users_ = userEntities.users_table.First(x => x.phone_n == txtbox.Text);
            if(users_ != null )
            {
                userEntities.users_table.Remove(users_);
                userEntities.SaveChanges();
                MessageBox.Show("user deleted successfully!");
            }
            else
            {
                MessageBox.Show("no user found!");
            }
        }
    }
}
