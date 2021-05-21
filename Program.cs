using System;

namespace testedate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("-------------------------------------------------------------------");
            DateTime agora = DateTime.Now;
            //datetime retorna a data e hora do sistema e Now retorna a dt e hora atual
            DateTime torresGemeas = new DateTime(2001, 9, 11, 8, 46, 0);
            
            Console.WriteLine(torresGemeas);
            Console.WriteLine(agora);
            Console.WriteLine(DateTime.Today);
            //today retorna somenta a data
            Console.WriteLine(agora.Day);
            //Day retorna o dia
            Console.WriteLine(agora.Month);
            //Month retorna o mês
            Console.WriteLine(agora.Year);
            //Year retorna o ano
            Console.WriteLine(agora.Hour);
            //Hour retorna o componente da hora
            Console.WriteLine(agora.Minute);
            //Minute retorna os minutos
            Console.WriteLine(agora.Second);
            //Second retorna os segundos
            Console.WriteLine(agora.Millisecond);		
            Console.WriteLine(agora.Date);
            //Date retorna só a data
            Console.WriteLine(agora.TimeOfDay);
            //timeofDay retorna hora
            Console.WriteLine(agora.DayOfWeek);
            //DayOfWeek retorna o dia da semana
            Console.WriteLine(agora.DayOfYear);
            //DayOfYear retorna quantos dias a data está distante do icício do ano
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------------");
            DateTime agora2 = DateTime.Now;
            Console.WriteLine(agora2.IsDaylightSavingTime());
            //Para saber se a data/hora está no período de horário de verão, IsDaylightSavingTime
            Console.WriteLine(DateTime.IsLeapYear(2020));
            //IsLeapYear usado para saber se um ano é bissexto
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            //DaysInMonth usado0 para saber quantos dias tem um mês
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------------");
            DateTime agora3 = DateTime.Now;
            Console.WriteLine(agora3.ToShortDateString());
            Console.WriteLine(agora3.ToLongDateString());
            //Para formatos de exibição padronizados, use ToShortDateString e ToLongDateString.
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("-------------------------------------------------------------------");
            //Podemos alterar uma data somando valores individuais:
            //AddYear, AddMonth, AddDay, AddHour, AddMinute, AddSecond e AddMillisecond.
            // Compare para comparar
            DateTime agora4 = DateTime.Now;
            DateTime amanha4 = DateTime.Today.AddDays(1);
            Console.WriteLine(agora4);
            Console.WriteLine(amanha4);
            Console.WriteLine(DateTime.Compare(agora4, amanha4));
            Console.WriteLine(DateTime.Compare(amanha4, agora4));
            Console.ResetColor();
             
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------------");
            //Para representar intervalos de tempo, utilizamos TimeSpan.
            DateTime agora5 = DateTime.Now;
            DateTime amanha5 = DateTime.Today.AddDays(1);
            TimeSpan intervalo = amanha5 - agora;
            TimeSpan tresHorasEQuinze = new TimeSpan(3, 15, 0);
            Console.WriteLine(agora5);
            Console.WriteLine(amanha5);
            Console.WriteLine(intervalo);
            Console.WriteLine(tresHorasEQuinze);
            Console.WriteLine(agora5 + tresHorasEQuinze);
            Console.ResetColor();
           



        }
    }
}
