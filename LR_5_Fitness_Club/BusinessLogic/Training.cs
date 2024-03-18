using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class Training
    {
        /// <summary>
        /// Переменная для нумерации
        /// </summary>
        private readonly int _k;

        /// <summary>
        /// Типы тренировок и их цели
        /// </summary>
        public Dictionary<string, string> MainGoals = new Dictionary<string, string>();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="tOt"></param>
        /// <param name="gOt"></param>
        /// <param name="d"></param>
        public Training(string tOt, string[] gOt, string d)
        {
            TypeOfTraining = tOt ?? throw new ArgumentNullException(nameof(tOt));
            GoalsOfTraining = gOt ?? throw new ArgumentNullException(nameof(gOt));
            Description = d ?? throw new ArgumentNullException(nameof(d));
            for (var i = 0; i < GoalsOfTraining.Length; i++)
            {
                MainGoals.Add(_k.ToString(), GoalsOfTraining[i]);
                _k++;
            }
        }

        /// <summary>
        /// Внутренние переменные
        /// </summary>
        public string TypeOfTraining { get; }
        public string[] GoalsOfTraining { get; }
        public string Description { get; }
    }
}
