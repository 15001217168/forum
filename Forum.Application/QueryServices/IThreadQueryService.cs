using System;
using System.Collections.Generic;

namespace Forum.Application.QueryServices
{
    /// <summary>�����б��ѯ����
    /// </summary>
    public interface IThreadQueryService
    {
        /// <summary>���ݰ��ID��ѯ�����б�
        /// </summary>
        /// <param name="sectionId"></param>
        /// <returns></returns>
        IEnumerable<dynamic> QueryThreads(Guid sectionId);
    }
}