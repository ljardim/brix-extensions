using UnityEngine;
using UnityAtoms.BaseAtoms;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Transform to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Transform Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncTransformVariableInstancerToCollection : SyncVariableInstancerToCollection<Transform, TransformVariable, TransformVariableInstancer> { }
}
