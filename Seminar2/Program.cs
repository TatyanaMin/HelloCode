class Program 
{ 
static void SelectRace() 
    { 
        string[] nameRace = {"Люди", "Эльф", "Орги", "Гоблины", "Маги"}; 
        for (int i=0; i<nameRace.Length-1; i++) 
        { 
            Console.Write(i+1 + "-" + nameRace[i] + ", "); 
        } 
        Console.WriteLine(nameRace.Length + "-" + nameRace[nameRace.Length-1] + ", "); 
        Console.WriteLine("Укажите вашу расу"); 
        int numberRace = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Ваша раса " + nameRace[numberRace-1]); 
    } 
    static void SelectSex() 
    { 
        string[] nameSex = {"Женский", "Мужской"}; 
        for (int i=0; i<nameSex.Length-1; i++) 
        { 
                Console.Write(i+1 + "-" + nameSex[i] + ", "); 
        } 
        Console.WriteLine(nameSex.Length + "-" + nameSex[nameSex.Length-1] + ", "); 
        Console.WriteLine("Укажите ваш пол"); 
        int numberSex = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Ваш пол " + nameSex[numberSex-1]);  
    } 
static void SelectClass() 
{ 
        string[] nameClass = {"Чернокнижник", "Воин", "Вор"}; 
        WriteChoise(nameClass); 
        Console.WriteLine("Выберите свой класс"); 
        int numberClass = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Ваш класс " + nameClass[numberClass-1]);  
    } 
 
static void WriteChoise(string[] args) 
{ 
         
    for (int i=0; i<args.Length-1; i++) 
    { 
        Console.Write(i+1 + "-" + args[i] + ", "); 
    } 
     Console.WriteLine(args.Length + "-" + args[args.Length-1] + ", "); 
} 
 
    static void Main(string[] args) 
    { 
        SelectRace(); 
        SelectSex(); 
        SelectClass(); 
    } 
}