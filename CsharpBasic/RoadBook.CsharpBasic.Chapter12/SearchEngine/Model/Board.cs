using System;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine.Model
{
    public class Board
    {
        /// <summary>
        /// 게시글 번호
        /// </summary>
        public int IDX { get; set; }
        /// <summary>
        /// 게시글 제목
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// 게시글 내용
        /// </summary>
        public string CONTENT { get; set; }
        /// <summary>
        /// 게시글 작성자
        /// </summary>
        public string WRITER_NAME { get; set; }
        /// <summary>
        /// 게시글 작성일
        /// </summary>
        public DateTime? CREATE_DATE { get; set; }
        /// <summary>
        /// 게시글 수정일
        /// </summary>
        public DateTime? MODIFY_DATE { get; set; }
        /// <summary>
        /// 해시태그
        /// </summary>
        public string TAG { get; set; }
        /// <summary>
        /// 게시판 카테고리
        /// </summary>
        public string CATEGORY_NAME { get; set; }
        /// <summary>
        /// 답글
        /// </summary>
        public string REPLY_COMMENT { get; set; }
        /// <summary>
        /// 답글 작성자
        /// </summary>
        public string REPLY_WRITER { get; set; }
    }
}
