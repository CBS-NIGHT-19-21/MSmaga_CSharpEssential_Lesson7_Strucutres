namespace Task2_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта 
            //назначения, номер поезда, время отправления. 
            //Написать программу, выполняющую следующие действия:
            //-ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть 
            //упорядочены по номерам поездов);
            //-вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
            //вывести соответствующее сообщение).
            #endregion

            /// <summary>
            /// Sorts structure instances as elements of the array by serial number of its train.
            /// </summary>
            static void Sort(Train[] trainList)
            {
                bool changes = false;
                do
                {

                    for (int i = 0; i < trainList.Length - 1; i++)
                    {
                        if (trainList[i].Number > trainList[i + 1].Number)
                        {
                            Train buffer = trainList[i + 1];
                            trainList[i + 1] = trainList[i];
                            trainList[i] = buffer;
                            changes = true;
                        }
                    }
                } while (changes == false);
            }

            /// <summary>
            /// Shows elements of the array.
            /// </summary>
            static void Show(Train[] trainList)
            {
                foreach (Train train in trainList)
                {
                    Console.WriteLine($" Distanation:{train.Destination} \t" +
                                      $" Number: {train.Number}\t" +
                                      $" Departure Time: {train.DepartureTime}\t");
                }

                Console.WriteLine();
            }

            // Declare array of the structures Train.
            Train[] trainList = new Train[8];

            // Instace the structures.
            trainList[0] = new Train("Kyiv", 32145, "06 July 2021 7:32:47 AM");
            trainList[1] = new Train("Lviv", 19198, "12 Dec 2021 5:52:17 AM");
            trainList[2] = new Train("Summy", 77668, "09 Dec 2021 11:12:00 AM");
            trainList[3] = new Train("Kharkiv", 65135, "26 July 2021 7:32:47 AM");
            trainList[4] = new Train("Odesa", 24248, "22 Dec 2021 5:52:17 AM");
            trainList[5] = new Train("Dnipro", 71362, "19 Sep 2021 11:12:00 AM");
            trainList[6] = new Train("Donetsk", 34435, "16 July 2021 7:32:47 AM");
            trainList[7] = new Train("Sevast", 88908, "11 Oct 2021 5:52:17 AM");


            Show(trainList);

            Sort(trainList);

            Show(trainList);

            Console.ReadLine();
        }
    }
}

