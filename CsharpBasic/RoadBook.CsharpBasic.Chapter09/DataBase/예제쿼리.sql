USE testdb

--���̺����
CREATE TABLE TB_USER
(
	ID VARCHAR(100),
	NAME VARCHAR(100),
	AGE INT,
	JOB VARCHAR(100)
)

--�������߰�
INSERT INTO TB_USER ( ID, NAME, AGE, JOB )
VALUES ( 'U001', '����', '20', '�л�' )

INSERT INTO TB_USER ( ID, NAME, AGE, JOB )
VALUES ( 'U002', '����', '28', '�����̳�' )

INSERT INTO TB_USER ( ID, NAME, AGE, JOB )
VALUES ( 'U003', '����', '30', '���α׷���' )

INSERT INTO TB_USER ( ID, NAME, AGE, JOB )
VALUES ( 'U004', '����', '25', '�丮��' )

INSERT INTO TB_USER ( ID, NAME, AGE, JOB )
VALUES ( 'U005', '����', '32', '����' )

--��������ȸ
SELECT
	ID, NAME, AGE, JOB
FROM
	TB_USER WITH(NOLOCK)

--�����ͼ���
UPDATE
	TB_USER
SET
	NAME = '����_����'
WHERE
	ID = 'U001'

--�����ͻ���
DELETE FROM TB_USER WHERE ID = 'U006'