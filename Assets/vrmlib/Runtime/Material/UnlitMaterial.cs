using System.Numerics;

namespace VrmLib
{
    //
    // https://github.com/KhronosGroup/glTF/tree/master/extensions/2.0/Khronos/KHR_materials_unlit
    //
    public class UnlitMaterial : Material
    {
        public const string ExtensionName = "KHR_materials_unlit";

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("[Unlit]");
            if (BaseColorTexture != null)
            {
                sb.Append($" => {BaseColorTexture}");
            }
            return sb.ToString();
        }

        public void AssignUnlitData(Material src)
        {
            // copy
            BaseColorFactor = src.BaseColorFactor;
            BaseColorTexture = src.BaseColorTexture;
            AlphaMode = src.AlphaMode;
            AlphaCutoff = src.AlphaCutoff;
        }

        public UnlitMaterial(string name) : base(name)
        {
        }

        public override bool CanIntegrate(Material _rhs)
        {
            var rhs = _rhs as UnlitMaterial;
            if (rhs == null)
            {
                return false;
            }

            // copy
            if (BaseColorFactor != rhs.BaseColorFactor) return false;
            if (BaseColorTexture != rhs.BaseColorTexture) return false;
            if (AlphaMode != rhs.AlphaMode) return false;
            if (AlphaCutoff != rhs.AlphaCutoff) return false;

            return true;
        }
    }
}