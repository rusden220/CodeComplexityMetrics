using System;
using System.Collections.Generic;
using ArchiMetrics;
using ArchiMetrics.Analysis;

namespace CodeComplexityMetrics
{
	public class MetrixData
	{
		private readonly string _name;
		private readonly string _linesOfCode;
		public MetrixData(string name, string linesOfCode)
		{
			_name = name;
			_linesOfCode = linesOfCode;
		}
		public string Name { get { return _name;} }
		public string LinesOfCode{ get { return _linesOfCode;} }
	}

	public class MetrixProvider
	{
		public IEnumerable<MetrixData> GetMetrixData(string solutionPath)
		{
			System.Diagnostics.Debug.WriteLine($"Load archMetrix for {solutionPath}");

			//var solutionProvider = new SolutionProvider();
			//var solution = await solutionProvider.Get(solutionPath);
			//var projects = solution.Projects.ToList();
			//var metricsCalculator = new CodeMetricsCalculator();
			//var calculateTasks = projects.Select(p => metricsCalculator.Calculate(p, solution));
			//var metrics = (Task.WhenAll(calculateTasks)).SelectMany(nm => nm);

			return GetMetrixData_Plug(solutionPath);
		}
		/// <summary>
		/// just for test
		/// </summary>
		/// <returns>The metrix data plug.</returns>
		/// <param name="solutionPath">Solution path.</param>
		[Obsolete]
		private IEnumerable<MetrixData> GetMetrixData_Plug(string solutionPath)
		{
			return new MetrixData[] { 
				new MetrixData("Metrix name 1", "10"), 
				new MetrixData("Metrix name 2", "20") 
			};
		}


	}
}
