<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewassignment.aspx.cs" Inherits="GUCera.viewassignment" %>

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
            margin-top:20px;
            margin-bottom:10px;

         }
         #Label1 {
               color:red;
               font-size: 20px;

         }
       #Label2 {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            margin-top:20px;
        }
         .submit {
             margin-bottom:20px;
           margin-top:20px;
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

          #card{
              margin-top:150px;
              margin-left:240px;
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
        #courseid{
             margin-top:10px;
         }
    </style>
    <div id="card">
    <form id="form1" runat="server">
        <h1>View Assignments</h1>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Enter CourseID"></asp:Label><br />
            
            <asp:TextBox ID="crsid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="viewsubmitted" class="submit" runat="server" Text="View Assignments" OnClick="View_submitted"/>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
       
    
</body>
</html>
