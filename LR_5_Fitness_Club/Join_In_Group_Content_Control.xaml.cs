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
    /// Логика взаимодействия для Join_In_Group_Content_Control.xaml
    /// </summary>
    public partial class Join_In_Group_Content_Control : UserControl
    {
        FitnessClub _fitnessClub1 = new FitnessClub();
        public Join_In_Group_Content_Control(string Info, FitnessClub _fitnessClub)
        {
            InitializeComponent();
            List_Of_Groups_Textbox.Text = Info;
            _fitnessClub1 = _fitnessClub;
        }

        private void Join_In_Group_Button_Click(object sender, RoutedEventArgs e)
        {
            var choice = Choice_Group_ComboBox.SelectedIndex + 1;
            var secondname = Second_Name_TextBox.Text;
            var name = First_Name_TextBox.Text;
            string age = Age_TextBox.Text;

            MessageBox.Show(_fitnessClub1.Groups[int.Parse(Choice_Group_ComboBox.SelectedIndex.ToString())].AddPerson(new Person(secondname, name, age)));
        }

        private void Age_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(Convert.ToChar(e.Text))) return;
            else
                e.Handled = true;
        }

        private void Second_Name_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(Convert.ToChar(e.Text)) && !Char.IsSymbol(Convert.ToChar(e.Text))) return;
            else
                e.Handled = true;
        }

        private void First_Name_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(Convert.ToChar(e.Text)) && !Char.IsSymbol(Convert.ToChar(e.Text))) return;
            else
                e.Handled = true;
        }
    }
}
