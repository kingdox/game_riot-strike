﻿#region Access
using UnityEngine;
#endregion
#region Enums
/// <summary>
/// Identification of the player controller
/// </summary>
public enum EControl
{
    ATTACK=0,
    AIM = 1,
    RELOAD=2,
    CAST=3,
    FORWARD=4,
    BACK=5,
    LEFT=6,
    RIGHT=7,
    CHAT=8, // multiplayer only
    PAUSE=9,
}
/// <summary>
/// Identifyier of the player characters availables
/// </summary>
public enum ECharacter{
    NO = -1,
    /// <summary>
    /// Healer spell, Wear a Sniper
    /// </summary>
    [InspectorName("Enlai Ming")] ENLAI_MING = 0,
    /// <summary>
    /// Jump and speed, Wear bombs grenades
    /// </summary>
    [InspectorName("Tabare Flare")]TABARE_FLARE = 1,
    /// <summary>
    /// Tank, wear a gun
    /// </summary>
    [InspectorName("Cole Megalos")]COLE_MEGALOS = 2,
    /// <summary>
    /// Samurai guy, katana weapon
    /// </summary>
    [InspectorName("Akiyama Arata")]AKIYAMA_ARATA = 3,
    /// <summary>
    /// Robot
    /// </summary>
    [InspectorName("X-F20")]X_F20 = 4,
}
/// <summary>
/// Enumeration of the character stats
/// </summary>
public enum EStat
{
    ATTACK=0,
    DEFENSE=1,
    SPEED=2,
    HEALTH=3,
}
/// <summary>
/// Special elements who define the player and their own play style
/// </summary>
public enum EQuirk
{
    SPELL=0,
    WEAPON=1,
}
/// <summary>
/// List of options Switch
/// </summary>
public enum ESwitchOpt
{
    POST_PROCESSING = 0,
    INVERT_AXIS_X = 1,
    INVERT_AXIS_Y = 2,
}
#endregion