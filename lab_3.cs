﻿//Task 1.6
Console.WriteLine("Task 1.6");
double[] a = new double[5];
double L = 0;
string u;
for (int i = 0; i < a.Length; i++)
{
    u = Console.ReadLine();
    a[i] = Convert.ToDouble(u);
    L += a[i] * a[i];
}
Console.WriteLine(Math.Sqrt(L));

//Task 1.10
Console.WriteLine("Task 1.10");
a = new double[10];
double p;
double q;
int k = 0;
for (int i = 0; i < a.Length; i++)
{
    u = Console.ReadLine();
    a[i] = Convert.ToDouble(u);
}
u = Console.ReadLine();
p = Convert.ToDouble(u);
u = Console.ReadLine();
q = Convert.ToDouble(u);
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < q & a[i] > p)
    {
        k += 1;
    }
}
Console.WriteLine(k);

//Task 1.11
Console.WriteLine("Task 1.11");
a = new double[10];
k = 0;
for (int i = 0; i < a.Length; i++)
{
    u = Console.ReadLine();
    a[i] = Convert.ToDouble(u);
    if (a[i] > 0)
    {
        k += 1;
    }
}
double[] b = new double[k];
k = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        b[k] = a[i];
        k += 1;
    }
}
for (int i = 0; i < b.Length; i++)
{
    Console.Write($"{b[i]} ");
}
Console.WriteLine("");

//Task 1.12
Console.WriteLine("Task 1.12");
a = new double[8];
k = 0;
p = 0;
for (int i = 0; i < a.Length; i++)
{
    u = Console.ReadLine();
    a[i] = Convert.ToDouble(u);
    if (a[i] < 0)
    {
        p = a[i];
        k = i;
    }
}
Console.WriteLine($"{p} {k}");

//Task 1.13
Console.WriteLine("Task 1.13");
a = new double[10];
b = new double[5];
double[] c = new double[5];
int f = 0;
k = 0;
for (int i = 0; i < a.Length; i++)
{
    u = Console.ReadLine();
    a[i] = Convert.ToDouble(u);
    if (i % 2 == 0)
    {
        b[f] = a[i];
        f += i;
    }
    else
    {
        c[k] = a[i];
        k += i;
    }
}

//Task 2.5
Console.WriteLine("Task 2.5");
double x;
double min = 100000000;
int mini = 0;
double max = -100000000;
int maxi = 0;
int z = 0;
double s = 0;
Console.WriteLine("Введите числа в строку");
string[] g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < min)
    {
        min = a[i];
        mini = i;
    }
    if (a[i] > max)
    {
        max = a[i];
        maxi = i;
    }
}
if (mini > maxi)
{
    z = maxi;
    maxi = mini;
    mini = z;
}
z = maxi - mini;
b = new double[z - 1];
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (i > mini & i < maxi & a[i] < 0)
    {
        b[k] = a[i];
        k += 1;
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

//Task 2.6
Console.WriteLine("Task 2.6");
double P = 0;
Console.WriteLine("Введите числа в строку");
s = 0;
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите P");
g = Console.ReadLine().Split();
if (g.Length == 1)
{
    if (double.TryParse(g[0], out x))
    {
        P = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}
for (int i = 0; i < a.Length; i += 1)
{
    s += a[i];
}
s = s / a.Length;
min = 1000000000;
mini = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (Math.Abs(P - a[i]) < min)
    {
        mini = i;
        min = Math.Abs(P - a[i]);
    }
}
b = new double[a.Length + 1];
for (int i = 0; i < a.Length; i += 1)
{
    if (i <= mini)
    {
        b[i] = a[i];
    }
    if (i > mini)
    {
        b[i + 1] = a[i];
    }
}
b[mini + 1] = P;
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

//Task 2.9
Console.WriteLine("Task 2.9");
max = -1000000000;
min = 100000000;
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < min)
    {
        min = a[i];
        mini = i;
    }
    if (a[i] > max)
    {
        max = a[i];
        maxi = i;
    }
}
if (mini > maxi)
{
    z = maxi;
    maxi = mini;
    mini = z;
}

Console.WriteLine(mini);
Console.WriteLine(maxi);
z = maxi - mini;
Console.WriteLine(z);
b = new double[z - 1];
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (i > mini & i < maxi)
    {
        b[k] = a[i];
        k += 1;
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    s += b[i];
}
s = s / b.Length;
Console.WriteLine(s);

