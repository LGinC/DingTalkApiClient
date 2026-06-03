using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.Robot;

/// <summary>
/// 下载机器人消息文件请求
/// </summary>
public class DownloadRobotMessageFileRequest
{
    /// <summary>
    /// 初始化 <see cref="DownloadRobotMessageFileRequest"/> 类的新实例
    /// </summary>
    public DownloadRobotMessageFileRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="DownloadRobotMessageFileRequest"/> 类的新实例
    /// </summary>
    public DownloadRobotMessageFileRequest(string downloadCode, string robotCode)
    {
        DownloadCode = downloadCode;
        RobotCode = robotCode;
    }

    /// <summary>
    /// 用户向机器人发送文件消息后，机器人回调给开发者消息中的下载码。
    /// </summary>
    public string DownloadCode { get; set; } = string.Empty;

    /// <summary>
    /// 机器人的编码；企业内部应用或第三方企业应用通过机器人名词表-robotCode内容获取robotCode字段值。
    /// </summary>
    public string RobotCode { get; set; } = string.Empty;
}

/// <summary>
/// 下载机器人消息文件响应
/// </summary>
public class DownloadRobotMessageFileResponse : DingTalkResult
{
    /// <summary>
    /// 文件的临时下载链接；访问临时下载链接获取文件后，需开发者替换本地下载的文件扩展名。
    /// </summary>
    public string? DownloadUrl { get; set; }
}

/// <summary>
/// 批量撤回人与机器人会话消息请求
/// </summary>
public class BatchRecallOtoMessagesRequest
{
    /// <summary>
    /// 初始化 <see cref="BatchRecallOtoMessagesRequest"/> 类的新实例
    /// </summary>
    public BatchRecallOtoMessagesRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="BatchRecallOtoMessagesRequest"/> 类的新实例
    /// </summary>
    public BatchRecallOtoMessagesRequest(string robotCode, List<string> processQueryKeys)
    {
        RobotCode = robotCode;
        ProcessQueryKeys = processQueryKeys;
    }

    /// <summary>
    /// 机器人的编码，需要与批量发送人与机器人会话中机器人消息接口中使用的robotCode保持一致。
    /// </summary>
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 消息唯一标识列表，可通过批量发送人与机器人会话中机器人消息接口获取；每次最多传20个。
    /// </summary>
    public List<string> ProcessQueryKeys { get; set; } = [];
}

/// <summary>
/// 批量撤回私聊机器人消息请求
/// </summary>
public class BatchRecallPrivateChatMessagesRequest
{
    /// <summary>
    /// 初始化 <see cref="BatchRecallPrivateChatMessagesRequest"/> 类的新实例
    /// </summary>
    public BatchRecallPrivateChatMessagesRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="BatchRecallPrivateChatMessagesRequest"/> 类的新实例
    /// </summary>
    public BatchRecallPrivateChatMessagesRequest(string openConversationId, string chatbotId, List<string> processQueryKeys)
    {
        OpenConversationId = openConversationId;
        ChatbotId = chatbotId;
        ProcessQueryKeys = processQueryKeys;
    }

    /// <summary>
    /// 会话ID，需要与人与人会话中机器人发送普通消息接口或人与人会话中机器人发送互动卡片接口使用的openConversationId保持一致。
    /// </summary>
    public string OpenConversationId { get; set; } = string.Empty;

    /// <summary>
    /// 机器人编码，需要与人与人会话中机器人发送普通消息接口或人与人会话中机器人发送互动卡片接口使用的robotCode保持一致。
    /// </summary>
    public string ChatbotId { get; set; } = string.Empty;

    /// <summary>
    /// 消息id；可通过人与人会话中机器人发送互动卡片接口或人与人会话中机器人发送普通消息接口获取processQueryKey参数值。
    /// </summary>
    public List<string> ProcessQueryKeys { get; set; } = [];
}

/// <summary>
/// 撤回群聊机器人消息请求
/// </summary>
public class RecallGroupMessagesRequest
{
    /// <summary>
    /// 初始化 <see cref="RecallGroupMessagesRequest"/> 类的新实例
    /// </summary>
    public RecallGroupMessagesRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="RecallGroupMessagesRequest"/> 类的新实例
    /// </summary>
    public RecallGroupMessagesRequest(string openConversationId, string robotCode, List<string> processQueryKeys)
    {
        OpenConversationId = openConversationId;
        RobotCode = robotCode;
        ProcessQueryKeys = processQueryKeys;
    }

    /// <summary>
    /// 群ID，需要与机器人发送群聊消息接口时使用的openConversationId一致。
    /// </summary>
    public string OpenConversationId { get; set; } = string.Empty;

    /// <summary>
    /// 机器人的编码，需要与机器人发送群聊消息接口时使用的robotCode一致。
    /// </summary>
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 消息ID列表，可通过机器人发送群聊消息接口返回参数processQueryKey字段获取。
    /// </summary>
    public List<string> ProcessQueryKeys { get; set; } = [];
}

