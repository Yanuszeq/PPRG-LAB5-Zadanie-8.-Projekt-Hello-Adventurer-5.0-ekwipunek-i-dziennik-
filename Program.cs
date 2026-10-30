﻿﻿﻿Console.WriteLine("Podaj Imię bohatera: ");
String Imie = Console.ReadLine();

double Miejsce_w_plecaku = 2;

int Zdrowie = 80;
int maksymalneZdrowie = 100;

int Ilosc_zlota = 10;

int liczbaEksploracji = 0;

int tura = 1;
bool graDziala = true;

string[] znaleziska =
{
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
};

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura"
};

List<string> historia = new List<string>();

while (graDziala)
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("+=======================================+");
    Console.Write("|            ");
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Write("KARTA BOHATERA");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("             |");
    Console.WriteLine("+=======================================+");
    Console.ResetColor(); 

    Console.ForegroundColor = ConsoleColor.Blue;


    Console.Write("| Tura: ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write($"{tura}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\t\t\t\t|");

    Console.WriteLine($"| Imię bohatera: {Imie}\t\t\t|");

    if (Miejsce_w_plecaku > 6)
    {
        Console.Write("| ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Miejsce w plecaku: zła wartość\t");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|");

    }
    else
    {
    Console.WriteLine($"| Miejsce w plecaku: {Miejsce_w_plecaku}/6\t\t|");
    }

    if (Zdrowie > 100) 
    {
      Zdrowie = 100;
      Console.WriteLine($"| Zdrowie: {Zdrowie}\t\t\t\t|");
    }
    else
    {
        if(Zdrowie < 0) Zdrowie = 0;
    Console.WriteLine($"| Zdrowie: {Zdrowie}\t\t\t\t|");
    }

    Console.WriteLine($"| Ilość złota: {Ilosc_zlota}\t\t\t|");
  
    Console.ResetColor(); 
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("+=======================================+");


    Console.Write("|                 ");
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Write("Info");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("                  |");


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("+=======================================+");

    Console.ResetColor(); 

    if( Zdrowie > 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nCo chcesz zrobić?");
        Console.WriteLine("\n1 - Idź na misję");
        Console.WriteLine("\n2 - Pokaż plecak");
        Console.WriteLine("\n3 - Pokaż historię");
        Console.WriteLine("\n4 - Pokaż statystyki wyprawy");
        Console.WriteLine("\n5 - Wyjdź z gry\n");
        Console.ResetColor(); 

        string akcja = Console.ReadLine(); 

        switch (akcja.ToLower())
        {
            case "1":
                if (Zdrowie > 0)    
                    {
                        tura ++;
                        Zdrowie -= 8;
                        Ilosc_zlota += 10;
                    }
                else if(Zdrowie <= 0)
                    {
                        Zdrowie = 0;
                    }
            break;
            
            case "2":
            
                if(Ilosc_zlota >= 3)
                {
                    Console.WriteLine($"{plecak}");

                    
                }
            break;

            case "3":
                
                
            break;

            case "4":
            
                
            
            break;

            case "5":
            
                graDziala = false;
            
            break;
        }
                
    }
        else if(Zdrowie <=0 )
        {
            Console.WriteLine("\n5 - Wyjdź z gry\n");
            string akcja2 = Console.ReadLine();
            switch (akcja2.ToLower())
                {
                case "4":
                    {
                        graDziala = false;
                    }break;
                }
        }
                    
                
}