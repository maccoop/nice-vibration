using Lofelt.NiceVibrations;
using UnityEngine;

public class VibrationController
{
    /// <summary>
    /// tai sao lai la 0.1005f
    /// </summary>
    private const float DELAY_HAPTIC_SECOND = 0.1005f;
    private static float nextTimePlay = 0;
    public static void PlayByPreset(HapticPatterns.PresetType type)
    {
        if (Time.time < nextTimePlay) return;
        HapticPatterns.PlayPreset(type);
        nextTimePlay = DELAY_HAPTIC_SECOND + Time.time;
    }
}