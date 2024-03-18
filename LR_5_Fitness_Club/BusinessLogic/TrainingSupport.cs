using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class TrainingSupport
    {
        /// <summary>
        /// Помощь с выбором занятия
        /// </summary>
        /// <param name="_fitnessClub1"></param>
        /// <param name="helpchoice"></param>
        /// <returns></returns>
        public string HelpWithChoice(FitnessClub _fitnessClub1, string helpchoice)
        {
            var result = "";
            var goals = helpchoice.Split(", ");
            foreach (var goal in goals)
                if (_fitnessClub1.Trainings.Where(x => x.GoalsOfTraining.Contains(goal)).Count() > 0)
                {
                    var tr = _fitnessClub1.Trainings.Where(x => x.GoalsOfTraining.Contains(goal)).ToList();
                    foreach (var v in tr)
                        result += "Цель тренировки: " + goal + " Тип тренировки: " + v.TypeOfTraining + "\n";
                }

            return result;
        }
    }
}
