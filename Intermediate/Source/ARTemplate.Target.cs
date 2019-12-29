using UnrealBuildTool;

public class ARTemplateTarget : TargetRules
{
	public ARTemplateTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARTemplate");
	}
}
