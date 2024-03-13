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
- kontakt na autora: gruncl.michal@femboy.in
- kontakt na organizaci: info@femboy.in


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

# Vlastnosti systému
## Vlastnost A - Tvorba témat
- ID: A1
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
1A: Tvorba témat 


## Vlastnost C - Obnovení RSS souborů
- ID: 3A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 
Po otevření témata či stištění určeného tlačítka program vyvolá všechny odkazy RSS a stáhne tak do příslušné složky všechny nové soubory RSS. Hned po té co se stáhnou všechny RSS soubory se také začnou formovat z nich odozené články ().

### Kritérium akceptovatelnosti 
Po spuštění události jak přes otevření složky tak přes tlačítko se stáhnou požadované soubory, uloží se na správné místo a spustí se funkce zodpovědná za vyzobrazení článků.
  
### Souvislosti 
???


## Vlastnost _ - 
- ID: A
- Typ: Funkční
- Vlastník: Vyučující předmětu MVOP-PVA 
- Priorita: Vysoká
- Urgence: Střední

### Popis 

  
### Kritérium akceptovatelnosti 

  
### Souvislosti 
