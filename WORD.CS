 //Объявляем входные параметры
            int characters = 3; //Допустимое количество символов в строке
            string[] inputStr = new string[] { "Hello world!", "Ms.", "True", "No", "Yes" }; //Исходный массив строк
            string[] outputStr = new string[0]; //Вычисляемый массив (изначально количество элементов массива равно 0)

            Console.WriteLine("Исходный массив:");
            //Перебираем элементы исходного массива
            for (int i = 0; i < inputStr.Length; i++)
            {
                Console.WriteLine(inputStr[i]); //выводим рассматриваемую строку вычисляемого массива
                if (inputStr[i].Length <= characters) //Проверяет строку на условие количества символов
                    outputStr = AddLine(outputStr, inputStr[i]); //Добавляем строку в вычислемый массив
            }
            Console.WriteLine("Полученный массив:");
            //Перебираем элементы вычисляемого массива
            for (int i = 0; i < outputStr.Length; i++)
                Console.WriteLine(outputStr[i]); //выводим рассматриваемую строку вычисляемого массива
        

     static string[] AddLine(string[] data, string line)
        {
            int originalLength = data.Length; //Узнаем размерность полученного массива 
            string[] newData = new string[originalLength + 1]; //Создаем новый массив размерностью на 1 единицу больше полученного
            //Перебираем элементы полученного массива
            for (int i = 0; i < originalLength; i++)
                newData[i] = data[i]; //переносим элементы полученного массива в новый, только что созданный
            newData[originalLength] = line; //Заносим в последнюю строку нового иассива переменную line
            return newData; //Возвращаем новый массив
        }

