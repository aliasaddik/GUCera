<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addmobile.aspx.cs" Inherits="GUCera.addmobile" %>

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

        }
            #Label2{
                font-family: sans-serif;
                font-size: 20px;
                color:red;

            }
        #Label,#Label1,#Label5{
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            
        }
         .submit {
           width: 200px;
           color: white;
           background-color: 	#D3D3D3;
          font-size: 20px;
            margin-top: 17px;
            margin-bottom:40px;
        }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
         

         #card:hover {
           box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
          }

          .container {
            padding: 2px 16px;
           }
          #card{
              margin-top:100px;
             
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 50%;
              margin-left:300px;
              border-radius: 5px;
             background-color: #F0F8FF;
            
          }
          body{
             background-color: #B0C4DE;
             
          }
         #form1{
             text-align: center;
         }
         #mobileno{
             margin-top:20px;
         }
    </style>
    <div id="card">
    <form id="form1" runat="server">
        <h1>Add Mobile</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your mobile number"></asp:Label><br />
            <asp:TextBox ID="mobileno" runat="server">

            </asp:TextBox><br />
            <asp:Button ID="add" class="submit" runat="server" Text="add mobile number" OnClick="add_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
              

        </div>
    </form>
     </div>
    
</body>
</html>
