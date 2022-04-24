<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeassignment.aspx.cs" Inherits="GUCera.gradeassignment" %>

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
         #Label4 {
               color:red;
               font-size: 20px;

         }
        .label,#stid,#studentID,#coid,#courseid,#assignum,#assignn,#Asst,#asstype,#gr,#assgrade {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
            margin-top:20px;
        }
         .submit {
           margin-top:20px;
           margin-bottom:20px;
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
              margin-top:50px;
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
        <h1>Grade Assignments</h1>
        <div>
            <asp:Label ID="stid" runat="server" Text="StudentID"></asp:Label>
            <br />
            <asp:TextBox ID="studentID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="coid" runat="server" Text="CourseID"></asp:Label>
            <br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="assignum" runat="server" Text="Assignment Number"></asp:Label>
            <br />
            <asp:TextBox ID="assignn" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Asst" runat="server" Text="Assignment Type"></asp:Label>
            <br />
            <asp:TextBox ID="asstype" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="gr" runat="server" Text="Grade"></asp:Label>
            <br />
            <asp:TextBox ID="assgrade" runat="server"></asp:TextBox>
            <br />
          
            <asp:Button ID="gradeass" class="submit" runat="server" Text="Grade Assignment" OnClick="grade_ass" />
        </div>
        <p>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
    </form>
       </div>
</body>
</html>
