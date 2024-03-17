# SRS: RSS Čtečka
- Verze: 1.0
- Datum vytvoření: 10.3.2024
- Autor: Gruncl Michal
- Shrnutí: Okenní aplikace pro shromažďování článků pomocí technologie RSS.


# Úvod
### Účel
Aplikace bude umožňovat uživateli využít technologie RSS pro snadnější vyhledávání požadovaných informací.

### Cílová skupina 
Cílovím uživatelem bude člověk, který chce zůstat v obraze v tématech, která si sám vybere. Pravděpodobně bude technologicky zběhlejší avšak bude potřebovat myslet i na lidi v technologiích méně zběhlích. Bude to pravděpodobně člověk který ocenní možnost si informace sám nějak uspořádat. 

### Další informace
Zatím žádné další informace


### Kontakty
- kontakt na autora: gruncl.mi.2021@skola.ssps.cz


### Odkazy na další dokumenty
Zatím žádné další dokumenty


# Celkový popis
### Popis produktu jako celek
Produkt bude okenní aplikace spouštěná přes .exe soubor. 


### Funkce
Po spuštění se otevře jednoduchá okenní aplikace. Hlavní funkcí programu bude možnost si vytvořit jednotlivé složky (témata), kterým pak bude uživatel moct přiřadit jednotlivé RSS odkazy. Po otevření složky či stištění příslušného tlačítka pro obnovení se načte nejnovější RSS soubor na jehož základě se uživateli zobrazí jednotlivé články. Každé téma rovněž bude mít dvě kategorie: "Nové" a "Historie". V kategorii "Nové" se budou zobrazovat pouze články, které vznikli od minulého načtení RSS. V kategorii "Historie" se budou zobrazovat články z celého nového souboru. 


### Provozní prostředí
PC


### Uživatelské prostředí
Windows Presentation Foundation


### Požadavky a závislosti
Po zanedbání zpoždění internetového připojení by se nové příspěvky neměli načítat déle než 5s. 


# Požadavky na rozhraní
### Uživatelské rozhraní
Uživatelské rozhraní se bude skládat ze 2 hlavních částí. Panel vpravo bude sloužit pro tvorbu nových či výběr a mazání již existujících témat. Rovněž zde pomocí určených tlačítek bude uživatel moct upravovat list RSS odkazů jednotlivých témat, či si načíst nový RSS soubor. V panelu napravo se pak budou zobrazovat jednotlivé články. V horní části pravého panelu pak bude moct uživatel přepínat mezi kategoriemi: "Nové" a "Historie". 

### Softwarové rozhraní
N/A

### Hardwarové rozhraní
N/A

# Funkční vlastnosti systému
## Vlastnost A - Tvorba témat
- ID: 1A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA
- Priorita: Vysoká
- Urgence: Střední

### Popis
Po stisknutí určeného tlačítka dostane Uživatel možnost zadat jméno tématu. Po potvrzení se v souborech vytvoří nová složka se jménem které uživatel poskytnul. Uvnitř složky se vytvoří soubor obsahující všechny RSS odkazy určené pro dané téma a později se sem budou ukládat soubory RSS. 

### Kritérium akceptovatelnosti
Po zadání jména a potvrzení se vytvoří nová složka se jménem tématu a program jí uvidí a bude schopen s ní pracovat.

### Souvislosti
Zatím žádné


## Vlastnost B - Přidání RSS odkazu
- ID: 2A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis
Po stisknutí určitého tlačítka se otevře textové pole díky kterému bude uživatel schopen měnit list RSS odkazů jednotlivých témat. Tento list se poté bude ukládat ve složce příslušného tématu.

### Kritérium akceptovatelnosti
Uživatel je skrze aplikaci schopen měnit list RSS odkazů jednotlivých témat.

### Souvislosti
1A - Tvorba témat 


## Vlastnost C - Obnovení RSS souborů
- ID: 3A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 
Po otevření témata či stištění určeného tlačítka program vyvolá všechny odkazy RSS a stáhne tak do příslušné složky všechny nové soubory RSS. Hned po té co se stáhnou všechny RSS soubory se také začne formovat list požadovaných článků ([1B](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/SRS.md#vlastnost-d---tvorba-%C4%8Dl%C3%A1nk%C5%AF)).

### Kritérium akceptovatelnosti 
Po spuštění události jak přes otevření složky tak přes tlačítko se stáhnou požadované soubory, uloží se na správné místo a spustí se funkce zodpovědná za tvorbu listu požadovaných článků. 
  
### Souvislosti 
1B - Tvorba listu článků


## Vlastnost D - Tvorba článků
- ID: 4A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 
Po vybrání listu článků ([A5](https://github.com/MikeTheFoxFromDream/RssReader/blob/main/README.md#vlastnost-e---vybr%C3%A1n%C3%AD-listukategorie)) se spustí funkce zodpovědná za tvorbu článků. Pro každý požadovaný článek se vytvoří vlastní karta. Karta bude v levé části obsahovat obrázek (pokud nebude obrázek poskytnut tak bude existovat výchozí varianta) a v pravé části pak bude nadpisek článku. Celá karta bude fungovat jako kliknutelný odkaz, který uživatele nasměruje na článek.
  
### Kritérium akceptovatelnosti 
Karty se utvoří v popsaném stylu a po kliknutí přesměrují uživatele na správnou stránku.
  
### Souvislosti 
5A - Vybírání listu/kategorie


## Vlastnost E - Vybrání listu/kategorie
- ID: 5A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Střední
- Urgence: Střední

### Popis 
Na vrchu stránky se bude dát pomocí přepínače změnit kategorie (Nové/Historie). V kategorii "Nové" se nám ukazují poze články nahrané po datu poslední obnovy, v "Historieů pak všechny. V základu bude nastaven stav kdy se ukazují pouze nové články. Pokud bude list článků prázdný, či nepřibudou žádné nové články, tak se na panelu zobrazí příslušné hlášení.

### Kritérium akceptovatelnosti 
Při vybrání katgorie Nové se budou ukazovat pouze nové články. Při vybrání kategorie Historie se nám zobrazí všechny články. Je-li daná kategrie prázdná, zobrazí se příslušné hlášení.
  
### Souvislosti 
4A - Tvorba článků


# Nefunkční vlastnosti systému
## Vlastnost A - Tvorba listu článků
- ID: 1B
- Typ: Nefunkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 
Po načtení RSS souborů budeme muset uspořádat články do listu článků seřazeného podle data vydání. Záznam o každém článku by měl obsahovat: nadpis, datum vydání/úpravy, jméno autora a odkazy na článek příadně na náhledový obrázek.

### Kritérium akceptovatelnosti 
Po načtení nových RSS souborů se vytvoří list článků, kde každý záznam o článku obsahuje uvedené informace.
  
### Souvislosti 
3A - Obnovení RSS souborů


## Vlastnost B - Ukládání poseldního data
- ID: 2B
- Typ: Nefunkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 
Když nastane událost stahování nového souboru RSS tak ještě před započatím příslušných procesů se uloží informace o datu posledního nahraného příspěvku v aktuálním RSS souboru.

### Kritérium akceptovatelnosti 
Před stáhnutím nového souboru se uloží v souborech datum posledního nahraného článku.
  
### Souvislosti 
???
