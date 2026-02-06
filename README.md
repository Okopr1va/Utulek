# 🐾 Útulek pro zvířata

Konzolová aplikace v jazyce C# pro správu evidence zvířat v útulku.

## 📋 Popis

Aplikace umožňuje pracovníkům útulku jednoduše spravovat evidenci zvířat. Nabízí základní operace jako přidávání zvířat, vyhledávání, sledování adopcí a zobrazení statistik.

## ✨ Funkce

- **Přidání zvířete** – evidence nového zvířete s informacemi o jménu, druhu, věku a zdravotním stavu
- **Výpis všech zvířat** – přehledná tabulka všech zvířat v útulku
- **Vyhledávání podle druhu** – filtrování zvířat dle typu (pes, kočka, jiné)
- **Označení adopce** – zaznamenání adopce zvířete s datem
- **Statistiky** – celkový počet zvířat a počet adoptovaných

## 🏗️ Struktura projektu

```
utulek/
├── Model/
│   └── Zvire.cs          # Datový model zvířete
├── Services/
│   └── Evidence.cs       # Správa seznamu zvířat
├── UI/
│   └── KonzoleUI.cs      # Uživatelské rozhraní
└── Program.cs            # Vstupní bod aplikace
```

## 🚀 Spuštění

### Požadavky
- .NET Framework 4.x

### Kompilace a spuštění
```bash
# Přejděte do složky projektu
cd utulek

# Sestavte projekt
msbuild utulek.csproj

# Spusťte aplikaci
bin\Debug\utulek.exe
```

## 📖 Použití

Po spuštění se zobrazí hlavní menu:

```
===== UTULEK PRO ZVIRATA =====
1 - Pridat zvire
2 - Vypsat vsechna zvirata
3 - Vyhledat podle druhu
4 - Oznacit adopci
5 - Statistiky
0 - Konec
```

Vyberte možnost zadáním čísla a stiskněte Enter.
