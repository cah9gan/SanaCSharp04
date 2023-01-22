int N, M;
Random rnd = new Random();
Console.WriteLine("Введіть значення N");
N = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення M");
M = int.Parse(Console.ReadLine());
int[,] mass = new int[N, M];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        mass[i, j] = rnd.Next(-10, 10);
        Console.Write("{0}        ", mass[i, j]);
    }
    Console.WriteLine();
}
int kilk_dodat_el = 0, max1 = mass[0, 0], max2 = mass[0, 0];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (mass[i, j] > 0)
        {
            kilk_dodat_el++;
        }
    }
}
Console.WriteLine("Кількість додатних елементів = {0}", kilk_dodat_el);
Console.WriteLine();
bool fl = false;
int kolryad = 0;
int[] massdop = new int[1000];

int k = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        massdop[k] = mass[i, j];
        k++;
    }
}
int[] arr = new int[1000];
k = 0;
for (int m = 0; m < N * M; m++)
{
    for (int i = m + 1; i < N * M; i++)
    {
        if (massdop[m] == massdop[i])
        {
            arr[k] = massdop[m];
            k++;
            break;
        }
    }
}
int max = -11;
for (int i = 0; i < k; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine();
Console.WriteLine("максимальне із чисел, що зустрічається в заданій матриці більше одного разу = {0}", max);
for (int i = 0; i < N; i++)
{
    fl = false;
    for (int j = 0; j < M; j++)
    {
        if (mass[i, j] == 0)
        {
            fl = true;
        }
    }
    if (fl == false)
    {
        kolryad++;
    }
}
Console.WriteLine("кількість рядків, які не містять жодного нульового елемента = {0}", kolryad);
Console.WriteLine();
bool ml = false;
int kolstovp = 0;
for (int i = 0; i < M; i++)
{
    ml = false;
    for (int j = 0; j < N; j++)
    {
        if (mass[j, i] == 0)
        {
            ml = true;
        }
    }
    if (ml == true)
    {
        kolstovp++;
    }
}
Console.WriteLine("кількість стовпців, які містять хоча б один нульовий елемент = {0}", kolstovp);
Console.WriteLine();
int sum = 0, sumpam = 0;
int nomerad = 0;
for (int i = 0; i < N; i++)
{
    sum = 0;
    for (int j = 0; j < M; j++)
    {
        for (int t = M - 1; t >= 0; t--)
        {
            if (mass[i, j] == mass[i, t])
            {
                if (j == t)
                {
                    break;
                }
                else
                {
                    sum = sum + 1;
                }
            }
        }
    }
    if (sumpam < sum)
    {
        nomerad = i;
    }
    sumpam = sum;
}
Console.WriteLine("номер рядка, в якому знаходиться найдовша серія однакових елементів = {0}", nomerad + 1);
Console.WriteLine();
int dobutok = 1, dobpam = 1;
for (int i = 0; i < N; i++)
{
    dobpam = 1;
    for (int j = 0; j < M; j++)
    {
        if (dobpam < 0)
        {
            break;
        }

        dobpam *= mass[i, j];

    }
    if (dobpam > 0)
    {
        dobutok *= dobpam;
    }
}
if (dobutok == 1)
{
    Console.WriteLine("Рядка який не містить відїємний елемент немає");
}
else
{
    Console.WriteLine("добуток елементів в тих рядках, які не містять від’ємних елементів = {0}", dobutok);
}
Console.WriteLine();
int sumstovp = 0, sumstovppam = 0;
for (int i = 0; i < N; i++)
{
    sumstovppam = 0;
    for (int j = 0; j < M; j++)
    {
        if (mass[j, i] >= 0)
        {
            sumstovppam += mass[j, i];
        }
        else
        {
            sumstovppam = 0;
            break;
        }
    }
    sumstovp += sumstovppam;
}
if (sumstovp != 0)
{
    Console.WriteLine("суму елементів в тих стовпцях, які не містять від’ємних елементів = {0}", sumstovp);
}
else
{
    Console.WriteLine("Немає стовпця, який не містить від’ємних елементів");
}
Console.WriteLine();
int schet = 0, summa = 0, summadop = 0;
for (int i = 0; i < N; i++)
{
    schet = 0;
    summadop = 0;
    for (int j = 0; j < M; j++)
    {
        if (mass[j, i] < 0)
        {
            schet++;
        }
        summadop += mass[j, i];
    }
    if (schet > 0)
    {
        summa += summadop;
    }
}
Console.WriteLine("суму елементів в тих стовпцях, які  містять хоча б один від’ємний елемент = {0}", summa);
int[,] massive = new int[N, N];
Console.WriteLine();
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        massive[i, j] = rnd.Next(-10, 10);
        Console.Write("{0}        ", massive[i, j]);
    }
    Console.WriteLine();
}
int[] massive2 = new int[N * 2];
int o = 0;
for (int i = 1; i < N; i++)
{
    int index = i;
    int sum_to_diag = 0;
    for (int j = 0; j < N; j++)
    {
        sum_to_diag += massive[index++, j];
        if (index == N)
            break;
    }
    massive2[o] = sum_to_diag;
    o++;
}
o = o - 1;
for (int i = 0; i < N; i++)
{
    int index = i;
    int sum_to_diag = 0;
    for (int j = 1; j < N; j++)
    {
        sum_to_diag += massive[j, index++];
        if (index == N)
            break;
    }
    massive2[o] = sum_to_diag;
    o++;
}
int maximale = massive2[0];
for (int i = 0; i < o; i++)
{
    if (maximale < massive2[i])
    {
        maximale = massive2[i];
    }
}
Console.WriteLine("максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці = {0}", maximale);
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        massive[i, j] = rnd.Next(-10, 10);
        Console.Write("{0}        ", massive[i, j]);
    }
    Console.WriteLine();
}
int[] massive3 = new int[N * 2];
o = 0;
for (int i = 0; i < N; i++)
{
    int index = i;
    int sum_to_modul_diag = 0;
    for (int j = N - 1; j >= 0; j--)
    {
        sum_to_modul_diag += Math.Abs(massive[index++, j]);
        if (index == N)
            break;
    }
    massive3[o] = sum_to_modul_diag;
    o++;
}
int minimale = massive3[0];
for (int i = 0; i < o; i++)
{
    if (massive3[i] < minimale)
    {
        minimale = massive3[i];
    }
}
Console.WriteLine("мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці = {0}", minimale);
Console.WriteLine("Транспанована матриця:");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write("{0}  ", mass[j, i]);
    }
    Console.WriteLine();
}