using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(TopCameraMod.BuildInfo.Description)]
[assembly: AssemblyDescription(TopCameraMod.BuildInfo.Description)]
[assembly: AssemblyCompany(TopCameraMod.BuildInfo.Company)]
[assembly: AssemblyProduct(TopCameraMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TopCameraMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(TopCameraMod.BuildInfo.Company)]
[assembly: AssemblyVersion(TopCameraMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TopCameraMod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(TopCameraMod.TopCameraMod), TopCameraMod.BuildInfo.Name, TopCameraMod.BuildInfo.Version, TopCameraMod.BuildInfo.Author, TopCameraMod.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]