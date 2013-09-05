using System.Collections.Generic;
using Forum.Application.DTOs;

namespace Forum.Application.QueryServices
{
    /// <summary>�����б��ѯ����
    /// </summary>
    public interface IThreadQueryService
    {
        /// <summary>��ѯ�����б�
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        IEnumerable<Thread> QueryThreads(ThreadQueryOption option);
    }
}