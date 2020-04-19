# BlazorEFCURD <br />
 1 Change connections string in Appsetting.JSON to your server. <br />
 2 Make sure you already have migrations file and update <br>
- Create migrations <br>
> dotnet ef migrations add "Init" <br />
- Update into your database <br />
> dotnet ef database update "Init"
