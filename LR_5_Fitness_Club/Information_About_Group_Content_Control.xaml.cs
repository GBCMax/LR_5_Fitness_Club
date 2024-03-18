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

namespace LR_5_Fitness_Club
{
    /// <summary>
    /// Логика взаимодействия для Information_About_Group_Content_Control.xaml
    /// </summary>
    public partial class Information_About_Group_Content_Control : UserControl
    {
        public Information_About_Group_Content_Control(string Inf)
        {
            InitializeComponent();
            Info.Text = Inf;
        }
    }
}
