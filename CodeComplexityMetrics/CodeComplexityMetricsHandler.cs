using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using System;

namespace CodeComplexityMetrics
{

	public enum CodeComplexityMetricsCommands
	{
		ShowMetrixPad,
	}

	public class CodeComplexityMetricsHandler: CommandHandler
	{
		
		protected override void Run()
		{
			var solutionPath = new SolutionInformationHelper().GetCurrentSolutionPath();

			var metrixData = new MetrixProvider().GetMetrixData(solutionPath);

		}

		protected override void Update(CommandInfo info)
		{

		}

		public CodeComplexityMetricsHandler()
		{
			try
			{
				var ccmp = new CodeComplexityMetricsPad();
				IdeApp.Workbench.AddPad(ccmp, "CodeComplexityMetrics.CodeComplexityMetricsPad", "Code Metrix", "", null);
				//ccmp.Window.Activate(true);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
		}
	}
}
