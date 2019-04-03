using System;
using System.ComponentModel.DataAnnotations;

namespace DingTalkApiClient.Dto
{

    /// <summary>
    /// API消息返回
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int Errcode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Errmsg { get; set; }

        /// <summary>
        /// 检查返回是否错误 如果返回errcode != 0 则为错误，抛出异常
        /// </summary>
        /// <param name="methodName">正在执行的方法名</param>
        public void CheckError(string methodName = null)
        {
            if (Errcode != 0) throw new Exception($"{methodName} Error:{Errcode}  {Errmsg}");
        }


    }

    /// <summary>
    /// 钉钉api分页请求
    /// </summary>
    public class DingTalkPagedRequest
    {
        /// <summary>
        /// 获取数据的起始点，第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit，0、1、2...依次递增
        /// </summary>
        public int offset { get; set; } = 0;
        /// <summary>
        /// 表示获取数据的条数，最大不能超过50条
        /// </summary>
        [Range(0, 50)]
        public int size { get; set; } = 50;
    }
    /// <summary>
    /// 钉钉api分页请求
    /// </summary>
    public class DingTalkLimitePagedRequest
    {
        /// <summary>
        /// 获取数据的起始点，第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit，0、1、2...依次递增
        /// </summary>
        public int offset { get; set; } = 0;
        /// <summary>
        /// 表示获取数据的条数，最大不能超过50条
        /// </summary>
        [Range(0, 50)]
        public int limit { get; set; } = 50;
    }

    /// <summary>
    /// 钉钉api分页请求
    /// </summary>
    public class DingTalkCursorPagedRequest
    {
        /// <summary>
        /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值
        /// </summary>
        public int cursor { get; set; } = 0;
        /// <summary>
        /// 分页参数，每页大小，最多传10
        /// </summary>
        [Range(0, 50)]
        public int size { get; set; } = 10;
    }
    /// <summary>
    /// 包含是否有更多 属性
    /// </summary>
    public interface IHasMore
    {
        /// <summary>
        /// 是否还有更多消息，用于分页
        /// </summary>
        bool HasMore { get; set; }
    }
    /// <summary>
    /// 是否有下一页数据
    /// </summary>
    public interface IHasNextCursor
    {
        /// <summary>
        /// 有值，值为下次查询的游标
        /// </summary>
        int? Next_cursor { get; set; }
    }

    /// <summary>
    /// 访问凭据返回
    /// </summary>
    public class AccessToken : BaseResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string Access_token { get; set; }

        /// <summary>
        /// 过期时间   单位 s
        /// </summary>
        public int Expires_in { get; set; }
    }
}
