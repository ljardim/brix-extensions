#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Event property drawer of type `Animator`. Inherits from `AtomDrawer&lt;AnimatorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorEvent))]
    public class AnimatorEventDrawer : AtomDrawer<AnimatorEvent> { }
}
#endif
