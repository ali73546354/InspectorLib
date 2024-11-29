using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private const string InspectionName = "Автоинспекция г. Чита";
        private string ChiefInspector = "Васильев Василий Иванович";
        private readonly List<string> Employees = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        // Метод возвращает ФИО главного инспектора
        public string GetInspector()
        {
            return ChiefInspector;
        }

        // Метод возвращает название автоинспекции
        public string GetCarInspection()
        {
            return InspectionName;
        }

        // Метод изменяет ФИО главного инспектора, только если данное ФИО есть в списке сотрудников
        public bool SetInspector(string fullname)
        {
            if (Employees.Contains(fullname))
            {
                ChiefInspector = fullname;
                return true;
            }
            return false;
        }

        // Метод формирует из принимаемых аргументов госномер
        public string GenerateNumber(string number, string symbol, int code)
        {
            symbol = symbol.ToUpper();
            return $"{symbol}{number}_{code}";
        }

        // Метод возвращает список сотрудников
        public List<string> GetWorker()
        {
            return Employees;
        }

        // Метод добавляет нового сотрудника в список сотрудников
        public void AddWorker(string employee)
        {
            if (!Employees.Contains(employee))
            {
                Employees.Add(employee);
            }
        }
    }
}
