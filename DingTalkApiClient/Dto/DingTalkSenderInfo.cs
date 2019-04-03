using System.Collections.Generic;

namespace DingTalkApiClient.Dto
{
    /// <summary>
    /// ActionCard消息
    /// </summary>
    public class DingTalkSenderInfo
    {
        /// <summary>
        /// 目标用户Id
        /// </summary>
        public string touser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string toparty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string agentid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgtype { get => "action_card"; }
        /// <summary>
        /// 
        /// </summary>
        public Action_card action_card { get; set; }
    }
    /// <summary>
    /// 消息内容
    /// </summary>
    public class Action_card
    {
        /// <summary>
        /// 透出到会话列表和通知的文案
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 消息内容，支持markdown，语法参考标准markdown语法。图片举例：![alt text](serverapi2/mediaId)
        /// </summary>
        public string markdown { get; set; }
        /// <summary>
        /// 使用独立跳转ActionCard样式时的按钮排列方式，竖直排列(0)，横向排列(1)；必须与btn_json_list同时设置
        /// </summary>
        public string btn_orientation { get; set; }
        /// <summary>
        /// 使用独立跳转ActionCard样式时的按钮列表；必须与btn_orientation同时设置
        /// </summary>
        public IEnumerable<Btn_json_list> btn_json_list { get; set; }

    }
    /// <summary>
    /// 按钮信息
    /// </summary>
    public class Btn_json_list
    {
        /// <summary>
        /// 使用独立跳转ActionCard样式时的按钮的标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 消息点击链接地址，当发送消息为E应用时支持E应用跳转链接
        /// </summary>
        public string action_url { get; set; }
    }
}
