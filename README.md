ShowMeSomeSkills
================

Complete each exercise using the data provided by Repo.All().
Store the data returned by Repo.All(), each call to this method randomly generates data.
Each exercise should end with a Console.ReadLine().  You may change anything within this solution.

When you have completed this task, submit a pull request or zip the solution and return to your recruiter.

Exercise 1
--
Calculate the SubTotal and Total for InvoiceItems.

Output invoice number and all line item properties.

* InvoiceItem SubTotal; Will be equal to the UnitPrice * Quantity
* InvoiceItem Total; Will be equal to the SubTotal, minus the percentage based discount, and if line item is taxable apply the invoiced tax rate

Exercise 2
--
Calculate the SubTotal and Total for Invoice.

Output invoice number, Company Name, SubTotal, Total, and the invoice line items with it's SubTotal and Total.

* Invoice SubTotal; Will be equal to the summation of line items Total
* Invoice Total; will be equal to SubTotal plus the Shipping

Exercise 3
--
Add a new field to store commission amount for the invoice.
Commission must be calculated from the line item subtotal minus any discounts.
Commission rate is 3%.
Round the commission amount to the nearest half dollar.

Use the same output from Exercise 2 and include the commission amount.

* $10.25 = $10.00
* $10.30 = $10.50
* $10.60 = $10.50
* $10.90 = $11.00

Extra Credit
--
Write sql statements to create backing tables for Invoice and Invoice Item.