Payment Event Logger Template

A lightweight ASP.NET Core Web API template for logging and debugging payment webhook events.
This project helps developers capture payment provider events and store them in SQL Server for easier debugging and monitoring.

⭐ Download the complete working project:
https://ramapratheeba.gumroad.com/l/gdzkpw

Why This Tool?

When integrating payment providers like Stripe or WorldPay, debugging webhook events can be difficult.
If something fails, it is often hard to understand:

What event was received?
What payload was sent?
What error occurred?

This template provides a simple API to log payment events so developers can easily monitor and debug payment flows.

Features

✔ Log payment webhook events
✔ Store events in SQL Server
✔ Simple REST API
✔ Lightweight and easy to integrate
✔ Works with any payment provider

Technology Stack

ASP.NET Core Web API

SQL Server

Dapper

REST API

Database Setup

Create the following table in SQL Server.

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
Setup Instructions

1️⃣ Clone or download the repository.

2️⃣ Create the database table using the SQL script above.

3️⃣ Update the connection string in Program.cs.

Example:

string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PaymentEventLoggerDb;Trusted_Connection=True;";

4️⃣ Run the project.

API Endpoint
Log Payment Event

POST

/api/PaymentEvent/log-payment
Example Request
{
  "Provider": "Stripe",
  "EventType": "payment_failed",
  "Status": "Failed",
  "ReferenceId": "pi_123456",
  "Payload": "{}",
  "ErrorMessage": "Insufficient funds"
}
Example Response
Payment event logged successfully!
Example Logged Data
Provider	EventType	Status	ReferenceId	CreatedAt
Stripe	payment_failed	Failed	pi_123456	2026-03-05
WorldPay	payment_succeeded	Success	wp_567890	2026-03-05
Use Cases

This tool can be used for:

Debugging payment webhook failures

Monitoring payment events

Logging Stripe / WorldPay webhook calls

Auditing payment activity

Building payment dashboards

Paid Support & Priority Fixes

If you are using this project in production and need:

Bug fixes

Priority support

Custom payment provider integrations

Performance improvements

You can download the complete project and receive support via Gumroad.

📥 Download:
https://ramapratheeba.gumroad.com/l/gdzkpw

📧 Contact:
ramapratheeba@gmail.com

Roadmap

Planned improvements:

Payment event dashboard

Event search and filtering

Multiple provider support

Webhook validation support

Event retry mechanism

Contributing

Contributions are welcome.
You can submit improvements via pull requests.

License

This project is provided for educational and development purposes.

⭐ If you found this project useful, please consider starring the repository.

