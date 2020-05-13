using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReflexOffic.App.Models;
using ReflexOffice.Shared.Models;

namespace ReflexOffice.ClientApp.View
{
    /// <summary>
    /// Interaction logic for ItemOverView.xaml
    /// </summary>
    public partial class ItemOverView : Page
    {
        private const int MAX_SQL_RECORD = 100;
        public List<Visitor> Employees { get; set; } = new List<Visitor>();
        VisitorData dbVisitor = new VisitorData();

        private const int STAGE_START = 1;
        private const int STAGE_LIST = 2;
        private const int STAGE_EDIT = 3;

        public ItemOverView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Grid_Visitor.Items.Clear();
            List<Visitor> List = dbVisitor.GetAll(MAX_SQL_RECORD);
            foreach (var item in List)
            {
                Grid_Visitor.Items.Add(item);
            }
            tabListItem.IsSelected = true;
            tabListItem.Visibility = Visibility.Hidden;
            tabEdit.Visibility = Visibility.Hidden;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSave_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Grid_Visitor_OnPreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnNewItemClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBoxTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
