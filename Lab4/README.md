# **Լաբ 4 — using in, out, ref, params, and parameters by default values**

## Խնդրի դրվածքը

* Ստեղծել static A(), B(), C() մեթոդները, համապատասխանաբար in, out, ref, մոդֆիկատորները փորձարկելու համար
* Ստեղծել նաև SumValues(parasm … ) մեթոդը որը կգումարի մուտքում եկած ամբողջ թվերը, թվերի քանակը ֆիքսված չէ
* ցույց տալ թե ինչպես են աշխատում այս մեթոդները, Main() մեթոդում

## Կատարած առաջադրանքը

Կոդը՝ [Methods.cs](Methods.cs), [Program.cs](Program.cs)

Գործարկում՝ `dotnet run`

Արդյունքը.

```
=== in ===
A(in value)       = 14   (default multiplier = 2)
A(in value, 5)    = 35
value after A     = 7   (unchanged)

=== out ===
B(4, 6) -> sum = 10, product = 24

=== ref ===
counter before    = 5
after C(ref)      = 15   (default step = 10)
after C(ref, 100) = 115

=== params ===
SumValues()                = 0
SumValues(5)               = 5
SumValues(1, 2, 3)         = 6
SumValues(10, 20, 30, 40)  = 100
SumValues(arr)             = 30
```
