using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine
{
    public class Crawl
    {
        private Manager.XmlManager _xmlManager;
        private Manager.DBManager _dbManager;

        private int _crawlCnt = 0;
        private string _multipleRowSeparator = "||";

        public Crawl()
        {
            _xmlManager = new Manager.XmlManager(Manager.XmlManager.USE_TYPE.WRITE);
            _dbManager = new Manager.DBManager();
        }

        public void run()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            _dbManager.open();

            List<Model.Board> boardList = _dbManager.scanBoardTable();

            boardList.ForEach(b =>
            {
                List<LinqProvider.TB_REPLY> replyList = _dbManager.scanReplyTable(b.IDX);

                replyList.ForEach(r =>
                {
                    b.REPLY_COMMENT += r.COMMENT + _multipleRowSeparator;
                    b.REPLY_WRITER += r.WRITER_NAME + _multipleRowSeparator;
                });
                
                _xmlManager.writeXML(b);

                _crawlCnt++;
            });

            _xmlManager.saveXML();
            _dbManager.close();

            sw.Stop();

            Console.WriteLine("총 " + _crawlCnt + "건 수집 / 소요시간 : " + sw.Elapsed.ToString());
        }
    }
}
