using Moq.Protected;
using Moq;
using System.Net;
using DingTalkApiClient.Apis.Contacts;
using DingTalkApiClient.Models.Contacts.UserManage;
using Microsoft.Extensions.DependencyInjection;

namespace DingTalkApiClient.Tests;

public class UserManageApiTests : TestBase
{
    private readonly IUserManageApi _api;

    public UserManageApiTests()
    {
        _api = Provider.GetRequiredService<IUserManageApi>();
    }

    [Fact]
    public async Task GetUserByMobileAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("user/getbymobile")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"errcode\":0,\"errmsg\":\"ok\",\"result\":{\"userid\":\"user01\"}}", System.Text.Encoding.UTF8, "application/json")
            });

        var request = new MobileRequest("13800138000");
        var response = await _api.GetUserByMobileAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
        Assert.NotNull(response.Result);
        Assert.Equal("user01", response.Result.Userid);
    }

    [Fact]
    public async Task GetUserAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("user/get")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""
                {
                  "errcode":0,
                  "errmsg":"ok",
                  "result":{
                    "exclusive_account_type":"dingtalk",
                    "extension":"{}",
                    "unionid":"union01",
                    "boss":"false",
                    "exclusive_account":"false",
                    "manager_userid":"",
                    "admin":"false",
                    "remark":"",
                    "title":"",
                    "hired_date":"0",
                    "userid":"user01",
                    "org_email_type":"",
                    "work_place":"",
                    "real_authed":"true",
                    "nickname":"",
                    "dept_id_list":"1",
                    "job_number":"",
                    "email":"",
                    "login_id":"",
                    "exclusive_account_corp_name":"",
                    "mobile":"",
                    "active":"true",
                    "telephone":"",
                    "avatar":"",
                    "hide_mobile":"false",
                    "exclusive_account_corp_id":"",
                    "senior":"false",
                    "org_email":"",
                    "name":"张三",
                    "state_code":"86"
                  }
                }
                """, System.Text.Encoding.UTF8, "application/json")
            });

        var request = new GetUserInfoRequest("user01");
        var response = await _api.GetUserAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
        Assert.Equal("张三", response.Result!.Name);
    }
}
