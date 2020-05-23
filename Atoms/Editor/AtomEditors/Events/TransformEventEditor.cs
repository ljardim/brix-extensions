#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Event property drawer of type `Transform`. Inherits from `AtomEventEditor&lt;Transform, TransformEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TransformEvent))]
    public sealed class TransformEventEditor : AtomEventEditor<Transform, TransformEvent> { }
}
#endif
