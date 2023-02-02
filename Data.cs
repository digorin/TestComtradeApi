using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DataFrame
    {
        public class Data
        {
            public string? typeCode { get; set; }
            public string? freqCode { get; set; }
            public int? refPeriodId { get; set; }
            public int? refYear { get; set; }
            public int? refMonth { get; set; }
            public string? period { get; set; }
            public int? reporterCode { get; set; }
            public object? reporterISO { get; set; }
            public object? reporterDesc { get; set; }
            public string? flowCode { get; set; }
            public object? flowDesc { get; set; }
            public int? partnerCode { get; set; }
            public object? partnerISO { get; set; }
            public object? partnerDesc { get; set; }
            public int? partner2Code { get; set; }
            public object? partner2ISO { get; set; }
            public object? partner2Desc { get; set; }
            public string? classificationCode { get; set; }
            public string? classificationSearchCode { get; set; }
            public bool? isOriginalClassification { get; set; }
            public string? cmdCode { get; set; }
            public object? cmdDesc { get; set; }
            public int? aggrLevel { get; set; }
            public object? isLeaf { get; set; }
            public string? customsCode { get; set; }
            public object? customsDesc { get; set; }
            public string? mosCode { get; set; }
            public int? motCode { get; set; }
            public object? motDesc { get; set; }
            public int? qtyUnitCode { get; set; }
            public object? qtyUnitAbbr { get; set; }
            public double? qty { get; set; }
            public bool? isQtyEstimated { get; set; }
            public int? altQtyUnitCode { get; set; }
            public object? altQtyUnitAbbr { get; set; }
            public double? altQty { get; set; }
            public bool? isAltQtyEstimated { get; set; }
            public double? netWgt { get; set; }
            public bool? isNetWgtEstimated { get; set; }
            public double? grossWgt { get; set; }
            public bool? isGrossWgtEstimated { get; set; }
            public double? cifvalue { get; set; }
            public double? fobvalue { get; set; }
            public double? primaryValue { get; set; }
            public int? legacyEstimationFlag { get; set; }
            public bool? isReported { get; set; }
            public bool? isAggregate { get; set; }
        }

        public class Root
        {
            public string? elapsedTime { get; set; }
            public int? count { get; set; }
            public List<Data>? data { get; set; }
            public string? error { get; set; }
        }
    }
}
