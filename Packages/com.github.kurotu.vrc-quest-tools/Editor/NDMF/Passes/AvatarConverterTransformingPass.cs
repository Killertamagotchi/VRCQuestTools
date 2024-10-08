using KRT.VRCQuestTools.Components;
using nadena.dev.ndmf;

namespace KRT.VRCQuestTools.Ndmf
{
    /// <summary>
    /// Convert the avatar with AvatarConverterSettings component in NDMF.
    /// </summary>
    internal class AvatarConverterTransformingPass : Pass<AvatarConverterTransformingPass>
    {
        /// <inheritdoc/>
        public override string DisplayName => "Convert avatar for Android in transforming phase";

        /// <inheritdoc/>
        protected override void Execute(BuildContext context)
        {
            var settings = context.AvatarRootObject.GetComponent<AvatarConverterSettings>();
            if (settings == null)
            {
                return;
            }

            if (settings.ndmfPhase == Models.AvatarConverterNdmfPhase.Transforming)
            {
                NdmfPluginUtility.ConvertAvatarInPass(context, settings);
            }
        }
    }
}
