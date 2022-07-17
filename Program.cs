/* Zadacha 47 
void Matrica(int n, int m)
{
    float[,] array = new float [n, m];
 Random rand = new Random();
 for (int i = 0; i<n; i++)
 {
    for (int j = 0; j<m; j++)
    {
        array[i,j] = rand.Next(100);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
 }
}
Matrica(5,2);
*/
/* Zadacha 50 
int IlementMassiva(int n, int m, int a, int b)
{
 int ilement = 0;
 int [,] array = new int [n,m];
 Random rand = new Random();
 for (int i = 0; i<n; i++)
 {
    for (int j = 0; j<m; j++)
    {
        array[i,j] = rand.Next(100);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
 }

        if (a>n | b>m)
        {
            Console.WriteLine("Нет такого элемента массива");
        }
        if (a<n && b<m)
        {
           ilement = array [a,b];
        }
    
 
 return ilement;
}
Console.Write("Введите количество строк ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int stl = Convert.ToInt32(Console.ReadLine());
int result = IlementMassiva(str, stl, 2, 3);
Console.WriteLine("");
Console.WriteLine("Элемент массива  = " + result);
*/
/* Zadacha 52 */
void SredneeMassiva(int n, int m)
{
    int [,] array = new int [n,m];
    double [] sum = new double [m];
    double [] srednee = new double [m];
 Random rand = new Random();
 for (int i = 0; i<n; i++)
 {
    for (int j = 0; j<m; j++)
    {
        array[i,j] = rand.Next(100);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
 }
 for (int j = 0; j<m;j++)
 {
    sum[j] = 0;
 }
 for ( int j = 0; j<m; j++)
 {
    for (int i = 0; i<n; i++)
   {
     sum[j] = sum[j] + array[i,j];

   }
 }
 for (int j = 0; j<m;j++)
 {
    srednee[j] = sum[j]/m;
 }
 Console.WriteLine("Среднее арифметическое столбцов:");
 for (int j = 0; j<m;j++)
 {
    srednee[j] = Math.Round(srednee[j],3);
    Console.Write(" " + srednee[j]);
 }
}
SredneeMassiva(4,4);