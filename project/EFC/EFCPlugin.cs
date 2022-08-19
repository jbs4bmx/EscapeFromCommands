using BepInEx;
using BepInEx.Configuration;
using COM = EFC.ComController;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EFC
{
    [BepInPlugin("com.jbs4bmx.efc", "EscapeFromCommands", "0.0.1")]
    public class EFCPlugin : BaseUnityPlugin
    {
        //public static GameObject Hook;

        private const string SectionPlayer = "Player";
        internal static ConfigEntry<KeyboardShortcut> ToggleInstantHeal;
        internal static ConfigEntry<KeyboardShortcut> ToggleInertia;
        internal static ConfigEntry<KeyboardShortcut> ToggleHighJump;
        internal static ConfigEntry<KeyboardShortcut> ToggleCamoflage;
        internal static ConfigEntry<KeyboardShortcut> ToggleNoRecoil;

        private const string SectionEnvironment = "Environment";
        internal static ConfigEntry<KeyboardShortcut> ToggleDesharpen;
        internal static ConfigEntry<KeyboardShortcut> ToggleNightVision;
        internal static ConfigEntry<KeyboardShortcut> ToggleFoliage;
        internal static ConfigEntry<KeyboardShortcut> ToggleHurtMePlenty;
        internal static ConfigEntry<KeyboardShortcut> ToggleUnlockDoors;

        public static GameObject input;

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo("Plugin EscapeFromCommands (v0.0.1) is loaded!");
     
            DontDestroyOnLoad(this);


            // ----- Player Binds ----- ----- ----- -----
            ToggleInstantHeal = Config.Bind(
                SectionPlayer,
                "Instantly Heal Your PMC",
                new KeyboardShortcut(KeyCode.Slash),
                "Pressing this key will instantly heal your character while in raid. Heals EVERYTHING."
            );
            ToggleInertia = Config.Bind(
                SectionPlayer,
                "Enable/Disable Inertia",
                new KeyboardShortcut(KeyCode.I),
                "Enable/Disable inertia settings so you can run fast or slow. Why would you choose slow?"
            );
            ToggleHighJump = Config.Bind(
                SectionPlayer,
                "High Jump",
                new KeyboardShortcut(KeyCode.H),
                "Enable/Disable the ability to jump higher than most obsticles. WARNING - You may be able to make it off of the map and potentially get stuck. ALT+F4 would be the only escape."
            );
            ToggleCamoflage = Config.Bind(
                SectionPlayer,
                "Camoflage",
                new KeyboardShortcut(KeyCode.Quote),
                "Enable/Disable AI ability to see you."
            );
            ToggleNoRecoil = Config.Bind(
                SectionPlayer,
                "No Recoil",
                new KeyboardShortcut(KeyCode.L),
                "Enable/Disable firearm recoil."
            );


            // ----- Environment Binds ----- ----- ----- -----
            ToggleNightVision = Config.Bind(
                SectionEnvironment,
                "Enable/Disable Night Vision.",
                new KeyboardShortcut(KeyCode.N),
                "Enable/Disable NVG overlay. Works whether you have NVGs or not."
            );
            ToggleFoliage = Config.Bind(
                SectionEnvironment,
                "Enable/Disable Foliage",
                new KeyboardShortcut(KeyCode.Semicolon),
                "Enable/Disable the ability to run through foliage without being obstructed."
            );
            ToggleHurtMePlenty = Config.Bind(
                SectionEnvironment,
                "Hurt Me Plenty",
                new KeyboardShortcut(KeyCode.Period),
                "Turn the dial up to Eleven! You thought 'Impossible' was the hardest difficulty? Fuck outta here!"
            );
            ToggleUnlockDoors = Config.Bind(
                SectionEnvironment,
                "Unlock Doors",
                new KeyboardShortcut(KeyCode.K),
                "Unlock doors in your current raid. Will only work once per raid."
            );
            ToggleDesharpen = Config.Bind(
                SectionEnvironment,
                "Screen Sharpener",
                new KeyboardShortcut(KeyCode.LeftBracket),
                "Enable/Disable the sharpening effect when using painkillers."
            );
        }

        private void Update()
        {
            // Start this shit.
            if (Input.GetKeyDown(ToggleInstantHeal.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleInertia.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleHighJump.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleCamoflage.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleNoRecoil.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleNightVision.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleFoliage.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleHurtMePlenty.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleUnlockDoors.Value.MainKey))
            {
                //...
            }

            if (Input.GetKeyDown(ToggleDesharpen.Value.MainKey))
            {
                COM.Desharpen();
            }

        }
    }
}
