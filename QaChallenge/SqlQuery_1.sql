
/*Question 1 */
SELECT city, name
FROM Customers
JOIN Accounts 
    ON Customers.customer_no = Accounts.customer_no
WHERE open_date='1996/12/05';


/*Question 2 */
SELECT country, COUNT(*) AS cards_exp_soon
FROM Customers
JOIN Accounts
  ON Customers.customer_no = Accounts.customer_no
JOIN Cards
  ON Cards.account_number =  Accounts.account_number
WHERE exp_date BETWEEN '2023/01/01' AND '2023/01/31'
GROUP BY country 
ORDER BY cards_exp_soon DESC 
LIMIT 1;


/*Question 3 */
SELECT name, balance
FROM "Customers"
INNER JOIN "Accounts"
  ON "Customers".customer_no = "Accounts".customer_no;


  /* Posibil sa fie o greseala in diagrama UML? Sageata de la tabelul 1 la 2 e gresit pusa. 
  Selecturile le-am facut punand in tabelul Customers PK la customers_no in loc de FK1 */