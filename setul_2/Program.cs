﻿using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

int ui;
Console.WriteLine("Introduceti numarul problemei:");
ui = int.Parse(Console.ReadLine());
if (ui == 1)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p1();
}
if (ui == 2)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p2();
}
if (ui == 3)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p3();
}
if (ui == 4)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p4();
}
if (ui == 5)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p5();
}
if (ui == 6)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p6();
}
if (ui == 7)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p7();
}
if (ui == 8)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p8();
}
if (ui == 9)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p9();
};
if (ui == 10)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p10();
}
if (ui == 11)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p11();
}
if (ui == 12)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p12();
}
if (ui == 13)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p13();
}
if (ui == 14)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p14();
}
if (ui == 15)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p15();
}
if (ui == 16)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p16();
}

if (ui == 17)
{
    Console.WriteLine($"Ati accesat problema {ui}");
    p17();
}

void p1()
{
    int nr = 0;
    int n=int.Parse(Console.ReadLine());
    for(int i = 0; i < n; i++)
    {
       int x=int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            nr++;
        }
    }
    Console.WriteLine(nr);
}
void p2()
{
    int neg = 0;
    int poz = 0;
    int nul = 0;
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        if (x < 0)
        {
            neg++;
        }
        if (x == 0)
        {
            nul++;
        }
        if (x > 0)
        {
            poz++;
        }
    }
    Console.WriteLine($"In secventa introdusa sunt {neg} numere negative, {nul} 0-uri, {poz} numere pozitive");
}
void p3()
{
    ulong n = ulong.Parse(Console.ReadLine());
    ulong p = 1;
    ulong s = 0;
    for(ulong i = 1; i<=n; i++)
    {
        s += i;
        p *= i;
    }
    Console.WriteLine($"Suma numerelor de la 1 pana la {n} este {s}");
    Console.WriteLine($"Produsul numerelor de la 1 pana la {n} este {p}");
}
void p4()
{
    int n = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    int poz = -1;
    for(int i = 0; i < n; i++)
    {
        int x=int.Parse(Console.ReadLine());
        if (x == a)
        {
            poz = i;
            
        }
    }
    if (poz==-1)
    {
        Console.WriteLine($"{poz}");
    }
    else
        Console.WriteLine($"Pozitia lui {a} este {poz}");
}
void p5()
{
    int n = int.Parse(Console.ReadLine());
    int nr = 0;
    for (int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        if (x == i)
        {
            nr++;
        }
    }
    Console.WriteLine(nr);
}
void p6()
{
    int n = int.Parse(Console.ReadLine());
    bool ok = true;
    int x1 = int.Parse(Console.ReadLine());
    for (int i = 1; i < n; i++)
    {
        int x2= int.Parse(Console.ReadLine());
        if (x1>x2)
        {
            ok = false;
        }
        x1 = x2;
    }
    if (ok)
    {
        Console.WriteLine($"Sirul este in ordine crescatoare");
    }
    else
        Console.WriteLine($"Sirul nu este in ordine crescatoare");
}
void p7()
{
    int n=int.Parse(Console.ReadLine());
    int min = 0;
    int max = 0;
    for(int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        if (min == 0)
        {
            min = x;
        }
        if (x < min)
        {
            min = x;
        }
        if (x > max)
        {
            max = x;
        }
    }
    Console.WriteLine($"Minimul sirului este {min}, iar maximul sirului este {max}");
}
void p8()
{
    int n = int.Parse(Console.ReadLine());
    int f1 = 0;
    int f2 = 1;
    int fn = 0;
    for(int i=2;i<=n; i++)
    {
        fn = f2 + f1;
        f1 = f2;
        f2 = fn;
       }
    Console.WriteLine($"{fn}");
}
void p9()
{
    int n = int.Parse(Console.ReadLine());
    bool ok1 = true;
    bool ok2 = true;
    int x1 = int.Parse(Console.ReadLine());
    for (int i = 1; i < n; i++)
    {
        int x2 = int.Parse(Console.ReadLine());
        if (x1 > x2)
        {
            ok1 = false;
        }
        if (x1 < x2)
        {
            ok2 = false;
        }
        x1 = x2;
    }
    if (ok1 || ok2)
    {
        Console.WriteLine($"Sirul este monoton");
    }
    else
        Console.WriteLine($"Sirul nu este monoton");
}
void p10()
{
    int n = int.Parse(Console.ReadLine());
    int nrmax = 1;
    int nr = 1;
    int x1 = int.Parse(Console.ReadLine());
    for (int i = 1; i < n; i++)
    {
            int x2 = int.Parse(Console.ReadLine());
            if (x1 == x2)
            {
                nr++;
            }
            else
                nr = 1;
            if (nr > nrmax)
            {
                nrmax = nr;
            }
        x1 = x2;
    }
    Console.WriteLine($"Numarul maxim de numere conscutive din secventa este {nrmax}");
}
void p11(){
    int n = int.Parse(Console.ReadLine());
    int suma = 0;
    for(int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        int xinv = 0;
        while (x > 0)
        {
            xinv = xinv * 10 + x % 10;
            x /= 10;
        }
        suma += xinv;
    }
    Console.WriteLine(suma);
}
void p12()
{
        int n = int.Parse(Console.ReadLine());
        int nr = 0;
        int x1 = int.Parse(Console.ReadLine());
        if (x1 != 0)
            nr++;
        for (int i = 1; i < n; i++)
        {
            int x2 = int.Parse(Console.ReadLine());
            if (x2 != 0 && x1 == 0)
                nr++;
            x1 = x2;
        }
        Console.WriteLine(nr);

 }
