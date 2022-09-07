// ЗАДАЧА 41_____________________________________________________________

Console.Write("Введите длину массива: ");
bool isLength = int.TryParse(Console.ReadLine(), out int length);
int [] array = new int[length];

if (!isLength){
    Console.WriteLine("Введите число.");
    return;
}

void GetRandom(int a){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(-9, 10);
    }
}

void PrintArray(int b){
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
    
}

int GetAmountNumber(int c){
    int amount=0;
    for(int i =0; i<array.Length; i++){
        if(array[i] !> 0){
            amount++;
        }
    }
    return amount;
}
Console.WriteLine("");
Console.Write("Масcив: ");
GetRandom(length);
PrintArray(length);
Console.WriteLine("");
int res = GetAmountNumber(length);
Console.WriteLine($"Количество чисел больше нуля равно {res}.");
