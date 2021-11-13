namespace TimberbornAPI.AssetLoader
{
    public interface IAssetLoaderSystem
    {
        /// <summary>
        /// Adds assets to a scene that are placed in the assetLocation
        /// </summary>
        /// <param name="prefix">prefix to find mod related asset, same prefix can be used in different entry points</param>
        /// <param name="assetEntryPoint">In what scene does the asset need to be loaded</param>
        /// <param name="assetLocation">root location relative to where the DLL is placed</param>
        void AddSceneAssets(string prefix, IAssetLoaderSystem.EntryPoint assetEntryPoint, string[] assetLocation);
        
        /// <summary>
        /// Adds assets to a scene that are placed in the asset folder relative to the dll
        /// </summary>
        /// <param name="prefix">prefix to find mod related asset, same prefix can be used in different entry points</param>
        /// <param name="assetEntryPoint">In what scene does the asset need to be loaded</param>
        void AddSceneAssets(string prefix, IAssetLoaderSystem.EntryPoint assetEntryPoint);
        
        /// <summary>
        /// Loads all assets for the given scene
        /// Not recommended to do this manually, this will effect all mods
        /// </summary>
        /// <param name="scene">timberborn scene</param>
        void LoadSceneAssets(IAssetLoaderSystem.EntryPoint scene);

        /// <summary>
        /// Unloads all assets for the given scene
        /// Not recommended to do this manually, this will effect all mods
        /// </summary>
        /// <param name="scene">timberborn scene</param>
        void UnloadSceneAssets(IAssetLoaderSystem.EntryPoint scene);

        public enum EntryPoint
        {
            Global,
            InGame,
            MainMenu,
            MapEditor
        }
    }
}