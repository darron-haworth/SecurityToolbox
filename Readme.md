# Security Toolbox

**TechStack**: Windows Form application<br />
**Application**: Personal Security Toolbox<br />
**Manufacturer**: Darron Haworth<br />
**Version**: 1.2.0.1 - Public  IP Lookup tab + Encoding tools tab 

**Support Info**:  This app is a work in progress, built for myself and my personal use I thought it might be useful to others. This application is not officially supported, if you have issues with the tool or would like to make feature enhancements email darron.haworth@gmail.com

**Release Notes**: 

v1.2.0.0: The Public IP lookup feature is working, but it needs more robust error handling.  Right now it uses http://ip-api.com/ to do IP lookups in batches of 100, the free api service has a limit of 150 requests per minute.  If you exceed this, the public IP you are running the app from will be blacklisted and you will need to request the public IP removal from ip-api.com blacklist.

The checkbox option for blacklist info makes individual dns queries against the spamhaus blacklist db for each ip in the list, this is slow and I hope to refactor this to do batch lookups as well if possible.


v1.2.1.0: Added Encoding/Decoding logic and UI - working

##### ToDo:
- Add threadding so long lookups don't block the UI + add progress indicators etc (also bulk reverse-dns for performance)

 
Enjoy,
Darron