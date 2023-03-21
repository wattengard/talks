# Notater

Yes, the notes are in norwegian, these are my notes while doing the talk 😊

## "Kapittel"

### myp1: Nyopprettet blazor wasm app uten endringer
Vi lager en ny blazor wasm app med dotnet new blazorwasm. Vi får en standard app med en teller og en side som simulerer henting av været.

> Vis fram teller, værside. Og så kode for teller, været og endepunktet den henter fra i `wwwroot/sample-data`.

### myp2: Håndtere state i minnet
Vi må lagre state for telleren en plass. Vi kan lage oss en tjeneste for det. Denne tjenesten legger vi i dependencyinjectoren med `.AddScoped`. For Blazor webassembly er det i praksis ingen forskjell på `.AddScoped` og `.AddSingleton` da applikasjonen lever i nettleseren. For Blazor Server ville man brukt `.AddTransient` her for å unngå å dele state mellom brukere...

Dette er overhodet ikke et godt eksempel på hvordan man lager en statecontainer... Det er en grunn til at Redux og Flux ikke er 20 linjer lang... Men det viser poenget 😊

> Vis fram `StateManager.cs`, `Program.cs` og endringene vi har gjort i `Counter.razor` for å få state til å fungere. 

### myp3: Legge state i localstorage istedet.
Å lagre state i en dictionary som ligger i minnet er litt begrensende da den nullstilles hver gang man laster applikasjonen på nytt. En vanlig løsning er derfor å legge state i localstorage. For å gjøre det litt lettere for oss selv så bruker vi en pakke fra Chris Sainty som heter Blazored.LocalStorage. For enkelthets skyld i denne presentasjonen implementerer vi lagring i localstorage kun for counter siden.

> Vis frem `MyPenguins.csproj` for å se innslag i packagereference. Vis frem `Program.cs` for å vise at vi legger den i services. Vis fram `Counter.razor` for å se endringer for å lagre i localstorage.

### myp4: Vi fikser på vær-siden så den faktisk henter været.
Vær siden i standardprosjektet henter været fra en statisk json fil. Hadde det ikke vært gøy om vi kunne fått den til å hente været fra YR istedet?