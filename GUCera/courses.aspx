<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="GUCera.courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        .button {
          background-color: #ddd;
          border: none;
          color: black;
          padding: 10px 20px;
          text-align: center;
          text-decoration: none;
          display: inline-block;
          margin: 4px 2px;
          cursor: pointer;
          border-radius: 16px;
         }
        
          div:hover {
           box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
          }

          .container {
            padding: 2px 16px;
           }
          div{
              margin-top:30px;
              margin-left:250px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 50%;
              border-radius: 5px;
             background-color: ghostwhite;
            
          }

          body{
            background-color: #B0C4DE;
             
          }
          h3{
              
              
              font-family: sans-serif;
              color: #4682B4;

          }
        #form1 {
            text-align:center;
        }
         h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;
            text-align:center;

        }
    </style>
    <form id="form1" runat="server">
        <h1>Available Courses</h1>
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
