USE assessment;
GO

-- Select all the columns in cart where the username is kmilner1j
Select *
From Carts
Where username ='kmilner1j'
-- Select the id and name columns from items where the item was added on or after Jan. 15, 2019 and the weight is null
Select id, name
From items
Where added > '2019-01-15' AND Weight IS NULL
-- Select username and the cookie_value from carts where the username isn't null, ordered by the created date, latest first
Select username, cookie_value
FRom carts
WHERE carts.username is not null
Order by created desc
-- Select the added date and the count of all the items added on that date ***come back
--SELECT Count(added) as newadded
--From items
--Order by newadded


SELECT count(added), added

FRom items
group by added


-- Select the cart's username and created date and the item's name for all carts created in the month of Sept. 2019**Comeback
SELECT username, created
FROM carts 
--join items on carts.id = items.cart_id 
WHERE created >='2019-09-01' and created <='2019-10-01'







Insert into carts VALUES ('rhuch', 'b053d', '2020-02-24')