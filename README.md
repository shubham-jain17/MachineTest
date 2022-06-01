Project Brief: 
Project is created using asp.net web api with authenication template .Net FrameWork 4.7.2.
Entity Framework 6 is used as ORM (code-first approach is used)



As Mentioned in the TASK 
1. Register the user

                Fields: Name, Email, Password

                Should send email on successful registration (use Gmail SMTP)

    for this use URI:https://localhost:xxxxX/api/Account/Register



2. Login using email password (Bearer token)
    for this use : https://localhost:XXXX/Token 
                   use this to access token value,passs token value under header key should be 'Authorization' and value like  bearer 'token value'
                   https://localhost:XXXX/api/Account/logindetails?returnUrl=%2F&generateState=true



3. Get the profile of logged in user
    
    Note: Only logged in user can request
    for this use :https://localhost:XXXXX/api/Account/UserInfo
   

4. Save the product data in 2 tables using single api request

                table_products: product name, qty, sku,  price

                table_product_information: product_id, description, product category

    Note: Only logged in user can request

    for this use: https://localhost:xxxxx/api/products
    use post type request it will save data in 2 table on a single request as above mentioned

5. Get the products list with all information.
   
   Note: Only logged in user can request

   for this use: https://localhost:xxxxx/api/products
   use get request will return all products availiable in product table.


6. Enable / Disable the product
    
    Note: Only logged in user can request
    
    for this use: https://localhost:XXXXX/api/products?sku=skuvalue & status= false
    use put request you need to send sku and status value in query string,
    Logic is like if you send status value false in query string status value in database will update to 0,means Product is disable and vice versa is also true. 
    subsequent logic can be prepared on basis of status value 
    note SKU is kept as primary key of product table,Sku data type string and status datatype is boolean.


Note : 
How to setup project.
1.Run Update-Database command in PM console.So that Database will be created in your local machine.
2.Entity Framework 6 must be installed if not


if needed any explanation give a call on +91 7987168806



----EOD-----
