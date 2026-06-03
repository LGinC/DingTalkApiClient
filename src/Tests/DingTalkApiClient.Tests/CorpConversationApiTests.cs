using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using DingTalkApiClient.Apis.IM;
using DingTalkApiClient.Models.IM.CorpConversation;
using Xunit;
using Moq;
using Moq.Protected;

namespace DingTalkApiClient.Tests;

public class CorpConversationApiTests : TestBase
{
    private readonly ICorpConversationApi _api;

    public CorpConversationApiTests()
    {
        _api = Provider.GetRequiredService<ICorpConversationApi>();
    }

    [Fact]
    public async Task AsyncSendCorpConversationV2Async_Text_Test()
    {
        var request = new AsyncSendCorpConversationV2Request(
            agentId: 123456,
            userIdList: "manager01",
            deptIdList: "",
            toAllUser: false,
            msg: CorpConversationMsgRequest.Create(
                CorpConversationMsgType.Text,
                new CorpConversationMsgRequest.TextObj { Content = "测试工作通知内容" }
            ));

        var response = await _api.AsyncSendCorpConversationV2Async(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task RecallCorpConversationAsyncTest()
    {
        var request = new RecallCorpConversationRequest(agentId: 123456, msgTaskId: 12345);
        var response = await _api.RecallCorpConversationAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task GetSendProgressCorpConversationAsyncTest()
    {
        var request = new GetSendProgressCorpConversationRequest(agentId: 123456, taskId: 12345);
        var response = await _api.GetSendProgressCorpConversationAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task GetSendResultCorpConversationAsyncTest()
    {
        var request = new GetSendResultCorpConversationRequest(agentId: 123456, taskId: 12345);
        var response = await _api.GetSendResultCorpConversationAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task UpdateStatusBarCorpConversationAsyncTest()
    {
        var request = new UpdateStatusBarCorpConversationRequest(agentId: 123456, taskId: 12345, statusValue: "处理中", statusBg: "0x0000FF");
        var response = await _api.UpdateStatusBarCorpConversationAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendByTemplateCorpConversationAsyncTest()
    {
        var request = new SendByTemplateCorpConversationRequest(agentId: 123456, templateId: "template1", userIdList: "user1", data: "{}");
        var response = await _api.SendByTemplateCorpConversationAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task AsyncSendCorpConversationV2Async_OA_Test()
    {
        var oaBody = new CorpConversationMsgRequest.OAObj
        {
            Head = new CorpConversationMsgRequest.OAHead { BgColor = "FFBBBBBB", Text = "头部标题" },
            Body = new CorpConversationMsgRequest.OABody
            {
                Title = "正文标题",
                Content = "正文内容",
                Form = [new() { Key = "姓名", Value = "张三" }],
                Author = "李四"
            }
        };
        var request = new AsyncSendCorpConversationV2Request(
            agentId: 123456,
            userIdList: "user1",
            deptIdList: null,
            toAllUser: false,
            msg: CorpConversationMsgRequest.Create(CorpConversationMsgType.OA, oaBody));

        var response = await _api.AsyncSendCorpConversationV2Async(request, cancellationToken: TestContext.Current.CancellationToken);
        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task AsyncSendCorpConversationV2Async_ActionCard_Test()
    {
        var actionCard = new CorpConversationMsgRequest.ActionCardObj
        {
            Title = "卡片标题",
            Markdown = "卡片内容",
            BtnOrientation = "1",
            BtnJsonList = [new() { Title = "按钮1", ActionUrl = "http://test.com" }]
        };
        var request = new AsyncSendCorpConversationV2Request(
            agentId: 123456,
            userIdList: "user1",
            deptIdList: null,
            toAllUser: false,
            msg: CorpConversationMsgRequest.Create(CorpConversationMsgType.ActionCard, actionCard));

        var response = await _api.AsyncSendCorpConversationV2Async(request, cancellationToken: TestContext.Current.CancellationToken);
        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task AsyncSendCorpConversationV2Async_Image_Test()
    {
        var request = new AsyncSendCorpConversationV2Request(
            agentId: 123456,
            userIdList: "user1",
            deptIdList: null,
            toAllUser: false,
            msg: CorpConversationMsgRequest.Create(CorpConversationMsgType.Image, new CorpConversationMsgRequest.ImageObj { MediaId = "mediaId" }));

        var response = await _api.AsyncSendCorpConversationV2Async(request, cancellationToken: TestContext.Current.CancellationToken);
        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }
}
