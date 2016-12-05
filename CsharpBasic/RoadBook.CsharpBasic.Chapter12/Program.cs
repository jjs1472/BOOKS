namespace RoadBook.CsharpBasic.Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.LuceneBasic basic = new Examples.LuceneBasic();
            basic.run();

            //Examples.LuceneBasic2 basic = new Examples.LuceneBasic2();
            //basic.run();

            // 수집
            //SearchEngine.Crawl crawl = new SearchEngine.Crawl();
            //crawl.run();

            // 색인
            //SearchEngine.Index index = new SearchEngine.Index();
            //index.run();

            // 검색
            //SearchEngine.Search search = new SearchEngine.Search();
            //search.run("진짜");
        }
    }
}