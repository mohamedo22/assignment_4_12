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
    /// Interaction logic for Log_in_page.xaml
    /// </summary>
    public partial class Log_in_page : Page
    {
        userEntities userentity = new userEntities();
        public Log_in_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (list_of_users.Text == "user")
            {
                users_table user1 = new users_table();
                bool look = false;
                foreach (users_table users in userentity.users_table)
                {
                    if (users.user_namee == username.Text && users.pass == password.Text)
                    {
                        look = true;
                        user1 = users;
                    }
                }
                if (look)
                {
                    profile_page profile_Page = new profile_page(user1);
                    this.NavigationService.Navigate(profile_Page);
                }
                else
                {
                    MessageBox.Show("Your not user!");
                }
            }
            else if(list_of_users.Text == "admin")
            {
                admin user1 = new admin();
                bool look = false;
                foreach (admin users in userentity.admins)
                {
                    if (users.admin_user_namee == username.Text && users.admin_pass == password.Text)
                    {
                        look = true;
                    }
                }
                if (look)
                {
                    if(list_of_pages_admin.Text == "search")
                    {
                        search_page search_Page = new search_page();
                        this.NavigationService.Navigate(search_Page);
                    }
                    else if(list_of_pages_admin.Text == "delete")
                    {
                        delete_page delete_Page = new delete_page();
                        this.NavigationService.Navigate(delete_Page);
                    }
                    else
                    {
                        MessageBox.Show("Please select what is the page you want to open!");
                    }
                }
                else
                {
                    MessageBox.Show("Your not user!");
                }
            }
            else
            {
                MessageBox.Show("Please choose who are you?");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget_pass_page forget_Pass_Page = new forget_pass_page();
            this.NavigationService.Navigate(forget_Pass_Page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            signup_page signup_Page = new signup_page();
            this.NavigationService.Navigate(signup_Page);
        }
    }
}
