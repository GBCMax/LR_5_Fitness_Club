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
    /// Логика взаимодействия для Help_With_Choice_Content_Control.xaml
    /// </summary>
    public partial class Help_With_Choice_Content_Control : UserControl
    {
        FitnessClub _fitness_Club1 = new FitnessClub();
        TrainingSupport _trainingSupport= new TrainingSupport();
        public Help_With_Choice_Content_Control(FitnessClub fitnessClub, MainGoals _mainGoals, TrainingSupport trainingSupport)
        {
            InitializeComponent();
            _fitness_Club1 = fitnessClub;
            Support_TextBox.Text += "Выберите цель:\n\r";
            foreach (var v in _mainGoals.MainGoalsDictionary) Support_TextBox.Text += v.Key + " - " + v.Value + "\n\r";
            Support_TextBox.Text += "Чего вы желаете добиться от тренировок?\n\r";
            Support_TextBox.Text += "Введите нужное:\n\r";
            _trainingSupport= trainingSupport;
        }

        private void Find_Trainings_Button_Click(object sender, RoutedEventArgs e)
        {
            var helpchoice = Goals_TextBox.Text;
            var res = _trainingSupport.HelpWithChoice(_fitness_Club1, helpchoice);
            if (res != "")
            {
                MessageBox.Show("По вашему запросу найдено следующее:\n\r" + res);
            }
            else
            {
                MessageBox.Show("Не найдено!");
            }
        }
    }
}
