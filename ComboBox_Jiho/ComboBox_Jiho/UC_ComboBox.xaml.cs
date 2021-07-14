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

namespace JihoControl
{

    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UC_ComboBox : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(UC_ComboBox));
        public static readonly DependencyProperty ItemsListProperty = DependencyProperty.Register("ItemsList", typeof(List<ComboBoxItem>), typeof(UC_ComboBox));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public int ItemsList
        {
            get { return (int)GetValue(ItemsListProperty); }
            set { SetValue(ItemsListProperty, value); }
        }   

        public UC_ComboBox()
        {
            InitializeComponent();
        }
    }
}
