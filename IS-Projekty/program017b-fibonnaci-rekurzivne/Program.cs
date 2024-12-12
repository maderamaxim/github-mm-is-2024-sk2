static void Main(string[] args){
    int vysledek = Fibonacci(5);
    Console.WriteLine(vysledek);
}
static int Fibonacci(int n){
    return n > 1 ? Fibonacci(n-1) + Fibonacci(n - 2) : n;
}