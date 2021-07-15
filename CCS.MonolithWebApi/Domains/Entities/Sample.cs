using System;

namespace CCS.MonolithWebApi.Domains.Entities
{
    public class Sample
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 登録された日時
        /// </summary>
        public DateTimeOffset CreateDateTime { get; set; }
        /// <summary>
        /// 更新された日時
        /// </summary>
        public DateTimeOffset UpdateDateTime { get; set; }
    }
}
