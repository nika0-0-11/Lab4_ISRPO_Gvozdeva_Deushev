/*Console.WriteLine("Привет меня зовут Гвоздева Вероника Александровна");
Console.WriteLine("Привет меня зовут Деушев Тимур Тимурович");
Console.WriteLine("ИСП-231");
Console.WriteLine($"{DateTime.Now}, {DateTime.Now:D}");*/

while(true)
{
    Console.WriteLine("1 - Показать ФИО \n2 - Показать группу \n3 - Показать дату \n4 - Выход");
    Console.Write("Введите номер: ");

    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Гвоздева Вероника Александровна");
            Console.WriteLine("Деушев Тимур Тимурович \n");
            break;

        case 2:
            Console.WriteLine("ИСП-231 \n");
            break;

        case 3:
            Console.WriteLine($"{DateTime.Now:D} \n");
            break;

        case 4:
            Console.WriteLine("Выход из программы \n");
            return;
    }
}