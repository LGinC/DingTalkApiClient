using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApiClient.Apis.IM;
using DingTalkApiClient.Models.IM.Interconnections;

namespace DingTalkApiClient.Tests;

public class InterconnectionsApiTests : TestBase
{
    private readonly IInterconnectionsApi _api;

    public InterconnectionsApiTests()
    {
        _api = Provider.GetRequiredService<IInterconnectionsApi>();
    }

    [Fact]
    public async Task CreateGroupAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v2.0/im/interconnections/groups", """{"openConversationId":"cid01","conversationId":"dingcid01","appUserIds":["app01"],"userIds":["user01"]}""");

        var response = await _api.CreateGroupAsync(new CreateInterconnectionGroupRequest
        {
            GroupName = "客户群",
            GroupTemplateId = "tpl01",
            Users = [new() { AppUserId = "app01" }]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("cid01", response.OpenConversationId);
        Assert.Equal("app01", Assert.Single(response.AppUserIds));
    }

    [Fact]
    public async Task CreateCoupleGroupAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v2.0/im/interconnections/couples/groups", """{"openConversationId":"cid02","conversationId":"dingcid02","appUserIds":["app01"],"userIds":["user01"]}""");

        var response = await _api.CreateCoupleGroupAsync(new CreateInterconnectionCoupleGroupRequest
        {
            GroupTemplateId = "tpl01",
            Users = [new() { AppUserId = "app01" }, new() { UserId = "user01" }]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("dingcid02", response.ConversationId);
    }

    [Fact]
    public async Task CreateInterconnectionsAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections", """{"results":[{"appUserId":"app01","userId":"user01","message":"ok"}]}""");

        var response = await _api.CreateInterconnectionsAsync(new CreateInterconnectionsRequest
        {
            Interconnections = [new() { AppUserId = "app01", AppUserName = "客户", AppUserMobile = "13800138000" }]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("ok", Assert.Single(response.Results).Message);
    }

    [Fact]
    public async Task QueryDoubleGroupsAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/doubleGroups/query", """{"openConversations":[{"openConversationId":"cid01","appUserId":"app01","userId":"user01"}]}""");

        var response = await _api.QueryDoubleGroupsAsync(new QueryDoubleGroupsRequest
        {
            GroupTemplateId = "tpl01",
            GroupMembers = [new() { AppUserId = "app01", UserId = "user01" }]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("cid01", Assert.Single(response.OpenConversations).OpenConversationId);
    }

    [Fact]
    public async Task GetConversationUrlAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/conversations/urls", """{"url":"https://example.com/chat"}""");

        var response = await _api.GetConversationUrlAsync(new GetConversationUrlRequest
        {
            AppUserId = "app01",
            UserId = "user01",
            ChannelCode = "channel01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("https://example.com/chat", response.Url);
    }

    [Fact]
    public async Task QueryUnreadMessagesAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/unReadMsgs/query", """{"unReadCount":3,"unReadItems":[{"openConversationId":"cid01","unReadCount":3}]}""");

        var response = await _api.QueryUnreadMessagesAsync(new QueryUnreadMessagesRequest { AppUserId = "app01" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(3, response.UnReadCount);
        Assert.Equal("cid01", Assert.Single(response.UnReadItems).OpenConversationId);
    }

    [Fact]
    public async Task AddGroupMembersAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/groups/members", """{"appUserIds":["app01"],"userIds":["user01"]}""");

        var response = await _api.AddGroupMembersAsync(new UpdateGroupMembersRequest
        {
            OpenConversationId = "cid01",
            AppUserIds = ["app01"],
            UserIds = ["user01"],
            OperatorId = "user01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("user01", Assert.Single(response.UserIds));
    }

    [Fact]
    public async Task RemoveGroupMembersAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/groups/members/remove", """{"message":"ok"}""");

        var response = await _api.RemoveGroupMembersAsync(new UpdateGroupMembersRequest
        {
            OpenConversationId = "cid01",
            AppUserIds = ["app01"],
            OperatorId = "user01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("ok", response.Message);
    }

    [Fact]
    public async Task UpdateGroupAvatarAsyncTest()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/im/interconnections/groups/avatars", """{"newGroupAvatar":"https://example.com/a.png"}""");

        var response = await _api.UpdateGroupAvatarAsync(new UpdateGroupAvatarRequest { OpenConversationId = "cid01", GroupAvatar = "https://example.com/a.png" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("https://example.com/a.png", response.NewGroupAvatar);
    }

    [Fact]
    public async Task UpdateGroupNameAsyncTest()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/im/interconnections/groups/names", """{"newGroupName":"新群名"}""");

        var response = await _api.UpdateGroupNameAsync(new UpdateGroupNameRequest { OpenConversationId = "cid01", GroupName = "新群名" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("新群名", response.NewGroupName);
    }

    [Fact]
    public async Task UpdateGroupOwnerAsyncTest()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/im/interconnections/groups/owners", """{"newGroupOwnerId":"app01","newGroupOwnerType":2}""");

        var response = await _api.UpdateGroupOwnerAsync(new UpdateGroupOwnerRequest { OpenConversationId = "cid01", GroupOwnerId = "app01", GroupOwnerType = 2 }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(2, response.NewGroupOwnerType);
    }

    [Fact]
    public async Task QueryGroupMembersAsyncTest()
    {
        SetupResponse(HttpMethod.Get, "/v1.0/im/interconnections/conversations/members", """{"openConversationId":"cid01","groupMembers":[{"groupMemberId":"app01","groupMemberName":"客户","groupMemberType":2,"groupMemberAvatar":"https://example.com/a.png","groupMemberDynamics":"{}"}]}""");

        var response = await _api.QueryGroupMembersAsync(new QueryGroupMembersRequest("cid01"), cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("客户", Assert.Single(response.GroupMembers).GroupMemberName);
    }

    [Fact]
    public async Task DismissGroupAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/groups/dismiss", """{"openConversationId":"cid01"}""");

        var response = await _api.DismissGroupAsync(new DismissGroupRequest { OpenConversationId = "cid01" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("cid01", response.OpenConversationId);
    }

    [Fact]
    public async Task SendRobotGroupMessageAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/robotMessages/send", """{"success":true}""");

        var response = await _api.SendRobotGroupMessageAsync(new SendRobotGroupMessageRequest
        {
            OpenConversationIds = ["cid01"],
            MsgType = "text",
            MsgContent = "{\"text\":{\"content\":\"hello\"}}",
            AtAll = true
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
    }

    [Fact]
    public async Task SendMessageAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/messages/send", """{"requestId":"req01"}""");

        var response = await _api.SendMessageAsync(new SendInterconnectionMessageRequest
        {
            SenderId = "app01",
            ReceiverId = "user01",
            MessageType = "text",
            Message = "{\"text\":{\"content\":\"hello\"}}"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req01", response.RequestId);
    }

    [Fact]
    public async Task SendDingMessageAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/im/interconnections/dingMessages/send", """{"requestId":"req02"}""");

        var response = await _api.SendDingMessageAsync(new SendDingMessageRequest
        {
            SenderId = "user01",
            ReceiverId = "app01",
            MessageType = "text",
            Message = "{\"text\":{\"content\":\"hello\"}}",
            Code = "code01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req02", response.RequestId);
    }

    private void SetupResponse(HttpMethod method, string path, string json)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == method &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            });
    }
}
