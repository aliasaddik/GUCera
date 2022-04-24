<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="GUCera.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
       h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;
            text-align:center;

        }
        
       

         #card:hover {
           box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
          }

          .container {
            padding: 2px 16px;
           }
          #card{
              margin-top:50px;
              margin-left:245px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 60%;
              border-radius: 5px;
             background-color: #F0F8FF;
            
          }
          body{
             background-color: #B0C4DE;
             
          }
         #form1{
             
         }
        h3 {
            margin-left:230px;
            font-family: sans-serif;
        }

    </style>
   
   

   

<div id="card"> 
    <form id="form1" runat="server">
         <h1>My Profile</h1>
        
    </form>
</div>

   
    


        
        
        
        
       
        
        
        
        
   
   
    
   
</body>
</html>
