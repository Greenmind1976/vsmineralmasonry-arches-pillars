using System;
using System.Linq;
using Vintagestory.API.Common;

namespace VSMineralMasonry;

public class VSMineralMasonryModSystem : ModSystem
{
    private const string ModId = "vsmineralmasonryarchespillars";
    private const string MuralSlabsModId = "vsmineralmasonrymuralslabs";

    public override double ExecuteOrder()
    {
        // Run before block and recipe registration so optional burnished content can
        // disappear cleanly when Mural Slabs is not installed.
        return 0.05;
    }

    public override void AssetsLoaded(ICoreAPI api)
    {
        if (api.ModLoader.IsModEnabled(MuralSlabsModId))
        {
            return;
        }

        int removedBlocktypes = RemoveMatchingAssets(api, "blocktypes/stone", IsBurnishedBlocktype);
        int removedRecipes = RemoveMatchingAssets(api, "recipes/grid/stone", IsBurnishedRecipe);

        api.Logger.Notification(
            "[{0}] {1} is not enabled; skipped {2} burnished blocktype assets and {3} burnished recipe assets.",
            ModId,
            MuralSlabsModId,
            removedBlocktypes,
            removedRecipes
        );
    }

    private static int RemoveMatchingAssets(ICoreAPI api, string pathPrefix, System.Func<AssetLocation, bool> shouldRemove)
    {
        AssetLocation[] locations = api.Assets.GetLocations(pathPrefix, ModId)
            .Where(shouldRemove)
            .ToArray();

        foreach (AssetLocation location in locations)
        {
            api.Assets.AllAssets.Remove(location);
        }

        return locations.Length;
    }

    private static bool IsBurnishedBlocktype(AssetLocation location)
    {
        return location.Path.StartsWith("blocktypes/stone/burnished");
    }

    private static bool IsBurnishedRecipe(AssetLocation location)
    {
        return location.Path.StartsWith("recipes/grid/stone/burnished")
            && location.Path.EndsWith("-fromburnished.json");
    }
}
