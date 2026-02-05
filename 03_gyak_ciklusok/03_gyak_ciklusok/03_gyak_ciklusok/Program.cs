// WHILE - elöltesztelő ciklus

// 1. írjuk ki a számokat 1-10-ig
/*int n = 1;
// amíg n értéke kisebb, mint 11
while(n <= 10) {
    Console.WriteLine(n);
    n++; // n += 1; // n = n + 1;
}*/

// 2. írjuk ki a számokat 10-1-ig
/*int m = 10;

// amíg m értéke nagyobb vagy =, mint 1
while (m > 0) {
    Console.WriteLine(m);
    m--; // m -= 1; // m = m - 1;
}*/

// 3. írjuk ki az első 20 páros számot
/*int n = 0;

while(n <= 20) {
    if(n % 2 == 0) { // a szám páros
        Console.WriteLine(n);
    }
    n++;
}*/

// 4. elágazás nélkül, hatékonyabb verzió
/*int n = 0;

while (n <= 20) {
    Console.WriteLine(n);
    n+=2; // n = n + 2
}*/

// kérjünk be a felhasználótól 0 végjelig értékeket
// ha beírja a 0-át, akkor megáll a ciklus
/*int szam = -1;
// addig ismételje, amíg a szam változó értéke NEM egyenlő 0-val
while(szam != 0) {
    Console.WriteLine("Kérek egy számot:");
    szam = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A beírt szám: {szam}");
}*/

// írjuk ki a számokat 20-tól 10-ig csökkenő sorrendben
/*int szam = 20;

while(szam >= 10) {
    Console.WriteLine(szam);
    szam--;
}*/

// DO-WHILE
// kérjünk be számokat 0 végjelig
/*int szam;
// 1x mindenképpen lefut, nem érdekli a feltétel (hátul tesztel)
do {
    Console.WriteLine("Írj be egy számot:");
    szam = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A bekért szám: {szam}");
} while (szam != 0);*/

// kérd be a user nevét, de NE FOGADJ EL üres stringet ""
// amíg üres stringet ír be, addig kérjük be a nevet

/*string nev;

do {
    Console.WriteLine("Írd be a neved:");
    nev = Console.ReadLine();
    Console.WriteLine($"A neved: {nev}");
} while (nev.Equals(""));*/
// stringek esetében a string.Equals() -> a == operátor primitíveknél használatos

// kérjünk be a usertől számokat, de CSAK 1 és 7 közöttit fogadjunk el
// majd írjuk ki SWITCH szerkezettel, hogy hétköznap / hétvége van
/*int szam;

do {
    Console.WriteLine("Kérek egy számot:");
    szam = Convert.ToInt32(Console.ReadLine());
} while (szam < 1 || szam > 7);
// mindig azt fogalmazom meg, amit NEM FOGADOK EL

switch(szam) {
    case 1: case 2: case 3: case 4: case 5:
        Console.WriteLine("Hétköznap"); break;
    case 6: case 7:
        Console.WriteLine("Hétvége"); break;
}*/

// kérj be egy számot és írj ki annyi db. XO jelet
// a szám nem lehet 1-nél kisebb

/*int szam;
do {
    Console.WriteLine("Kérek egy számot:");
    szam = Convert.ToInt32(Console.ReadLine());
} while (szam < 1);

while(szam > 0) {
    Console.Write("XO");
    szam--;
}*/

// kérj be a usertől egy számot (nem kell ciklusba)
// a kapott számot írd ki csökkenő sorrendben 0-ig
// pl.: 5 -> 5, 4, 3, 2, 1, 0

/*Console.WriteLine("Kérek egy számot:");
int szam = Convert.ToInt32(Console.ReadLine());

do {
    Console.Write($"{szam}, ");
    szam--;
} while (szam >= 0);*/

// break vs. continue kulcsszavak
/*int n = 0;

// true = végtelen ciklus -> KELL KILÉPÉSI FELTÉTEL
while(true) {
    n++;
    if(n % 2 == 1) { continue; } // páratlanokat átugorjuk
    Console.WriteLine(n);
    if (n >= 10) break; // ha 10 az n értéke -> kilépek
}*/

// bemenet validálás
int n;
while (true)
{
    Console.WriteLine("Kérek egy egész számot:");
    // int.TryParse - próbálja ráilleszteni az int értéket
    // out n -> ha ráilleszthető, akkor rakja az n változóba
    if (int.TryParse(Console.ReadLine(), out n))
    {
        break; // kilépek a ciklusból, ha JÓ, EGÉSZET adott a user
    }
    Console.WriteLine("Nem egész szám, próbáld újra!");
}
Console.WriteLine($"Köszi, n = {n}");