//Task 2.10
Console.WriteLine("Task 2.10");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < min & a[i] > 0)
    {
        min = a[i];
        mini = i;
    }
}
b = new double[a.Length - 1];
for (int i = 0; i < b.Length; i += 1)
{
    if (i < mini)
    {
        b[i] = a[i];
    }
    if (i >= mini)
    {
        b[i] = a[i + 1];
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

//Task 2.11
Console.WriteLine("Task 2.11");
z = 0;
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите P");
g = Console.ReadLine().Split();
if (g.Length == 1)
{
    if (double.TryParse(g[0], out x))
    {
        P = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] > 0)
    {
        z = i;
    }
}
b = new double[a.Length + 1];
for (int i = 0; i < a.Length; i += 1)
{
    if (i <= z)
    {
        b[i] = a[i];
    }
    if (i > z)
    {
        b[i + 1] = a[i];
    }
}
b[z + 1] = P;
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

//Task 2.13
Console.WriteLine("Task 2.13");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
max = -100000000;
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] > max & i % 2 == 0)
    {
        max = a[i];
        maxi = i;
    }
}
a[maxi] = maxi;
for (int i = 0; i < a.Length; i += 1)
{
    Console.WriteLine($"a[{i}]={a[i]}");
}

//Task 2.15
Console.WriteLine("Task 2.15");
Console.WriteLine("Введите A в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите B в строку");
g = Console.ReadLine().Split();
b = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        b[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите k");
g = Console.ReadLine().Split();
if (g.Length == 1)
{
    if (int.TryParse(g[0], out z))
    {
        k = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}
int l = 0;
double[] m = new double[b.Length + a.Length - 1];
if (k < a.Length - 1)
{
    for (int i = 0; i < m.Length; i += 1)
    {
        if (i <= k)
        {
            m[i] = a[i];
        }
        if (i > k & i <= k + b.Length)
        {
            m[i] = b[l];
            l++;
        }
        if (i > k + b.Length)
        {
            m[i] = a[i - b.Length];
        }
    }
    for (int i = 0; i < m.Length; i += 1)
    {
        Console.WriteLine($"m[{i}]={m[i]}");
    }
}

//Task 3.1
Console.WriteLine("Task 3.1");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
max = -100000000;
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] == max)
    {
        b[k] = i;
        k++;
    }
    if (a[i] > max)
    {
        k = 0;
        max = a[i];
        b = new double[a.Length];
        b[k] = i;
        k++;
    }

}
m = new double[k];
for (int i = 0; i < m.Length; i += 1)
{
    m[i] = b[i];
}
for (int i = 0; i < m.Length; i += 1)
{
    Console.WriteLine($"m[{i}]={m[i]}");
}

//Task 3.5
Console.WriteLine("Task 3.5");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
k = 0;
b = new double[a.Length / 2];
for (int i = 0; i < a.Length; i += 1)
{
    if (i % 2 == 0)
    {
        b[k] = a[i];
        k++;
    }
}
Array.Sort(b);
for (int i = 0; i < b.Length; i += 1)
{
    a[i * 2] = b[i];
}
for (int i = 0; i < a.Length; i += 1)
{
    Console.WriteLine($"a[{i}]={a[i]}");
}

//Task 3.8
Console.WriteLine("Task 3.8");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < 0)
    {
        k++;
    }
}
b= new double[k];
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < 0)
    {
        b[k] = a[i];
        k++;
    }
}
Array.Sort(b);
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] < 0)
    {
        a[i]=b[k];
        k++;
    }
}
for (int i = 0; i < a.Length; i += 1)
{
    Console.WriteLine($"a[{i}]={a[i]}");
}

//Task 3.9
Console.WriteLine("Task 3.9");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
int len1=1;
maxi = 0;
int len2 = 1;
mini = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if(i>0)
    {
        if (a[i] > a[i-1])
        {
            len1++;
            if(len1>maxi)
            {
                maxi = len;
            }
        }
        else
        {
            len1 = 1;
        }
    }
    if (i > 0)
    {
        if (a[i] < a[i - 1])
        {
            len2++;
            if (len2 > mini)
            {
                mini = len;
            }
        }
        else
        {
            len2 = 1;
        }
    }
}
if (mini>maxi)
{ 
    maxi = mini; 
}
Console.WriteLine(maxi);

