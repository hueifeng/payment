using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserBenefitEditModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserBenefitEditModel : AlipayObject
    {
        /// <summary>
        /// 权益专区码，在创建权益前应该先向蚂蚁会员平台申请一个合适的专区码。 专区必须存在。
        /// </summary>
        [JsonProperty("benefit_area_code")]
        [XmlElement("benefit_area_code")]
        public string BenefitAreaCode { get; set; }

        /// <summary>
        /// 权益图标地址
        /// </summary>
        [JsonProperty("benefit_icon_url")]
        [XmlElement("benefit_icon_url")]
        public string BenefitIconUrl { get; set; }

        /// <summary>
        /// 权益的ID
        /// </summary>
        [JsonProperty("benefit_id")]
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益的名称
        /// </summary>
        [JsonProperty("benefit_name")]
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 是否将权益的名称用作专区的副标题, 若为true,则会使用该权益的名称自动覆盖所属专区的副标题(暂未实现)
        /// </summary>
        [JsonProperty("benefit_name_as_area_subtitle")]
        [XmlElement("benefit_name_as_area_subtitle")]
        public string BenefitNameAsAreaSubtitle { get; set; }

        /// <summary>
        /// 权益详情页面地址
        /// </summary>
        [JsonProperty("benefit_page_url")]
        [XmlElement("benefit_page_url")]
        public string BenefitPageUrl { get; set; }

        /// <summary>
        /// 权益兑换消耗的积分数(修改时必填，防止默认不传的时候被修改成0)
        /// </summary>
        [JsonProperty("benefit_point")]
        [XmlElement("benefit_point")]
        public long BenefitPoint { get; set; }

        /// <summary>
        /// 权益使用场景索引ID，接入时需要咨询@田豫如何取值
        /// </summary>
        [JsonProperty("benefit_rec_biz_id")]
        [XmlElement("benefit_rec_biz_id")]
        public string BenefitRecBizId { get; set; }

        /// <summary>
        /// 支付宝商家券 ALIPAY_MERCHANT_COUPON  口碑商家券 KOUBEI_MERCHANT_COUPON  花呗分期免息券 HUABEI_FENQI_FREE_INTEREST_COUP  淘系通用券 TAOBAO_COMMON_COUPON  淘系商家券 TAOBAO_MERCHANT_COUPON  国际线上商家券 INTER_ONLINE_MERCHANT_COUPON  国际线下商家券 INTER_OFFLINE_MERCHANT_COUPON  通用商户权益 COMMON_MERCHANT_GOODS  其它 OTHERS, 接入是需要咨询@田豫如何选值
        /// </summary>
        [JsonProperty("benefit_rec_type")]
        [XmlElement("benefit_rec_type")]
        public string BenefitRecType { get; set; }

        /// <summary>
        /// 权益的副标题，用于补充描述权益
        /// </summary>
        [JsonProperty("benefit_subtitle")]
        [XmlElement("benefit_subtitle")]
        public string BenefitSubtitle { get; set; }

        /// <summary>
        /// 支付宝的营销活动id，若不走支付宝活动，则不需要填
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// primary,golden,platinum,diamond分别对应大众、黄金、铂金、钻石会员等级。eligible_grade属性用于限制能够兑换当前权益的用户等级，用户必须不低于配置的等级才能进行兑换。如果没有等级要求，则不要填写该字段。
        /// </summary>
        [JsonProperty("eligible_grade")]
        [XmlElement("eligible_grade")]
        public string EligibleGrade { get; set; }

        /// <summary>
        /// 权益展示结束时间，填如自January 1, 1970, 00:00:00 GMT到目标时间的毫秒数，参考(new Date()).getTime()
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 兑换规则以及不满足该规则后给用户的提示文案，规则id和文案用:分隔；可配置多个，多个之间用,分隔。(分隔符皆是英文半角字符)规则id联系蚂蚁会员pd或运营提供
        /// </summary>
        [JsonProperty("exchange_rule_ids")]
        [XmlElement("exchange_rule_ids")]
        public string ExchangeRuleIds { get; set; }

        /// <summary>
        /// 该权益对应每个等级会员的兑换折扣。等级和折扣用:分隔，多组折扣规则用:分隔。折扣0~1。分隔符皆为英文半角字符
        /// </summary>
        [JsonProperty("grade_discount")]
        [XmlElement("grade_discount")]
        public string GradeDiscount { get; set; }

        /// <summary>
        /// 权益展示起始时间，填如自January 1, 1970, 00:00:00 GMT到目标时间的毫秒数，参考(new Date()).getTime()
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}