namespace Task_Additional_Notebok
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Создайте структуру с именем - Notebook. 
            // Поля структуры: модель, производитель, цена.
            // В структуре должен быть реализован конструктор для инициализации полей и метод для вывода 
            // содержимого полей на экран.
            #endregion


            // Instance the structure Notebook.
            Notebook notebook = new Notebook("P70", "Lenovo", 1399.0m);

            // Call method of the structure.
            notebook.Show();

            //Delay.
            Console.ReadLine();
        }
    }
}

