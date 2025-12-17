# Payment Event Logger Template

This is a simple template for logging payment events using an ASP.NET Core Web API and SQL Server.

## Repository URL
You can access the full code here: [GitHub Repository](https://github.com/PratheebaAnand/PaymentEventLogger)

## Features
- Logs payment events (e.g., payment_failed, payment_succeeded).
- Stores events in a SQL Server database.

## Setup Instructions
1. Clone or download the project from [GitHub Repository](https://github.com/PratheebaAnand/PaymentEventLogger).
2. Set up a SQL Server database and run the following SQL script:
```sql
CREATE TABLE PaymentEvents (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Provider NVARCHAR(50) NOT NULL,
    EventType NVARCHAR(100) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    ReferenceId NVARCHAR(100) NULL,
    Payload NVARCHAR(MAX) NOT NULL,
    ErrorMessage NVARCHAR(MAX) NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
3. Update the connectionString in Program.cs.

## API Endpoint

The API for logging payment events can be accessed at the following endpoint:

**POST** `/log-payment`

**URL:** `https://yourdomain.com/api/PaymentEvent/log-payment`

### **Request Example:**

Send a POST request to /log-payment with the following JSON body:

{
  "Provider": "Stripe",
  "EventType": "payment_failed",
  "Status": "Failed",
  "ReferenceId": "pi_123456",
  "Payload": "{}",
  "ErrorMessage": "Insufficient funds"
}

