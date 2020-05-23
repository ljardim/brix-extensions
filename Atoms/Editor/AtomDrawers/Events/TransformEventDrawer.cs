#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Event property drawer of type `Transform`. Inherits from `AtomDrawer&lt;TransformEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TransformEvent))]
    public class TransformEventDrawer : AtomDrawer<TransformEvent> { }
}
#endif
