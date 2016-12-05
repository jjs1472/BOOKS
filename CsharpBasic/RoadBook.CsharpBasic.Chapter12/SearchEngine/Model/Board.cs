using System;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine.Model
{
    public class Board
    {
        public int IDX { get; set; }
        public string TITLE { get; set; }
        public string CONTENT { get; set; }
        public string WRITER_NAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string TAG { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string REPLY_COMMENT { get; set; }
        public string REPLY_WRITER { get; set; }
    }
}
