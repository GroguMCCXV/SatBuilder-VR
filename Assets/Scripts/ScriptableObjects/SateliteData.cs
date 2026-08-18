using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SateliteData", menuName = "Scriptable Objects/SateliteData")]
public class SateliteData : ScriptableObject
{
    [Header("Identificación")]
    public string idSatelite;
    public string nombreSatelite;
    [TextArea(3, 6)]
    public string fichaTecnica;

    [Header("Configuración 3D y Tiempo")]
    public GameObject prefabChasisBase;
    public float tiempoMemorizacion = 5.0f;

    [Header("Estructura de Armado")]
    public List<ComponenteData> listaComponentes = new List<ComponenteData>();

    [Header("Puntos de Anclaje (Sockets)")]
    public List<Vector3> posicionesAnclaje = new List<Vector3>();
    public List<Quaternion> rotacionesAnclaje = new List<Quaternion>();
}
