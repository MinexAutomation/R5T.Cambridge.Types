﻿using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    public class SolutionConfigurationPlatformsGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "SolutionConfigurationPlatforms";


        #region Static

        /// <summary>
        /// Creates a new <see cref="SolutionConfigurationPlatformsGlobalSection"/> with the <see cref="SolutionConfigurationPlatformsGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PreSolution"/>.
        /// </summary>
        public static SolutionConfigurationPlatformsGlobalSection New()
        {
            var output = new SolutionConfigurationPlatformsGlobalSection
            {
                Name = SolutionConfigurationPlatformsGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PreSolution,
            };
            return output;
        }

        /// <summary>
        /// Creates a new <see cref="SolutionConfigurationPlatformsGlobalSection"/> with the <see cref="SolutionConfigurationPlatformsGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PreSolution"/>.
        /// Adds all default <see cref="SolutionBuildConfigurationPlatform"/> values.
        /// </summary>
        public static SolutionConfigurationPlatformsGlobalSection NewAddDefaultSolutionBuildConfigurationPlatforms()
        {
            var output = SolutionConfigurationPlatformsGlobalSection.New();

            output.AddDefaultSolutionBuildConfigurationPlatforms();

            return output;
        }

        #endregion


        public List<SolutionBuildConfigurationPlatform> SolutionBuildConfigurationMappings { get; } = new List<SolutionBuildConfigurationPlatform>();
    }
}
