using UnityEngine;

[CreateAssetMenu(fileName = "ComponenteData", menuName = "Scriptable Objects/ComponenteData")]
public class ComponenteData : ScriptableObject
{
    [Header("Información Básica")]
    public string idComponente;
    public string nombrePieza;
    [TextArea(3, 5)]
    public string descripcion;

    [Header("Recursos Audiovisuales")]
    public AudioClip locucionAudio;
    public GameObject prefab3D;
    public Sprite iconoUI;

}
