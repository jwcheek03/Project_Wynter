// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Project_Wynter : ModuleRules
{
	public Project_Wynter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Project_Wynter",
			"Project_Wynter/Variant_Platforming",
			"Project_Wynter/Variant_Combat",
			"Project_Wynter/Variant_Combat/AI",
			"Project_Wynter/Variant_SideScrolling",
			"Project_Wynter/Variant_SideScrolling/Gameplay",
			"Project_Wynter/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
