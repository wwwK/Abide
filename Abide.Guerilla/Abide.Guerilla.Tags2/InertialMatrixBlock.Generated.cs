#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(36, 4)]
    public class InertialMatrixBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("yy+zz    -xy     -zx", typeof(Vector3))]
        public Vector3 YyzzXyZx;
        [Abide.Guerilla.Tags.FieldAttribute(" -xy    zz+xx    -yz", typeof(Vector3))]
        public Vector3 XyZzxxYz;
        [Abide.Guerilla.Tags.FieldAttribute(" -zx     -yz    xx+yy", typeof(Vector3))]
        public Vector3 ZxYzXxyy;
    }
}
#pragma warning restore CS1591