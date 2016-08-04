using Com.HSJF.Infrastructure.DoMain;
using System;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class EstimateSource : EntityModel
    {
        public string ID { get; set; }
        public string EstimateInstitutions { get; set; }
        public Nullable<decimal> RushEstimate { get; set; }
        public string InformationProvider { get; set; }
        public string ContactNumber { get; set; }
        public string HouseDetailID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        public virtual HouseDetail HouseDetail { get; set; }
    }
}