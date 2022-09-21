namespace AKnightsTale.MaicolBattistini.utils
{
    /// <summary>
    /// Utility to get application paths.
    /// </summary>
    public static class AppPaths
    {
        /// <summary>
        /// Get the path to a file in the application's data folder.
        /// </summary>
        /// <param name="pathsToAppend"></param>
        /// <returns></returns>
        public static string GetFilePath(params string[] pathsToAppend)
        {
            var appDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                , "unibo", App.AppName, App.AppVersion);
            
            if (Environment.GetCommandLineArgs().Contains("headless")) {
                appDir = Path.GetFullPath("build");
            }

            return Path.Combine(pathsToAppend.Prepend(appDir).ToArray());
        }
    }
}