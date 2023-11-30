Console.WriteLine("ВВедите числа m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n) { 
    if (m == 0) {
        return n+1;
    }
    if (m>0 && n == 0) {
        return Akkerman(m-1,1);
    }
    return Akkerman(m-1, Akkerman(m, n-1));}
    
Console.WriteLine($"Число Аккермана для {n} и {m}: {Akkerman(m,n)}");