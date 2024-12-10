create table tbCustomer (
ID int,
Customer_ID varchar(max),
Transaction_Date date
)

insert into tbCustomer
SELECT 1, '21', '7/30/2019'
UNION ALL SELECT 2, '15', '7/21/2019'
UNION ALL SELECT 3, '16', '7/18/2019'
UNION ALL SELECT 4, '20', '7/22/2019'
UNION ALL SELECT 5, '15', '7/15/2019'
UNION ALL SELECT 6, '20', '7/12/2019'
UNION ALL SELECT 7, '15', '7/21/2019'
UNION ALL SELECT 8, '20', '7/12/2019'

SELECT Customer_ID, count(Transaction_Date) as 'Total Penjualan' 
FROM tbCustomer
GROUP BY Customer_ID
ORDER BY count(Transaction_Date) desc, Customer_ID asc 