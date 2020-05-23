#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Constant property drawer of type `Transform`. Inherits from `AtomDrawer&lt;TransformConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TransformConstant))]
    public class TransformConstantDrawer : VariableDrawer<TransformConstant> { }
}
#endif
