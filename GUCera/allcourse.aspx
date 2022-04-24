<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allcourse.aspx.cs" Inherits="GUCera.allcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <style>
         #Label4 {
               color:red;
               font-size: 20px;

         }
        .label,#Label1,#Label2,#Label3 {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            margin-top:5px;
            margin-bottom:5px;
        }
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
              text-align:center;
              margin-top:30px;
              margin-left:350px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 40%;
              border-radius: 5px;
             background-color: ghostwhite;
            
          }

          body{
             background-color: #B0C4DE;
             
          }
          h3{

              margin-top:10px;
              font-family: sans-serif;
              font-size: 20px;
              margin: 0 0 10px 0;
              color: #4682B4;
              font-size: 30px;


          }
           h1{
             text-align:center;
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;

         }
    </style>

    <form id="form1" runat="server">
        <h1>All Courses</h1>
        
    </form>
</body>
</html>
