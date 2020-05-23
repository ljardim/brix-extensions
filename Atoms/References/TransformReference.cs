using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;


namespace UnityAtoms.Brix
{

    /// <summary>
    /// Reference of type `Transform`. Inherits from `AtomReference&lt;Transform, TransformPair, TransformConstant, TransformVariable, TransformEvent, TransformPairEvent, TransformTransformFunction, TransformVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TransformReference : AtomReference<
        Transform,
        TransformPair,
        TransformConstant,
        TransformVariable,
        TransformEvent,
        TransformPairEvent,
        TransformTransformFunction,
        TransformVariableInstancer>, IEquatable<TransformReference>
    {
        public TransformReference() : base() { }
        public TransformReference(Transform value) : base(value) { }
        public bool Equals(TransformReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Transform other)
        {
            throw new NotImplementedException();
        } 
    }
}
