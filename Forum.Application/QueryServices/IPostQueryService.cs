using System.Collections.Generic;
using Forum.Application.DTOs;

namespace Forum.Application.QueryServices
{
    /// <summary>���Ӳ�ѯ����
    /// </summary>
    public interface IPostQueryService
    {
        /// <summary>��ѯ�����б�
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        IEnumerable<Post> QueryPosts(PostQueryOption option);
    }
}