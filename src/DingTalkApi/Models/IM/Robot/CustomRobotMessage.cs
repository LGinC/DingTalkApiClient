using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.Robot;

/// <summary>
/// 机器人消息类型枚举
/// </summary>
public enum RobotMsgType
{
    /// <summary>
    /// 文本消息
    /// </summary>
    Text,
    /// <summary>
    /// 链接消息
    /// </summary>
    Link,
    /// <summary>
    /// Markdown消息
    /// </summary>
    Markdown,
    /// <summary>
    /// 动作卡片消息
    /// </summary>
    ActionCard,
    /// <summary>
    /// 图文卡片消息
    /// </summary>
    FeedCard
}

/// <summary>
/// 机器人消息体约束接口
/// </summary>
public interface IRobotMsgBody { }

/// <summary>
/// 自定义机器人发送群消息请求参数
/// </summary>
public class CustomRobotMessageRequest
{
    /// <summary>
    /// 初始化 <see cref="CustomRobotMessageRequest"/> 类的新实例
    /// </summary>
    public CustomRobotMessageRequest() { }

    /// <summary>
    /// 通过泛型约束创建机器人消息请求参数
    /// </summary>
    /// <typeparam name="TBody">消息体类型</typeparam>
    /// <param name="msgType">消息类型枚举</param>
    /// <param name="msgBody">对应的消息体对象</param>
    /// <param name="at">at 相关参数</param>
    public static CustomRobotMessageRequest Create<TBody>(RobotMsgType msgType, TBody msgBody, AtObj? at = null)
        where TBody : IRobotMsgBody
    {
        var req = new CustomRobotMessageRequest { MsgType = msgType, At = at };
        switch (msgBody)
        {
            case TextObj text:
                req.Text = text;
                break;
            case LinkObj link:
                req.Link = link;
                break;
            case CustomRobotMarkdownObj markdown:
                req.Markdown = markdown;
                break;
            case ActionCardObj actionCard:
                req.ActionCard = actionCard;
                break;
            case FeedCardObj feedCard:
                req.FeedCard = feedCard;
                break;
        }
        return req;
    }

    /// <summary>
    /// 消息类型（外部使用枚举）
    /// </summary>
    [JsonIgnore]
    public RobotMsgType MsgType { get; set; }

    /// <summary>
    /// 仅序列化使用的消息类型字符串
    /// </summary>
    [JsonPropertyName("msgtype")]
    public string MsgTypeString
    {
        get => MsgType.ToString().ToLower();
        set
        {
            if (System.Enum.TryParse<RobotMsgType>(value, true, out var parsed)) MsgType = parsed;
        }
    }

    /// <summary>
    /// 文本消息
    /// </summary>
    [JsonPropertyName("text")]
    public TextObj? Text { get; set; }

    /// <summary>
    /// 链接消息
    /// </summary>
    [JsonPropertyName("link")]
    public LinkObj? Link { get; set; }

    /// <summary>
    /// Markdown 消息
    /// </summary>
    [JsonPropertyName("markdown")]
    public CustomRobotMarkdownObj? Markdown { get; set; }

    /// <summary>
    /// 动作卡片
    /// </summary>
    [JsonPropertyName("actionCard")]
    public ActionCardObj? ActionCard { get; set; }

    /// <summary>
    /// 图文卡片
    /// </summary>
    [JsonPropertyName("feedCard")]
    public FeedCardObj? FeedCard { get; set; }

    /// <summary>
    /// at 相关参数
    /// </summary>
    [JsonPropertyName("at")]
    public AtObj? At { get; set; }

