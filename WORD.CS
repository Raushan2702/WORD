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