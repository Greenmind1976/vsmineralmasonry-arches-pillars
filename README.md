# VSMineralMasonry - Arches and Pillars

Standalone Vintage Story mod for the refined structural stonework pieces from VSMineralMasonry.

## Included Content

- Burnished arches
- Burnished pillars
- Burnished pillar bases and tops
- Burnished thin pillars
- Burnished thin pillar bases and tops

## Build

Set `VINTAGE_STORY` to your Vintage Story app folder, then build the project:

```bash
dotnet build VSMineralMasonry.ArchesPillars.csproj -c Release -p:NuGetAudit=false
```

## Release Package

Create a distributable zip with:

```bash
./release.sh
```

## Local Install

Install the built mod into your local Vintage Story app with:

```bash
./build-install.sh
```
