using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.IM.Chat;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.IM;

/// <summary>
/// 即时通讯群会话 API (Top API)
/// </summary>
public interface IChatApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建群
    /// </summary>
    [HttpPost("/chat/create")]
    ITask<CreateChatResponse> CreateChatAsync([JsonContent] CreateChatRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新群
    /// </summary>
    [HttpPost("/chat/update")]
    ITask<DingTalkResult> UpdateChatAsync([JsonContent] UpdateChatRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询群信息
    /// </summary>
    [HttpGet("/chat/get")]
    ITask<GetChatResponse> GetChatAsync(GetChatRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新群成员的群昵称
    /// </summary>
    [HttpPost("/topapi/chat/updategroupnick")]
    ITask<ChatBooleanResponse> UpdateGroupNickAsync([JsonContent] UpdateGroupNickRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新群管理员
    /// </summary>
    [HttpPost("/topapi/chat/subadmin/update")]
    ITask<ChatBooleanResponse> UpdateChatSubAdminAsync([JsonContent] UpdateChatSubAdminRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置禁止群成员私聊
    /// </summary>
    [HttpPost("/topapi/chat/member/friendswitch/update")]
    ITask<ChatBooleanResponse> UpdateMemberFriendSwitchAsync([JsonContent] UpdateMemberFriendSwitchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取入群二维码链接
    /// </summary>
    [HttpPost("/topapi/chat/qrcode/get")]
    ITask<GetChatQrCodeResponse> GetChatQrCodeAsync([JsonContent] GetChatQrCodeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建场景群
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/create")]
    ITask<CreateSceneGroupResponse> CreateSceneGroupAsync([JsonContent] CreateSceneGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新场景群
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/update")]
    ITask<ChatBooleanResponse> UpdateSceneGroupAsync([JsonContent] UpdateSceneGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询场景群信息
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/get")]
    ITask<GetSceneGroupResponse> GetSceneGroupAsync([JsonContent] GetSceneGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增场景群成员
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/member/add")]
    ITask<ChatBooleanResponse> AddSceneGroupMemberAsync([JsonContent] SceneGroupMemberRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除场景群成员
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/member/delete")]
    ITask<ChatBooleanResponse> DeleteSceneGroupMemberAsync([JsonContent] SceneGroupMemberRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 启用群模板
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/template/apply")]
    ITask<ChatBooleanResponse> ApplySceneGroupTemplateAsync([JsonContent] SceneGroupTemplateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 停用群模板
    /// </summary>
    [HttpPost("/topapi/im/chat/scenegroup/template/close")]
    ITask<ChatBooleanResponse> CloseSceneGroupTemplateAsync([JsonContent] SceneGroupTemplateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送群助手消息
    /// </summary>
    [HttpPost("/topapi/im/chat/scencegroup/message/send_v2")]
    ITask<SendSceneGroupMessageResponse> SendSceneGroupMessageAsync([JsonContent] SendSceneGroupMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 注册互动卡片回调地址
    /// </summary>
    [HttpPost("/topapi/im/chat/scencegroup/interactivecard/callback/register")]
    ITask<RegisterInteractiveCardCallbackResponse> RegisterInteractiveCardCallbackAsync([JsonContent] RegisterInteractiveCardCallbackRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
