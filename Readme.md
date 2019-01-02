# Security Toolbox

**Application**: Personal Security Toolbox

**Manufacturer**: Darron Haworth

**Version**: 1.2.0.0 - Public  IP Lookup tab complete

**Support Info**:  Not officially supported, if you have issues with the tool or would like to make feature enhancements email darron.haworth@gmail.com

**Release Notes**:

This app is a work in progress, built for myself and my personal use I thought it might be useful to others.  

The Public IP lookup feature is working, but it needs more robust error handling.  Right now it uses http://ip-api.com/ to do IP lookups in batches of 100, the free api service has a limit of 150 requests per minute.  If you exceed this, the public IP you are running the app from will be blacklisted and you will need to request the public IP removal from ip-api.com blacklist.

When running the application, the checkbox option for blacklist info makes individual dns queries against the spamhaus blacklist db for each ip in the list, this is slow and I hope to refactor this to do batch lookups as well if possible.

Enjoy,
Darron