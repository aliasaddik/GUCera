<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcourse.aspx.cs" Inherits="GUCera.addcourse" %>

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
         #Label,#Label1 {
               color:red;
               font-size: 20px;

         }
        Label{
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
          font-size: 15px;
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
              margin-top:30px;
              margin-left:270px;
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
    <form id="form1" runat="server">
        <h1>Add Course</h1>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
         <asp:Label ID="Label" runat="server" Text=""></asp:Label>

        <div class="card">
        Credit Hours<br />
        <asp:TextBox ID="credithours" runat="server"></asp:TextBox>
        <br />
        Course Name<br />
        <asp:TextBox ID="cname" runat="server"></asp:TextBox>
        <br />
        Price<br />
        <asp:TextBox ID="price" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addc" class="submit" runat="server" Text="Add Course" OnClick="add_Course" />
        <br />
        <br />
        <br />
            </div>
        <div class="card">
        <asp:Label ID="crsID" runat="server" Text="CourseID"></asp:Label>
        <br />
        <asp:TextBox ID="crssid" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Coursedes" runat="server" Text="Course Description"></asp:Label>
        <br />
        <asp:TextBox ID="crsdes" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="crsdesc" class="submit" runat="server" Text="Update Course Description" OnClick="upd_desc" />
        <br />
        <br />
        <br />
         </div>
        <div class="card">
        <asp:Label ID="crusID" runat="server" Text="CourseID"></asp:Label>
        <br />
        <asp:TextBox ID="couuID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="crscon" runat="server" Text="Course Content"></asp:Label>
        <br />
        <asp:TextBox ID="coucon" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="courcon" class="submit" runat="server" OnClick="upd_con" Text="Update Course Content" />
        <p>
           
        </p>
            </div>
    </form>
    
</body>
</html>
