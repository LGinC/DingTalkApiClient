using System.ComponentModel;
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace DingTalkApiClient.Enums;

/// <summary>
/// ding消息通知类型
/// </summary>
public enum DingRemindType
{
    /// <summary>
    /// 应用内DING
    /// </summary>
    [Description("应用内DING")]
    InternalApplication = 1,
    /// <summary>
    /// 短信DING 需要单独购买权益包
    /// </summary>
    [Description("短信DING")]
    Sms = 2,
    /// <summary>
    /// 电话DING 需要单独购买权益包
    /// </summary>
    [Description("电话DING")]
    PhoneCall = 3,
}

/// <summary>
/// 电话音色
/// </summary>
public enum CallVoiceEnum
{
    /// <summary>
    /// 标准女声
    /// </summary>
    Standard_Female_Voice,
    /// <summary>
    /// 粤语女声
    /// </summary>
    Cantonese_Female_Voice,
    /// <summary>
    /// 
    /// </summary>
    Gentine_Female_Voice,
    /// <summary>
    /// 
    /// </summary>
    Overbearing_Female_Voice,
    /// <summary>
    /// 可爱女声
    /// </summary>
    Lovely_Girl_Voice,
    /// <summary>
    /// 标准男声
    /// </summary>
    Standard_Male_Voice,
}