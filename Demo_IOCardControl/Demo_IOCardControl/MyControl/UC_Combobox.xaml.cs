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

namespace Demo_IOCardControl.MyControl
{

    //public class Category
    //{
    //    public string Name { get; set; }
    //    public string[] List { get; set; }
    //}
    /// <summary>
    /// UC_Listbox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UC_Combobox : UserControl
    {
        //private Category categoryData;
        //public Category CategoryData
        //{
        //    get
        //    {
        //        return categoryData;
        //    }

        //    set
        //    {
        //        categoryData = value;

        //        label_CategoryName.Content = categoryData.Name;

        //        if (categoryData.List != null)
        //        {
        //            if(categoryData.List.Count() > 0)
        //            {
        //                foreach (string itemsName in categoryData.List)
        //                {
        //                    ComboBox_Category.Items.Add(itemsName);
        //                }
        //            }
        //            else
        //            {
        //                ComboBox_Category.Items.Add("Nothing");
        //            }
        //        }
                
                
        //    }
        //}


        public UC_Combobox()
        {
            InitializeComponent();
        }
    }
}
