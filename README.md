# ViewState-C-Sharp
64 bit Memory stored on a SINGLE page in an ASP.Net hidden field called "_ViewState".

https://www.youtube.com/watch?v=Lvt1BnSwRvo

ViewState = data held on one single web page, and is not available to other web pages.

It is base 64 encoded, on the server it is base 64 decoded and then loaded back into the 
control on the page.
It is NOT stored on the web server or on the client, it is actually stored on the page.
If you RC the page, there will be a hidden field called "_Viewstate" where ASP.Net stores
the data. 
