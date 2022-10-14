--MY SQL
--Runtime 578 ms Beats 53.86%
select

    ROUND(
            IFNULL(
                   
                   (select count(*) from  (select distinct requester_id  , accepter_id  from RequestAccepted  ) as b)
                   /
                   ( select count(*) from (select distinct sender_id , send_to_id  from FriendRequest ) as a)
                   
                ,0)
        ,2)

 as accept_rate 


 --SQL SERVER
 --Runtime 600 ms Beats 62.9%
 select

   ROUND(
       
        ISNULL
            (
                (select count(*) from(select distinct requester_id ,accepter_id from RequestAccepted )as a)*1.00
                /
              nullif
              (
                  (select count(*) from(select distinct sender_id  ,send_to_id  from FriendRequest  ) as b)
              ,0)  

                ,0
            )

       ,2)
 as accept_rate 
