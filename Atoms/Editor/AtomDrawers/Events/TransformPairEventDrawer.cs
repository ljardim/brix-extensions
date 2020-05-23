#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Event property drawer of type `TransformPair`. Inherits from `AtomDrawer&lt;TransformPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TransformPairEvent))]
    public class TransformPairEventDrawer : AtomDrawer<TransformPairEvent> { }
}
#endif
