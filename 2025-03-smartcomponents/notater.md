# Notater

## Slide 1: (intro)
Ikke en innføring i KI. Praktisk bruk.

## Slide 2: (smartkomponent)
En smart komponent tar input fra brukeren og behandler dette i en eller annen form for KI-modell, i dette tilfellet en LLM, en large language model, språkmodell. Den bruker naturlig språk for å gjøre om data til et bestemt format. Dette kalles Structured outputs og tvinger modellen til å benytte et bestemt utdataformat, i vårt tilfelle en json struktur.

## Slide 3: (modeller)
Tungt å kjøre modeller lokalt. Mange modeller å velge mellom. 7 mrd parametre er "greit nok" på min dell.

## Slide 4: (kjøre lokalt)
Bruker Ollama med OllamaSharp for eksemplene.
LM Studio litt enklere å komme i gang med.

## Slide 5: (parametre)
Forenklet, flere parametre, smartere modell.
On-device AI. Spesialsydde modeller for bruk på for eksempel en telefon eller en klokke.
Kundesupport bot. Spesielt opplært for å svare på en bestemt mengde spørsmål.

## Slide 6: (mistral)
Bruker Mistral 7B.
Har prøvd Codestral 12B, treig.

# DEMO TIME!

### Adresseeksempel:
Første eksempel ved bruk av codestral, en variant av mistral modellen laget spesielt for koding, brukte ett minutt ved testing.
Med "vanlig" mistral så bruker denne mellom 6 og 20 sekunder, og har et OK+ resultat.

### Tabellkomponent:
Kan spørres om å gjøre ting med tabellen. Har en tendens til å renske hele tabellen for data.

### Autocomplete:
"Fruit", "Accessories", "Dairy", "Snacks", "Softdrinks", "Alcoholic drinks", "General food", "Other"

### Takk for meg:
Steve Sanderson forklarer det mye bedre. 
