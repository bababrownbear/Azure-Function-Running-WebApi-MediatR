# Serverless WebApi - Host an ASP.NET Core WebApi in a single Azure Function PLUS MediatR
  
Forked:  
https://blog.wille-zone.de/post/serverless-webapi-hosting-aspnetcore-webapi-in-azure-functions/  
Followed:  
https://carljackson.io/how-to-get-started-with-mediatr-and-asp-net-core-2/  
https://github.com/jbogard/MediatR/wiki  
  
Result:  
![image](https://user-images.githubusercontent.com/29419183/50062238-b0bfd080-016b-11e9-811f-2354478d00a2.png)
  
  
The 'Proxy' Azure function has regex to allow for any route to be entered to target the API. 
  
Sample calls:  
/api/values/5  
/api/todo/something%20to%20%do  
