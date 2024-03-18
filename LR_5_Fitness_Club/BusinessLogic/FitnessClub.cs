using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class FitnessClub
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FitnessClub()
        {
            Groups = new List<Group>();
            Trainings = new List<Training>();
        }

        /// <summary>
        /// Группы
        /// </summary>
        public List<Group> Groups { get; }
        /// <summary>
        /// Возможные тренировки
        /// </summary>
        public List<Training> Trainings { get; }
        /// <summary>
        /// Добавление группы
        /// </summary>
        /// <param name="training"></param>
        /// <param name="i"></param>
        public void AddGroup(Training training)
        {
            Trainings.Add(training);
            Groups.Add(new Group("Группа №" + (Groups.Count + 1).ToString() + ": ", Trainings[Groups.Count]));
        }
    }
}
