using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.CorpConversation;

/// <summary>
/// 工作通知消息类型枚举
/// </summary>
public enum CorpConversationMsgType
{
    /// <summary>
    /// 文本消息
    /// </summary>
    Text,
    /// <summary>
    /// 图像消息
    /// </summary>
    Image,
    /// <summary>
    /// 语音消息
    /// </summary>
    Voice,
    /// <summary>
    /// 文件消息
    /// </summary>
    File,
    /// <summary>
    /// 链接消息
    /// </summary>
    Link,
    /// <summary>
    /// OA消息
    /// </summary>
    OA,
    /// <summary>
    /// Markdown消息
    /// </summary>
    Markdown,
    /// <summary>
    /// 卡片消息
    /// </summary>
    ActionCard
}

/// <summary>
/// 工作通知消息体约束接口
/// </summary>
public interface ICorpConversationMsgBody { }

/// <summary>
/// 发送工作通知消息内容要求
/// </summary>
public class CorpConversationMsgRequest
{
    /// <summary>
    /// 初始化 <see cref="CorpConversationMsgRequest"/> 类的新实例
    /// </summary>
    public CorpConversationMsgRequest() { }

    /// <summary>
    /// 通过泛型约束创建工作通知消息内容要求
    /// </summary>
    /// <typeparam name="TBody">消息体类型</typeparam>
    /// <param name="msgType">消息类型枚举</param>
    /// <param name="msgBody">对应的消息体对象</param>
    public static CorpConversationMsgRequest Create<TBody>(CorpConversationMsgType msgType, TBody msgBody) 
        where TBody : ICorpConversationMsgBody
    {
        var req = new CorpConversationMsgRequest { MsgType = msgType };
        switch (msgBody)
        {
            case TextObj text:
                req.Text = text;
                break;
            case ImageObj image:
                req.Image = image;
                break;
            case VoiceObj voice:
                req.Voice = voice;
                break;
            case FileObj file:
                req.File = file;
                break;
            case LinkObj link:
                req.Link = link;
                break;
            case OAObj oa:
                req.OA = oa;
                break;
            case CorpConversationMarkdownObj markdown:
                req.Markdown = markdown;
                break;
            case ActionCardObj actionCard:
                req.ActionCard = actionCard;
                break;
        }
        return req;
    }

    /// <summary>
    /// 消息类型（外部使用枚举）
    /// </summary>
    [JsonIgnore]
    public CorpConversationMsgType MsgType { get; set; }

    /// <summary>
    /// 仅序列化使用的消息类型字符串
    /// </summary>
    [JsonPropertyName("msgtype")]
    public string MsgTypeString
    {
        get => MsgType == CorpConversationMsgType.ActionCard ? "action_card" : MsgType.ToString().ToLower();
        set
        {
            if (value == "action_card") MsgType = CorpConversationMsgType.ActionCard;
            else if (System.Enum.TryParse<CorpConversationMsgType>(value, true, out var parsed)) MsgType = parsed;
        }
    }

    /// <summary>
    /// 文本消息
    /// </summary>
    [JsonPropertyName("text")]
    public TextObj? Text { get; set; }

    /// <summary>
    /// 图像消息
    /// </summary>
    [JsonPropertyName("image")]
    public ImageObj? Image { get; set; }

    /// <summary>
    /// 语音消息
    /// </summary>
    [JsonPropertyName("voice")]
    public VoiceObj? Voice { get; set; }

    /// <summary>
    /// 文件消息
    /// </summary>
    [JsonPropertyName("file")]
    public FileObj? File { get; set; }

    /// <summary>
    /// 链接消息
    /// </summary>
    [JsonPropertyName("link")]
    public LinkObj? Link { get; set; }
    
    /// <summary>
    /// OA消息
    /// </summary>
    [JsonPropertyName("oa")]
    public OAObj? OA { get; set; }

    /// <summary>
    /// Markdown消息
    /// </summary>
    [JsonPropertyName("markdown")]
    public CorpConversationMarkdownObj? Markdown { get; set; }

    /// <summary>
    /// 卡片消息
    /// </summary>
    [JsonPropertyName("action_card")]
    public ActionCardObj? ActionCard { get; set; }

    /// <summary>
    /// 文本消息内容
    /// </summary>
    public class TextObj : ICorpConversationMsgBody
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
    /// 图像消息内容
    /// </summary>
    public class ImageObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="ImageObj"/> 类的新实例
        /// </summary>
        public ImageObj() { }

