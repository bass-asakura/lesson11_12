namespace lesson11_12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(palindrome("walaw"));
    }

    public static int factorial_recurs(int a){
        if (a < 0){
            return 0;
        }
        else if ((a == 0) || (a == 1)){
            return 1;
        }
        else{
            return a * factorial_recurs(a - 1);
        }
    }
    
    public static int number_fibonachi_rekurs(int a){
        if ((a == 1)||(a == 2)){
            return 1;
        }
        else{
            return number_fibonachi_rekurs(a - 2) + number_fibonachi_rekurs(a - 1);
        }
    }

    public static string obrawenie_stroki(string a){
        if (a.Length > 0){
            return a[a.Length - 1] + obrawenie_stroki(a.Substring(0, a.Length - 1));
        }
        else{
            return a;
        }
    }

    public static int sum_massiv_recurs(int[] a, int index){
        if(a.Length == index){
            return 0;
        }
        return a[index] + sum_massiv_recurs(a, index + 1);
    }

    public static int NOD_recurs(int a, int b){
        if (b == 0){
            return a;
        }
        else{
            return NOD_recurs(b, a % b);
        }
    }

    public static bool palindrome(string a){
        if (a.Length <= 1){
            return true;
        }
        return a[0] == a[a.Length - 1] && palindrome(a.Substring(1, a.Length -2));
    }

}
                     
