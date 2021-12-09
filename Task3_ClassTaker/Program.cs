namespace Task3_ClassTaker
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            //Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
            //В классе Program создайте два метода: 
            //- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра 
            //myClass значение «изменено». 
            //- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра 
            //myStruct значение «изменено». 
            //Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
            //структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы 
            //ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте 
            //полученные результаты.
            #endregion


            static void ClassTaker(MyClass myClass)
            {
                myClass._change = "The myClass value has been changed";
                Console.WriteLine(myClass._change);
            }


            static void StructTaker(MyStruct myStruct)
            {
                myStruct._change = "The myStruct value has been changed";
                Console.WriteLine(myStruct._change);
            }

            MyClass myClass = new MyClass();

            ClassTaker(myClass);


            MyStruct myStruct = new MyStruct();

            StructTaker(myStruct);


            Console.ReadLine();
        }
    }
}