/// <summary>
/// 批量撤回机器人消息响应
/// </summary>
public class BatchRecallRobotMessagesResponse : DingTalkResult
{
    /// <summary>
    /// 撤回成功的消息ID列表。
    /// </summary>
    public List<string> SuccessResult { get; set; } = [];

    /// <summary>
    /// 撤回失败的消息ID列表及对应的失败原因。
    /// </summary>
    public List<RobotMessageRecallFailedResult> FailedResult { get; set; } = [];
}

/// <summary>
/// 机器人消息撤回失败结果
/// </summary>
public class RobotMessageRecallFailedResult
{
    /// <summary>
    /// 消息唯一标识。
    /// </summary>
    public string? ProcessQueryKey { get; set; }

    /// <summary>
    /// 错误码
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 错误消息
    /// </summary>
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// 获取群内机器人列表请求
/// </summary>
public class GetBotListInGroupRequest
{
    /// <summary>
    /// 初始化 <see cref="GetBotListInGroupRequest"/> 类的新实例
    /// </summary>
    public GetBotListInGroupRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="GetBotListInGroupRequest"/> 类的新实例
    /// </summary>
    public GetBotListInGroupRequest(string openConversationId)
    {
        OpenConversationId = openConversationId;
    }

    /// <summary>
    /// 群ID，可调用根据corpid选择会话jsapi获取。
    /// </summary>
    public string OpenConversationId { get; set; } = string.Empty;
}

/// <summary>
/// 获取群内机器人列表响应
/// </summary>
public class GetBotListInGroupResponse : DingTalkResult
{
    /// <summary>
    /// 返回的机器人列表。
    /// </summary>
    public List<ChatbotInstanceInfo> ChatbotInstanceVOList { get; set; } = [];
}

/// <summary>
/// 机器人实例信息
/// </summary>
public class ChatbotInstanceInfo
{
    /// <summary>
    /// 机器人的编码，参见机器人名词表-robotCode内容获取robotCode。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 机器人名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 机器人头像
    /// </summary>
    public string? Icon { get; set; }
}

/// <summary>
/// 设置机器人插件请求
/// </summary>
public class SetRobotPluginsRequest
{
    /// <summary>
    /// 初始化 <see cref="SetRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public SetRobotPluginsRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="SetRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public SetRobotPluginsRequest(string robotCode, List<RobotPluginInfo> pluginInfoList)
    {
        RobotCode = robotCode;
        PluginInfoList = pluginInfoList;
    }

    /// <summary>
    /// 机器人的编码，参见机器人名词表-robotCode内容获取robotCode。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 插件列表。
    /// </summary>
    public List<RobotPluginInfo> PluginInfoList { get; set; } = [];
}

/// <summary>
/// 查询机器人插件请求
/// </summary>
public class QueryRobotPluginsRequest
{
    /// <summary>
    /// 初始化 <see cref="QueryRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public QueryRobotPluginsRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="QueryRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public QueryRobotPluginsRequest(string robotCode)
    {
        RobotCode = robotCode;
    }

    /// <summary>
    /// 机器人的编码，参见机器人名词表-robotCode内容获取robotCode。
    /// </summary>
    public string RobotCode { get; set; } = string.Empty;
}

/// <summary>
/// 清空机器人插件请求
/// </summary>
public class ClearRobotPluginsRequest : QueryRobotPluginsRequest
{
    /// <summary>
    /// 初始化 <see cref="ClearRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public ClearRobotPluginsRequest()
    {
    }

    /// <summary>
    /// 初始化 <see cref="ClearRobotPluginsRequest"/> 类的新实例
    /// </summary>
    public ClearRobotPluginsRequest(string robotCode) : base(robotCode)
    {
    }
}

/// <summary>
/// 机器人插件响应
/// </summary>
public class RobotPluginResultResponse : DingTalkResult
{
    /// <summary>
    /// 是否成功设置或清空机器人快捷入口。
    /// </summary>
    public bool? Result { get; set; }
}

/// <summary>
/// 查询机器人插件响应
/// </summary>
public class QueryRobotPluginsResponse : DingTalkResult
{
    /// <summary>
    /// 快捷入口列表。
    /// </summary>
    public List<RobotPluginInfo> PluginInfoList { get; set; } = [];
}

/// <summary>
/// 机器人插件信息
/// </summary>
public class RobotPluginInfo
{
    /// <summary>
    /// 插件 ID
    /// </summary>
    public string? PluginId { get; set; }

    /// <summary>
    /// 插件名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 插件图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 插件 PC 地址
    /// </summary>
    public string? PcUrl { get; set; }

    /// <summary>
    /// 插件移动端地址
    /// </summary>
    public string? MobileUrl { get; set; }

    /// <summary>
    /// 扩展信息
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}
