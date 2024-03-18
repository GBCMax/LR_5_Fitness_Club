using LR_5_Fitness_Club.BusinessLogic;
using LR_5_Fitness_Club.Repository;
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

namespace LR_5_Fitness_Club
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FitnessClub _fitnessClub1 = Repository.FitnessClubRepository.GetGroups();
        private readonly MainGoals _mainGoals = new MainGoals();
        private readonly TrainingSupport _trainingSupport = new TrainingSupport();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ContentControl Exit_Window = new Exit_Content_Control(_fitnessClub1);
            Tab_For_Item.Content = Exit_Window;
        }

        private void Help_With_Choice_Click(object sender, RoutedEventArgs e)
        {
            AddGoals();
            ContentControl Help_With_choice_Wnidow = new Help_With_Choice_Content_Control(_fitnessClub1, _mainGoals, _trainingSupport);
            Tab_For_Item.Content = Help_With_choice_Wnidow;
        }

        private void Join_In_Group_Click(object sender, RoutedEventArgs e)
        {
            string Info = "";
            Info += "Выберите группу:\n\r";
            Info += "Список групп:\n\r";
            var i = 0;
            foreach (var group in _fitnessClub1.Groups)
            {
                Info += ++i + " - " + group.GroupName;
                Info += Environment.NewLine;
            }
            ContentControl Join_In_Group_Window = new Join_In_Group_Content_Control(Info, _fitnessClub1);
            Tab_For_Item.Content = Join_In_Group_Window;
        }

        private void Information_About_Groups_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            string Info = "";
            foreach (var training in _fitnessClub1.Trainings)
            {
                Info += "Группа №" + ++i + ": Тип тренировки: " + training.TypeOfTraining + "; Описание: " +
                                  training.Description;
                Info += Environment.NewLine;
            }
            ContentControl Inf_About_Group_Window = new Information_About_Group_Content_Control(Info);
            Tab_For_Item.Content = Inf_About_Group_Window;
        }

        /// <summary>
        /// Вызов метода добавления целей тренировок
        /// </summary>
        private void AddGoals()
        {
            _mainGoals.AddGoals(_fitnessClub1.Trainings);
            ContentControl Help_With_Choice = new Help_With_Choice_Content_Control(_fitnessClub1, _mainGoals, _trainingSupport);
            Tab_For_Item.Content = Help_With_Choice;
        }

        /// <summary>
        /// Вывод списка всех групп с участниками
        /// </summary>
        private void WriteAllGroups()
        {
            Console.WriteLine("Список всех групп:");
            foreach (var g in _fitnessClub1.Groups)
            {
                Console.WriteLine(g.GroupName);
                for (var i = 0; i < g.People.Count; i++)
                    Console.WriteLine("Фамилия: " + g.People[i].SecondName + " Имя: " + g.People[i].Name +
                                      " Возраст: " + g.People[i].Age);
            }
        }

        /// <summary>
        /// Оповещение о результате добавления в группу
        /// </summary>
        /// <param name="choiceGroup"></param>
        /// <param name="secondname"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        private void AddInGroup(string choiceGroup, string secondname, string name, string age)
        {
            MessageBox.Show(_fitnessClub1.Groups[int.Parse(choiceGroup) - 1].AddPerson(new Person(secondname, name, age)));
        }

        /// <summary>
        /// Очистка словаря с целями тренировок
        /// </summary>
        private void Clear()
        {
            _mainGoals.MainGoalsDictionary.Clear();
        }
    }
}
