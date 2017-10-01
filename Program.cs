using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store
{
    class Program
    {
        private static SportsEquipment[] listSportsEquipment = new SportsEquipment[0];
        private static void Main(string[] args)
        {
            new Program().MainMenu();
        }
        private void MainMenu()
        {
            string selectAction;
            do
            {
                TextMainMenu();
                selectAction = Console.ReadLine();
                switch(selectAction)
                {
                    case "1":
                        AthleticsAdd();
                        break;
                    case "2":
                        SkatesSkiingSportAdd();
                        break;
                    case "3":
                        SportGamesAdd();
                        break;
                    case "4":
                        ShowListSportsEquipment();
                        break;
                    case "5":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неизвесная команда!");
                        break;
                }
            } while (true);
        }
        #region Text menu
        private void TextMainMenu()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine("Выберите действие:");
            sb.AppendLine(" 1 - Добавить инвентарь для легкой атлетики");
            sb.AppendLine(" 2 - Добавить инвентарь для конько-лыжного спорта");
            sb.AppendLine(" 3 - Добавить инвентарь для спортивных игор");
            sb.AppendLine(" 4 - Просмотреть инвентарь");
            sb.AppendLine(" 5 - Выход из программы");
            Console.WriteLine(sb.ToString());
        }
        private void TextMenuAthleticsAdd()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine("Выберите действие:");
            sb.AppendLine(" 1 - Инвентарь для прыжков в высоту");
            sb.AppendLine(" 2 - Инвентарь для спортивного бега");
            sb.AppendLine(" 3 - Инвентарь для спортивного метания");
            sb.AppendLine(" 4 - Вернуться в главное меню");
            Console.WriteLine(sb.ToString());
        }
        private void TextMenuSkatesSkiingSportAdd()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine("Выберите действие:");
            sb.AppendLine(" 1 - Инвентарь для коньков");
            sb.AppendLine(" 2 - Инвентарь для лыж");
            sb.AppendLine(" 3 - Вернуться в главное меню");
            Console.WriteLine(sb.ToString());
        }
        private void TextMenuSportGamesAdd()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine("Выберите действие:");
            sb.AppendLine(" 1 - Инвентарь для игры в бадминтон");
            sb.AppendLine(" 2 - Вернуться в главное меню");
            Console.WriteLine(sb.ToString());
        }
        #endregion
        private void IncreaseRangeArray()
        {
            SportsEquipment[] newListSportsEquipment = new SportsEquipment[listSportsEquipment.Length + 1];
            if(listSportsEquipment.Length != 0)
                for (int i = 0; i <= listSportsEquipment.Length-1; i++)
                {
                    newListSportsEquipment[i] = listSportsEquipment[i];
                }
            listSportsEquipment = newListSportsEquipment;
        }
        private void ShowListSportsEquipment()
        {            
            for (int i = 0; i < listSportsEquipment.Length; i++)
            {
                Console.WriteLine(listSportsEquipment[i].ShowElement());
                if (listSportsEquipment[i] is KindSport.Athletics)
                    Console.WriteLine("Тип родителя: Athletics");
                if (listSportsEquipment[i] is KindSport.SkatesSkiingSport)
                    Console.WriteLine("Тип родителя: SkatesSkiingSport");
                if (listSportsEquipment[i] is KindSport.SportGames)
                    Console.WriteLine("Тип родителя: SportGames");
            }
        }

        #region AthleticsAdd
        private void AthleticsAdd()
        {
            TextMenuAthleticsAdd();
            switch(Console.ReadLine())
            {
                case "1":
                    HighJumpEquipmentAdd();
                    break;
                case "2":
                    SportsRunningEquipmentAdd();
                    break;
                case "3":
                    SportThrowingEquipmentAdd();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Неизвесная команда!");
                    break;
            }
        }
        private void HighJumpEquipmentAdd()
        {
            int id;
            string name;
            string kindSport = "Легкая атлетика";
            string athleticsType = "Прыжки в высоту";
            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифер");
            } while (true);
            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length - 1] = new TypeAthletics.HighJump(id, name, kindSport, athleticsType);
        }
        private void SportsRunningEquipmentAdd()
        {
            int id;
            string name;
            string kindSport = "Легкая атлетика";
            string athleticsType = "Спортивный бег";
            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифер");
            } while (true);
            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length-1] = new TypeAthletics.SportsRunning(id, name, kindSport, athleticsType);
        }
        private void SportThrowingEquipmentAdd()
        {
            int id;
            string name;
            string kindSport = "Легкая атлетика";
            string athleticsType = "Спортивное метание";
            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифер");
            } while (true);
            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length-1] = new TypeAthletics.SportThrowing(id, name, kindSport, athleticsType);
        }
        #endregion

        #region SkatesSkiingSportAdd
        private void SkatesSkiingSportAdd()
        {
            TextMenuSkatesSkiingSportAdd();
            switch (Console.ReadLine())
            {
                case "1":
                    SkatesEquipmentAdd();
                    break;
                case "2":
                    SkiingEquipmentAdd();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Неизвесная команда!");
                    break;
            }
        }
        private void SkatesEquipmentAdd()
        {
            int id;
            string name;
            string kindSport = "Конько-лыжный спорт";
            string skatesSkiingSportType = "Коньки";
            int skatesSize;
            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифер");
            } while (true);

            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            Console.WriteLine("Введите размер коньков:");
            skatesSize = int.Parse(Console.ReadLine());

            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length - 1] = new TypeSkatesSkiingSport.Skates(id, name, kindSport, skatesSkiingSportType, skatesSize);
        }
        private void SkiingEquipmentAdd()
        {
            int id;
            string name;
            string kindSport = "Конько-лыжный спорт";
            string skatesSkiingSportType = "Лыжи";
            int skiingLength;
            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифер");
            } while (true);

            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            Console.WriteLine("Введите длину лыж:");
            skiingLength = int.Parse(Console.ReadLine());

            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length - 1] = new TypeSkatesSkiingSport.Skiing(id, name, kindSport, skiingLength, skatesSkiingSportType);
        }
        #endregion

        #region SportGamesAdd
        private void SportGamesAdd()
        {
            TextMenuSportGamesAdd();
            switch (Console.ReadLine())
            {
                case "1":
                    BadmintonGameAdd();
                    break;
                default:
                    Console.WriteLine("Неизвесная команда!");
                    break;
            }
        }
        private void BadmintonGameAdd()
        {
            int id;
            string name;
            string kindSport = "Спортивные игры";
            string typeSportGame ="Бадминтон";
            string material;
            int numberInKit;

            do
            {
                Console.WriteLine("Введите ID:");
                if (int.TryParse(Console.ReadLine(), out id))
                    break;
                else
                    Console.WriteLine("ID должен состоять только из цифр");
            } while (true);
            Console.WriteLine("Введите название инвентаря:");
            name = Console.ReadLine();
            Console.WriteLine("Введите материал:");
            material = Console.ReadLine();
            Console.WriteLine("Введите количество в наборе:");
            numberInKit = int.Parse(Console.ReadLine());

            IncreaseRangeArray();
            listSportsEquipment[listSportsEquipment.Length - 1] = new TypeSportGames.BadmintonGame(id, name, kindSport, typeSportGame, material, numberInKit);
        }
        #endregion
    }
}