using BepInEx;
using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using EFT;
using Comfort.Common;
using EFC.EFCPlugin;

namespace EFC
{
	internal class ComController
	{
		public static GameWorld GameWorld { get => Singleton<GameWorld>.Instance; }
		public static bool InGame { get => Singleton<GameWorld>.Instantiated; }
		public static Player LocalPlayer { get => GameWorld.RegisteredPlayers.Find(p => p.IsYourPlayer); }

		//private static Player LocalPlayer() => Singleton<GameWorld>.Instance ??Singleton<GameWorld>.Instance.RegisteredPlayers.Find(p => p.IsYourPlayer);


		// ----- ----- Instant Heal PMC ----- -----  ----- -----
		public class InstantHeal
        {
			//...
        }



		// ----- ----- Enable/Disable Inertia ----- -----  ----- -----
		public class Inertia
        {
			//...
        }



		// ----- ----- Enable/Disable High Jump ----- -----  ----- -----
		public class HighJump
        {
			//...
        }



		// ----- ----- Enable/Disable Camoflage Cheat ----- -----  ----- -----
		public class Camoflage
        {
			//...
        }



		// ----- ----- Enable/Disable Recoil ----- -----  ----- -----
		public class NoRecoil
        {
			//...
        }



		// ----- ----- Enable/Disable Screen Sharpening ----- -----  ----- -----
		public class Desharpen
		{
			Desharpen._targetType = PatchConstants.EftTypes.Single(new Func<Type, bool>(this.IsTargetType));
			}
			private bool IsTargetType(Type type)
			{
				return type.GetMethod("UpdateAmount") != null && type.GetMethod("ChangeDefaultSharpenValue") != null;
			}
			protected override MethodBase GetTargetMethod()
			{
				return Desharpen._targetType.GetMethod("UpdateAmount");
			}
			[PatchPrefix]
			private static bool PatchPrefix()
			{
				return false;
			}
			private static Type _targetType;
		}



		// ----- ----- Enable/Disable NightVision ----- -----  ----- -----
		public class NightVision
		{
			override public void Init(Dictionary<string, string> options)
			{
				base.Init(options);
				if (!options.ContainsKey("key"))
				{
					options["key"] = "k";
				}
			}

			void Update()
			{
				if (Input.GetKeyDown(options["key"]))
				{
					var component = Camera.main.GetComponent<BSG.CameraEffects.NightVision>();
					component?.StartSwitch(!component.On);
				}
			}
		}



		// ----- ----- Enable/Disable Foliage Stopping Sprinting ----- -----  ----- -----
		public class Foliage
        {
			//...
        }



		// ----- ----- Enable/Disable DOOM Mode (HurtMePlenty) ----- -----  ----- -----
		public class HurtMePlenty
        {
			//...
        }



		// ----- ----- Lock/Unlock All Doors on the Current Map ----- -----  ----- -----
		public class UnlockDoors
        {
			//...
        }

	}
}
