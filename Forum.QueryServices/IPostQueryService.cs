using System.Collections.Generic;
using Forum.QueryServices.DTOs;

namespace Forum.QueryServices
{
    /// <summary>���Ӳ�ѯ����
    /// </summary>
    public interface IPostQueryService
    {
        /// <summary>��ѯ�����б�
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        IEnumerable<PostInfo> QueryPosts(PostQueryOption option);
        /// <summary>��ѯ��������
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        PostInfo QueryPost(string postId);
    }
}