        /// <summary>
        /// 媒体文件mediaid
        /// </summary>
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }

    /// <summary>
    /// 语音消息内容
    /// </summary>
    public class VoiceObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="VoiceObj"/> 类的新实例
        /// </summary>
        public VoiceObj() { }

        /// <summary>
        /// 媒体文件mediaid
        /// </summary>
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
        
        /// <summary>
        /// 正整数，小于60，表示音频时长
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; set; } = string.Empty;
    }

    /// <summary>
    /// 文件消息内容
    /// </summary>
    public class FileObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="FileObj"/> 类的新实例
        /// </summary>
        public FileObj() { }

        /// <summary>
        /// 媒体文件mediaid
        /// </summary>
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }

    /// <summary>
    /// 链接消息内容
    /// </summary>
    public class LinkObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="LinkObj"/> 类的新实例
        /// </summary>
        public LinkObj() { }

        /// <summary>
        /// 消息点击链接地址
        /// </summary>
        [JsonPropertyName("messageUrl")]
        public string MessageUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("picUrl")]
        public string PicUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        
        /// <summary>
        /// 消息描述
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }

    /// <summary>
    /// Markdown 消息内容
    /// </summary>
    public class CorpConversationMarkdownObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="CorpConversationMarkdownObj"/> 类的新实例
        /// </summary>
        public CorpConversationMarkdownObj() { }

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
    }

    /// <summary>
    /// OA 消息内容
    /// </summary>
    public class OAObj : ICorpConversationMsgBody
    {
        /// <summary>
        /// 初始化 <see cref="OAObj"/> 类的新实例
        /// </summary>
        public OAObj() { }

        /// <summary>
        /// 消息点击链接地址
        /// </summary>
        [JsonPropertyName("message_url")]
        public string MessageUrl { get; set; } = string.Empty;

        /// <summary>
        /// PC端点击消息时跳转到的链接地址
        /// </summary>
        [JsonPropertyName("pc_message_url")]
        public string? PcMessageUrl { get; set; }

        /// <summary>
        /// 消息头部内容
        /// </summary>
        [JsonPropertyName("head")]
        public required OAHead Head { get; set; }

        /// <summary>
        /// 消息体内容
        /// </summary>
        [JsonPropertyName("body")]
        public OABody? Body { get; set; }

        /// <summary>
        /// 状态栏内容
        /// </summary>
        [JsonPropertyName("status_bar")]
        public OAStatusBar? StatusBar { get; set; }
    }

    /// <summary>
    /// OA消息头部内容
    /// </summary>
    public class OAHead
    {
        /// <summary>
        /// 初始化 <see cref="OAHead"/> 类的新实例
        /// </summary>
        public OAHead() { }

        /// <summary>
        /// 消息头部的背景颜色
        /// </summary>
        [JsonPropertyName("bgcolor")]
        public string BgColor { get; set; } = string.Empty;

        /// <summary>
        /// 消息头部标题
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }

    /// <summary>
    /// OA消息体内容
    /// </summary>
    public class OABody
    {
        /// <summary>
        /// 初始化 <see cref="OABody"/> 类的新实例
        /// </summary>
        public OABody() { }

        /// <summary>
        /// 消息体的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 消息体的表单内容
        /// </summary>
        [JsonPropertyName("form")]
        public List<OAFormItem>? Form { get; set; }

        /// <summary>
        /// 消息的内容图片
        /// </summary>
        [JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 消息的内容摘要
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 消息体中的富文本备注
        /// </summary>
        [JsonPropertyName("rich")]
        public OARich? Rich { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 附件数量
        /// </summary>
        [JsonPropertyName("file_count")]
        public string? FileCount { get; set; }
    }

    /// <summary>
    /// OA消息表单项
    /// </summary>
    public class OAFormItem
    {
        /// <summary>
        /// 初始化 <see cref="OAFormItem"/> 类的新实例
        /// </summary>
        public OAFormItem() { }

        /// <summary>
        /// 表单项标题
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// 表单项内容
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// OA消息富文本
    /// </summary>
    public class OARich
    {
        /// <summary>
        /// 初始化 <see cref="OARich"/> 类的新实例
        /// </summary>
        public OARich() { }

        /// <summary>
        /// 富文本的数量
        /// </summary>
        [JsonPropertyName("num")]
        public string? Num { get; set; }

        /// <summary>
        /// 富文本的单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    /// <summary>
    /// OA消息状态栏
    /// </summary>
    public class OAStatusBar
    {
        /// <summary>
        /// 初始化 <see cref="OAStatusBar"/> 类的新实例
        /// </summary>
        public OAStatusBar() { }

        /// <summary>
        /// 状态栏文案
        /// </summary>
        [JsonPropertyName("status_value")]
        public string? StatusValue { get; set; }

        /// <summary>
        /// 状态栏背景色
        /// </summary>
        [JsonPropertyName("status_bg")]
        public string? StatusBg { get; set; }
    }

    /// <summary>
    /// 卡片消息内容
    /// </summary>
    public class ActionCardObj : ICorpConversationMsgBody
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
        [JsonPropertyName("markdown")]
        public string Markdown { get; set; } = string.Empty;
        
        /// <summary>
        /// 使用独立跳转ActionCard样式时的按钮的文案
        /// </summary>
        [JsonPropertyName("single_title")]
        public string? SingleTitle { get; set; }
        
        /// <summary>
        /// 消息点击链接地址
        /// </summary>
        [JsonPropertyName("single_url")]
        public string? SingleUrl { get; set; }
        
        /// <summary>
        /// 使用整体跳转ActionCard样式时的按钮排列方式
        /// </summary>
        [JsonPropertyName("btn_orientation")]
        public string? BtnOrientation { get; set; }
        
        /// <summary>
        /// 使用独立跳转ActionCard样式时的列表
        /// </summary>
        [JsonPropertyName("btn_json_list")]
        public List<ActionCardBtn>? BtnJsonList { get; set; }

        /// <summary>
        /// 卡片按钮对象
        /// </summary>
        public class ActionCardBtn
        {
            /// <summary>
            /// 初始化 <see cref="ActionCardBtn"/> 类的新实例
            /// </summary>
            public ActionCardBtn() { }

            /// <summary>
            /// 按钮的文案
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;
            
            /// <summary>
            /// 按钮的跳转链接
            /// </summary>
            [JsonPropertyName("action_url")]
            public string ActionUrl { get; set; } = string.Empty;
        }
    }
}

/// <summary>
/// 发送工作通知请求
/// </summary>
public class AsyncSendCorpConversationV2Request
{
    /// <summary>
    /// 初始化 <see cref="AsyncSendCorpConversationV2Request"/> 类的新实例
    /// </summary>
    public AsyncSendCorpConversationV2Request() { }

    /// <summary>
    /// 初始化 <see cref="AsyncSendCorpConversationV2Request"/> 类的新实例
    /// </summary>
    /// <param name="agentId">应用 agentId</param>
    /// <param name="userIdList">接收者的 userid 列表</param>
    /// <param name="deptIdList">接收者的部门 id 列表</param>
    /// <param name="toAllUser">是否发送给企业全部用户</param>
    /// <param name="msg">消息内容</param>
    public AsyncSendCorpConversationV2Request(long agentId, string? userIdList, string? deptIdList, bool toAllUser, CorpConversationMsgRequest msg)
    {
        AgentId = agentId;
        UserIdList = userIdList;
        DeptIdList = deptIdList;
        ToAllUser = toAllUser;
        Msg = msg;
    }

    /// <summary>
    /// 应用agentId
    /// </summary>
    [JsonPropertyName("agent_id")] 
    public long AgentId { get; set; }

    /// <summary>
    /// 接收者的userid列表
    /// </summary>
    [JsonPropertyName("userid_list")] 
    public string? UserIdList { get; set; }

    /// <summary>
    /// 接收者的部门id列表
    /// </summary>
    [JsonPropertyName("dept_id_list")] 
    public string? DeptIdList { get; set; }

    /// <summary>
    /// 是否发送给企业全部用户
    /// </summary>
    [JsonPropertyName("to_all_user")] 
    public bool ToAllUser { get; set; }

    /// <summary>
    /// 消息内容
    /// </summary>
    [JsonPropertyName("msg")] 
    public CorpConversationMsgRequest Msg { get; set; } = new();
}

/// <summary>
/// 发送工作通知响应
/// </summary>
public class AsyncSendCorpConversationV2Response : DingTalkResult
{
    /// <summary>
    /// 创建的异步发送任务ID
    /// </summary>
    [JsonPropertyName("task_id")]
    public long TaskId { get; set; }
}
