# Calculator Application

## Acceptanstester

### Test 1: Addition

#### Instruktioner
1. Öppna applikationen.
2. Välj Addition i menyn.
3. Ange två tal för addition (till exempel, `1` och `1`).
4. Tryck på ENTER.
5. Kontrollera att resultatet visar `2`.

#### Förväntat resultat
Applikationen ska returnera summan av de två inmatade talen. För ovanstående exempel ska resultatet vara `2`.

### Test 2: Subtraktion

#### Instruktioner
1. Öppna applikationen.
2. Välj Subtraktion i menyn.
3. Ange två tal för subtraktion (till exempel, `5` och `3`).
4. Tryck på ENTER.
5. Kontrollera att resultatet visar `2`.

#### Förväntat resultat
Applikationen ska returnera differensen av de två inmatade talen. För ovanstående exempel ska resultatet vara `2`.

### Test 3: Multiplikation

#### Instruktioner
1. Öppna applikationen.
2. Välj Multiplikation i menyn.
3. Ange två tal för multiplikation (till exempel, `2` och `3`).
4. Tryck på ENTER.
5. Kontrollera att resultatet visar `6`.

#### Förväntat resultat
Applikationen ska returnera produkten av de två inmatade talen. För ovanstående exempel ska resultatet vara `6`.

### Test 4: Division

#### Instruktioner
1. Öppna applikationen.
2. Välj Division i menyn.
3. Ange två tal för division (till exempel, `10` och `2`).
4. Tryck på ENTER.
5. Kontrollera att resultatet visar `5`.

#### Förväntat resultat
Applikationen ska returnera kvoten av de två inmatade talen. För ovanstående exempel ska resultatet vara `5`.

### Test 5: Division med noll

#### Instruktioner
1. Öppna applikationen.
2. Välj Division i menyn.
3. Ange ett tal för täljaren (till exempel, `1`) och `0` för nämnaren.
4. Tryck på ENTER.
5. Kontrollera att applikationen visar ett felmeddelande.

#### Förväntat resultat
Applikationen ska generera ett felmeddelande för att nämnaren är noll och kasta ett undantag av typen `DivideByZeroException`.

### Test 6: Visa resultat

#### Instruktioner
1. Öppna applikationen.
2. Utför en beräkning (till exempel, `3 + 4`).
3. Kontrollera så att konsolutdata ger rätt information.

#### Förväntat resultat
Applikationen ska visa resultatet av beräkningen med formatet:
`Result: {num1} {symbol} {num2} = {result}`
För exemplet ovan ska resultatet vara: `Result: 3 + 4 = 7`.

### Test 7: Visa tidigare beräkningar

#### Instruktioner
1. Öppna applikationen.
2. Utför en beräkning av valfritt räknesätt.
3. Gå tillbaka till menyn igen.
4. Välj alternativet för att visa tidigare beräkningar.
5. Kontrollera att beräkningen visas på rätt sätt.

#### Förväntat resultat
Applikationen ska lista alla tidigare beräkningar med formatet:
`{Number1} {MathOperation} {Number2} = {Result} (Date of Calculation: {DateOfCalculation})`.
