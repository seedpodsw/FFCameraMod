using System;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace TopCameraMod
{
    public static class BuildInfo
    {
        public const string Name = "TopCameraMod"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "TopCameraMod"; // Description for the Mod.  (Set as null if none)
        public const string Author = "twitch.tv/topeveryday"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TopCameraMod : MelonMod
    {
        float maxAngle = 0;
        float maxDistanceFromTarget = 0;
        float maxFieldOfView = 0;
        float minDistanceFromTarget = 0;
        float minAngle = 0;
        public bool first = true;

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("OnApplicationStart");
        }

        public override void OnApplicationLateStart() // Runs after OnApplicationStart.
        {
            //MelonLogger.Msg("OnApplicationLateStart");
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            //MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            //MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            //MelonLogger.Msg("OnUpdate");

            if (Input.GetKeyUp(KeyCode.Backspace))
            {
                CameraManager cameraManager = GameObject.Find("Main Camera").GetComponent<CameraManager>();

                if (first)
                {
                    maxAngle = cameraManager.maxAngle;
                    maxDistanceFromTarget = cameraManager.maxDistanceFromTarget;
                    maxFieldOfView = cameraManager.maxFieldOfView;
                    minDistanceFromTarget = cameraManager.minDistanceFromTarget;
                    minAngle = cameraManager.minAngle;
                    first = false;
                }
                 
                if (cameraManager.maxAngle == maxAngle)
                {
                    cameraManager.maxAngle = 85;
                    cameraManager.maxDistanceFromTarget = 425;
                    cameraManager.maxFieldOfView = 65;
                    cameraManager.minDistanceFromTarget = 35;
                    cameraManager.minAngle = 8;
                }
                else
                {
                    cameraManager.maxAngle = maxAngle;
                    cameraManager.maxDistanceFromTarget = maxDistanceFromTarget;
                    cameraManager.maxFieldOfView = maxFieldOfView;
                    cameraManager.minDistanceFromTarget = minDistanceFromTarget;
                    cameraManager.minAngle = minAngle;
                }

            }
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            //MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            //MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            //MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            //MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            //MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            //MelonLogger.Msg("OnPreferencesLoaded");
        }

        public override void BONEWORKS_OnLoadingScreen() // Runs when BONEWORKS shows the Loading Screen. Only runs if the Melon is used in BONEWORKS.
        {
            //MelonLogger.Msg("BONEWORKS_OnLoadingScreen");
        }
    }
}