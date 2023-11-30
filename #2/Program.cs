// Вариант с положительным шагом в рекурсии
/*Console.WriteLine("Введите два числа M и N: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int start, int end) {    
    int sum = 0;    
    if (start == end) {        
        return sum+start;    
    }    
    sum = start + Sum(start+1, end);    
    return sum;}
Console.WriteLine($"Сумма промежутка: {Sum(M, N)}"); */

// Выриант с отрицательным шагом

Console.WriteLine("Введите два числа M и N: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int end) {
    if (start == end) return start;
    return start + Sum(start-1, end);
    }

Console.WriteLine($"Сумма промежутка: {Sum(N, M)}");