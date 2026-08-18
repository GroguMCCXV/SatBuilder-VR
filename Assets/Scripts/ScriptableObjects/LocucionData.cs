using UnityEngine;

[CreateAssetMenu(fileName = "LocucionData", menuName = "Scriptable Objects/LocucionData")]
public class LocucionData : ScriptableObject
{
    [Header("Narración y Bienvenida")]
    public AudioClip clipBienvenida;

    [Header("Efectos de Sonido (SFX)")]
    public AudioClip sfxAcople;
    public AudioClip sfxBotonUI;

    [Header("Música de Fondo")]
    public AudioClip musicaAmbiental;
}
