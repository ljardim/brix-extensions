using UnityEngine;


namespace UnityAtoms.Brix
{
    /// <summary>
    /// Event Instancer of type `Transform`. Inherits from `AtomEventInstancer&lt;Transform, TransformEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Transform Event Instancer")]
    public class TransformEventInstancer : AtomEventInstancer<Transform, TransformEvent> { }
}
