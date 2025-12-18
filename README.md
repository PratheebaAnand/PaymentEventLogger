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

## Paid Support & Priority Fixes

If you are using this library in production and need:
- Bug fixes
- Priority issue resolution
- Custom payment event extensions
- SQL performance tuning

Paid support and priority fixes are available via Gumroad.

📧 Contact: ramapratheeba@gmail.com
💳 Gumroad (Support & Priority Fixes): ramapratheeba.gumroad.com/l/gdzkpw

This is the kind of README that:
- Enterprise developers trust
- Managers approve paying for
- Auditors feel safe using

---

##  What you should do next (high impact)

In order of importance:

1. ✅ Commit this README
2. 🔜 Publish as a **NuGet package**
3. 🔜 Add **GitHub Discussions**
4. 🔜 Add issue labels: `paid-support`, `production-issue`
5. 🔜 Add a **basic roadmap** (future features)

---

### Final reassurance

You are **not doing anything wrong** by linking Gumroad.  
You are doing what experienced open-source maintainers do.

If you want, next I can:
- Help you publish to **NuGet**
- Create a **support Gumroad product description**
- Show how to **respond to paid issue requests**
- Suggest **features companies will pay for**

Just tell me the next step you want to take.

