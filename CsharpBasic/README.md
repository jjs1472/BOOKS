### 본 예제 프로그램은 Csharp 기본편에 해당 하는 내용으로 구성 되어 있다.

# 1. 목차
1. Intro
    * Hello World
2. 데이터 짝 맞추기
    * 변수
3. 데이터의 흐름을 제어하자
    * 조건문
    * 반복문
4. 여러 개의 데이터를 담아내고 싶어
    * 배열
5. 코드를 조립하자
    * namespace
    * using
    * class
    * method
    * interface
6. 문자열/숫자 다루기
    * 문자열 함수
    * 숫자 함수
    * 파일 입출력
7. 어디에 담을까?
    * Collection
      * ArrayList
      * Queue
      * Stack
      * Hashtable
    * Generic
      * List&lt;T&gt;
      * Queue
      * Stack
      * Dictionary
8. 예외 처리
    * try - catch - finally
9. 데이터베이스와의 만남
    * ADO.NET
10. 콘솔 게시판 만들기
11. Lambda 와 Linq
    * delegate
    * event
    * extend method
    * lambda
    * linq
12. 검색엔진 만들기
    * Nuget
    * Crawling
      * Linq to SQL
      * Linq to XML
    * Lucene.net
      * Indexing
      * Searching
13. Csharp New Feature
    * 4.x 기능
    * 5.x 기능
    * 6.x 기능
    * 7.x 기능(Expected)
14. 부록
    * WEB
      * ASP.NET 웹폼을 이용한 웹페이지구현
    * DB
      * SQL 기본 쿼리문

# 2. 실행
* 실행하고자 하는 프로젝트에 "오른쪽 마우스 클릭 > 시작 프로젝트로 설정"
* Program.cs 파일 오픈
* 메인 메소드에, 실행 하고자 하는 클래스 객체 생성 후 객체.run() 수행

ex) Chapter1의 Hello.cs를 실행 하고 싶다고 가정,
```csharp
Examples.Hello hello = new Examples.Hello();
hello.run();
```