Console.WriteLine("Введите числа M и N: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
string Chet(int start, int end) {
    if (start == end) { 
        if (start % 2 == 0) {
            return start.ToString();
        }
        else return " ";
    }
    if (start % 2 == 0) {
        return start + " " + Chet(start+1, end);
    }
    return Chet(start+1, end);
    }
Console.WriteLine($"Чётные числа из промежутка от {M} до {N}: {Chet(M, N)}");
