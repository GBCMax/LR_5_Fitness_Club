using LR_5_Fitness_Club.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LR_5_Fitness_Club.Repository
{
    public class FitnessClubRepository
    {
        /// <summary>
        /// Считывание текста с файла
        /// </summary>
        /// <returns></returns>
        public static FitnessClub GetGroups()
        {
            var fitnessClub = new FitnessClub();
            if (File.Exists("groups.txt"))
            {
                var data = new StreamReader("groups.txt");
                while (!data.EndOfStream)
                {
                    var line = data.ReadLine();
                    var tr = line.Split("; ");
                    var goals = tr[1].Split(", ");
                    fitnessClub.AddGroup(new Training(tr[0], goals, tr[2]));
                }
            }

            return fitnessClub;
        }
    }
}
