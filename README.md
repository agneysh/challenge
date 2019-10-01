# Gateway Challenge

## Technical Details
 - .Net Core 2.2
 - Entity Framework Core
 - AutoMapper
 - Repository Pattern

 ## The Scope
 A Web API that will place orders and send the checkout to a bank

 - Create a RESTful service that allows client applications to manage the deal with the Orders. It needs to expose endpoints to create, read.

## Assumptions
 - No handling of Stock
 - No Shipping
 - Always Store all the requests for tracking.

# API Endpoints
### CREATE Order

````
POST /api/orders

{
    "ClientId" : "CL124",
    "CardNumber" : 5555666677778888,
    "CVV" : 321,
    "CardExpiry" : "01/2020",
    "OrderRef" : "ORD2CL124",
    "OrderDate" : "12/09/2019",
    "Amount" : 20.00,
    "Currency" : "MUR",
    "MerchantID" : "MERCH1963254"
}
````

### GET Orders
````
GET /api/orders
````

## Improvements

- Unit Testing

- The Architecture could have been better.

- The Storage is using in Memory currently, modifications have been made for it to use SQL Server.

- Authentication for the API.

- Encryption

- Logging the transactions done.

- The URL For the "Bank" could be moved to a config file for easier change and reuse.
