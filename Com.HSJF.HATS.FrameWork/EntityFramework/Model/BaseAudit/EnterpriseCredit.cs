using Com.HSJF.Infrastructure.DoMain;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class EnterpriseCredit : EntityModel
    {
        public string ID { get; set; }
        public string CreditCard { get; set; }
        public string CreditInfo { get; set; }
        public string ShareholderDetails { get; set; }
        public string OtherDetailes { get; set; }
        public string BaseAuditID { get; set; }

        public string EnterpriseID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        public virtual BaseAudit BaseAudit { get; set; }
    }
}