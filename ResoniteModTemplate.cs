using HarmonyLib;
using ResoniteModLoader;
using System;
using System.Reflection;
using FrooxEngine;
using Elements.Core;

namespace TemplateNamespace;

public class ResoniteModTemplate : ResoniteMod
{
    public override string Name => "Resonite Mod Template";
    public override string Author => "Owner";
    public override string Version => "1.0.0";
    public override string Link => "resonite.com";
    public static ModConfiguration? Config;

    public override void OnEngineInit()
    {
        Harmony harmony = new("net.Owner.ResoniteModTemplate");
        Config = GetConfiguration();
        Config?.Save(true);
        harmony.PatchAll();
    }
}
