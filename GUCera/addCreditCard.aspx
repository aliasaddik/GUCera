<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCreditCard.aspx.cs" Inherits="GUCera.addCreditCard" %>

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
            #Label{
                font-family: sans-serif;
                font-size: 20px;
                color:red;

            }
        #Label1,#Label2,#Label3,#Label4{
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
        
    </style>
    <div id="card">
    <form id="form1" runat="server">
        
       <h1>Add Credit Card </h1>
       
        <asp:Label ID="Label1" runat="server" Text="Enter Card Number"></asp:Label><br />
        <asp:TextBox ID="number" runat="server"></asp:TextBox>
        <br />
       
        <asp:Label ID="Label2" runat="server" Text="Enter Card Holder Name"></asp:Label><br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <p>
         <asp:Label ID="Label3" runat="server" Text="Enter expiry date: "></asp:Label><br />
            <asp:Label  runat="server" Text="Format: [mm/dd/yyyy] "></asp:Label><br />
        <asp:TextBox ID="date" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Enter CVV "></asp:Label><br />
        <asp:TextBox ID="cvv" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" class="submit" runat="server" onClick="addCard" Text="add credit card" />
        </p>
        <p>
            <asp:Label ID="Label" runat="server" Text=""></asp:Label>
        </p>
        
    </form>
        </div>
</body>
</html>
