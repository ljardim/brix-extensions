#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;


namespace UnityAtoms.Brix.Editor
{
    /// <summary>
    /// Value List property drawer of type `Transform`. Inherits from `AtomDrawer&lt;TransformValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TransformValueList))]
    public class TransformValueListDrawer : AtomDrawer<TransformValueList> { }
}
#endif
