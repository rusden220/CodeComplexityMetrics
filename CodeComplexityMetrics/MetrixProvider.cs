using System;
using System.Collections.Generic;

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
