using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class Group
    {
        /// <summary>
        /// Внутренние переменные
        /// </summary>
        private readonly Training _training;
        /// <summary>
        /// Список людей в группе
        /// </summary>
        public List<Person> People { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="training"></param>
        public Group(string name, Training training)
        {
            GroupName = name ?? throw new ArgumentNullException(nameof(name));
            People = new List<Person>();
            _training = training ?? throw new ArgumentNullException(nameof(training));
        }

        /// <summary>
        /// Внутренняя переменная
        /// </summary>
        public string GroupName { get; }

        /// <summary>
        /// Добавление человека в группу
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string AddPerson(Person p)
        {
            if (p.Age == "") return "Вы не проходите возрастное ограничение!";
            else if (byte.Parse(p.Age) < 5 || byte.Parse(p.Age) > 70) return "Вы не проходите возрастное ограничение!";
            else if (People.Count >= 3) return "Группа заполнена!";
            else if ((People.Exists(x => x.SecondName == p.SecondName)) && (People.Exists(x => x.Name == p.Name)) && (People.Exists(x => x.Age == p.Age))) return "Вы уже записаны в эту группу!";
            else
            {
                People.Add(p);
                return "Вы записались в группу!";
            }
        }
    }
}
