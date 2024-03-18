using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace LR_5_Fitness_Club.BusinessLogic
{
    public class Person
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sN"></param>
        /// <param name="n"></param>
        /// <param name="a"></param>
        public Person(string sN, string n, string a)
        {
            try 
            {
                if (String.IsNullOrEmpty(sN)) MessageBox.Show("Вы не ввели фамилию!");
                if (String.IsNullOrEmpty(n)) MessageBox.Show("Вы не ввели имя!");
                if (String.IsNullOrEmpty(a)) MessageBox.Show("Вы не ввели возраст!");
                SecondName = sN;
                Name = n;
                Age = a;
            }
            catch
            {

            } 
        }

        /// <summary>
        /// Внутренние переменные
        /// </summary>
        public string Name { get; }
        public string SecondName { get; }
        public string Age { get; }
    }
}
