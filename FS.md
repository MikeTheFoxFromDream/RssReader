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
| :----: | :--------------: | :-----: |
| 1. | Vše je v pořádku | Správný výsledek |
| 2. | V textovém poli nic není | Nad textovím polem se oběví červený nápis "Jméno nesmí být prázdné"  |
| 3. | V textovém poli je zakázaný znak | Nad textovím polem se oběví červený nápis "Pole nesmí obsahovat tyto znaky "/ :*?"<>|~" "

### Možnosti s tématy
Každé téma bude reprezenrováno kartou na **Listu témat**. Na každé kartě budou přítomna dvě tlačítka: **Smazat** (označené křížkem) a **Nastavení tématu** (označené ikonou ozubeného kolečka)
- Po stištění tlačítka **Smazat** se smaže složka o daném tématu uložená v souborech i se všemi dokumenty v ní. Dále jejho karta bude odebrána z **Listu témat**.
- Po stištění tlačítka **Nastavení tématu** se otevře okénko **List odkazů**. (více v kapitole: [Možnosti listu odkazů](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/FS.md#mo%C5%BEnosti-listu-odkaz%C5%AF))

### Možnosti listu odkazů
V okénku bude listview **Odkazy**, tlačítko **Přidat odkaz** a každý odakz v listu bude opatřen tlačítkem **Smazat odkaz** (označeno křížkem).
- Po stištění tlačítka **Smazat odkaz** se daný odkaz smaže ze souboru obsahujícím všechny RSS odkazy, dále se také vymaže záznam o jeho existenci z listview **Odkazy**.
- Po stištění tlačítka **Přidat odkaz** se objeví okénko **Text odkazu** obsahující textové pole s placeholderem "Odkaz", tlačítkem **Přidat odkaz** a tlačítko **Zrušit**. . Je-li v textovém poli alespoň jeden znak vytvoří se po stisknutí tlačítka **Přidat odkaz** nový záznam v listview a rovněž budou informace o jeho existenci zapsány do souboru obsahujícím všechny RSS odkazy.

| číslo  | Když... | Pak... |
| :----: | :--------------: | :-----: |
| 1. | Vše je v pořádku | Správný výsledek |
| 2. | V textovém poli nic není | Nad textovím polem se oběví červený nápis "Jméno nesmí být prázdné"  |

### Prohlížení tématu
