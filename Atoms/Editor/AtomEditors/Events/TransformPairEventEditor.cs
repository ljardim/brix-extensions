#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Event property drawer of type `TransformPair`. Inherits from `AtomEventEditor&lt;TransformPair, TransformPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TransformPairEvent))]
    public sealed class TransformPairEventEditor : AtomEventEditor<TransformPair, TransformPairEvent> { }
}
#endif
