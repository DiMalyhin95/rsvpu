using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Program
    {
        static void Main(string[] args)
        {
/*1*/       string d = Console.ReadLine(); ;                                                               //Ввод данных
/*2*/       int result = Obrabotchik(d);                                                        //Запуск промграммы
/*3*/       Console.WriteLine(result);
/*4*/       Console.ReadKey();
        }

        public static int Obrabotchik(string d)
        {
/*5*/       string s = d.ToLower();                                                             //Конвертирование текста
/*6*/       int result = 0;                                                                     //Инициальзация счётной переменной
/*7*/       for (int i = 0; i < s.Length; i++)                                                  //начало цикла, условие i < s.Length
            {
/*8*/           if (s[i] == 'а' || s[i] == 'о' || s[i] == 'у' || s[i] == 'е' || s[i] == 'ё' ||  //начало условия  
                    s[i] == 'ы' || s[i] == 'э' || s[i] == 'я' || s[i] == 'и' || s[i] == 'ю')
                {
/*9*/               result += 1;                                                                //вывод результата условися
/*10*/          }                                                                               //конец условия 
/*11*/          if (s[i] == '!')                                                                //начало условия s[i] = '!'
                {
/*12*/              break;                                                                      //Вывод результата условия
/*13*/          }                                                                               //Конец условия
/*14*/      }                                                                                   //Конец цикла
/*15*/      return result;                                                                      //вывод результатов
        }

    }
}
