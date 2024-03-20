# FS: RSS čtečka
- verze: 1.0
- Datum vytvoření: 17.3.2024.
- Autor: Gruncl Michal
- Shrnutí: 
  
# Úvod
### Účel
Účelem dokumentu je detailní popsání funkcí aplikace a jejího designu

### Cílová skupina
Programátoři, testeři a zákazník

### Odkazy na další dokumenty
- SRS ([zde](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/SRS.md))

### Kontakty
- kontakt na autora: gruncl.mi.2021@skola.ssps.cz

# Scénáře
### Všechny reálné způsoby použití
Jen jeden, běžné uživatelské použití.

### Typy uživatelských rolí
- čtenář - Disponuje právy na tvorbu a manipulaci s tématy, přidávání RSS odkazů, čtení článků a přepínání kategorií požívání

# Celková hrubá architektura
## Pracovní tok
Zvýrazněný text odkazuje na obrázky v kapitole "Hlavní moduly"

### Vytvoření tématu
Po stisknutí tlačítka **Nové téma** se otevře okénko **Název tématu** obsahující textové pole s placeholderem "Jméno", tlačítko **Přidat** a tlačítko **Zrušit**. Je-li v textovém poli alespoň jeden znak a zároveň neobsahuje ani jeden ze zakázaných znaků (/, , :, *, ?, ", <, >, |, ~ ), vytvoří se po stisknutí tlačítka **Přidat** nová složka v souborech, se jménem, které bylo uvedeno v textovém boxu, v níž také bude vytovřen soubor "RSSOdkazy", v němž budou uchovávány veškeré RSS odkazy daného tématu. Rovněž se ve listview **témata** oběvý nová položka nesoucí totéž jméno. Zmáčkne-li uživatel tlačítko **Zrušit** okénko se zavře. 

| číslo  | Když... | Pak... |
| :----: | :----: | :----: |
| 1. | Vše je v pořádku | Správný výsledek |
| 2. | V textovém poli nic není | Nad textovím polem se oběví červený nápis "Jméno nesmí být prázdné"  |
| 3. | V textovém poli je zakázaný znak | Nad textovím polem se oběví červený nápis "Pole nesmí obsahovat tyto znaky "/ :*?"<>|~" " |

### Možnosti s tématy
Každé téma bude reprezenrováno kartou na **Listu témat**. Na každé kartě budou přítomna dvě tlačítka: **Smazat** (označené křížkem) a **Nastavení tématu** (označené ikonou ozubeného kolečka)
- Po stištění tlačítka **Smazat** se smaže složka o daném tématu uložená v souborech i se všemi dokumenty v ní. Dále jejho karta bude odebrána z **Listu témat**.
- Po stištění tlačítka **Nastavení tématu** se otevře okénko **List odkazů**. (více v kapitole: [Možnosti listu odkazů](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/FS.md#mo%C5%BEnosti-listu-odkaz%C5%AF))

### Možnosti listu odkazů
V okénku bude listview **Odkazy**, tlačítko **Přidat odkaz** a každý odakz v listu bude opatřen tlačítkem **Smazat odkaz** (označeno křížkem).
- Po stištění tlačítka **Smazat odkaz** se daný odkaz smaže ze souboru obsahujícím všechny RSS odkazy, dále se také vymaže záznam o jeho existenci z listview **Odkazy**.
- Po stištění tlačítka **Přidat odkaz** se objeví okénko **Přidání odkazu** obsahující textové pole s placeholderem "Odkaz", tlačítkem **Přidat odkaz** a tlačítko **Zrušit**. . Je-li v textovém poli alespoň jeden znak vytvoří se po stisknutí tlačítka **Přidat odkaz** nový záznam v listview a rovněž budou informace o jeho existenci zapsány do souboru obsahujícím všechny RSS odkazy.

| číslo  | Když... | Pak... |
| :----: | :----: | :----: |
| 1. | Vše je v pořádku | Správný výsledek |
| 2. | V textovém poli nic není | Nad textovím polem se oběví červený nápis "Jméno nesmí být prázdné" |

### Prohlížení tématu
Po kliknutí na kartu tématu (mimo vyhrazená tlačítka) na viewlistu **List témat** se ve viewlistu **List článku** oběví karty reprezentující jednotlivé články (**Článek** je příklad rozložení takovéto karty) seřazenné podle data vydání článku. Pokud se tak stalo poprvé pro dané téma od začátku běhu instance programu, stáhnou se nové RSS soubory a spracují se do listu v soubor "ListClanku".

| číslo  | Když... | Pak... |
| :----: | :----: | :----: |
| 1. | První kliknutí na téma od začátku běhu programu. | Stáhnou se nové soubory RSS, spracují se do listu a článků a zobrazí se jednotlivé články. |
| 2. | Druhé či více kliknutí na téma od začátku běhu programu. | Zobrazí se jednotlivé články načtené z listu článků. |


### Přepínání kategorie
Po kliknutí na binární přepínač **Přepínač kategorií** se změní kategorie prohlížení. Uživatel může přepínat mezi dvěmi kategoriemi: "Nové" a "Historie". Po přepnutí kategorie se znovu spustí funkce zodpovědná za zobrazování článků.
- Pokud je nastavená kategorie "Nové", při zobrazování článků se zobrazí pouze články nahrané od doby posledního načtení RSS souborů.
- Pokud je nastavená kategorie "Historie", při zobrazování článků se zobrazí dvacet posledních nahraných článků a tlačítko, které načte dalších 20 článků a další tlačítko.

### Přesměrování na článek
Po kliknutí na kartu článku se v primárním prohlížeči otevře odkaz na článek poskytnutý v RSS souboru.

## Hlavní moduly

### Hlavní okno
Dva viewListy, jeden pro témata **List témat** a druhý pro jdenotlivé články **List článků**. Tlačítko **Nové téma** které nám umožní přidat nové téma. Každé téma má také dvě tlačítka, **Nastavení tématu** (1.) pro změnu RSS odkazů a **Smazat téma** (2.) pro smazání tématu. Nad **Listem článků** máme **Přepínač kategorií** (3.). Dále pak máme v **Listu článků** dva příklady jednotlivých článků.

![Hlavní okno](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/img/HlavniOkno.png)
1. = **Nastavení tématu**
2. = **Smazat téma**
3. = **Přepínač kategorií**


### Název tématu
Textové pole **Název tématu** pro uživatelský vstup zodpovědný za pojmenovámí nového tématu. Dvě tlačítka, **Přidat** pro dokončeení akce tvorby nového tématu a **Zrušit** pro stornování akce. Dále zde je červený text **Error Text** kde se bude zobrazovat případná chybová hlášení.

![Název tématu](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/img/NoveTema.png)

### List odkazů
Dvě tlačítka, jedno pro přidání nového odkazu **Přidat odkaz** a druhé pro zavření okénka **Zavřít**. Je zde přítomné listview **Odkazy** v němž se shromažďují jednotlivé odkazy. Dále je zde reprezentace jednoho záznamu o odkazu **Odkaz** kde na levo je samotný odkaz a napravo je tlačítko **Smazat odkaz** (1.) které smaže záznam o daném odkazu.

![List odkazů](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/img/Odkazy.png)
1. = **Smazat odkaz**

### Přidání odkazu
Textové pole **Text odkazu** pro uživatelský vstup, zodpovědný za příjmutí RSS odkazu. Dvě tlačítka, **Přidat** pro dokončeení akce přijímání nového RSS odkazu a **Zrušit** pro stornování akce. Dále zde je červený text **Error Text** kde se bude zobrazovat případná chybová hlášení.


![Přidání odkazu](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/img/PridatOdkaz.png)
