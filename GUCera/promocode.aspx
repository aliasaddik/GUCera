<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promocode.aspx.cs" Inherits="GUCera.promocode" %>

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
         #Label4 {
               color:red;
               font-size: 20px;

         }
        .label,#Label1,#Label2,#Label3 {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            margin-top:20px;
        }
         .submit {
           width: 200px;
           color: white;
           background-color: 	#D3D3D3;
          font-size: 20px;
          }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
         .container {
            padding: 2px 16px;

          }

          .card{
              margin-top:150px;
              margin-left:235px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 60%;
              height:60%;
              border-radius: 5px;
             background-color: #F0F8FF;
            
          }
          body{
             background-color: #B0C4DE;
             
          }
         #form1{
             text-align: center;
         }
         #Button1{
             margin-bottom:40px;
         }
          
       
    </style>
    <div class="card">
    <form id="form1" runat="server">
        <h1>Create Promocode</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Code:"></asp:Label><br />
            <asp:TextBox ID="code" runat="server"></asp:TextBox><br />
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="expiry date:"></asp:Label><br />
             <asp:Label  runat="server" Text="Format: [mm/dd/yyyy] "></asp:Label><br />
            <asp:TextBox ID="expirydate" runat="server"></asp:TextBox><br />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="discount:"></asp:Label><br />
            <asp:TextBox ID="discount" runat="server"></asp:TextBox><br />
        </p>
        <p>
            <asp:Button ID="Button1"  class="submit" runat="server" Text="create promocode" OnClick="Button1_Click" /><br />

        </p>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </form>
        </div>
</body>
</html>
