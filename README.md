# KayPro

A small WinForms desktop app (C# / .NET Framework) for keeping a library of
technical documents: it stores records in a local database, lists them in a
grid, and opens the attached file.

Kept as the last working version of five attempts that were on the backup
drive (2022–2023):

| Revision | Approach | Status |
|---|---|---|
| `Trial1KayPro` | single form, hard-coded paths | superseded |
| `Trial1KayProWeb` | WebForms + WinForms hybrid | superseded |
| `Trial2KayProWeb` | ASP.NET `Startup.cs` restructure | dropped |
| `KayProWeb` | pure ASP.NET page with JSON data | dropped |
| **`TrialKayPro`** | WinForms + `Database.cs` + `LiteratureForm` | **published here** |

Built with Visual Studio 2022. Open `TrialKayPro.sln`.

MIT licensed — see [LICENSE](LICENSE).

## Database configuration

No credentials are stored in the source. Set the MySQL connection through
environment variables before running:

| Variable | Default |
|---|---|
| `KAYPRO_DB_SERVER` | `localhost` |
| `KAYPRO_DB_USER` | `root` |
| `KAYPRO_DB_PASSWORD` | *(empty)* |
| `KAYPRO_DB_NAME` | `kaypro` |
