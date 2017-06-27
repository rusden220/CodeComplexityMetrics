using System;
using MonoDevelop.Ide;
using System.Diagnostics;
using MonoDevelop.Core;

namespace CodeComplexityMetrics
{
	public class SolutionInformationHelper
	{
		public FilePath GetCurrentSolutionPath()
		{
			var selectedSolution = IdeApp.ProjectOperations.CurrentSelectedSolution.Items;
			var parentSolution = selectedSolution[0].ParentSolution;
			return parentSolution.FileName;
		}
	}
}
