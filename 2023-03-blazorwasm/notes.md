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
