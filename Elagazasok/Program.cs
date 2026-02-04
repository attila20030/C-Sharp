// ÉRDEKESSÉGEK

// 1. lebegőpontos számítási hiba
/*double a = 0.1f; // f - float típus (kisebb)
double b = 0.2f;
double sum = a + b;
Console.WriteLine(sum);*/

// 2. Pontatlan eredmény osztásnál
//int result = 5 / 2;
// egész / egész = egész (levágja a tizedes pont utáni részt)
//Console.WriteLine(result);

// 3. nullával való osztás tört számoknál
/*double x = 10.0;
double y = 0.0;*/
// lebegőpontos számoknál NINCS HIBA, végtelent ír
//Console.WriteLine(x / y);

// ELÁGAZÁSOK

// Páros vagy páratlan szám vizsgálata
/*Console.WriteLine("Kérek egy számot:");
int szam = Convert.ToInt32(Console.ReadLine());*/

// 6 % 2 = megvan 3x, maradt: 0
// szam % 2 == 1 - páratlan szám vizsgálata
// szam % 2 == 0 - páros szám vizsgálata
/*if(szam % 2 == 0) { // páros szám vizsgálata
    Console.WriteLine("A szám páros!");
} else {
    Console.WriteLine("A szám páratlan!");
}*/

/*string nap = "Péntek";
int lovagok = 8;*/

// false || false -> false
// 8 >= 10 -> false || "Péntek" == "Szombat" -> false
/*if(lovagok >= 10 || nap.Equals("Szombat")) {
    Console.WriteLine("Hétvégi kocsmázás");
// true && true -> true
// 8 > 5 && "Péntek" == "Péntek"
} else if(lovagok > 5 && nap.Equals("Péntek")) {
    Console.WriteLine("Lovagi torna");
// EZ MÁR NEM FUT LE, MERT A FÖLÖTTE LÉVŐ TRUE VOLT
// true && true -> true
// 8 >= 8 && "Péntek" == "Péntek"
} else if(lovagok >= 8 && nap.Equals("Péntek")) {
    Console.WriteLine("Alvás");
} else {
    Console.WriteLine("Elővesszük a trójai fanyulat.");
}*/
// FALSE
// (false) || (false)
// (false && true) || (true && false)
// (2 > 3 && 1 == 1) || (3 <= 6 && 23 < 4)

// TERNARY OPERÁTOR
// feltétel ? igaz ág : hamis ág
// kötelező megadni MINDIG a hamis ágat

//int kor = 17;
/*Console.WriteLine(
    kor >= 18 ? "nagykorú" : "kiskorú"
);*/

/*Console.WriteLine(
    kor >= 18 ? "nagykorú" : 
    (kor >= 12 ? "tini" : "gyermek")
);*/

// SWITCH
int hetNapja = 4; // 1-7 (hétfő-vasárnap)

/*switch(hetNapja) {
    case 1: Console.WriteLine("Hétfő"); break;
    case 2: Console.WriteLine("Kedd"); break;
    case 3: Console.WriteLine("Szerda"); break;
    case 4: Console.WriteLine("Csütörtök"); break;
    case 5: Console.WriteLine("Péntek"); break;
    case 6: Console.WriteLine("Szombat"); break;
    case 7: Console.WriteLine("Vasárnap"); break;
    default: Console.WriteLine("Nincs ilyen nap"); break;
}*/
// default: egyéb ág, nem kötelező megadni -> ha egyik ágra sem fut le, akkor ezt választja
// break: minden ághoz meg kell adni, kilépés a switchből

/*switch(hetNapja) {
    // ha 1, 2, 3, 4 vagy 5 az értéke, ez a blokk fut le
    case 1: case 2: case 3: case 4: case 5 : {
        Console.WriteLine("Hétköznap");
        // több utasítás is beírható, ha {} blokkot használsz itt
    } break;
    case 6: case 7: Console.WriteLine("Hétvége"); break;
}*/

// Pattern matching
// ősosztály, minden típust magában foglal
/*object x = 42;
// ha az x object típusban INT van, akkor n-ként kezelje
if(x is int n) {
    Console.WriteLine($"Ez egy int, értéke: {n}");
}*/

// SWITCH + Pattern matching
//int szam = 4;
/*string eredmeny = szam switch{
    < 0 => "Negatív",
    0 => "Nulla",
    < 10 => "Egyszámjegyű pozitív",
    _ => "Nagy szám"
};
Console.WriteLine(eredmeny);*/

/*if(szam is > 0 and < 20) {
    Console.WriteLine("Pozitív és kisebb, mint 20");
}*/

/*int szam = 1255;
Console.WriteLine(
    szam >= 1000 && szam <= 2000 
    ? "megfelelő" 
    : "nem megfelelő"
);*/

// tagadás (negáció) -> felkiáltójel a logikai kifejezés előtt
//Console.WriteLine(!true);

/*int a = 29;
int b = 13;

if(a > b) 
    Console.WriteLine($"{a} > {b}, ennyivel: {a-b}");
else if(a < b) 
    Console.WriteLine($"{a} < {b}, ennyivel: {b-a}");
else
    Console.WriteLine($"{a} == {b}");*/

// 1. Kérd be a hónap számát a usertől
// és írd ki melyik évszakban van

// 2. Kérd be a user születési évét
// ill. hogy van-e nála személyi (bool)
// döntsd el, hogy beléphet-e a szórakozóhelyre

// 3. Kérj be egy számot és döntsd el, hogy 
// osztható-e 3-al VAGY 5-el



Console.WriteLine("Melyik hónap van? (1-12)");
int honap = Convert.ToInt32(Console.ReadLine());

switch (honap)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Tél"); break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Tavasz"); break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Nyár"); break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Ősz"); break;
    default: Console.WriteLine("Nincs ilyen hónap"); break;
}