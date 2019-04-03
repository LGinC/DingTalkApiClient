using System.Collections.Generic;

namespace DingTalkApiClient.Dto
{
    /// <summary>
    /// 钉钉组织架构列表Dto
    /// </summary>
    public class OrgListDtoInDD : BaseResponse
    {
        /// <summary>
        /// 部门
        /// </summary>
        public IEnumerable<DepartmentInDDListDto> Department { get; set; }
    }
    /// <summary>
    /// 钉钉部门列表
    /// </summary>
    public class DepartmentInDDListDto 
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 当群已经创建后，是否有新人加入部门会自动加入该群
        /// </summary>
        public bool AutoAddUser { get; set; }
        /// <summary>
        /// 是否同步创建一个关联此部门的企业群
        /// </summary>
        public bool CreateDeptGroup { get; set; }
        /// <summary>
        /// 父部门id，根部门为1
        /// </summary>
        public int? Parentid { get; set; }

    }
}