void p13()
{
    int n = int.Parse(Console.ReadLine());
    int x1 = int.Parse(Console.ReadLine());
    int prim = x1;
    int bec = 0;
    for (int i = 1; i < n; i++)
    {
        int x2 = int.Parse(Console.ReadLine());
        if (x1 > x2)
        {
            bec++;
        }
        x1 = x2;
    }
    if (bec == 1 && prim > x1)
    {
        Console.WriteLine($"Secventa este crescatoare rotita");
    }
    else Console.WriteLine($"Secventa nu este crescatoare rotita");
}
void p14()
{
    int n = int.Parse(Console.ReadLine());
    int x1 = int.Parse(Console.ReadLine());
    int prim = x1;
    int bec1 = 0;
    int bec2 = 0;
    for (int i = 1; i < n; i++)
    {
        int x2 = int.Parse(Console.ReadLine());
        if (x1 > x2)
        {
            bec1++;
        }
        if (x1 < x2)
        {
            bec2++;
        }
        x1 = x2;
    }
    if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1))
    {
        Console.WriteLine($"Secventa este monotona rotita");
    }
    else Console.WriteLine($"Secventa nu este monotona rotita");
}
void p15()
{
    int n, x, y;
    bool? crescator = null;
    bool ok = true, switched = false;
    n = int.Parse(Console.ReadLine());
    x = int.Parse(Console.ReadLine());
    for (int i = 1; i < n; i++)
    {
        y = int.Parse(Console.ReadLine());
        if (x < y)
        {
            if (!crescator.HasValue)
            {
                crescator = true;
            }
            else if (!crescator.Value && !switched)
            {
                switched = true;
                crescator = true;
            }
            else if (!crescator.Value && switched)
            {
                ok = false;
            }
        }
        if (x > y)
        {
            if (!crescator.HasValue)
            {
                crescator = false;
            }
            else if (crescator.Value && !switched)
            {
                switched = true;
                crescator = false;
            }
            else if (crescator.Value && switched)
            {
                ok = false;
            }
        }
        x = y;
    }
    if (ok && switched == true)
    {
        Console.WriteLine("Secventa este bitonica");
    }
    else
    {
        Console.WriteLine("Secventa nu este bitonica");
    }
}

void p16()
{
    int n = int.Parse(Console.ReadLine());
    int x1 = int.Parse(Console.ReadLine());
    bool? crescator = null;
    bool ok = true, switched = false;
    int prim = x1;
    int bec1 = 0;
    int bec2 = 0;
    for (int i = 1; i < n; i++)
    {
        int x2 = int.Parse(Console.ReadLine());
        if (x1 > x2)
        {
            bec1++;
        }
        if (x1 < x2)
        {
            bec2++;
        }
        x1 = x2;
        if (x1 < x2)
        {
            if (!crescator.HasValue)
            {
                crescator = true;
            }
            else if (!crescator.Value && !switched)
            {
                switched = true;
                crescator = true;
            }
            else if (!crescator.Value && switched)
            {
                ok = false;
            }
        }
        if (x1 > x2)
        {
            if (!crescator.HasValue)
            {
                crescator = false;
            }
            else if (crescator.Value && !switched)
            {
                switched = true;
                crescator = false;
            }
            else if (crescator.Value && switched)
            {
                ok = false;
            }
        }
        x1 = x2;
    }
    if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1) && ok && switched == true)
    {
        Console.WriteLine($"Secventa este bitonica rotita");
    }
    else
        Console.WriteLine($"Secventa nu este bitonica rotita");
}
void p17()
{
    string[] t =Console.ReadLine().Split(' ');
    int zero = 0;
    int unu = 0;
    int a = 0;
    int incuibare = 0;
    int incuibaremax = 0;
    for(int i=0; i < t.Length; i++)
    {
        a = int.Parse(t[i]);
        if(a == 0)
        {
            zero++;
            incuibare++;
        }
        if(a == 1)
        {
            unu++;
            incuibare = 0;
        }
        if (incuibare > incuibaremax)
            incuibaremax = incuibare;
    }
    if (t[0] == "1" || t[t.Length - 1] == "0")
        Console.WriteLine($"Secventa este incorecta");
    else if (unu == zero && a != 0)
        Console.WriteLine($"Secventa este corecta si incuibarea maxima este {incuibaremax}");
    else
        Console.WriteLine($"Secventa este incorecta");
}