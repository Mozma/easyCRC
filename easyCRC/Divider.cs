using System;

namespace EasyCRC
{
    static class Divider{
        // Метод получения остатка. Возвращает бинарную строку.
        public static string getReminder(this string firstPolynom, string secondPolynom)
        {
            // Проверка полей ввода.
            if (firstPolynom.Equals("") || secondPolynom.Equals("")) {
                throw new Exception("Поля не заполнены.");
            }

            // Получение строк с удалением ведущих нулей.
            firstPolynom = firstPolynom.TrimStart(new char[] { '0' });
            secondPolynom = secondPolynom.TrimStart(new char[] { '0' });



            // Проверка длины.
            if (firstPolynom.Length < secondPolynom.Length)
            {
                throw new ArithmeticException("Делитель больше делимого!");
            }
            // Вычисление остатка.
            string result = firstPolynom;
            while (result.Length >= secondPolynom.Length)
            {
                result = result.getXOR(secondPolynom);
            }

            return result;
        }
        // Метод возвращает результат посимвольного сравнения двух строк.
        static string getXOR(this string a, string b)
        {
            string res = "";
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i] == b[i])
                {
                    res += "0";
                }
                else
                {
                    res += "1";
                }
            }

            res += a.Substring(b.Length);

            return res.TrimStart(new char[] { '0' });
        }

    }
}
