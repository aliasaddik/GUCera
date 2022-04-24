<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addassignment.aspx.cs" Inherits="GUCera.addassignment" %>

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
         #Label{
               color:red;
               font-size: 20px;

         }
        h5 {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            margin-top:20px;
        }
         .submit {
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
              margin-top:10px;
              margin-left:255px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 60%;
              height:970px;
             
              
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
        <h1>Define Assignment</h1>
        <div style="height: 244px">
            <h5>CourseID</h5>
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <h5>Assignment#</h5><br />
            <asp:TextBox ID="assignum" runat="server"></asp:TextBox>
            <br />
            <h5>Assignment Type</h5><br />
            <asp:TextBox ID="assignt" runat="server"></asp:TextBox>
            <br />
            <h5>Full Grade</h5><br />
            <asp:TextBox ID="fullg" runat="server"></asp:TextBox>
            <br />
            <h5>Weight</h5><br />
            <asp:TextBox ID="assignw" runat="server"></asp:TextBox>
            <br />
           <h5> Deadline</h5><br />
            <asp:TextBox ID="deadl" runat="server"></asp:TextBox>
            <br />
            <h5>Content</h5><br />
            <asp:TextBox ID="assigncontent" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="defineassign" class="submit" runat="server" Text="Define Assignment" OnClick="Add_assign"/>
            <p>
            <asp:Label ID="Label" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
        </div>
</body>
</html>
