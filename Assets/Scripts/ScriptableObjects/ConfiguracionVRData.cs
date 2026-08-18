using UnityEngine;

[CreateAssetMenu(fileName = "ConfiguracionVRData", menuName = "Scriptable Objects/ConfiguracionVRData")]
public class ConfiguracionVRData : ScriptableObject
{
    [Header("Físicas e Interacción VR")]
    [Range(0.01f, 0.5f)]
    public float toleranciaSnap = 0.1f;

    [Header("Controles y Accesibilidad")]
    public bool usarSnapTurn = true;

    [Header("Niveles de Audio")]
    [Range(0f, 1f)]
    public float volumenMusica = 0.5f;
    [Range(0f, 1f)]
    public float volumenLocucion = 1.0f;
}
