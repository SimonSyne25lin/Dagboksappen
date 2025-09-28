# Dagboksappen
## Beskrivning
Dagboksappen är en konsolbaserad C#-applikation där användaren kan skriva, spara och läsa dagboksanteckningar. Anteckningarna lagras i en fil i JSON-format och kan sökas fram baserat på datum. Programmet innehåller en meny med olika alternativ och hanterar fel som ogiltig input eller saknad fil.

## Så kör du appen
1. Klona eller ladda ner projektet.
2. Öppna terminalen i projektmappen.
3. Kör kommandot:
   ```bash
   dotnet run

## I/O Exempel

Välj ett alternativ
1. Skriv ny anteckning
2. Anteckningslista
3. Sök anteckningar på datum
4. Spara
5. Läs fil
6. Avsluta

Val: 1
Skriv datum här: (YYYY-MM-DD)
2025-09-28
Skriv din anteckning här:
Idag lärde jag mig om filhantering i C#!
Anteckning tillagd.

## Reflektion
När jag började med dagboksappen visste jag inte hur man sparar data till en fil, men nu har jag lärt mig att använda JSON med hjälp av Copilot. Jag förstod att JSON är ett enkelt och strukturerat sätt att lagra information som passar bra ihop med C#. Jag valde att använda en List<DiaryEntry> för att lagra anteckningar eftersom det är lätt att lägga till och söka i. För att undvika krascher lärde jag mig att använda try/catch och logga fel till en separat fil. Jag använder DateTime.TryParse() för att kontrollera att datum är korrekt och ser till att texten inte är tom. Att jobba med Git och branches är fortfarande ganska nytt, men jag lärde mig hur man håller ordning på kod och samarbetar med sig själv. Det här projektet har hjälpt mig förstå hur olika delar av ett program hänger ihop och hur man bygger något som faktiskt fungerar.
