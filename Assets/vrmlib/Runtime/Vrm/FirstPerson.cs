using System.Collections.Generic;
using System.Numerics;

namespace VrmLib
{
    public enum FirstPersonMeshType
    {
        Auto, // Create headlessModel
        Both, // Default layer
        ThirdPersonOnly,
        FirstPersonOnly,
    }

    public class FirstPersonMeshAnnotation
    {
        public readonly MeshGroup Mesh;

        public readonly FirstPersonMeshType FirstPersonFlag;

        public FirstPersonMeshAnnotation(MeshGroup mesh, FirstPersonMeshType flag)
        {
            Mesh = mesh;
            FirstPersonFlag = flag;
        }
    }

    public class FirstPerson
    {
        // obsolete
        public Node m_fp;

        // Move to LookAt Offset
        // public Vector3 m_offset;

        public readonly List<FirstPersonMeshAnnotation> Annotations = new List<FirstPersonMeshAnnotation>();
    }
}
