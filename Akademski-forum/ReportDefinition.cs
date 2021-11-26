using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademski_forum
{
    ///<summary>
    ///Podatci od kojih se report sastoji.
    ///Report prima (putanju reporta, ime DataSeta reporta, Data tabelu u kojoj su spremljeni podaci)
    ///</summary>
    public class ReportDefinition
    {
            public ReportDefinition(string reportEmbededResource, string reportDataSourceName, DataTable reportDataTable)
            {
                ReportEmbededResource = reportEmbededResource;
                ReportDataSourceName = reportDataSourceName;
                ReportDataTable = reportDataTable;
            }

            public string ReportEmbededResource { get; set; }

            public string ReportDataSourceName { get; set; }

            public DataTable ReportDataTable { get; set; }
    }
}
