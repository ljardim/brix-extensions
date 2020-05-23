#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Variable property drawer of type `Transform`. Inherits from `AtomDrawer&lt;TransformVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TransformVariable))]
    public class TransformVariableDrawer : VariableDrawer<TransformVariable> { }
}
#endif
