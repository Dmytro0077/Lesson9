//namespace ClassworkException
//{
//    internal class Classwork
//    {
//        static void Main()
//        {
//            ////Приклад1
//            //int x = 5;
//            //int y = x / 0;
//            //Console.WriteLine($"Результат: {y}");
//            //Console.WriteLine("Кінець програми");


//            ////Приклад2
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("Виникло виключення!");
//            //}
//            //finally
//            //{
//            //    Console.WriteLine("Блок finally");
//            //}
//            //Console.WriteLine("Кінець програми");


//            ////Приклад3
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("Виникло виключення!");
//            //}
//            //Console.WriteLine("Кінець програми");


//            ////Приклад4
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}            
//            //finally
//            //{
//            //    Console.WriteLine("Блок finally");
//            //}
//            //Console.WriteLine("Кінець програми");

//            ////Приклад7
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch (DivideByZeroException)
//            //{
//            //    Console.WriteLine("Виникло виключення DivideByZeroException!");
//            //}


//            ////Приклад8
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch (DivideByZeroException ex)
//            //{
//            //    Console.WriteLine($"Виникло виключення! {ex.Message}");
//            //}


//            ////Приклад9
//            //int x = 1;
//            //int y = 0;
//            //try
//            //{
//            //    int result1 = x / y;
//            //    int result2 = y / x;
//            //}
//            //catch (DivideByZeroException) when (y == 0)
//            //{
//            //    Console.WriteLine("y не повинен дорівнювати 0");
//            //}
//            //catch (DivideByZeroException ex)
//            //{
//            //    Console.WriteLine(ex.Message);
//            //}


//            ////Приклад10
//            //try
//            //{
//            //    int x = 5;
//            //    int y = x / 0;
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"Виключення: {ex.Message}");
//            //    Console.WriteLine($"Метод: {ex.TargetSite}");
//            //    Console.WriteLine($"Трасування стеку: {ex.StackTrace}");
//            //}


//            ////Приклад10
//            //try
//            //{
//            //    int[] numbers = new int[4];
//            //    numbers[7] = 9;     // IndexOutOfRangeException
//            //    int x = 5;
//            //    int y = x / 0;  // DivideByZeroException
//            //    Console.WriteLine($"Результат: {y}");
//            //}
//            //catch (DivideByZeroException)
//            //{
//            //    Console.WriteLine("Виникло виключення DivideByZeroException");
//            //}
//            //catch (IndexOutOfRangeException ex)
//            //{
//            //    Console.WriteLine(ex.Message);
//            //}

//            //Console.Read();

//            ////Приклад11
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"Исключение: {ex.Message}");
//            //}


//            ////Приклад12
//            //try
//            //{
//            //    Console.Write("Введіть ім'я: ");
//            //    string? name = Console.ReadLine();
//            //    if (name == null || name.Length < 2)
//            //    {
//            //        throw new Exception("Довжина імені менше 2 символів");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine($"Ваше ім'я: {name}");
//            //    }
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine($"Помилка: {e.Message}");
//            //}


//            ////Приклад13
//            //Console.Write("Введіть ім'я: ");
//            //string? name = Console.ReadLine();
//            //if (name == null || name.Length < 2)
//            //{
//            //    throw new Exception("Довжина імені менше 2 символів");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"Ваше ім'я: {name}");
//            //}


//            //Приклад14
//            try
//            {
//                try
//                {
//                    Console.Write("Введіть ім'я: ");
//                    string? name = Console.ReadLine();
//                    if (name == null || name.Length < 2)
//                    {
//                        throw new Exception("Довжина імені менше 2 символів");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Ваше ім'я: {name}");
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Помилка: {e.Message}");
//                    throw;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }



//            ////Приклад5 та 6 (частина коду нижче)
//            //Square("12");
//            //Square("ab");

//        }

//        ////Приклад5
//        //static void Square(string data)
//        //{
//        //    int x = int.Parse(data);
//        //    Console.WriteLine($"Квадрат числа {x}: {x * x}");
//        //}


//        ////Приклад6
//        //static void Square(string data)
//        //{
//        //    if (int.TryParse(data, out var x))
//        //    {
//        //        Console.WriteLine($"Квадрат числа {x}: {x * x}");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("Некоректний ввід");
//        //    }
//        //}


//    }
//}