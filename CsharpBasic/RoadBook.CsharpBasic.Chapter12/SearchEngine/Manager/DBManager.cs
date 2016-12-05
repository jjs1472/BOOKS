using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine.Manager
{
    public class DBManager
    {
        private LinqProvider.BoardDataContext _boardContext;
        
        public void open()
        {
            _boardContext = new LinqProvider.BoardDataContext();
        }

        public List<LinqProvider.TB_REPLY> scanReplyTable(int boardIdx)
        {
            List<LinqProvider.TB_REPLY> replyResult;

            replyResult = _boardContext.TB_REPLY.Where(r => r.B_IDX == boardIdx).Select(r => r).ToList();

            return replyResult;
        }

        public List<Model.Board> scanBoardTable()
        {
            List<Model.Board> boardResult;

            boardResult = _boardContext.TB_BOARD
                                .Join(
                                _boardContext.TB_CATEGORY,
                                b => b.C_IDX,
                                c => c.IDX,
                                (b, c) => new Model.Board
                                {
                                    IDX = b.IDX,
                                    TITLE = b.TITLE,
                                    CONTENT = b.CONTENT,
                                    WRITER_NAME = b.WRITER_NAME,
                                    CREATE_DATE = b.CREATE_DATE,
                                    MODIFY_DATE = b.MODIFY_DATE,
                                    TAG = b.TAG,
                                    CATEGORY_NAME = c.CATEGORY_NM
                                }
                                ).Select(p => p).ToList();

            return boardResult;
        }

        public void close()
        {
            if (_boardContext != null)
            {
                _boardContext.Dispose();
            }
        }
    }
}
