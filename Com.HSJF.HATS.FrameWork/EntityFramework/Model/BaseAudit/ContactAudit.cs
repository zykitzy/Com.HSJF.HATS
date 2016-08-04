﻿using Com.HSJF.Infrastructure.DoMain;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class ContactAudit : EntityModel
    {
        public string ID { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
        public bool IsDefault { get; set; }
        public string PersonID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        public virtual RelationPersonAudit RelationPersonAudit { get; set; }
    }
}