using System.Collections.Generic;
using Forum.QueryServices.DTOs;

namespace Forum.QueryServices
{
    /// <summary>����ѯ����
    /// </summary>
    public interface ISectionQueryService
    {
        /// <summary>��ѯ���а��
        /// </summary>
        /// <returns></returns>
        IEnumerable<SectionInfo> FindAll();
    }
}