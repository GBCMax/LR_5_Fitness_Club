using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class MainGoals
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainGoals()
        {
            MainGoalsDictionary = new Dictionary<string, string>();
        }

        /// <summary>
        /// Цели тренировок
        /// </summary>
        public Dictionary<string, string> MainGoalsDictionary { get; }

        /// <summary>
        /// Добавление целей тренировок
        /// </summary>
        /// <param name="trainings"></param>
        public void AddGoals(List<Training> trainings)
        {
            if (MainGoalsDictionary.Count == 0)
            {
                var j = 0;
                for (var i = 0; i < trainings.Count; i++)
                    foreach (var v in trainings[i].GoalsOfTraining)
                        if (!MainGoalsDictionary.ContainsValue(v))
                        {
                            MainGoalsDictionary.Add((j + 1).ToString(), v);
                            j++;
                        }
            }
        }
    }
}
