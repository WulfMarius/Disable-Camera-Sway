using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Harmony;

namespace DisableCameraSway
{
     [HarmonyPatch(typeof(PlayerManager), "MaybeRotateCamera")]
    internal class PlayerManager_MaybeRotateCamera
    {
        internal static bool Prefix()
        {
            return false;
        }
    }
}