    /// <summary>
    /// 文本消息内容
    /// </summary>
    public class TextObj : IRobotMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="TextObj"/> 类的新实例
        /// </summary>
        public TextObj() { }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }

    /// <summary>
    /// 链接消息内容
    /// </summary>
    public class LinkObj : IRobotMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="LinkObj"/> 类的新实例
        /// </summary>
        public LinkObj() { }

        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// 点击消息跳转的URL
        /// </summary>
        [JsonPropertyName("messageUrl")]
        public string MessageUrl { get; set; } = string.Empty;

        /// <summary>
        /// 图片URL
        /// </summary>
        [JsonPropertyName("picUrl")]
        public string? PicUrl { get; set; }
    }

    /// <summary>
    /// Markdown 消息内容
    /// </summary>
    public class CustomRobotMarkdownObj : IRobotMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="CustomRobotMarkdownObj"/> 类的新实例
        /// </summary>
        public CustomRobotMarkdownObj() { }

        /// <summary>
        /// 首屏会话透出的展示内容
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        
        /// <summary>
        /// markdown 格式的消息内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }

    /// <summary>
    /// 动作卡片内容
    /// </summary>
    public class ActionCardObj : IRobotMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="ActionCardObj"/> 类的新实例
        /// </summary>
        public ActionCardObj() { }

        /// <summary>
        /// 透出到会话列表和通知的文案
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 消息内容，支持markdown
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// 0：按钮竖直排列 1：按钮横向排列
        /// </summary>
        [JsonPropertyName("btnOrientation")]
        public string? BtnOrientation { get; set; }

        /// <summary>
        /// 单个按钮的标题
        /// </summary>
        [JsonPropertyName("singleTitle")]
        public string? SingleTitle { get; set; }

        /// <summary>
        /// 点击单个按钮跳转的URL
        /// </summary>
        [JsonPropertyName("singleURL")]
        public string? SingleUrl { get; set; }

        /// <summary>
        /// 按钮
        /// </summary>
        [JsonPropertyName("btns")]
        public List<ActionCardBtn>? Btns { get; set; }

        /// <summary>
        /// 动作卡片按钮
        /// </summary>
        public class ActionCardBtn
        {
            /// <summary>
            /// 初始化 <see cref="ActionCardBtn"/> 类的新实例
            /// </summary>
            public ActionCardBtn() { }

            /// <summary>
            /// 按钮标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// 点击按钮跳转的URL
            /// </summary>
            [JsonPropertyName("actionURL")]
            public string ActionUrl { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// 图文卡片内容
    /// </summary>
    public class FeedCardObj : IRobotMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="FeedCardObj"/> 类的新实例
        /// </summary>
        public FeedCardObj() { }

        /// <summary>
        /// 链接列表
        /// </summary>
        [JsonPropertyName("links")]
        public List<FeedCardLink>? Links { get; set; }

        /// <summary>
        /// 图文卡片链接
        /// </summary>
        public class FeedCardLink
        {
            /// <summary>
            /// 初始化 <see cref="FeedCardLink"/> 类的新实例
            /// </summary>
            public FeedCardLink() { }

            /// <summary>
            /// 单条图文信息的标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// 点击单条图文信息跳转的URL
            /// </summary>
            [JsonPropertyName("messageURL")]
            public string MessageUrl { get; set; } = string.Empty;

            /// <summary>
            /// 单条图文信息的图片URL
            /// </summary>
            [JsonPropertyName("picURL")]
            public string PicUrl { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// AT 相关的对象
    /// </summary>
    public class AtObj
    {
        /// <summary>
        /// 初始化 <see cref="AtObj"/> 类的新实例
        /// </summary>
        public AtObj() { }

        /// <summary>
        /// 被@人的手机号
        /// </summary>
        [JsonPropertyName("atMobiles")]
        public IEnumerable<string>? AtMobiles { get; set; }
        
        /// <summary>
        /// 被@人的用户userid
        /// </summary>
        [JsonPropertyName("atUserIds")]
        public IEnumerable<string>? AtUserIds { get; set; }
        
        /// <summary>
        /// 是否@所有人
       /// </summary>
        [JsonPropertyName("isAtAll")]
        public bool IsAtAll { get; set; }
    }
}

/// <summary>
/// 自定义机器人发送群消息响应
/// </summary>
public class CustomRobotMessageResponse : DingTalkResult
{
}
