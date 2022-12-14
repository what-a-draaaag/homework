namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x)
        {
            if (x<0)
            {
                return 0.0;
            }
            else if (x%2<1)
            {
                return 1.0;
            }
            else
            {
                return -1.0;
            }
        }

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year)
        {
            if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0) || (year % 100 == 0 && year % 400 == 0))
            {
                return 366;
            }
            else 
            {
                return 365;
            }

        }

/*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            //char rotate1(char orientation, int cmd);
            return orientation;

            
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            int firstvalue = age / 10;
            int secondvalue =age%10;
            string decades;
            string years;
            string form;
            switch(firstvalue)
            {
                case 2:
                    decades = "двадцать";
                    break;
                case 3:
                    decades = "тридцать";
                    break;
                case 4:
                    decades = "сорок";
                    break;
                case 5:
                    decades = "пятьдесят";
                    break;
                case 6:
                    decades = "шестьдесят";
                    break;
                default:
                    decades = "";
                    break;
            }
            switch (secondvalue)
            {
                case 1:
                    years = "один";
                    form = "год";
                    break;
                case 0:
                    years = "";
                    form = "лет";
                    break;
                case 2:
                    years = "два";
                    form = "года";
                    break;
                case 3:
                    years = "три";
                    form = "года";
                    break;
                case 4:
                    years = "четыре";
                    form = "года";
                    break;
                case 5:
                    years = "пять";
                    form = "лет";
                    break;
                case 6:
                    years = "шесть";
                    form = "лет";
                    break;
                case 7:
                    years = "семь";
                    form = "лет";
                    break;
                case 8:
                    years = "восемь";
                    form = "лет";
                    break;
                case 9:
                    years = "девять";
                    form = "лет";
                    break;
                default:
                    years = "";
                    form = "";
                    break;
            }
            if (years!="")
            {
                return (decades + " " + years + " " + form);
            }
            else
            {
                return (decades + " " + form);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(0.0));
            Console.WriteLine(NumberOfDays(2021));
            Console.WriteLine(Rotate2('С', 1,-1));
            Console.WriteLine(AgeDescription(42));
        }
    }
}