# SimpleChat
this is an introduction about this simplechat service and client application

## Compile Program
- move workspace to .\src\server\simpleChats
- dotnet build
> **Example:** 

`CMD` cd E:\SourceCode\src\server\simpleChats  
`CMD` dotnet build  

## Run program:

### Service side
- move workspace to complied output bin folder(where simpleChats.dll located)
- dotnet simpleChats.dll --urls "http://0.0.0.0:5050"
### Service in Swagger
after servie running, it would launch a swagger page as API guide in following link:  
http://localhost:5050/swagger/index.html

### Client side
open 2 sampleA.html and sampleB.html locally with chrome browser. 
> **Note:** there would be cross-domain issue when debug it locally, please install Allow CORS: [Access-Control-Allow-Origin](https://chrome.google.com/webstore/detail/allow-cors-access-control/lhobafahddgcelffkeicbaginigeejlf?hl=en) from chrome extension web store, and enable it before load html page.

- in the sample html page-A, there is a sender Tom and receiver Jerry in the chat
- in the sample html page-B, there is a sender Jerry and receiver Tom in the chat

![image](https://user-images.githubusercontent.com/20292145/198251463-444df881-3995-43f5-9ce1-3bcc430df48c.png)
