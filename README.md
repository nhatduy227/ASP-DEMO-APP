
# API Developer Demo Web Application

## Run locally (Dev)

This demo has 2 main sections: <br/>
&nbsp;&nbsp;&nbsp;Default.apsx <br/>
&nbsp;&nbsp;&nbsp;Default.aspx.cs <br/>

### Default.aspx
Contains the ASP.NET elements of the default pages, including the following components:
- Welcome Text
- Load User Button
- Tabular Table Contain all of the user info (that will be fetch from the dummy API)

<br/>

### Default.aspx
Contains the ASP.NET functions of the default pages, including the following functions:
- LoadUsers_Click: Invoke an API call to https://dummyjson.com/users to get all the user info
- ExtractContentBetweenBrackets: Process Json data return from the API call to match with the desired format 
- DisplayUsers: create HTMLTableCell and HTMLTableRow once the data fetching step is completed to display user infomation in the table

### Demo Image
![Main Page Before Load User is hit](path/to/image.png)
![Main Page After Load User is hit](path/to/image.png)


