# **Լաբ 2 — Method overloading, default parameters**

## Խնդրի դրվածքը

* Ստեղծել static ToMultiplicate մեթոդը, 3 օրինակով, որը կնդունի x, N փոփոխականները
* N-ը կունենեա ըսկ լռելյայն (default) արժեք 2, կլինի int տիպի
* իսկ x-ը կլինի երեք տարբերակով int, double և string
* ֆունկցիան պիտի վերադարձնի N հատ x-երի գումարը, հատուկ սենց գրեցի որ string-ի դեպքն էլ հասկանալի լինի
* թեստավորել overloading-ի աշխատանքը Main() մեթոդում

## Կատարած առաջադրանքը

Կոդը՝ [Multiplicator.cs](Multiplicator.cs), [Program.cs](Program.cs)

Գործարկում՝ `dotnet run`

Արդյունքը.

```
Default N = 2:
  ToMultiplicate(5)      = 10
  ToMultiplicate(2.5)    = 5
  ToMultiplicate("ab")   = abab
Explicit N:
  ToMultiplicate(5, 4)   = 20
  ToMultiplicate(1.5, 3) = 4.5
  ToMultiplicate("Hi", 3) = HiHiHi
  ToMultiplicate(x: 7, N: 5) = 35
```
