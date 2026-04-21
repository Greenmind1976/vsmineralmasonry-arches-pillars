# VSMineralMasonry - Arches and Pillars

`VSMineralMasonry - Arches and Pillars` is a focused building mod for players who want cleaner stone structure pieces without pulling in the full Mineral Masonry set.

It adds a compact library of burnished stone support pieces for framing entrances, colonnades, facades, interiors, and other formal builds where plain cubes feel too heavy.

## What It Adds

- Burnished arches
- Burnished pillars
- Burnished pillar bases and tops
- Burnished thin pillars
- Burnished thin pillar bases and tops

## Best Use Cases

- Building temple, civic, and manor-style exteriors
- Breaking up flat stone walls with vertical support pieces
- Adding lighter trim and structure to interiors
- Creating repeated archways, cloisters, and covered walkways

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

Install the built mod into your local Vintage Story app with the script for the game version you are testing:

```bash
./build-install.sh
```

For 1.21.7 testing, use `./build-install.sh`. For 1.22 testing, use `./build-122-install.sh` from the `support/1.22` branch.
