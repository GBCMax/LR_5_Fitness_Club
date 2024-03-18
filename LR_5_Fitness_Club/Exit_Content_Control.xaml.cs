using LR_5_Fitness_Club.BusinessLogic;
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
    /// Логика взаимодействия для Exit_Content_Control.xaml
    /// </summary>
    public partial class Exit_Content_Control : UserControl
    {
        public Exit_Content_Control(FitnessClub _fitnessClub1)
        {
            InitializeComponent();
            All_Groups_TextBox.Text += "Список всех групп:\n\r";
            foreach (var g in _fitnessClub1.Groups)
            {
                All_Groups_TextBox.Text += g.GroupName + "\n\r";
                for (var i = 0; i < g.People.Count; i++)
                    All_Groups_TextBox.Text += "Фамилия: " + g.People[i].SecondName + " Имя: " + g.People[i].Name +
                                      " Возраст: " + g.People[i].Age + "\n\r";
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
