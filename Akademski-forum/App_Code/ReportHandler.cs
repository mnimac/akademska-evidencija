using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademski_forum.App_Code
{
    class ReportHandler
    {
        public ReportDefinition ReportDefinition { get; set; }

        public List<ReportDefinition> SubreportDefinitions { get; set; }

        public ReportHandler(ReportDefinition reportDefinition, List<ReportDefinition> subreportDefinitions)
        {
            SubreportDefinitions = subreportDefinitions;
            ReportDefinition = reportDefinition;
        }
    }
}
