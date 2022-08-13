With TopInvoice as
(
 select top 1 invoice_id 
    from Purchases as p1
    join  Products as p2
    on p1.product_id =p2.product_id 
    group by invoice_id 
    order by SUM(quantity *price ) desc, invoice_id asc
    )

select p1.product_id , quantity , quantity *price as price
 from Purchases as p1
    join  Products as p2
    on p1.product_id =p2.product_id 
    where  p1.invoice_id = (select * from TopInvoice)

--    sql server
--    Runtime: 1652 ms, faster than 100.00% of MS SQL Server online submissions for Generate the Invoice.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Generate the Invoice.


--With TopInvoice as
--(
-- select  invoice_id 
--    from Purchases as p1
--    join  Products as p2
--    on p1.product_id =p2.product_id 
--    group by invoice_id 
--    order by SUM(quantity *price ) desc, invoice_id asc
--    limit 1
--    )

--select p1.product_id , quantity , quantity *price as price
-- from Purchases as p1
--    join  Products as p2
--    on p1.product_id =p2.product_id 
--    where  p1.invoice_id = (select * from TopInvoice)

--    mysql
--    Runtime: 717 ms, faster than 100.00% of MySQL online submissions for Generate the Invoice.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Generate the Invoice.