//Task 3.12
Console.WriteLine("Task 3.12");
g = Console.ReadLine().Split();
if (g.Length == 12)
{
    a = new double[g.Length];
    for (int i = 0; i < g.Length; i += 1)
    {
        if (double.TryParse(g[i], out x))
        {
            a[i] = x;
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i]<0)
    {
        k++;
    }
}
b =new double[a.Length-k];
k = 0;
for (int i = 0; i < a.Length; i += 1)
{
    if (a[i] >= 0)
    {
        b[k] = a[i];  
        k++;
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

//Task 3.13
Console.WriteLine("Task 3.13");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
z = 0;
for (int i = 0; i < a.Length; i += 1)
{
    k = 1;
    for (int j = 0; j < a.Length; j += 1)
    {
        if (a[i] == a[j] & i != j)
        {
            k = 0;
        }
    }
    z += k;
}
b = new double[z];
z = 0;
for (int i = 0; i < a.Length; i += 1)
{
    k = 1;
    for (int j = 0; j < a.Length; j += 1)
    {
        if (a[i] == a[j] & i != j)
        {
            k = 0;
        }
    }
    if (k == 1)
    {
        b[z] = a[i];
        z++;
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

// Task 11
Console.WriteLine("Task 11");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите x");
x = 0;
g = Console.ReadLine().Split();
if (g.Length == 1)
{
    if (double.TryParse(g[0], out x))
    {
        x = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Array.Sort(a);
k = 0;
z = 0;
int k1 = 0;
int k2 = a.Length-1;
while (x != a[k] & k2>=k1)
{
    k=(k1+k2)/2;
    if (x < a[k])
    {
        k2 = k - 1;
    }
    if (x > a[k])
    {
        k1 = k +1 ;
    }
    if (x == a[k])
    {
        Console.WriteLine($"Искомый элемент {k} в массиве");
        z = 1;
    }
}
if (z==0)
{
    Console.WriteLine("Искомого элеменa нет в массиве");
}

// Task 12
Console.WriteLine("Task 12");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
b = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        b[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
c = new double[a.Length + b.Length - 1];
if (a.Length > b.Length)
{
    k = b.Length;
}
else
{
    k = a.Length;
}
for (int i = 0; i < k * 2; i += 1)
{
    if (i % 2 == 0)
    {
        c[i] = a[i / 2];
    }
    else
    {
        c[i] = b[i / 2];
    }
}
if (a.Length > b.Length)
{
    for (int i = 0; i < a.Length - b.Length; i += 1)
    {
        c[i + 2 * k] = a[i + k];
    }
}
if (a.Length < b.Length)
{
    for (int i = 0; i < b.Length - a.Length; i += 1)
    {
        c[i + 2 * k - 1] = b[i + k];
    }
}
for (int i = 0; i < c.Length; i += 1)
{
    Console.WriteLine($"c[{i}]={c[i]}");
}

// Task 13
Console.WriteLine("Task 13");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
b = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        b[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
c = new double[a.Length + b.Length];
//k=i z=j
k = 0;
z = 0;
int r = 0;
while (k < a.Length & z < b.Length)
{
    if (a[k] >= b[z])
    {
        c[r] = a[k];
        k++;
        r++;
    }
    else
    {
        c[r] = b[z];
        z++;
        r++;
    }
}
while (k < a.Length)
{
    c[r] = a[k];
    k++;
    r++;
}
while (z < b.Length)
{
    c[r] = b[z];
    z++;
    r++;
}
for (int i = 0; i < c.Length; i += 1)
{
    Console.WriteLine($"c[{i}]={c[i]}");
}

// Task 14
Console.WriteLine("Task 14");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
b= new double[a.Length];
for (int i = 0; i < a.Length; i += 1)
{
    b[i] = a[a.Length-1-i];
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}

// Task 15
Console.WriteLine("Task 15");
Console.WriteLine("Введите числа в строку");
g = Console.ReadLine().Split();
a = new double[g.Length];
for (int i = 0; i < g.Length; i += 1)
{
    if (double.TryParse(g[i], out x))
    {
        a[i] = x;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите x");
z = 0;
g = Console.ReadLine().Split();
if (g.Length == 1)
{
    if (int.TryParse(g[0], out k))
    {
        z = k;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
b = new double[a.Length];
for (int i = 0; i < a.Length; i += 1)
{
    if (i + z < a.Length)
    {
        b[i+z] = a[i];
    }
    else
    {
        b[i + z-a.Length] = a[i];
    }
}
for (int i = 0; i < b.Length; i += 1)
{
    Console.WriteLine($"b[{i}]={b[i]}");
}
