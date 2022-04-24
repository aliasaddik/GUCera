<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issuecertificate.aspx.cs" Inherits="GUCera.issuecertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
}
        #errorl {
            font-family: sans-serif;
            color:red;
            font-size: 20px;

         }
        .label,#cid,#couID,#sid,#stuID,#issd,#issdate,#issc{
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            margin-top:20px;
        }
        h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;

        }
        
         .submit {
           width: 200px;
           color: white;
           background-color: 	#D3D3D3;
          font-size: 20px;
            margin-top: 17px;
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
             text-align: center;
         }

    </style>
    <div id="card">
    <form id="form1" runat="server">
        <h1>Issue Certificate</h1>
        <div>
            <asp:Label ID="cid" runat="server" Text="CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="couID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="sid" runat="server" Text="StudentID"></asp:Label>
            <br />
            <asp:TextBox ID="stuID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="issd" runat="server" Text="IssueDate"></asp:Label>
            <br />
            <asp:TextBox ID="issdate" runat="server"></asp:TextBox>
            <br />
         
            <asp:Button ID="issc" class="submit" runat="server" Text="Issue Certificate" OnClick="issue_c"/><br />
             <asp:Label ID="errorl" runat="server" Text=""></asp:Label>
        </div>
       
                
    </form>
        </div>
</body>
</html>
