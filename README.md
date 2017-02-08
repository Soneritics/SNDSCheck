# SNDSCheck
WCF service to check if an IP has been listed on the Outlook Smart Network Data Service list.

## Smart Network Data Service
As described by Microsoft:
> Deliverability to Outlook.com is based on your reputation. The Outlook.com Smart Network Data Services (SNDS) gives you the data you need to understand and improve your reputation at Outlook.com. But just looking at the data isn't enough! Maintaining a good reputation is a lot of work. You should use this data to keep your mailing lists clean and to monitor the IPs you control for unusual behavior. Reputation is always the responsibility of the sender. SNDS gives senders access to detailed data about individual IPs, and it also includes our Junk Email Reporting Program, which lets you receive reports when users junk your messages. Now you can view IP data and manage feedback loop settings from one convenient website.

## Setting up
First, sign up for SNDS and request access for your server's IPs.
Next, go to View Data -> Automated Data Access.

The access key in the URL is the key to use with this service.

## Links
Smart Network Data Service:
* https://postmaster.live.com/snds/

Automated Data Access
* https://postmaster.live.com/snds/auto.aspx
