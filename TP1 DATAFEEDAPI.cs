


// 1.3
public class TP1
{
    public int AskUserForParameter()
    {
        Console.WriteLine("Please write a number and press enter :");
        int.TryParse(Console.ReadLine(), out var result);
        return result;
    }

    public void prime()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i == 1 || i == 0)
                continue;
            int flag = 1;

            for (int j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine(i);
        }
    }

    public void Fibonacci()
    {
        Console.WriteLine("Ecrire un nombre pour la suite fibo :");
        int.TryParse(Console.ReadLine(), out var n);
        int w;
        if (n <= 0) Console.WriteLine(0);
        if (n == 1) Console.WriteLine(1);
        int u = 0;
        int v = 1;
        for (int i = 2; i <= n; i++)
        {
            w = u + v;
            u = v;
            v = w;
        };
        Console.WriteLine(v);
    }

    public int factorial(long n)
    {
        if (n == 0) return 1;
        return (int)(n * factorial(n - 1));
    }

    public int PowerFunction(int x) { return (int)(Math.Pow(x, 2) - 4); }

    public void EX3()
    {
        try
        {
            int a = 10/ PowerFunction(3);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(2);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(1);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(0);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(-1);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(-2);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        try
        {
            int a = 10 / PowerFunction(-3);
        }
        catch (Exception)
        {
            Console.WriteLine("le programme a échoué");
        }
        Console.WriteLine("le programme a continué");
    }


    public void Rectangle(int width, int length){
        if ((width >= 1 && length >= 1) && (width <= 1000 && length <= 1000)){
            string rectangle = "";
            for (int i = 0; i < width; i++){
                for (int j = 0; j < length; j++){
                    if ((i == 0 && j == 0) || (i == width - 1 && j == 0) || (i == 0 && j == length - 1) || (i == width - 1 && j == length - 1)){
                        rectangle += "o";
                    }
                    else if ((j == 0) || (j == length - 1)){
                        rectangle += "|";
                    }
                    else if ((i == 0) || (i == width - 1)){
                        rectangle += "-";
                    }
                    else{
                        rectangle += " ";
                    }
                }
                rectangle += "\n";
            }
            Console.WriteLine(rectangle);
        }
        else{
            Console.WriteLine("Erreur: entrez valeures entre 1 et 1000");
        }
    }

    public void arbre(){
        Console.WriteLine("Saisisez un nombre entre 3 et 20 ");
        int n = int.Parse(Console.ReadLine());
        if (n < 21 && n > 2){
            for (int i = 0; i <= n - 1; i++){
                var stars = new string('*', i);
                var spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write("*");
                Console.Write(stars);
                Console.WriteLine(spaces);
            }
            var spaces_tree = new string(' ', n - 1);
            Console.Write(spaces_tree);
            var pied = new string("| |");
            Console.Write(pied);
        }
        else{
            Console.WriteLine("Le chiffre saisie est invalide");
        }
    }

    public void RectangleStars(int width, int length){
        if ((width >= 1 && length >= 1) && (width <= 1000 && length <= 1000))
        {
            string rectangle = "";
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    var etoile = j % 3;
                    if (i == 0 && j == 0 || i == width - 1 && j == 0 || i == 0 && j == length - 1 || i == width - 1 && j == length - 1)
                    {
                        rectangle += "o";
                    }
                    else if (j == 0 || j == length - 1)
                    {
                        rectangle += "|";
                    }
                    else if (i == 0 || i == width - 1)
                    {
                        rectangle += "-";
                    }
                    else if (i % 3 == etoile)
                    {
                        rectangle += "*";
                    }
                    else
                    {
                        rectangle += " ";
                    }
                }
                rectangle += "\n";
            }
            Console.WriteLine(rectangle);
        }
        else{
            Console.WriteLine("Erreur: entrez valeures entre 1 et 1000");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("EXO 1\n");

        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i + "\t");
            for (int j = 1; j <= 10; j++)
            {
                if (i > 0) Console.Write(i * j + "\t");
                else Console.Write(j + "\t");
            }
            Console.Write("\n");
        }

        Console.Write("\n");

        for (int i = 0; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                if (i > 0)
                {
                    if ((i * j) % 2 == 1)
                        Console.Write(i * j + "\t");
                }
            }
            Console.Write("\n");
        }
        var demo = new TP1();
        var number = demo.AskUserForParameter();
        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i * number + "\t");
        }
        Console.Write("\n");
        Console.Write("EXO 2\n");
        demo.prime();
        demo.Fibonacci();
        Console.WriteLine(demo.factorial(5));
        // avec 420000 on a dépassé la pile on est en "stack overflow"
        Console.Write("EXO 3\n");
        demo.EX3();
        Console.Write("EXO 4\n");
        demo.Rectangle(0,7);
        Console.Write("Pour (1,5) et (4,1) le programme renvoie juste des traits. Pour (3,3) c'est un petit rectangle qui a autant de charactère sur chaque coté.\n pour (5,7) bah c'est un rectangle\n");
        demo.RectangleStars(5,7);
        Console.Write("EXO 5\n");
        demo.arbre();
    }
}





